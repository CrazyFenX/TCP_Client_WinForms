using System.Text;
using TCP_Client_Server;

namespace TCP_Client_WinForms
{
    public partial class Form1 : Form
    {
        Client tcpClient;
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
                Client.WriteInLog("Сервер не подключен!", textBoxState);
                return;
            }
            tcpClient.StartRemoteStream();
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
    }
}