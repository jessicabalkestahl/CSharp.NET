using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppGEV
{
    internal class Supplier
    {
        public int SupplierId { get; set; }
        public string Designation { get; set; }
        public int NIF { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
        public bool Active { get; set; }

        public Supplier(string designation, int nif, string email, string mobile, string address, string city, string postCode, string country)
        {
            SupplierId = GenerateSupplierID();
            Designation = designation;
            NIF = nif;
            Email = email;
            Mobile = mobile;
            Address = address;
            City = city;
            PostCode = postCode;
            Country = country;
            Active = true;
        }

        private int GenerateSupplierID()
        {
            Random random = new();
            return random.Next(100, 100000);
        }
    }
}
