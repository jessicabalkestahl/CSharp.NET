using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppGEV
{
    public partial class Printing : Form
    {
        public Printing()
        {
            InitializeComponent();
        }

        List<Product> products = ProductsForm.ProductsList;
        List<Supplier> suppliers = SuppliersForm.SuppliersList;
        List<Client> clients = ClientsForm.ClientsList;
        List<Order> orders = OrdersForm.OrdersList;
        List<Sale> sales = SalesForm.SalesList;

        private void Printing_Enter(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;

            richTextBox1.Text = "";
            foreach (Client client in clients)
            {
                richTextBox1.Text += "ClientID: " + client.ClientId + "\n";
                richTextBox1.Text += "Name: " + client.Name + "\n";
                richTextBox1.Text += "NIF: " + client.NIF + "\n";
                richTextBox1.Text += "Email: " + client.Email + "\n";
                richTextBox1.Text += "Mobile: " + client.Mobile + "\n";
                richTextBox1.Text += "Address: " + client.Address + "\n";
                richTextBox1.Text += "City: " + client.City + "\n";
                richTextBox1.Text += "Country: " + client.Country + "\n";
                richTextBox1.Text += "Active: " + client.Active + "\n";
                richTextBox1.Text += "\n";
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;

            richTextBox1.Text = "";
            foreach (Product product in products)
            {
                richTextBox1.Text += "ProductID: " + product.ProductId + "\n";
                richTextBox1.Text += "Designation: " + product.Designation + "\n";
                richTextBox1.Text += "Description: " + product.Description + "\n";
                richTextBox1.Text += "Price: " + product.Price + "\n";
                richTextBox1.Text += "Amount: " + product.Amount + "\n";
                richTextBox1.Text += "\n";
            }
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;

            richTextBox1.Text = "";
            foreach (Supplier supplier in suppliers)
            {
                richTextBox1.Text += "ClientID: " + supplier.SupplierId + "\n";
                richTextBox1.Text += "Name: " + supplier.Designation + "\n";
                richTextBox1.Text += "NIF: " + supplier.NIF + "\n";
                richTextBox1.Text += "Email: " + supplier.Email + "\n";
                richTextBox1.Text += "Mobile: " + supplier.Mobile + "\n";
                richTextBox1.Text += "Address: " + supplier.Address + "\n";
                richTextBox1.Text += "City: " + supplier.City + "\n";
                richTextBox1.Text += "Country: " + supplier.Country + "\n";
                richTextBox1.Text += "Active: " + supplier.Active + "\n";
                richTextBox1.Text += "\n";
            }
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton5.Checked = false;

            richTextBox1.Text = "";
            foreach (Sale sale in sales)
            {
                richTextBox1.Text += "SaleID: " + sale.SaleId + "\n";
                richTextBox1.Text += "Date: " + sale.Date.ToLocalTime().ToString() + "\n";
                richTextBox1.Text += "Client: " + sale.Client.Name + "\n";
                richTextBox1.Text += "Product: " + sale.Products[0].Designation + "\n";
                richTextBox1.Text += "\n";
            }
        }

        private void radioButton5_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

            richTextBox1.Text = "";
            foreach (Order order in orders)
            {
                richTextBox1.Text += "SaleID: " + order.OrderId + "\n";
                richTextBox1.Text += "Date: " + order.Date.ToLocalTime().ToString() + "\n";
                richTextBox1.Text += "Supplier: " + order.Supplier.Designation + "\n";
                richTextBox1.Text += "Product: " + order.Products[0].Designation + "\n";
                richTextBox1.Text += "\n";
            }
        }
    }
}
