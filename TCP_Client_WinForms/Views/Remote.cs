using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCP_Client_Server;

namespace TCP_Client_WinForms
{
    public partial class Remote : Form
    {
        Client tcpClient;

        public Remote(Client _client)
        {
            tcpClient = _client;
            InitializeComponent();
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region MouseControl

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            SendMouse(e, 1);
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            SendMouse(e, 0);
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            SendMouse(e, 2);
        }

        private void SendMouse(MouseEventArgs e, int clickType)
        {
            if (e != null && tcpClient != null)
            {
                byte buttonId = 0;
                switch (e.Button.ToString())
                {
                    case "Left":
                        buttonId = 1;
                        break;

                    case "Middle":
                        buttonId = 2;
                        break;

                    case "Right":
                        buttonId = 3;
                        break;
                }
                MouseData mouse = new MouseData(0, e.X, e.Y, buttonId, clickType);
                byte[] btArray = MouseData.toByteArr(mouse);
                tcpClient.SendAsyncTCP(btArray);
            }
        }

        private void SendKeyBoard(KeyEventArgs e)
        {
            if (e != null && tcpClient != null)
            {
                byte buttonId = (byte)e.KeyValue;
                KeyBoardData keyBoard = new KeyBoardData(1, buttonId);
                byte[] btArray = KeyBoardData.toByteArr(keyBoard);
                tcpClient.SendAsyncTCP(btArray);
            }
        }
        #endregion

        private void Remote_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Remote_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
