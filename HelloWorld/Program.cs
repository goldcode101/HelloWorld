using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //get the message from the api.
            MessageBL messageBL = new MessageBL();
            var message = messageBL.GetMessage();
            
            //print message to console.
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
