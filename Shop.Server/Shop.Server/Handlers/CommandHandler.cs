using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Shop.Model;
using Shop.Server.Application;
using Shop.Server.Application.Struct;

namespace Shop.Server.Handlers
{
    public class CommandHandler : Handler, IHandler
    {
        public CommandHandler(String path)
        {
            Path = path;
        }
        public string Path { get; set; }

        public void Handler(HttpListenerContext context)
        {
            switch (context.Request.HttpMethod)
            {
                case "POST":
                    //var request = base.GetRequest<MenuItemRequestModel>(context);
                    //SelectMenuItem(request.MenuItemId, request.Quantity);

                    //context.Response.StatusCode = (int)HttpStatusCode.OK;
                    break;

                case "GET":
                    var order = GetOrder();
                    context.Response.StatusCode = (int)HttpStatusCode.OK;
                    SetResponse(context, order);
                    break;
            }

            context.Response.Close();
        }

        private ShopProductsApplication shopProductsApplication = new ShopProductsApplication();
        private ShowCaseModel GetOrder()
        {
            var showCases = new ShowCaseModel() 
            {
                ShowCaseItems=shopProductsApplication.GetShowCases().Select(x => new ShowCaseModelItem{
                    Id = x.Id,
                     Name= x.Name,
                    Vol=x.Vol,
                    Cathegory = x.Cathegory
                })
                .ToList()
            };

            return showCases;
        }
    }
}
