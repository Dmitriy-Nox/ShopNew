using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Shop.Server
{
    public class ApplicationServer
    {
        private readonly HttpListener _httpListener;
        private readonly Router _router;

        public ApplicationServer(HttpListener httpListener,Router router)
        {
            this._httpListener = httpListener;
            this._router = router;
        }

        public void Start()
        {
            Console.WriteLine("ServerApplication запушен");
            _httpListener.Start();

            try
            {
                while (true)
                {
                    var context = _httpListener.GetContext();
                    var path = context.Request.Url.PathAndQuery;
                    var handler = _router.GetHandler(path);
                    handler.Handler(context);
                }
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                _httpListener.Stop();
            }
        }

    }
}
