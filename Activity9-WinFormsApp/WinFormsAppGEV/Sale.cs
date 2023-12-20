using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppGEV
{
    internal class Sale
    {
        public int SaleId { get; set; }
        public DateTime Date { get; set; }
        public Client Client { get; set; }
        public List<Product> Products { get; set; }
        public Sale(Client client, List<Product> products) 
        {
            SaleId = GenerateSaleID();
            Date = DateTime.Now;
            Client = client;
            Products = products;
        }

        private int GenerateSaleID()
        {
            Random random = new();
            return random.Next(100, 100000);
        }
    }
}
