using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace WinFormsAppGEV
{
    internal static class Database
    {
        public static List<Client> ClientsList { get; set; } = new();
        public static List<Supplier> SuppliersList { get; set; } = new();
        public static List<Product> ProductsList { get; set; } = new();
        public static List<Sale> SalesList { get; set; } = new();
        public static List<Order> OrdersList { get; set; } = new(); 

        public static void InitializeClients()
        {
            Client client1 = new("Jessica", 11111111, "jessica@gmail.com", "11111111", "Rua Tejo", "Porto", "4200", "Portugal");
            Client client2 = new("Mi", 22222222, "mi@gmail.com", "22222222", "Rua Douro", "London", "SW8", "England");
            Client client3 = new("Li", 33333333, "li@gmail.com", "33333333", "Stadshuset", "Uppsala", "523", "Sweden");
            Client client4 = new("Diogo", 44444444, "diogo@gmail.com", "44444444", "Rua Madragoa", "Ovar", "3800", "Portugal");
            Client client5 = new("Madalena", 55555555, "madalena@gmail.com", "55555555", "Rua Pupilas", "Ovar", "3800", "Portugal");
            ClientsList.Add(client1);
            ClientsList.Add(client2);
            ClientsList.Add(client3);
            ClientsList.Add(client4);
            ClientsList.Add(client5);
        }

        public static void InitializeSuppliers()
        {
            Supplier supplier1 = new("Worten", 11111111, "worten@gmail.com", "11111111", "Rua Tejo", "Porto", "4200", "Portugal");
            Supplier supplier2 = new("Fnac", 11111111, "fnac@gmail.com", "22222222", "Rua Douro", "Porto", "4200", "Portugal");
            Supplier supplier3 = new("Radio Popular", 11111111, "radio@gmail.com", "33333333", "Rua Nilo", "Porto", "4200", "Portugal");
            Supplier supplier4 = new("Media Markt", 11111111, "markt@gmail.com", "44444444", "Rua Mondego", "Porto", "4200", "Portugal");
            Supplier supplier5 = new("PCDIGA", 11111111, "pcdiga@gmail.com", "55555555", "Rua Tamega", "Porto", "4200", "Portugal");
            SuppliersList.Add(supplier1);
            SuppliersList.Add(supplier2);
            SuppliersList.Add(supplier3);
            SuppliersList.Add(supplier4);
            SuppliersList.Add(supplier5);
        }

        public static void InitializeProducts()
        {
            Product product1 = new("Keyboard", "Mechanical", 99, 21);
            Product product2 = new("Monitor", "Gaming", 199, 8);
            Product product3 = new("Light", "RGB", 19, 10);
            Product product4 = new("Macbook", "Apple", 1699, 3);
            Product product5 = new("Webcam", "1080p", 30, 5);
            ProductsList.Add(product1);
            ProductsList.Add(product2);
            ProductsList.Add(product3);
            ProductsList.Add(product4);
            ProductsList.Add(product5);
        }

        public static void InitializeSales()
        {
            List<Product> product1 = new();
            product1.Add(ProductsList[0]);
            Sale sale1 = new(ClientsList[0], product1);
            List<Product> product2 = new();
            product2.Add(ProductsList[1]);
            Sale sale2 = new(ClientsList[1], product2);
            List<Product> product3 = new();
            product3.Add(ProductsList[2]);
            Sale sale3 = new(ClientsList[2], product2);
            List<Product> product4 = new();
            product4.Add(ProductsList[3]);
            Sale sale4 = new(ClientsList[3], product2);
            List<Product> product5 = new();
            product5.Add(ProductsList[4]);
            Sale sale5 = new(ClientsList[4], product2);
            SalesList.Add(sale1);
            SalesList.Add(sale2);
            SalesList.Add(sale3);
            SalesList.Add(sale4);
            SalesList.Add(sale5);
        }

        public static void InitializeOrders()
        {
            List<Product> product1 = new();
            product1.Add(ProductsList[0]);
            Order order1 = new(SuppliersList[0], product1);
            List<Product> product2 = new();
            product2.Add(ProductsList[1]);
            Order order2 = new(SuppliersList[1], product1);
            List<Product> product3 = new();
            product3.Add(ProductsList[2]);
            Order order3 = new(SuppliersList[2], product1);
            List<Product> product4 = new();
            product4.Add(ProductsList[3]);
            Order order4 = new(SuppliersList[3], product1);
            List<Product> product5 = new();
            product5.Add(ProductsList[4]);
            Order order5 = new(SuppliersList[4], product1);
            OrdersList.Add(order1);
            OrdersList.Add(order2);
            OrdersList.Add(order3);
            OrdersList.Add(order4);
            OrdersList.Add(order5);
        }

        public static void AddClient(string name, int nif, string email, string mobile, string address, string city, string postCode, string country)
        {
            Client client = new(name, nif, email, mobile, address, city, postCode, country);
            ClientsList.Add(client);
        }

        public static void AddSupplier(string designation, int nif, string email, string mobile, string address, string city, string postCode, string country)
        {
            Supplier supplier = new(designation, nif, email, mobile, address, city, postCode, country);
            SuppliersList.Add(supplier);
        }

        public static void AddProduct(string designation, string description, double price, int amount)
        {
            Product product = new(designation, description, price, amount);
            ProductsList.Add(product);
        }

        public static void AddSale(Client client, List<Product> product)
        {
            Sale sale = new(client, product);
            SalesList.Add(sale);
        }

        public static void AddOrder(Supplier supplier, List<Product> product)
        {
            Order order = new(supplier, product);
            OrdersList.Add(order);
        }

        public static void RemoveClient(Client client)
        {
            foreach (var c in ClientsList)
            {
                if(c == client)
                {
                    ClientsList.Remove(c);
                }
            }
        }

        public static void RemoveSupplier(Supplier supplier)
        {
            foreach (var s in SuppliersList)
            {
                if (s == supplier)
                {
                    SuppliersList.Remove(s);
                }
            }
        }

        public static void RemoveProduct(Product product)
        {
            foreach (var p in ProductsList)
            {
                if (p == product)
                {
                    ProductsList.Remove(p);
                }
            }
        }

        public static void RemoveSale(Sale sale)
        {
            foreach (var s in SalesList)
            {
                if (s == sale)
                {
                    SalesList.Remove(s);
                }
            }
        }

        public static void RemoveOrder(Order order)
        {
            foreach (var o in OrdersList)
            {
                if (o == order)
                {
                    OrdersList.Remove(o);
                }
            }
        }

    }
}
