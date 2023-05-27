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

        public Form1()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            var ip = textBoxIp.Text;
            var port = Convert.ToInt32(textBoxPort.Text);
            tcpClient = new Client(ip, port, textBoxState, pictureBox);
        }

        private void startStreamButton_Click(object sender, EventArgs e)
        {
            if (tcpClient == null)
            {
                Client.WriteInLog("������ �� ���������!", textBoxState);
                return;
            }
            tcpClient.StartRemoteStream();
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            if (tcpClient == null)
            {
                Client.WriteInLog("������ �� ���������!", textBoxState);
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

            Height = Convert.ToInt32(textBoxHeight.Text);
            Width = Convert.ToInt32(textBoxWidth.Text);

            Remote RemoteForm = new Remote();
            RemoteForm.Size = new Size(Width, Height);

            RemoteForm.Show();

            udpClient = new MyUdpClient(ip, port, textBoxState, RemoteForm.pictureBox);

            if (udpClient == null)
            {
                Client.WriteInLog("������ �� ���������!", textBoxState);
                return;
            }

            udpClient.StartRemoteStream();
        }
    }
}