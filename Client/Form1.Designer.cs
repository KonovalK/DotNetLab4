namespace Client
{
    partial class Form1
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
            this.inputUserName = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectBtn = new System.Windows.Forms.Button();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.sendMessageBtn = new System.Windows.Forms.Button();
            this.usersListBox = new System.Windows.Forms.ListBox();
            this.Chat = new System.Windows.Forms.ListBox();
            this.currentUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputUserName
            // 
            this.inputUserName.AutoSize = true;
            this.inputUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputUserName.Location = new System.Drawing.Point(243, 109);
            this.inputUserName.Name = "inputUserName";
            this.inputUserName.Size = new System.Drawing.Size(327, 29);
            this.inputUserName.TabIndex = 0;
            this.inputUserName.Text = "Введіть ім\'я користувача:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameTextBox.Location = new System.Drawing.Point(248, 164);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(322, 34);
            this.userNameTextBox.TabIndex = 1;
            // 
            // connectButton
            // 
            this.connectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connectButton.Location = new System.Drawing.Point(333, 222);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(155, 48);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Увійти";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // disconnectBtn
            // 
            this.disconnectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.disconnectBtn.Location = new System.Drawing.Point(682, 12);
            this.disconnectBtn.Name = "disconnectBtn";
            this.disconnectBtn.Size = new System.Drawing.Size(106, 37);
            this.disconnectBtn.TabIndex = 3;
            this.disconnectBtn.Text = "Вийти";
            this.disconnectBtn.UseVisualStyleBackColor = true;
            this.disconnectBtn.Visible = false;
            this.disconnectBtn.Click += new System.EventHandler(this.disconnectBtn_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messageTextBox.Location = new System.Drawing.Point(232, 386);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(395, 54);
            this.messageTextBox.TabIndex = 4;
            this.messageTextBox.Visible = false;
            this.messageTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.messageTextBox_KeyDown);
            // 
            // sendMessageBtn
            // 
            this.sendMessageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendMessageBtn.Location = new System.Drawing.Point(633, 386);
            this.sendMessageBtn.Name = "sendMessageBtn";
            this.sendMessageBtn.Size = new System.Drawing.Size(155, 54);
            this.sendMessageBtn.TabIndex = 5;
            this.sendMessageBtn.Text = "Надіслати";
            this.sendMessageBtn.UseVisualStyleBackColor = true;
            this.sendMessageBtn.Visible = false;
            this.sendMessageBtn.Click += new System.EventHandler(this.sendMessageBtn_Click);
            // 
            // usersListBox
            // 
            this.usersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersListBox.FormattingEnabled = true;
            this.usersListBox.ItemHeight = 29;
            this.usersListBox.Location = new System.Drawing.Point(1, 0);
            this.usersListBox.Name = "usersListBox";
            this.usersListBox.Size = new System.Drawing.Size(222, 468);
            this.usersListBox.TabIndex = 6;
            this.usersListBox.Visible = false;
            // 
            // Chat
            // 
            this.Chat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Chat.FormattingEnabled = true;
            this.Chat.ItemHeight = 25;
            this.Chat.Location = new System.Drawing.Point(231, 60);
            this.Chat.Name = "Chat";
            this.Chat.Size = new System.Drawing.Size(556, 304);
            this.Chat.TabIndex = 7;
            this.Chat.Visible = false;
            // 
            // currentUserName
            // 
            this.currentUserName.AutoSize = true;
            this.currentUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentUserName.Location = new System.Drawing.Point(238, 8);
            this.currentUserName.Name = "currentUserName";
            this.currentUserName.Size = new System.Drawing.Size(0, 32);
            this.currentUserName.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.currentUserName);
            this.Controls.Add(this.Chat);
            this.Controls.Add(this.usersListBox);
            this.Controls.Add(this.sendMessageBtn);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.disconnectBtn);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.inputUserName);
            this.Name = "Form1";
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputUserName;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnectBtn;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Button sendMessageBtn;
        public System.Windows.Forms.ListBox usersListBox;
        public System.Windows.Forms.ListBox Chat;
        public System.Windows.Forms.Label currentUserName;
    }
}

