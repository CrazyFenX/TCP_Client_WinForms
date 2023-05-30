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
            this.SendButton = new System.Windows.Forms.Button();
            this.startStreamButton = new System.Windows.Forms.Button();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.StartStreamUDP = new System.Windows.Forms.Button();
            this.buttonConnectUdp = new System.Windows.Forms.Button();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.connectGroupBox = new System.Windows.Forms.GroupBox();
            this.discoectBbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.browseOutputButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.OutPutFolderTextBox = new System.Windows.Forms.TextBox();
            this.sendFileButton = new System.Windows.Forms.Button();
            this.CountOfRaysTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.renderEngineComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CountOfRaysTrackBar = new System.Windows.Forms.TrackBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.newStateTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.connectGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountOfRaysTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxIp
            // 
            this.textBoxIp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxIp.Location = new System.Drawing.Point(71, 41);
            this.textBoxIp.Name = "textBoxIp";
            this.textBoxIp.Size = new System.Drawing.Size(154, 29);
            this.textBoxIp.TabIndex = 0;
            this.textBoxIp.Text = "192.168.0.14";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPort.Location = new System.Drawing.Point(71, 74);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(154, 29);
            this.textBoxPort.TabIndex = 1;
            this.textBoxPort.Text = "8888";
            // 
            // textBoxState
            // 
            this.textBoxState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxState.Location = new System.Drawing.Point(12, 1019);
            this.textBoxState.Multiline = true;
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxState.Size = new System.Drawing.Size(865, 51);
            this.textBoxState.TabIndex = 2;
            this.textBoxState.Text = "State";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConnectButton.Location = new System.Drawing.Point(71, 193);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(154, 33);
            this.ConnectButton.TabIndex = 3;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SendButton.Location = new System.Drawing.Point(14, 618);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(126, 33);
            this.SendButton.TabIndex = 6;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            // 
            // startStreamButton
            // 
            this.startStreamButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startStreamButton.Location = new System.Drawing.Point(71, 232);
            this.startStreamButton.Name = "startStreamButton";
            this.startStreamButton.Size = new System.Drawing.Size(154, 33);
            this.startStreamButton.TabIndex = 9;
            this.startStreamButton.Text = "Start stream";
            this.startStreamButton.UseVisualStyleBackColor = true;
            this.startStreamButton.Click += new System.EventHandler(this.startStreamButton_Click);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DisconnectButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DisconnectButton.Location = new System.Drawing.Point(71, 840);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(154, 33);
            this.DisconnectButton.TabIndex = 10;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // StartStreamUDP
            // 
            this.StartStreamUDP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartStreamUDP.Location = new System.Drawing.Point(71, 330);
            this.StartStreamUDP.Name = "StartStreamUDP";
            this.StartStreamUDP.Size = new System.Drawing.Size(154, 33);
            this.StartStreamUDP.TabIndex = 12;
            this.StartStreamUDP.Text = "Start stream UDP";
            this.StartStreamUDP.UseVisualStyleBackColor = true;
            this.StartStreamUDP.Click += new System.EventHandler(this.StartStreamUDP_Click);
            // 
            // buttonConnectUdp
            // 
            this.buttonConnectUdp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConnectUdp.Location = new System.Drawing.Point(71, 291);
            this.buttonConnectUdp.Name = "buttonConnectUdp";
            this.buttonConnectUdp.Size = new System.Drawing.Size(154, 33);
            this.buttonConnectUdp.TabIndex = 11;
            this.buttonConnectUdp.Text = "Connect UDP";
            this.buttonConnectUdp.UseVisualStyleBackColor = true;
            this.buttonConnectUdp.Click += new System.EventHandler(this.buttonConnectUdp_Click);
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxHeight.Location = new System.Drawing.Point(71, 158);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(154, 29);
            this.textBoxHeight.TabIndex = 14;
            this.textBoxHeight.Text = "1080";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxWidth.Location = new System.Drawing.Point(71, 123);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(154, 29);
            this.textBoxWidth.TabIndex = 13;
            this.textBoxWidth.Text = "1920";
            // 
            // connectGroupBox
            // 
            this.connectGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.connectGroupBox.Controls.Add(this.discoectBbutton);
            this.connectGroupBox.Controls.Add(this.label4);
            this.connectGroupBox.Controls.Add(this.label3);
            this.connectGroupBox.Controls.Add(this.label2);
            this.connectGroupBox.Controls.Add(this.label1);
            this.connectGroupBox.Controls.Add(this.textBoxIp);
            this.connectGroupBox.Controls.Add(this.textBoxPort);
            this.connectGroupBox.Controls.Add(this.DisconnectButton);
            this.connectGroupBox.Controls.Add(this.textBoxHeight);
            this.connectGroupBox.Controls.Add(this.ConnectButton);
            this.connectGroupBox.Controls.Add(this.textBoxWidth);
            this.connectGroupBox.Controls.Add(this.startStreamButton);
            this.connectGroupBox.Controls.Add(this.StartStreamUDP);
            this.connectGroupBox.Controls.Add(this.buttonConnectUdp);
            this.connectGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.connectGroupBox.Location = new System.Drawing.Point(12, 12);
            this.connectGroupBox.Name = "connectGroupBox";
            this.connectGroupBox.Size = new System.Drawing.Size(247, 458);
            this.connectGroupBox.TabIndex = 15;
            this.connectGroupBox.TabStop = false;
            this.connectGroupBox.Text = "Connection";
            // 
            // discoectBbutton
            // 
            this.discoectBbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.discoectBbutton.Location = new System.Drawing.Point(71, 409);
            this.discoectBbutton.Name = "discoectBbutton";
            this.discoectBbutton.Size = new System.Drawing.Size(154, 33);
            this.discoectBbutton.TabIndex = 19;
            this.discoectBbutton.Text = "Disconect";
            this.discoectBbutton.UseVisualStyleBackColor = true;
            this.discoectBbutton.Click += new System.EventHandler(this.discoectBbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Hight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "IP";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.browseOutputButton);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.OutPutFolderTextBox);
            this.groupBox2.Controls.Add(this.sendFileButton);
            this.groupBox2.Controls.Add(this.CountOfRaysTextBox);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.pathTextBox);
            this.groupBox2.Controls.Add(this.renderEngineComboBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.CountOfRaysTrackBar);
            this.groupBox2.Controls.Add(this.SendButton);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(265, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(612, 458);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Send File";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(14, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 33);
            this.button2.TabIndex = 27;
            this.button2.Text = "Send";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // browseOutputButton
            // 
            this.browseOutputButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseOutputButton.Location = new System.Drawing.Point(502, 76);
            this.browseOutputButton.Name = "browseOutputButton";
            this.browseOutputButton.Size = new System.Drawing.Size(95, 29);
            this.browseOutputButton.TabIndex = 26;
            this.browseOutputButton.Text = "Browse";
            this.browseOutputButton.UseVisualStyleBackColor = true;
            this.browseOutputButton.Click += new System.EventHandler(this.browseOutputButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(14, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 21);
            this.label8.TabIndex = 25;
            this.label8.Text = "Output folder";
            // 
            // OutPutFolderTextBox
            // 
            this.OutPutFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutPutFolderTextBox.Location = new System.Drawing.Point(131, 77);
            this.OutPutFolderTextBox.Name = "OutPutFolderTextBox";
            this.OutPutFolderTextBox.Size = new System.Drawing.Size(365, 29);
            this.OutPutFolderTextBox.TabIndex = 24;
            this.OutPutFolderTextBox.Text = "C:\\Users\\User\\Downloads";
            // 
            // sendFileButton
            // 
            this.sendFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sendFileButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sendFileButton.Location = new System.Drawing.Point(14, 240);
            this.sendFileButton.Name = "sendFileButton";
            this.sendFileButton.Size = new System.Drawing.Size(120, 33);
            this.sendFileButton.TabIndex = 23;
            this.sendFileButton.Text = "Send";
            this.sendFileButton.UseVisualStyleBackColor = true;
            this.sendFileButton.Click += new System.EventHandler(this.sendFileButton_Click);
            // 
            // CountOfRaysTextBox
            // 
            this.CountOfRaysTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CountOfRaysTextBox.Location = new System.Drawing.Point(502, 165);
            this.CountOfRaysTextBox.Name = "CountOfRaysTextBox";
            this.CountOfRaysTextBox.Size = new System.Drawing.Size(95, 29);
            this.CountOfRaysTextBox.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(502, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 29);
            this.button1.TabIndex = 21;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(14, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "File path";
            // 
            // pathTextBox
            // 
            this.pathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathTextBox.Location = new System.Drawing.Point(131, 41);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(365, 29);
            this.pathTextBox.TabIndex = 19;
            this.pathTextBox.Text = "C:\\Users\\User\\Downloads\\Controller.cs";
            // 
            // renderEngineComboBox
            // 
            this.renderEngineComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.renderEngineComboBox.FormattingEnabled = true;
            this.renderEngineComboBox.Items.AddRange(new object[] {
            "Eevee",
            "Cycle"});
            this.renderEngineComboBox.Location = new System.Drawing.Point(131, 126);
            this.renderEngineComboBox.Name = "renderEngineComboBox";
            this.renderEngineComboBox.Size = new System.Drawing.Size(128, 29);
            this.renderEngineComboBox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(14, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Count of rays";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Render engine";
            // 
            // CountOfRaysTrackBar
            // 
            this.CountOfRaysTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CountOfRaysTrackBar.Location = new System.Drawing.Point(131, 160);
            this.CountOfRaysTrackBar.Maximum = 4096;
            this.CountOfRaysTrackBar.Minimum = 128;
            this.CountOfRaysTrackBar.Name = "CountOfRaysTrackBar";
            this.CountOfRaysTrackBar.Size = new System.Drawing.Size(365, 45);
            this.CountOfRaysTrackBar.TabIndex = 7;
            this.CountOfRaysTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.CountOfRaysTrackBar.Value = 128;
            this.CountOfRaysTrackBar.Scroll += new System.EventHandler(this.CountOfRaysTrackBar_Scroll);
            // 
            // newStateTextBox
            // 
            this.newStateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newStateTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newStateTextBox.Location = new System.Drawing.Point(12, 476);
            this.newStateTextBox.Multiline = true;
            this.newStateTextBox.Name = "newStateTextBox";
            this.newStateTextBox.Size = new System.Drawing.Size(865, 64);
            this.newStateTextBox.TabIndex = 17;
            this.newStateTextBox.Text = "State";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 552);
            this.Controls.Add(this.newStateTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.connectGroupBox);
            this.Controls.Add(this.textBoxState);
            this.MinimumSize = new System.Drawing.Size(905, 591);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.connectGroupBox.ResumeLayout(false);
            this.connectGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountOfRaysTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxIp;
        private TextBox textBoxPort;
        private TextBox textBoxState;
        private Button ConnectButton;
        private Button SendButton;
        private Button startStreamButton;
        private Button DisconnectButton;
        private Button StartStreamUDP;
        private Button buttonConnectUdp;
        private TextBox textBoxHeight;
        private TextBox textBoxWidth;
        private GroupBox connectGroupBox;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private TrackBar CountOfRaysTrackBar;
        private TextBox CountOfRaysTextBox;
        private Button button1;
        private Label label7;
        private TextBox pathTextBox;
        private ComboBox renderEngineComboBox;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button discoectBbutton;
        private Button sendFileButton;
        private TextBox newStateTextBox;
        private OpenFileDialog openFileDialog1;
        private Button browseOutputButton;
        private Label label8;
        private TextBox OutPutFolderTextBox;
        private Button button2;
    }
}