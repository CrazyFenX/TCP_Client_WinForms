using System.Text;
using TCP_Client_Server;
using TCP_Client_WinForms.Services;

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
            tcpClient = new Client(ip, port, textBoxState/*, threadTCP, threadUDP*/);
            
            // ВАЖНАЯ СТРОКА!!
            //threadTCP = new Thread(new ThreadStart(tcpClient.StartRemoteStream));
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
                tcpClient = new Client(ip, port, textBoxState/*, pictureBox*//*, threadTCP, threadUDP*/);
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

        private void discoectBbutton_Click(object sender, EventArgs e)
        {
            if (tcpClient == null)
            {
                Client.WriteInLog("Сервер не подключен!", textBoxState);
                return;
            }
            tcpClient.ServerDisconnect();
        }

        private void sendFileButton_Click(object sender, EventArgs e)
        {
            string filePath = "";
            string engine = "";
            int raysCount = 0;

            if (pathTextBox.Text != "")
                filePath = pathTextBox.Text;
            else
                MessageBox.Show("Путь не заполнен!");

            engine = renderEngineComboBox.Text;
            raysCount = CountOfRaysTrackBar.Value;

            FileService fileService = new FileService(filePath, engine, raysCount);

            var result = fileService.GetArhive();

            tcpClient.SendArchive(result.FullName);
        }

        // browse
        private void button1_Click(object sender, EventArgs e)
        {
            //string path = "";
            //var a = folderBrowserDialog1.ShowDialog();
            //if (a == DialogResult.OK)
            //    path = folderBrowserDialog1.SelectedPath;

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                pathTextBox.Text = ofd.FileName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void browseOutputButton_Click(object sender, EventArgs e)
        {
            string path = "";
            var a = folderBrowserDialog1.ShowDialog();
            if (a == DialogResult.OK)
                path = folderBrowserDialog1.SelectedPath;
            OutPutFolderTextBox.Text = path;
        }

        private void CountOfRaysTrackBar_Scroll(object sender, EventArgs e)
        {
            CountOfRaysTextBox.Text = CountOfRaysTrackBar.Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tcpClient.SendSyncTCP(new byte[] { 1 });
        }
    }
}