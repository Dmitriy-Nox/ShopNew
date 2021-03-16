using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Server.Application.Struct
{
    public class ApplicationProduct
    {
        public ApplicationProduct(string name, string cathegory, double vol, decimal price)
        {
            Name = name;
            Vol = vol;
            Id = idProduct++;
            Cathegory = cathegory;
            Price = price;
        }

        static int idProduct = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public double Vol { get; set; }
        public decimal Price { get; set; }
        public string Cathegory { get; set; }
    }
}
