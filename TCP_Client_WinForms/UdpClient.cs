using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCP_Client_WinForms
{
    internal class MyUdpClient
    {
        int port = 8888;
        string hostname = "192.168.0.14";

        UdpClient udpServer;
        IPEndPoint LocalIp;
        IPEndPoint RemoteIp;

        bool connected = false;
        string errorString = "Нет ошибок";
        string resultString = "";
        int errorCode = 0;
        TextBox textBoxState;
        PictureBox pictureBox;

        int countErorr;

        public MyUdpClient(string _hostname, int _port, TextBox _textBoxState, PictureBox _pictureBox)
        {
            textBoxState = _textBoxState;
            pictureBox = _pictureBox;

            // Устанавливаем соединение с сервером
            Socket udpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //LocalIp = new IPEndPoint(IPAddress.Parse(Dns.), );
            RemoteIp = new IPEndPoint(IPAddress.Parse(hostname), port);
            try
            {
                ServerConnectAsync(_hostname, _port);
                connected = true;
                errorCode = 0;
                resultString = $"Подключено к {_hostname}:{_port}";

                //// Ожидание сообщения
                //ReceiveAsyncTCP(serverSocket);
                ReceiveAsyncUDP();
            }
            catch (SocketException)
            {
                connected = false;
                errorCode = 1;
                resultString = $"Не удалось установить подключение к {_hostname}. ErrorCode: {errorCode}";
            }
            WriteInLog(resultString);

        }

        ///// <summary>
        ///// Отправить сообщение (Устаревшее)
        ///// </summary>
        //public async void SendAsyncTCP()
        //{
        //    if (serverSocket == null)
        //    {
        //        WriteInLog("Клиент не доступен!");
        //        return;
        //    }

        //    // Определяем данные для отправки - текущее время
        //    byte[] data = Encoding.UTF8.GetBytes(DateTime.Now.ToLongTimeString());

        //    // Отправляем данные
        //    await serverSocket.SendAsync(data, SocketFlags.None);

        //    WriteInLog("Сообщение отправлено");
        //}

        /// <summary>
        /// Принять сообщение (В разработке)
        /// </summary>
        /// <param name="socket"> Сокет конекта </param>
        private async void ReceiveAsyncUDP()
        {
            // получаем данные
            var result = await udpServer.ReceiveAsync();
            // предположим, что отправлена строка, преобразуем байты в строку
            var message = Encoding.UTF8.GetString(result.Buffer);

            WriteInLog($"Получено {result.Buffer.Length} байт");
            WriteInLog($"Удаленный адрес: {result.RemoteEndPoint}");
            WriteInLog(message);
        }

        private async void ServerConnectAsync(string _hostname, int _port)
        {
            //serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //// пытаемся подключиться используя URL-адрес и порт
            //await serverSocket.ConnectAsync(_hostname, _port);

            udpServer = new UdpClient(8888);
            Console.WriteLine("UDP-сервер запущен...");

            //WriteInLog($"Адрес подключения {serverSocket.RemoteEndPoint}");
            //WriteInLog($"Адрес приложения {serverSocket.LocalEndPoint}");

        }

        //public void ServerDisconnect()
        //{
        //    udpServer?.DisconnectAsync(new SocketAsyncEventArgs(true)); // отключаемся
        //}

        //~MyUdpClient()
        //{
        //    if (connected)
        //    {
        //        this.ServerDisconnect();
        //        connected = false;
        //    }
        //}

        #region Потоки удаленного стола

        public async void StartRemoteStream()
        {
            //var udpServer = new UdpClient(8888);
            //Console.WriteLine("UDP-сервер запущен...");

            // получаем данные
            //var result = await udpServer.ReceiveAsync();

            if (udpServer == null)
            {
                WriteInLog("Сервер не доступен!");
                return;
            }
            while (connected)
            {
                try
                {
                    MemoryStream memoryStream = new MemoryStream();
                    var res = await udpServer.ReceiveAsync();
                    byte[] bytes = res.Buffer;
                    memoryStream.Write(bytes, 2, bytes.Length - 2);

                    int countMsg = bytes[0] - 1;
                    if (countMsg > 10)
                        throw new Exception("Потеря первого пакета");
                    for (int i = 0; i < countMsg; i++)
                    {
                        var res1 = await udpServer.ReceiveAsync();
                        byte[] bt = res1.Buffer;
                        memoryStream.Write(bt, 0, bt.Length);
                    }

                    var recievedImage1 = ByteToImage(memoryStream);

                    pictureBox.Image = recievedImage1;
                    pictureBox.Update();
                    pictureBox.Refresh();

                    //// получаем данные
                    //var result = await udpServer.ReceiveAsync();
                    //// предположим, что отправлена строка, преобразуем байты в строку
                    //var message = Encoding.UTF8.GetString(result.Buffer);

                    //WriteInLog($"Получено {result.Buffer.Length} байт");
                    ////WriteInLog($"Удаленный адрес: {result.RemoteEndPoint}");
                    ////WriteInLog(message);
                    //// получаем данные из потока
                    //await serverSocket.ReceiveFromAsync(result.Buffer, SocketFlags.None, RemoteIp);
                    //var recievedImage1 = ByteToImage(result.Buffer);

                    //pictureBox.Image = recievedImage1;
                    //pictureBox.Update();
                    //pictureBox.Refresh();

                }
                catch
                {
                    countErorr++;
                }
            }
        }

        #endregion


        #region Service Methods

        /// <summary>
        /// Запись в текстбокс лога изнутри 
        /// </summary>
        /// <param name="message"> Сообщение </param>
        private void WriteInLog(string message)
        {
            if (textBoxState != null)
                textBoxState.Text += "\r\n" + message;
        }

        /// <summary>
        /// Запись в текстбокс лога извне
        /// </summary>
        /// <param name="message"> Сообщение </param>
        /// <param name="_textBoxState"> Целевой текстбокс </param>
        public static void WriteInLog(string message, TextBox _textBoxState)
        {
            if (_textBoxState != null)
                _textBoxState.Text += "\r\n" + message;
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
        
        public static Bitmap ByteToImage(MemoryStream mStream)
        {
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        /// <summary>
        /// Конвертация массива битов в изображение
        /// </summary>
        /// <param name="imageIn"> Изображение </param>
        /// <returns></returns>
        private Image FromByteToImage(byte[] byteArrayIn)
        {
            Image returnImage = null;
            try
            {
                MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
                ms.Write(byteArrayIn, 0, byteArrayIn.Length);
                returnImage = Image.FromStream(ms, true); //Exception occurs here
            }
            catch (Exception ex)
            {
                WriteInLog(ex.Message);
            }
            return returnImage;
        }


        #endregion Service Methods

    }
}
