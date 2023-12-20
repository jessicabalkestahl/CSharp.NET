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
    public partial class OrdersForm : Form
    {
        internal static List<Order> OrdersList { get; set; } = new();
        List<Product> products = ProductsForm.ProductsList;
        List<Supplier> suppliers = SuppliersForm.SuppliersList;

        public OrdersForm()
        {
            InitializeComponent();
        }

        private void AddOrder()
        {
            Order order = new(GetSupplier()!, GetProduct()!);
            OrdersList.Add(order);
        }

        private Supplier GetSupplier()
        {
            foreach (var supplier in suppliers)
            {
                if (supplier.Designation == (string)comboBox2.Items[comboBox3.SelectedIndex])
                {
                    return supplier;
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
                AddOrder();
                MessageBox.Show("Order added successfully.");
                comboBox2.SelectedValue = -1;
                comboBox3.SelectedValue = -1;
            }
            else
            {
                MessageBox.Show("Please fill all the fields.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int orderID = (int)comboBox1.Items[comboBox3.SelectedIndex];
            FillOrderInfo(orderID);
        }

        private void FillOrderInfo(int orderID)
        {
            Order order = FindOrder(orderID);
            if (order != null)
            {
                textBox11.Text = order.Date.ToShortDateString();
                textBox10.Text = order.Supplier.Designation;
                textBox9.Text = order.Products[0].Designation;
            }
        }

        private Order FindOrder(int orderID)
        {
            foreach (var order in OrdersList)
            {
                if (order.OrderId == orderID)
                {
                    return order;
                }
            }
            return null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int orderID = (int)comboBox1.Items[comboBox3.SelectedIndex];
            Order order = FindOrder(orderID);

            var confirmResult = MessageBox.Show("Are you sure to delete this item ?",
                                     "Confirm Delete!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                OrdersList.Remove(order);
                textBox11.Text = "";
                textBox10.Text = "";
                textBox9.Text = "";
                comboBox1.SelectedItem = null;
                comboBox1.Items.Remove(orderID);
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


        private void ShowAllOrders()
        {
            dataGridView1.Rows.Clear();
            radioButton1.Checked = true;

            foreach (var order in OrdersList)
            {
                int rowId = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowId];
                row.Cells[0].Value = order.OrderId;
                row.Cells[1].Value = order.Date;
                row.Cells[2].Value = order.Supplier.Designation;
                row.Cells[3].Value = order.Products[0].Designation;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SearchOrder();
        }

        private void SearchOrder()
        {
            Order searchedOrder = null;
            foreach (Order order in OrdersList)
            {
                if (order.OrderId.ToString() == textBox24.Text)
                {
                    searchedOrder = order;
                    break;
                }
            }

            if (searchedOrder != null)
            {
                FillOrderData(searchedOrder);
            }
            else
            {
                ShowAllOrders();
                textBox24.Text = "";
                MessageBox.Show("Order not found.");
            }
        }

        private void FillOrderData(Order order)
        {
            dataGridView1.Rows.Clear();
            int rowId = dataGridView1.Rows.Add();
            DataGridViewRow row = dataGridView1.Rows[rowId];
            row.Cells[0].Value = order.OrderId.ToString();
            row.Cells[1].Value = order.Date.ToString();
            row.Cells[2].Value = order.Supplier.Designation;
            row.Cells[3].Value = order.Products[0].Designation;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addOrder_Enter(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            foreach (var supplier in suppliers)
            {
                comboBox2.Items.Add(supplier.Designation);
            }

            foreach (var product in products)
            {
                comboBox3.Items.Add(product.Designation);
            }
        }

        private void deleteOrder_Enter(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (var order in OrdersList)
            {
                comboBox1.Items.Add(order.OrderId);
            }
        }

        private void searchOrder_Enter(object sender, EventArgs e)
        {
            ShowAllOrders();
        }
    }


}
