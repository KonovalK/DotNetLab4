using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void SendMessage()
        {
            ChatServerConnector.GetInstance().SendMessageToServer(messageTextBox.Text, ChatServerConnector.GetInstance().SelectedUser());
            messageTextBox.Text = " ";

        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            string msg = ChatServerConnector.Connect(userNameTextBox.Text);

            if (msg != "OK")
            {
                MessageBox.Show(msg);
                return;
            }
            userNameTextBox.ReadOnly = true;
            connectButton.Visible = false;
            inputUserName.Visible = false;
            userNameTextBox.Visible = false;
            disconnectBtn.Visible = true;
            sendMessageBtn.Visible = true;
            messageTextBox.Visible = true;
            usersListBox.Visible = true;
            Chat.Visible = true;
        }

        private void disconnectBtn_Click(object sender, EventArgs e)
        {
            ChatServerConnector.Disconnect();
            Application.Exit();
        }

        private void messageTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendMessage();
                messageTextBox.Text = " ";

            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            usersListBox.Items.Clear();
        }

        private void sendMessageBtn_Click(object sender, EventArgs e)
        {
            SendMessage();
        }
    }
}
