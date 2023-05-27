using System.Text;
using TCP_Client_Server;

namespace TCP_Client_WinForms
{
    public partial class Form1 : Form
    {
        Client tcpClient;
        MyUdpClient udpClient;

        int Height = 0;
        int Width = 0;

        Thread threadTCP;
        Thread threadUDP;

        public Form1()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            var ip = textBoxIp.Text;
            var port = Convert.ToInt32(textBoxPort.Text);
            tcpClient = new Client(ip, port, textBoxState, pictureBox/*, threadTCP, threadUDP*/);
            threadTCP = new Thread(new ThreadStart(tcpClient.StartRemoteStream));
        }

        private void startStreamButton_Click(object sender, EventArgs e)
        {
            if (tcpClient == null)
            {
                Client.WriteInLog("Сервер не подключен!", textBoxState);
                return;
            }
            threadTCP.Start();
            //tcpClient.StartRemoteStream();
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            if (tcpClient == null)
            {
                Client.WriteInLog("Сервер не подключен!", textBoxState);
                return;
            }
            tcpClient.ServerDisconnect();
        }

        private void buttonConnectUdp_Click(object sender, EventArgs e)
        {
        }

        private void StartStreamUDP_Click(object sender, EventArgs e)
        {
            var ip = textBoxIp.Text;
            var port = Convert.ToInt32(textBoxPort.Text);

            try
            {
                tcpClient = new Client(ip, port, textBoxState, pictureBox/*, threadTCP, threadUDP*/);
                Client.WriteInLog("TCP Connected!", textBoxState);

                Height = Convert.ToInt32(textBoxHeight.Text);
                Width = Convert.ToInt32(textBoxWidth.Text);

                Remote RemoteForm = new Remote(tcpClient);
                RemoteForm.Size = new Size(Width, Height);

                RemoteForm.Show();

                udpClient = new MyUdpClient(ip, port, textBoxState, RemoteForm.pictureBox);
                Client.WriteInLog("UDP Connected!", textBoxState);

                if (udpClient == null)
                {
                    Client.WriteInLog("Сервер не подключен!", textBoxState);
                    return;
                }

                udpClient.StartRemoteStream();
            }
            catch (Exception ex)
            {
                Client.WriteInLog(ex.Message, textBoxState);
            }
        }
    }
}