using Client.ChatServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public class ChatServerConnector : IChatServiceCallback
    {
        private static ChatServerConnector Instance = null;
        private ChatServiceClient Client;
        private int UserId;
        private string Name;
        private ChatServerConnector()
        {
            Client = new ChatServiceClient(new System.ServiceModel.InstanceContext(this));

        }
        static ChatServerConnector()
        {
            if (Instance == null)
                Instance = new ChatServerConnector();
        }
        public static ChatServerConnector GetInstance()
        {
            if (Instance == null)
                Instance = new ChatServerConnector();
            return Instance;
        }

        public static void Disconnect()
        {
            GetInstance().Client.Disconnect(Instance.UserId);
        }
        internal static string Connect(string text)
        {
            if (text.Length < 4)
            {
                return ErrorMessageUserName();
            }
            Instance.UserId = Instance.Client.Connect(text);
            Instance.Name = text;
            (Application.OpenForms["Form1"] as Form1).currentUserName.Text = text;
            GetInstance().Client.UpdateUserList();
            return "OK";
        }
        public void SendMessageToServer(string message, int id)
        {
            GetInstance().Client.SendMessage(message, id, 1, Instance.Name);
        }

        public int SelectedUser()
        {
            return (Application.OpenForms["Form1"] as Form1).usersListBox.SelectedIndex;
        }
        public void SendMessageToClient(string message)
        {
            (Application.OpenForms["Form1"] as Form1).Chat.Items.Add(message);
        }

        public void UpdateUserListToClient(string[] users)
        {
            (Application.OpenForms["Form1"] as Form1).usersListBox.Items.Clear();
            (Application.OpenForms["Form1"] as Form1).usersListBox.Items.Add("Груповий чат");
            (Application.OpenForms["Form1"] as Form1).usersListBox.SelectedIndex = 0;
            foreach (var user in users)
            {
                  (Application.OpenForms["Form1"] as Form1).usersListBox.Items.Add(user);
            }
        }

        private static string ErrorMessageUserName()
        {
            return "Ім'я не може бути менше 4 символів";
        }

    }
}

