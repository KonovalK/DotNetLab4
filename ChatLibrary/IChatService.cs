using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace ChatLibrary
{
    [ServiceContract(CallbackContract = typeof(IChatServiceCallback))]
    public interface IChatService
    {
        [OperationContract]
        int Connect(string username);
        [OperationContract(IsOneWay = true)]
        void Disconnect(int id);
        [OperationContract(IsOneWay = true)]
        void SendMessage(string message, int id, int systBool, string name);

        [OperationContract(IsOneWay = true)]
        void UpdateUserList();

    }
}
