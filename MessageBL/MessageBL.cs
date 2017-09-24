using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class MessageBL
    {
        private string message;
        public MessageBL()
        {
            message = "Hello World";
        }

        public string GetMessage()
        {
            MessageDL messageDL = new MessageDL();
            return messageDL.LoadMessage();
        }
    }
}
