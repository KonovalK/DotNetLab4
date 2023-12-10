
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace ChatLibrary
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ChatService : IChatService
    {
        List<ChatUser> usersList = new List<ChatUser>();
        int nextUserId = 1;
        public int Connect(string username)
        {
            ChatUser user = new ChatUser()
            {
                Id = nextUserId++,
                Name = username,
                Context = System.ServiceModel.OperationContext.Current,
            };
            SendMessage($"{user.Name}: Приєднується до чату!", 0, 0);
            usersList.Add(user);
            return user.Id;
        }

        public void Disconnect(int id)
        {
            var user = usersList.FirstOrDefault(x => x.Id == id);
            if (user != null)
            {
                usersList.Remove(user);
                SendMessage($"{user.Name}: Від'єднався", 0, 0);
            }
        }

        public void SendMessage(string message, int id, int Sysbool, string nameSender = "")
        {
            string time = System.DateTime.Now.ToShortTimeString();
            string answer;

            if (id == 0)
            {
                foreach (ChatUser user in usersList)
                {
                    if (Sysbool == 0)
                    {
                        answer = message;
                        user.Context.GetCallbackChannel<IChatServiceCallback>().SendMessageToClient(answer);

                    }
                    else
                    {
                        answer = $"{nameSender}: {message}   ({time})";
                        user.Context.GetCallbackChannel<IChatServiceCallback>().SendMessageToClient(answer);

                    }
                }
            }
            else
            {
                var userFrom = usersList.FirstOrDefault(x => x.Name == nameSender);
                var userTo = usersList.FirstOrDefault(x => x.Id == id);
                answer = $"{userFrom.Name} до {userTo.Name}:\n" +
                    $"{message}   ({time})";
                userTo.Context.GetCallbackChannel<IChatServiceCallback>().SendMessageToClient(answer);
                userFrom.Context.GetCallbackChannel<IChatServiceCallback>().SendMessageToClient(answer);
            }

        }


        public void UpdateUserList()
        {
            List<string> list = new List<string>();
            foreach (var user in usersList)
            {
                list.Add(user.Name);
            }
            foreach (ChatUser user in usersList)
            {

                user.Context.GetCallbackChannel<IChatServiceCallback>().UpdateUserListToClient(list);
            }
        }
    }
}
