using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Server.Application.Struct
{
    public class ApplicationShowCase
    {
        static int idShowCase = 1;
        public ApplicationShowCase(double vol, string name, string cathegory)
        {
            Id = idShowCase++;
            Name = name;
            Cathegory = cathegory;
            Vol = vol;

        }

        public List<ApplicationProduct> ListClassProducts = new List<ApplicationProduct>();

        public int Id { get; set; }
        public String Name { get; set; }
        public double Vol { get; set; }
        public string Cathegory { get; set; }
    }
}
