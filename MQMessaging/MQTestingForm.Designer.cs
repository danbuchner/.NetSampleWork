namespace MQMessaging
{
    partial class MQTestingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.queueManagerBox = new System.Windows.Forms.TextBox();
            this.queueNameBox = new System.Windows.Forms.TextBox();
            this.channelBox = new System.Windows.Forms.TextBox();
            this.mqHostBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DisconnectBtn = new System.Windows.Forms.Button();
            this.connStatusLbl = new System.Windows.Forms.Label();
            this.MqConnectBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PutMessageBtn = new System.Windows.Forms.Button();
            this.sendMessageBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ReceiveMessageBox = new System.Windows.Forms.TextBox();
            this.GetMessageBtn = new System.Windows.Forms.Button();
            this.sysMsgLbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Queue Manager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Queue Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Channel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "MQ Host";
            // 
            // queueManagerBox
            // 
            this.queueManagerBox.Location = new System.Drawing.Point(99, 36);
            this.queueManagerBox.Name = "queueManagerBox";
            this.queueManagerBox.Size = new System.Drawing.Size(100, 20);
            this.queueManagerBox.TabIndex = 4;
            // 
            // queueNameBox
            // 
            this.queueNameBox.Location = new System.Drawing.Point(99, 63);
            this.queueNameBox.Name = "queueNameBox";
            this.queueNameBox.Size = new System.Drawing.Size(100, 20);
            this.queueNameBox.TabIndex = 5;
            // 
            // channelBox
            // 
            this.channelBox.Location = new System.Drawing.Point(99, 90);
            this.channelBox.Name = "channelBox";
            this.channelBox.Size = new System.Drawing.Size(100, 20);
            this.channelBox.TabIndex = 6;
            // 
            // mqHostBox
            // 
            this.mqHostBox.Location = new System.Drawing.Point(99, 117);
            this.mqHostBox.Name = "mqHostBox";
            this.mqHostBox.Size = new System.Drawing.Size(100, 20);
            this.mqHostBox.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DisconnectBtn);
            this.groupBox1.Controls.Add(this.connStatusLbl);
            this.groupBox1.Controls.Add(this.MqConnectBtn);
            this.groupBox1.Controls.Add(this.queueManagerBox);
            this.groupBox1.Controls.Add(this.mqHostBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.channelBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.queueNameBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 209);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MQ Information";
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.Location = new System.Drawing.Point(11, 143);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(75, 23);
            this.DisconnectBtn.TabIndex = 10;
            this.DisconnectBtn.Text = "Disconnect";
            this.DisconnectBtn.UseVisualStyleBackColor = true;
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // connStatusLbl
            // 
            this.connStatusLbl.AutoSize = true;
            this.connStatusLbl.ForeColor = System.Drawing.Color.Red;
            this.connStatusLbl.Location = new System.Drawing.Point(68, 184);
            this.connStatusLbl.Name = "connStatusLbl";
            this.connStatusLbl.Size = new System.Drawing.Size(73, 13);
            this.connStatusLbl.TabIndex = 9;
            this.connStatusLbl.Text = "Disconnected";
            // 
            // MqConnectBtn
            // 
            this.MqConnectBtn.Location = new System.Drawing.Point(124, 143);
            this.MqConnectBtn.Name = "MqConnectBtn";
            this.MqConnectBtn.Size = new System.Drawing.Size(75, 23);
            this.MqConnectBtn.TabIndex = 8;
            this.MqConnectBtn.Text = "Connect";
            this.MqConnectBtn.UseVisualStyleBackColor = true;
            this.MqConnectBtn.Click += new System.EventHandler(this.MqConnectBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PutMessageBtn);
            this.groupBox2.Controls.Add(this.sendMessageBox);
            this.groupBox2.Location = new System.Drawing.Point(241, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 75);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Send Message";
            // 
            // PutMessageBtn
            // 
            this.PutMessageBtn.Enabled = false;
            this.PutMessageBtn.Location = new System.Drawing.Point(188, 46);
            this.PutMessageBtn.Name = "PutMessageBtn";
            this.PutMessageBtn.Size = new System.Drawing.Size(75, 23);
            this.PutMessageBtn.TabIndex = 2;
            this.PutMessageBtn.Text = "Put";
            this.PutMessageBtn.UseVisualStyleBackColor = true;
            this.PutMessageBtn.Click += new System.EventHandler(this.PutMessageBtn_Click);
            // 
            // sendMessageBox
            // 
            this.sendMessageBox.Enabled = false;
            this.sendMessageBox.Location = new System.Drawing.Point(6, 22);
            this.sendMessageBox.Name = "sendMessageBox";
            this.sendMessageBox.Size = new System.Drawing.Size(257, 20);
            this.sendMessageBox.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ReceiveMessageBox);
            this.groupBox3.Controls.Add(this.GetMessageBtn);
            this.groupBox3.Location = new System.Drawing.Point(241, 105);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 79);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Retrieve Message";
            // 
            // ReceiveMessageBox
            // 
            this.ReceiveMessageBox.Enabled = false;
            this.ReceiveMessageBox.Location = new System.Drawing.Point(9, 26);
            this.ReceiveMessageBox.Name = "ReceiveMessageBox";
            this.ReceiveMessageBox.Size = new System.Drawing.Size(254, 20);
            this.ReceiveMessageBox.TabIndex = 1;
            // 
            // GetMessageBtn
            // 
            this.GetMessageBtn.Enabled = false;
            this.GetMessageBtn.Location = new System.Drawing.Point(188, 52);
            this.GetMessageBtn.Name = "GetMessageBtn";
            this.GetMessageBtn.Size = new System.Drawing.Size(75, 23);
            this.GetMessageBtn.TabIndex = 0;
            this.GetMessageBtn.Text = "Get";
            this.GetMessageBtn.UseVisualStyleBackColor = true;
            this.GetMessageBtn.Click += new System.EventHandler(this.GetMessageBtn_Click);
            // 
            // sysMsgLbl
            // 
            this.sysMsgLbl.AutoSize = true;
            this.sysMsgLbl.Location = new System.Drawing.Point(351, 196);
            this.sysMsgLbl.Name = "sysMsgLbl";
            this.sysMsgLbl.Size = new System.Drawing.Size(0, 13);
            this.sysMsgLbl.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(538, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MQTestingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 248);
            this.Controls.Add(this.sysMsgLbl);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MQTestingForm";
            this.Text = "MQTesting";
            this.Load += new System.EventHandler(this.MQTestingForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox queueManagerBox;
        private System.Windows.Forms.TextBox queueNameBox;
        private System.Windows.Forms.TextBox channelBox;
        private System.Windows.Forms.TextBox mqHostBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button MqConnectBtn;
        private System.Windows.Forms.Label connStatusLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button PutMessageBtn;
        private System.Windows.Forms.TextBox sendMessageBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox ReceiveMessageBox;
        private System.Windows.Forms.Button GetMessageBtn;
        private System.Windows.Forms.Label sysMsgLbl;
        private System.Windows.Forms.Button DisconnectBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

