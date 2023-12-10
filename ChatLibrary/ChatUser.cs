using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;

namespace ChatLibrary
{
    public class ChatUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public OperationContext Context { get; set; }
    }
}
