﻿using System;
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

        int buttonPressedId = 0;

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

        private void pictureBox_DragOver(object sender, DragEventArgs e)
        {
            SendMouse(e, 1);
        }

        private void pictureBox_DragDrop(object sender, DragEventArgs e)
        {
            SendMouse(e, 1);
        }

        #endregion

        #region KeyBoard Control

        private void Remote_KeyDown(object sender, KeyEventArgs e)
        {
            SendKeyBoard(e, 1);
        }

        private void Remote_KeyUp(object sender, KeyEventArgs e)
        {
            SendKeyBoard(e, 2);
        }

        #endregion

        #region Service methods

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

                if (clickType == 1)
                    buttonPressedId = buttonId;
                else if (clickType == 2)
                    buttonPressedId = 0;

                MouseData mouse = new MouseData(0, e.X, e.Y, buttonId, clickType);
                byte[] btArray = MouseData.toByteArr(mouse);
                tcpClient.SendAsyncTCP(btArray);
            }
        }

        private void SendMouse(DragEventArgs e, int clickType)
        {
            if (e != null && tcpClient != null)
            {
                MouseData mouse = new MouseData(0, e.X, e.Y, buttonPressedId, clickType);
                byte[] btArray = MouseData.toByteArr(mouse);
                tcpClient.SendAsyncTCP(btArray);
            }
        }

        private void SendKeyBoard(KeyEventArgs e, int clickType)
        {
            if (e != null && tcpClient != null)
            {
                byte buttonId = (byte)e.KeyValue;
                KeyBoardData keyBoard = new KeyBoardData(1, buttonId, Convert.ToByte(clickType));
                byte[] btArray = KeyBoardData.toByteArr(keyBoard);
                tcpClient.SendAsyncTCP(btArray);
            }
        }

        #endregion

    }
}
