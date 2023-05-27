namespace TCP_Client_WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxIp = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.startStreamButton = new System.Windows.Forms.Button();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.StartStreamUDP = new System.Windows.Forms.Button();
            this.buttonConnectUdp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxIp
            // 
            this.textBoxIp.Location = new System.Drawing.Point(3, 12);
            this.textBoxIp.Name = "textBoxIp";
            this.textBoxIp.Size = new System.Drawing.Size(111, 23);
            this.textBoxIp.TabIndex = 0;
            this.textBoxIp.Text = "100.124.160.151";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(3, 41);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(111, 23);
            this.textBoxPort.TabIndex = 1;
            this.textBoxPort.Text = "8888";
            // 
            // textBoxState
            // 
            this.textBoxState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxState.Location = new System.Drawing.Point(120, 627);
            this.textBoxState.Multiline = true;
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxState.Size = new System.Drawing.Size(1368, 51);
            this.textBoxState.TabIndex = 2;
            this.textBoxState.Text = "State";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(3, 70);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(109, 23);
            this.ConnectButton.TabIndex = 3;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxMessage.Location = new System.Drawing.Point(12, 627);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(102, 23);
            this.textBoxMessage.TabIndex = 5;
            this.textBoxMessage.Text = "Text";
            // 
            // SendButton
            // 
            this.SendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SendButton.Location = new System.Drawing.Point(12, 656);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(102, 23);
            this.SendButton.TabIndex = 6;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox.Location = new System.Drawing.Point(120, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1368, 621);
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            // 
            // startStreamButton
            // 
            this.startStreamButton.Location = new System.Drawing.Point(3, 99);
            this.startStreamButton.Name = "startStreamButton";
            this.startStreamButton.Size = new System.Drawing.Size(109, 23);
            this.startStreamButton.TabIndex = 9;
            this.startStreamButton.Text = "Start stream";
            this.startStreamButton.UseVisualStyleBackColor = true;
            this.startStreamButton.Click += new System.EventHandler(this.startStreamButton_Click);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DisconnectButton.Location = new System.Drawing.Point(12, 598);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(102, 23);
            this.DisconnectButton.TabIndex = 10;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // StartStreamUDP
            // 
            this.StartStreamUDP.Location = new System.Drawing.Point(3, 193);
            this.StartStreamUDP.Name = "StartStreamUDP";
            this.StartStreamUDP.Size = new System.Drawing.Size(109, 23);
            this.StartStreamUDP.TabIndex = 12;
            this.StartStreamUDP.Text = "Start stream UDP";
            this.StartStreamUDP.UseVisualStyleBackColor = true;
            this.StartStreamUDP.Click += new System.EventHandler(this.StartStreamUDP_Click);
            // 
            // buttonConnectUdp
            // 
            this.buttonConnectUdp.Location = new System.Drawing.Point(3, 164);
            this.buttonConnectUdp.Name = "buttonConnectUdp";
            this.buttonConnectUdp.Size = new System.Drawing.Size(109, 23);
            this.buttonConnectUdp.TabIndex = 11;
            this.buttonConnectUdp.Text = "Connect UDP";
            this.buttonConnectUdp.UseVisualStyleBackColor = true;
            this.buttonConnectUdp.Click += new System.EventHandler(this.buttonConnectUdp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 684);
            this.Controls.Add(this.StartStreamUDP);
            this.Controls.Add(this.buttonConnectUdp);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.startStreamButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.textBoxIp);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxIp;
        private TextBox textBoxPort;
        private TextBox textBoxState;
        private Button ConnectButton;
        private TextBox textBoxMessage;
        private Button SendButton;
        private PictureBox pictureBox;
        private Button startStreamButton;
        private Button DisconnectButton;
        private Button StartStreamUDP;
        private Button buttonConnectUdp;
    }
}