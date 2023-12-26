using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsAppGEV
{
    public partial class SalesForm : Form
    {
        List<Sale> SalesList = Database.SalesList;
        List<Product> products = Database.ProductsList;
        List<Client> clients = Database.ClientsList;

        public SalesForm()
        {
            InitializeComponent();
        }

        private void AddSale()
        {
            Sale sale = new(GetClient()!, GetProduct()!);
            SalesList.Add(sale);
        }

        private Client GetClient()
        {
            foreach (var client in clients)
            {
                if (client.Name == (string)comboBox2.Items[comboBox2.SelectedIndex])
                {
                    return client;
                }
            }
            return null;
        }

        private List<Product> GetProduct()
        {
            foreach (var product in products)
            {
                if (product.Designation == (string)comboBox3.Items[comboBox3.SelectedIndex])
                {
                    List<Product> productsList = new();
                    productsList.Add(product);
                    return productsList;
                }
            }
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1 && comboBox3.SelectedIndex != -1)
            {
                AddSale();
                MessageBox.Show("Sale added successfully.");
                comboBox2.SelectedValue = -1;
                comboBox3.SelectedValue = -1;
            }
            else
            {
                MessageBox.Show("Please fill all the fields.");
            }
        }

        private void deleteSale_Enter(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (var sale in SalesList)
            {
                comboBox1.Items.Add(sale.SaleId);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int saleID = (int)comboBox1.Items[comboBox1.SelectedIndex];
            FillSaleInfo(saleID);
        }

        private void FillSaleInfo(int saleID)
        {
            Sale sale = FindSale(saleID);
            if (sale != null)
            {
                textBox11.Text = sale.Date.ToShortDateString();
                textBox10.Text = sale.Client.Name;
                textBox9.Text = sale.Products[0].Designation;
            }
        }

        private Sale FindSale(int saleID)
        {
            foreach (var sale in SalesList)
            {
                if (sale.SaleId == saleID)
                {
                    return sale;
                }
            }
            return null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int saleID= (int)comboBox1.Items[comboBox1.SelectedIndex];
            Sale sale = FindSale(saleID);

            var confirmResult = MessageBox.Show("Are you sure to delete this item ?",
                                     "Confirm Delete!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                SalesList.Remove(sale);
                textBox11.Text = "";
                textBox10.Text = "";
                textBox9.Text = "";
                comboBox1.SelectedItem = null;
                comboBox1.Items.Remove(saleID);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void searchClient_Enter(object sender, EventArgs e)
        {
            ShowAllSales();
        }

        private void ShowAllSales()
        {
            dataGridView1.Rows.Clear();
            radioButton1.Checked = true;

            foreach (var sale in SalesList)
            {
                int rowId = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowId];
                row.Cells[0].Value = sale.SaleId;
                row.Cells[1].Value = sale.Date;
                row.Cells[2].Value = sale.Client.Name;
                row.Cells[3].Value = sale.Products[0].Designation;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SearchSale();
        }

        private void SearchSale()
        {
            Sale searchedSale = null;
            foreach (Sale sale in SalesList)
            {
                if (sale.SaleId.ToString() == textBox24.Text)
                {
                    searchedSale = sale;
                    break;
                }
            }

            if (searchedSale != null)
            {
                FillSaleData(searchedSale);
            }
            else
            {
                ShowAllSales();
                textBox24.Text = "";
                MessageBox.Show("Sale not found.");
            }
        }

        private void FillSaleData(Sale sale)
        {
            dataGridView1.Rows.Clear();
            int rowId = dataGridView1.Rows.Add();
            DataGridViewRow row = dataGridView1.Rows[rowId];
            row.Cells[0].Value = sale.SaleId.ToString();
            row.Cells[1].Value = sale.Date.ToString();
            row.Cells[2].Value = sale.Client.Name;
            row.Cells[3].Value = sale.Products[0].Designation;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addSale_Enter(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            foreach (var client in clients)
            {
                comboBox2.Items.Add(client.Name);
            }

            foreach (var product in products)
            {
                comboBox3.Items.Add(product.Designation);
            }
        }
    }


}
