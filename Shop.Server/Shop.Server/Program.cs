using System;
using System.Collections.Generic;
using System.Net;
using Shop.Server.Handlers;

namespace Shop.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseUrl = new Uri("http://localhost:37821/");

            var httpListener = new HttpListener();
            httpListener.Prefixes.Add(baseUrl.ToString());

            var handlers = new List<IHandler>() { new MenuHandler("/MainMenu"), new CommandHandler("/OpenShowCase"), new CommandHandler("/DeleteShowCase") };

            foreach (var handler in handlers)
            {
                var handlerUrl = new Uri(baseUrl, handler.Path + "/");
                httpListener.Prefixes.Add(handlerUrl.ToString());
            }

            var router = new Router(handlers);

            var application = new ApplicationServer(httpListener, router);
            application.Start();

        }
    }
}
