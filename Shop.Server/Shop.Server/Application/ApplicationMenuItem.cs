using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Server.Application
{
    public class ApplicationMenuItem
    {
        public ApplicationMenuItem(int id,string text)
        {
            Text = text;
            Id = id;
        }

        public int Id { get; set; }
        public string Text { get; set; }
    }
}
