using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsAppGEV
{
    public partial class ProductsForm : Form
    {
        List<Product> ProductsList = Database.ProductsList;

        public ProductsForm()
        {
            InitializeComponent();
        }

        private void AddProduct()
        {
            string designation = textBox1.Text;
            string description = textBox2.Text;
            double price = double.Parse(textBox3.Text);
            int amount = int.Parse(textBox4.Text);
            Product product = new(designation, description, price, amount);
            ProductsList.Add(product);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                try
                {
                    double.Parse(textBox3.Text);
                    int.Parse(textBox4.Text);
                    AddProduct();
                    MessageBox.Show("Product added successfully.");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                }
                catch
                {
                    MessageBox.Show("Price and Amount need to be a number.");
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields.");
            }
        }

        private void deleteClient_Enter(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (var product in ProductsList)
            {
                comboBox1.Items.Add(product.Designation);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentName = (string)comboBox1.SelectedItem;
            FillProductInfo(currentName);
        }

        private void FillProductInfo(string name)
        {
            Product product = FindProduct(name);
            if (product != null)
            {
                textBox11.Text = product.Description;
                textBox10.Text = product.Price.ToString();
                textBox9.Text = product.Amount.ToString();
            }
        }

        private Product FindProduct(string name)
        {
            foreach (var product in ProductsList)
            {
                if (product.Designation == name)
                {
                    return product;
                }
            }
            return null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string currentName = (string)comboBox1.SelectedItem;
            Product product = FindProduct(currentName);

            var confirmResult = MessageBox.Show("Are you sure to delete this item ?",
                                     "Confirm Delete!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                ProductsList.Remove(product);
                textBox11.Text = "";
                textBox10.Text = "";
                textBox9.Text = "";
                comboBox1.SelectedItem = null;
                comboBox1.Items.Remove(currentName);
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
            radioButton2.Checked = false;
            groupBox2.Text = "Search by Designation";
            label25.Text = "Designation:";
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            groupBox2.Text = "Search by Description";
            label25.Text = "Description:";
        }

        private void searchClient_Enter(object sender, EventArgs e)
        {
            ShowAllClients();
        }

        private void ShowAllClients()
        {
            dataGridView1.Rows.Clear();
            radioButton1.Checked = true;

            foreach (var product in ProductsList)
            {
                int rowId = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowId];
                row.Cells[0].Value = product.ProductId;
                row.Cells[1].Value = product.Designation;
                row.Cells[2].Value = product.Description;
                row.Cells[3].Value = product.Price;
                row.Cells[4].Value = product.Amount;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                SearchProduct("Designation");
            }
            else if (radioButton2.Checked)
            {
                SearchProduct("Description");
            }
        }

        private void SearchProduct(string searchProperty)
        {
            Product searchedProduct = null;
            foreach (Product product in ProductsList)
            {
                if (searchProperty == "Designation")
                {
                    if (product.Designation == textBox24.Text)
                    {
                        searchedProduct = product;
                        break;
                    }
                }
                else if (searchProperty == "Description")
                {
                    if (product.Description == textBox24.Text)
                    {
                        searchedProduct = product;
                        break;
                    }
                }
            }

            if (searchedProduct != null)
            {
                FillProductData(searchedProduct);
            }
            else
            {
                ShowAllClients();
                textBox24.Text = "";
                MessageBox.Show("Product not found.");
            }
        }

        private void FillProductData(Product product)
        {
            dataGridView1.Rows.Clear();
            int rowId = dataGridView1.Rows.Add();
            DataGridViewRow row = dataGridView1.Rows[rowId];
            row.Cells[0].Value = product.ProductId;
            row.Cells[1].Value = product.Designation;
            row.Cells[2].Value = product.Description;
            row.Cells[3].Value = product.Price;
            row.Cells[4].Value = product.Amount;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }


}
