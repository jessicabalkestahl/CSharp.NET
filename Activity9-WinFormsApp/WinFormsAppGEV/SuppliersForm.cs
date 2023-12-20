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

namespace WinFormsAppGEV
{
    public partial class SuppliersForm : Form
    {

        internal static List<Supplier> SuppliersList { get; set; } = new ();
        public SuppliersForm()
        {
            InitializeComponent();
        }

        private void AddSupplier()
        {
            string designation = textBox1.Text;
            string email = textBox2.Text;
            string address = textBox3.Text;
            int nif = int.Parse(textBox4.Text);
            string mobile = textBox5.Text;
            string city = textBox6.Text;
            string postCode = textBox7.Text;
            string country = textBox8.Text;
            Supplier supplier = new(designation, nif, email, mobile, address, city, postCode, country);
            SuppliersList.Add(supplier);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" &&
                textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
            {
                try
                {
                    int.Parse(textBox4.Text);
                    AddSupplier();
                    MessageBox.Show("Supplier added successfully.");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                }
                catch
                {
                    MessageBox.Show("NIF field needs to be an integer.");
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields.");
            }
        }

        private void deleteSupplier_Enter(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (var supplier in SuppliersList)
            {
                if (supplier.Active == true)
                {
                    comboBox1.Items.Add(supplier.Designation);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentDesignation = (string)comboBox1.SelectedItem;
            FillSupplierInfo(currentDesignation);
        }

        private void FillSupplierInfo(string designation)
        {
            Supplier supplier = FindSupplier(designation);
            if (supplier != null)
            {
                textBox23.Text = supplier.Email;
                textBox22.Text = supplier.Address;
                textBox21.Text = supplier.NIF.ToString();
                textBox20.Text = supplier.Mobile;
                textBox19.Text = supplier.City;
                textBox18.Text = supplier.PostCode;
                textBox17.Text = supplier.Country;
            }
        }

        private Supplier FindSupplier(string designation)
        {
            foreach (var supplier in SuppliersList)
            {
                if (supplier.Designation == designation)
                {
                    return supplier;
                }
            }
            return null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string currentDesignation = (string)comboBox1.SelectedItem;
            Supplier supplier = FindSupplier(currentDesignation);
            var confirmResult = MessageBox.Show("Are you sure to delete this item ?",
                                     "Confirm Delete!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                supplier.Active = false;
                textBox23.Text = "";
                textBox22.Text = "";
                textBox21.Text = "";
                textBox20.Text = "";
                textBox19.Text = "";
                textBox18.Text = "";
                textBox17.Text = "";
                comboBox1.SelectedItem = null;
                comboBox1.Items.Remove(currentDesignation);
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

        private void radioButton1_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
            groupBox2.Text = "Search by Designation";
            label25.Text = "Designation:";
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            groupBox2.Text = "Search by NIF";
            label25.Text = "NIF:";
        }

        private void searchSupplier_Enter(object sender, EventArgs e)
        {
            ShowAllSuppliers();
        }

        private void ShowAllSuppliers()
        {
            dataGridView1.Rows.Clear();
            radioButton2.Checked = true;

            foreach (var supplier in SuppliersList)
            {
                if(supplier.Active)
                {
                    int rowId = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[rowId];
                    row.Cells[0].Value = supplier.SupplierId;
                    row.Cells[1].Value = supplier.Designation;
                    row.Cells[2].Value = supplier.NIF;
                    row.Cells[3].Value = supplier.Email;
                    row.Cells[4].Value = supplier.Mobile;
                    row.Cells[5].Value = supplier.Address;
                    row.Cells[6].Value = supplier.City;
                    row.Cells[7].Value = supplier.Country;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                SearchSupplier("Designation");
            }
            else if (radioButton2.Checked)
            {
                SearchSupplier("NIF");
            }
        }

        private void SearchSupplier(string searchProperty)
        {
            Supplier searchedSupplier = null;
            foreach (Supplier supplier in SuppliersList)
            {
                if (searchProperty == "Designation")
                {
                    if (supplier.Designation == textBox24.Text)
                    {
                        searchedSupplier = supplier;
                        break;
                    }
                }
                else if (searchProperty == "NIF")
                {
                    if (supplier.NIF.ToString() == textBox24.Text)
                    {
                        searchedSupplier = supplier;
                        break;
                    }
                }
            }

            if (searchedSupplier != null)
            {
                FillSupplierData(searchedSupplier);
            }
            else
            {
                ShowAllSuppliers();
                textBox24.Text = "";
                MessageBox.Show("Supplier not found.");
            }
        }

        private void FillSupplierData(Supplier supplier)
        {
            dataGridView1.Rows.Clear();
            int rowId = dataGridView1.Rows.Add();
            DataGridViewRow row = dataGridView1.Rows[rowId];
            row.Cells[0].Value = supplier.SupplierId;
            row.Cells[1].Value = supplier.Designation;
            row.Cells[2].Value = supplier.NIF;
            row.Cells[3].Value = supplier.Email;
            row.Cells[4].Value = supplier.Mobile;
            row.Cells[5].Value = supplier.Address;
            row.Cells[6].Value = supplier.City;
            row.Cells[7].Value = supplier.Country;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
