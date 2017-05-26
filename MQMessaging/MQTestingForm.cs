using MQMessaging.MQConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * 
 * Simple MQ Messaging example 
 * DaniloBuchner.com
 * 
 * 
 * */

namespace MQMessaging
{
    public partial class MQTestingForm : Form
    {
        static MQConnect mqConnection;

        public MQTestingForm()
        {
            InitializeComponent();
            this.queueManagerBox.Text = MQMsg.Default.QueueManagerSet;
            this.queueManagerBox.Enabled = false;
            this.queueNameBox.Text = MQMsg.Default.QueueNameSet;
            this.queueNameBox.Enabled = false;
            this.channelBox.Text = MQMsg.Default.ChannelSet;
            this.channelBox.Enabled = false;
            this.mqHostBox.Text = MQMsg.Default.MQHostSet;
            this.mqHostBox.Enabled = false;
        }

        private void MqConnectBtn_Click(object sender, EventArgs e)
        {
            mqConnection = new MQConnect();

            if (mqConnection.ConnectMQ(this.queueManagerBox.Text, this.queueNameBox.Text, this.channelBox.Text, this.mqHostBox.Text))
            {
                this.connStatusLbl.Text = "Connected";
                this.connStatusLbl.ForeColor = System.Drawing.Color.Green;
                this.updateFields(true);
            }
            else
            {
                this.connStatusLbl.Text = "Disconnected";
                this.connStatusLbl.ForeColor = System.Drawing.Color.Red;
                Console.Write("MQ Connection Failed.");
            }
        }

        private void PutMessageBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.sendMessageBox.Text))
            {
                MessageBox.Show("Enter a message to send.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
            }
            else
            { 
                if (mqConnection.WriteMsgLocalMQ(this.sendMessageBox.Text, this.queueNameBox.Text))            
                {                    
                    MessageBox.Show("Message Sent to MQ.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.sendMessageBox.Text = "";
                }
                else
                {
                    this.sendMessageBox.Text = "Error please check MQ Connection and Logs";
                }
            }
        }

        private void GetMessageBtn_Click(object sender, EventArgs e)
        {
            Tuple<bool, string> resultObj = mqConnection.ReadMsgLocalMQ(this.queueNameBox.Text);
            if (resultObj.Item1)
            {
                this.ReceiveMessageBox.Text = resultObj.Item2;
            }
            else {
                this.ReceiveMessageBox.Text = "";
                MessageBox.Show(resultObj.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        private void updateFields(bool setTo)
        {
            this.sendMessageBox.Enabled = setTo;
            this.PutMessageBtn.Enabled = setTo;
            this.ReceiveMessageBox.Enabled = setTo;
            this.GetMessageBtn.Enabled = setTo;
        }        

        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            if (mqConnection.DisconnectMQ())
            {
                this.connStatusLbl.Text = "Disconnected";
                this.connStatusLbl.ForeColor = System.Drawing.Color.Red;
                this.updateFields(false);
                mqConnection = null;
            }           
        }

        private void MQTestingForm_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutMQMessaging about = new AboutMQMessaging();
            about.ShowDialog();
        }
    }
}
