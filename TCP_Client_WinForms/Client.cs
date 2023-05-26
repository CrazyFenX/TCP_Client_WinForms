using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace TCP_Client_Server
{
    public class Client
    {
        int port = 8888;
        string hostname = "192.168.0.14";

        Socket serverSocket;

        bool connected = false;
        string errorString = "Нет ошибок";
        string resultString = "";
        int errorCode = 0;
        TextBox textBoxState;
        Panel panel;
        PictureBox pictureBox;

        public Client(string _hostname, int _port, TextBox _textBoxState, Panel _panel, PictureBox _pictureBox)
        {
            textBoxState = _textBoxState;
            panel = _panel;
            pictureBox = _pictureBox;

            Socket tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                ServerConnectAsync(_hostname, _port);
                connected = true;
                errorCode = 0;
                resultString = $"Подключено к {_hostname}:{_port}";
            }
            catch (SocketException)
            {
                connected = false;
                errorCode = 1;
                resultString = $"Не удалось установить подключение к {_hostname}. ErrorCode: {errorCode}";
            }

            WriteInLog(resultString);

            ReceiveAsyncTCP(serverSocket);
        }

        /// <summary>
        /// Отправить сообщение
        /// </summary>
        public async void SendAsyncTCP()
        {
            if (serverSocket == null)
            {
                WriteInLog("Клиент не доступен!");
                return;
            }

            // определяем данные для отправки - текущее время
            byte[] data = Encoding.UTF8.GetBytes(DateTime.Now.ToLongTimeString());

            // отправляем данные
            await serverSocket.SendAsync(data, SocketFlags.None);

            WriteInLog("Сообщение отправлено");
        }

        /// <summary>
        /// Принять сообщение
        /// </summary>
        /// <param name="socket"></param>
        private async void ReceiveAsyncTCP(Socket socket)
        {
            byte[] data = new byte[100000000];

            // получаем данные из потока
            int bytes = await socket.ReceiveAsync(data, SocketFlags.None);
            // получаем отправленное время
            //string time = Encoding.UTF8.GetString(data, 0, bytes);
            var recievedImage = FromByteToImage(data);
            var recievedImage1 = ByteToImage(data);

            //panel.BackgroundImage = recievedImage1;
            //panel.BackgroundImage = recievedImage;
            //panel.Refresh();
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

        private void ServerDisconnectAsync(Socket socket)
        {
            socket.DisconnectAsync(new SocketAsyncEventArgs(true)); // отключаемся
        }


        ~Client()
        {
            if (connected)
            {
                this.ServerDisconnectAsync(serverSocket);
                connected = false;
            }
        }

        private void WriteInLog(string message)
        {
            if (textBoxState != null)
                textBoxState.Text += "\r\n" + message;
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

        private Image FromByteToImage(byte[] byteArrayIn)
        {
            Image returnImage = null;
            try
            {
                MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
                ms.Write(byteArrayIn, 0, byteArrayIn.Length);
                returnImage = Image.FromStream(ms, true); //Exception occurs here
            }
            catch ( Exception ex)
            {
                WriteInLog(ex.Message);
            }
            return returnImage;
        }
    }
}