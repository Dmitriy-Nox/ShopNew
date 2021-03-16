using System;
using System.Net.Http;

namespace Shop.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var httpClient = new HttpClient();
            var baseUri = new Uri("http://localhost:37821");
            var shopHttpClient = new ShopHttpClient(httpClient, baseUri);

            var application = new ApplicationClient(shopHttpClient);
            application.Start();
        }
    }
}
