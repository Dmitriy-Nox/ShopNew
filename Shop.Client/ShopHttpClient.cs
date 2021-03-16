using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using Shop.Model;

namespace Shop.Client
{
    public class ShopHttpClient
    {
        private readonly HttpClient _client;
        private readonly Uri _baseUri;

        public ShopHttpClient(HttpClient client,Uri baseUri)
        {
            this._client = client;
            _client.BaseAddress = baseUri;
        }




        public MenuModel GetMenu()
        {
            var response = _client.GetAsync($"MainMenu").Result;
            var json = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<MenuModel>(json);
        }
        public ShowCaseModel OpenShowCase()
        {
            var response = _client.GetAsync("OpenShowCase").Result;
            var json = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<ShowCaseModel>(json);
        }
        public void RemoveProduct()
        {

        }

        public void AddShowCase()
        {

        }

        public void RemoveShowCase()
        {

        }
    }
}
