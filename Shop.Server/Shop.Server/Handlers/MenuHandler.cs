using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Shop.Model;
using Shop.Server.Application;

namespace Shop.Server.Handlers
{
    public class MenuHandler : Handler, IHandler
    {
        public string Path { get; set; } = "/MainMenu";

        public void Handler(HttpListenerContext context)
        {
            switch (context.Request.HttpMethod)
            {
                case "GET":
                    var menu = GetMenu();
                    context.Response.StatusCode = (int)HttpStatusCode.OK;
                    SetResponse(context, menu);
                    break;
            }

            context.Response.Close();
        }

        public MenuModel GetMenu()
        {
            return new MenuModel() { MenuModelItems = ApplicationMenu.ApplicationMenuItems.Select(dat => new MenuItemModel() { Id = dat.Id, Text = dat.Text }).ToList() };
        }
    }
}
