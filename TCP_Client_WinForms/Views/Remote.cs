using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_Client_WinForms
{
    public partial class Remote : Form
    {
        MyUdpClient udpClient;

        public Remote()
        {
            InitializeComponent();
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region MouseControl

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {

        }

        #endregion

    }
}
