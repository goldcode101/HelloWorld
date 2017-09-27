using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string fileName = "../../../MessageFile.txt";
            if (new FileInfo(fileName).Length == 0)
            {
                File.WriteAllLines(fileName, new string[] { "Hello World", "Mobile Message", "Service Message", "Web Message" });
            }

            //get the message from the api.
            MessageBL messageBL = new MessageBL();
            var message = messageBL.GetMessage();

            HttpL httpL = new HttpL();
            httpL.ListenThreaded();
            
            //print message to console.
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
