using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Server.Application
{
    public static class ApplicationMenu
    {

        public static List<ApplicationMenuItem> ApplicationMenuItems = new List<ApplicationMenuItem>()
        {
            new ApplicationMenuItem(1,"Открыть витрину"),
            new ApplicationMenuItem(2,"Удалить витрину"),
            new ApplicationMenuItem(3,"Добавить продукт"),
            new ApplicationMenuItem(4,"Удалить продукт"),
            new ApplicationMenuItem(5,"Редактировать витрину"),
            new ApplicationMenuItem(6,"Редактировать продукт"),

        };

        public static ApplicationMenuItem GetMenuItem(int id)
        {
            return ApplicationMenuItems.SingleOrDefault(dat => dat.Id == id);
        }
    }
}
