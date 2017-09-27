using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;

namespace HelloWorld
{
    
    public abstract class PlatformMessageSender
    {
        protected string consoleMessage, mobileMessage, serviceMessage, webMessage;
        public abstract string GetMessage();



    }

    public class MessageBL : PlatformMessageSender
    {
        
        public override string GetMessage()
        {
            MessageDL messageDL = new MessageDL();
            consoleMessage = messageDL.LoadMessage()[0];
            return consoleMessage;
        }
    }

    public class MobileMessageBL : PlatformMessageSender
    {
        public override string GetMessage()
        {
            MessageDL messageDL = new MessageDL();
            mobileMessage = messageDL.LoadMessage()[1];
            return mobileMessage;
        }
    }

    public class ServiceMessageBL : PlatformMessageSender
    {
        public override string GetMessage()
        {
            MessageDL messageDL = new MessageDL();
            serviceMessage = messageDL.LoadMessage()[2];
            return serviceMessage;
        }
    }

    public class WebMessageBL : PlatformMessageSender
    {
        public override string GetMessage()
        {
            MessageDL messageDL = new MessageDL();
            webMessage = messageDL.LoadMessage()[3];
            return webMessage;
        }
    }

    public class HttpL
    {
        HttpListener httpListener;

        public HttpL()
        {
            httpListener = new HttpListener();
        }

        public void ListenThreaded()
        {
            ThreadStart d = new ThreadStart(Listen);
            Thread t = new Thread(d);
            t.Start();
        }

        public void Listen()
        {
            httpListener.Prefixes.Add("http://localhost/");
            httpListener.Start();
            while (true)
            {
                HttpListenerContext ctx = httpListener.GetContext();
                ThreadPool.QueueUserWorkItem((_) =>
                {
                    if (ctx.Request.Url.ToString().EndsWith("data"))
                    {

                        HttpListenerResponse response = ctx.Response;
                        string responseString = new MessageDL().LoadMessage()[0];
                        byte[] buffer = Encoding.UTF8.GetBytes(responseString);
                        response.ContentLength64 = buffer.Length;
                        Stream output = response.OutputStream;
                        output.Write(buffer, 0, buffer.Length);
                        output.Close();
                    }
                });

            }
        }
    }
}
