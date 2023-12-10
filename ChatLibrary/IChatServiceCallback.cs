using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;

namespace ChatLibrary
{
    [ServiceContract]
    public interface IChatServiceCallback
    {
        [OperationContract(IsOneWay = true)]
        void SendMessageToClient(string message);

        [OperationContract(IsOneWay = true)]
        void UpdateUserListToClient(List<string> users);
    }
}
