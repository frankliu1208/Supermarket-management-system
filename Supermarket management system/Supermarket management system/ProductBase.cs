using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket_management_system
{
    class ProductBase
    {
        public double Price { get; set; }

        public String Name { get; set; }

        public string ID { get; set; }


        public ProductBase(string id, double price, string name)
        {
            this.ID = ID;
            this.Price = price;
            this.Name = name;
        }


    }
}
