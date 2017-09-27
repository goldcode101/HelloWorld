using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class MessageDL
    {
        private string[] message;

        public string[] LoadMessage()
        {
            //get the message from a file.
            message = File.ReadAllLines("../../../MessageFile.txt", Encoding.UTF8);

            return message;
        }


    }
}
