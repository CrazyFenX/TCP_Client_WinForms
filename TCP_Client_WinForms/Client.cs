using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using TCP_Client_WinForms;

namespace TCP_Client_Server
{
    public class Client
    {
        int port = 5555;
        string hostname = "169.254.150.225";

        Socket serverSocket;

        bool connected = false;
        string errorString = "Нет ошибок";
        string resultString = "";
        int errorCode = 0;
        TextBox textBoxState;
        PictureBox pictureBox;

        int countErorr;

        Thread tcpThread = null;
        Thread udpThread = null;


        /// <summary>
        /// Основной конструктор клиента
        /// </summary>
        /// <param name="_hostname"> ip сервера </param>
        /// <param name="_port"> порт сервера </param>
        /// <param name="_textBoxState"> текстбокс для вывода логов </param>
        /// <param name="_pictureBox"> полотно для отрисовки переданных изображений </param>
        public Client(string _hostname, int _port, TextBox _textBoxState, PictureBox _pictureBox/*, Thread _tcpThread, Thread _udpThread*/)
        {
            textBoxState = _textBoxState;
            pictureBox = _pictureBox;
            //tcpThread = _tcpThread;
            //udpThread = _udpThread;

            // Устанавливаем соединение с сервером
            Socket tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                ServerConnectAsync(_hostname, _port);
                connected = true;
                errorCode = 0;
                resultString = $"Подключено к {_hostname}:{_port}";

                // передача публичного ключа

                //// Ожидание сообщения
                //ReceiveAsyncTCP(serverSocket);
            }
            catch (SocketException)
            {
                connected = false;
                errorCode = 1;
                resultString = $"Не удалось установить подключение к {_hostname}. ErrorCode: {errorCode}";
            }
            WriteInLog(resultString);
        }

        /// <summary>
        /// Отправить сообщение
        /// </summary>
        public async void SendAsyncTCP(byte[] data)
        {
            if (serverSocket == null)
            {
                WriteInLog("Клиент не доступен!");
                return;
            }

            // Отправляем данные
            await serverSocket.SendAsync(data, SocketFlags.None);

            WriteInLog("Сообщение отправлено");
        }

        /// <summary>
        /// Принять сообщение (В разработке)
        /// </summary>
        /// <param name="socket"> Сокет конекта </param>
        private async void ReceiveAsyncTCP(Socket socket)
        {
            byte[] data = new byte[100000000];

            // получаем данные из потока
            int bytes = await socket.ReceiveAsync(data, SocketFlags.None);
            var recievedImage = FromByteToImage(data);
            var recievedImage1 = ByteToImage(data);

            pictureBox.Image = recievedImage1;
            pictureBox.Update();
            pictureBox.Refresh();

            WriteInLog($"Плучено сообщение!");
        }

        private async void ServerConnectAsync(string _hostname, int _port)
        {
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // пытаемся подключиться используя URL-адрес и порт
            await serverSocket.ConnectAsync(_hostname, _port);

            WriteInLog($"Адрес подключения {serverSocket.RemoteEndPoint}");
            WriteInLog($"Адрес приложения {serverSocket.LocalEndPoint}");

        }

        public void ServerDisconnect()
        {
            serverSocket?.DisconnectAsync(new SocketAsyncEventArgs(true)); // отключаемся
        }

        ~Client()
        {
            if (connected)
            {
                this.ServerDisconnect();
                connected = false;
            }
        }

        #region Потоки удаленного стола

        public async void StartRemoteStream()
        {
            if (serverSocket == null)
            {
                //WriteInLog("Сервер не доступен!");
                WriteInFile("Сервер не доступен!", "TCP");
                return;
            }

            while (connected)
            {
                //WriteInLog("TCP-поток");
                WriteInFile("TCP-поток", "TCP");
                try
                {
                    byte[] data = new byte[100000000];

                    // получаем данные из потока
                    int bytes = await serverSocket.ReceiveAsync(data, SocketFlags.None);
                    var recievedImage1 = ByteToImage(data);

                    pictureBox.Image = recievedImage1;
                    pictureBox.Update();
                    pictureBox.Refresh();

                    WriteInFile("Плучено сообщение!", "TCP");
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

        /// <summary>
        /// Запись в файл лога извне
        /// </summary>
        /// <param name="message"> Сообщение </param>
        /// <param name="_textBoxState"> Целевой текстбокс </param>
        public static void WriteInFile(string message, string threadName)
        {
            var date = DateTime.Now;
            //using FileStream fileStream = new FileStream($"Logs\\{threadName}_Logs" + date.ToLongDateString(), FileMode.OpenOrCreate);
            //fileStream.Write(message + " " + threadName + " " + date.ToLongTimeString(), 0, 0);
            //using (FileStream file = File.OpenWrite($"Logs\\{threadName}_Logs" + date.ToLongDateString()))
            using (FileStream fileStream = new FileStream($"{threadName}_Logs" + date.ToShortDateString(), FileMode.Open))
            {
                // преобразуем строку в байты
                byte[] buffer = Encoding.Default.GetBytes(message);
                // запись массива байтов в файл
                fileStream.WriteAsync(buffer, 0, buffer.Length);
            }
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