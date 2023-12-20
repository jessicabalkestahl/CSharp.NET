using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppGEV
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string Designation {  get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }

        public Product(string designation, string description, double price, int amount)
        {
            ProductId = GenerateProductID();
            Designation = designation;
            Description = description;
            Price = price;
            Amount = amount;
        }

        private int GenerateProductID()
        {
            Random random = new();
            return random.Next(100, 100000);
        }
    }


}
