using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Shop.Server.Handlers
{
    public interface IHandler
    {
        string Path { get; set; }
        void Handler(HttpListenerContext context);
    }
}
