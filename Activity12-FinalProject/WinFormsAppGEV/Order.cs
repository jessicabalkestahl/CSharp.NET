using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppGEV
{
    internal class Order
    {
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public Supplier Supplier { get; set; } 
        public List<Product> Products { get; set; }

        public Order(Supplier supplier, List<Product> products)
        {
            OrderId = GenerateOrderID();
            Date = DateTime.Now;
            Supplier = supplier;
            Products = products;
        }

        private int GenerateOrderID()
        {
            Random random = new();
            return random.Next(100, 100000);
        }
    }
}
