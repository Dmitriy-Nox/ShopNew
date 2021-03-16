using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Shop.Client
{
    public class ApplicationClient
    {
        private readonly ShopHttpClient _httpClient;

        public ApplicationClient(ShopHttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
         
        public void Start()
        {
            GetMenu();
            while(true)
            {
                Console.ReadLine();
            }
        }


        public void GetMenu()
        {
            var menuItems = _httpClient.GetMenu().MenuModelItems;
            foreach(var itemMenu in menuItems)
                Console.WriteLine($"{ itemMenu.Id}  {itemMenu.Text}");
        }
    }
}
