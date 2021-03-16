using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shop.Server.Handlers;

namespace Shop.Server
{
    public class Router
    {
        private readonly List<IHandler> _handlers;

        public Router(List<IHandler> handlers)
        {
            this._handlers = handlers;
        }
        public IHandler GetHandler(String path)
        {
            return _handlers.SingleOrDefault(dat => dat.Path == path);
        }
    }
}
