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
    public partial class ClientsForm : Form
    {

        List<Client> ClientsList = Database.ClientsList;
        public ClientsForm()
        {
            InitializeComponent();
        }

        private void AddClient()
        {
            string name = textBox1.Text;
            string email = textBox2.Text;
            string address = textBox3.Text;
            int nif = int.Parse(textBox4.Text);
            string mobile = textBox5.Text;
            string city = textBox6.Text;
            string postCode = textBox7.Text;
            string country = textBox8.Text;
            Client client = new(name, nif, email, mobile, address, city, postCode, country);
            ClientsList.Add(client);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" &&
                textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
            {
                try
                {
                    int.Parse(textBox4.Text);
                    AddClient();
                    MessageBox.Show("Client added successfully.");
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

        private void deleteClient_Enter(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (var client in ClientsList)
            {
                comboBox1.Items.Add(client.Name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentName = (string)comboBox1.SelectedItem;
            FillClientInfo(currentName);
        }

        private void FillClientInfo(string name)
        {
            Client client = FindClient(name);
            if (client != null)
            {
                textBox23.Text = client.Email;
                textBox22.Text = client.Address;
                textBox21.Text = client.NIF.ToString();
                textBox20.Text = client.Mobile;
                textBox19.Text = client.City;
                textBox18.Text = client.PostCode;
                textBox17.Text = client.Country;
            }
        }

        private Client FindClient(string name)
        {
            foreach (var client in ClientsList)
            {
                if (client.Name == name)
                {
                    return client;
                }
            }
            return null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string currentName = (string)comboBox1.SelectedItem;
            Client client = FindClient(currentName);
            var confirmResult = MessageBox.Show("Are you sure to delete this item ?",
                                     "Confirm Delete!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                textBox23.Text = "";
                textBox22.Text = "";
                textBox21.Text = "";
                textBox20.Text = "";
                textBox19.Text = "";
                textBox18.Text = "";
                textBox17.Text = "";
                comboBox1.SelectedItem = null;
                comboBox1.Items.Remove(currentName);
                ClientsList.Remove(client);
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
            groupBox2.Text = "Search by Name";
            label25.Text = "Name:";
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            groupBox2.Text = "Search by NIF";
            label25.Text = "NIF:";
        }

        private void searchClient_Enter(object sender, EventArgs e)
        {
            ShowAllClients();
        }

        private void ShowAllClients()
        {
            dataGridView1.Rows.Clear();
            radioButton2.Checked = true;

            foreach (var client in ClientsList)
            {
                int rowId = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowId];
                row.Cells[0].Value = client.ClientId;
                row.Cells[1].Value = client.Name;
                row.Cells[2].Value = client.NIF;
                row.Cells[3].Value = client.Email;
                row.Cells[4].Value = client.Mobile;
                row.Cells[5].Value = client.Address;
                row.Cells[6].Value = client.City;
                row.Cells[7].Value = client.Country;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                SearchClient("Name");
            }
            else if (radioButton2.Checked)
            {
                SearchClient("NIF");
            }
        }

        private void SearchClient(string searchProperty)
        {
            Client searchedClient = null;
            foreach (Client client in ClientsList)
            {
                if (searchProperty == "Name")
                {
                    if (client.Name == textBox24.Text)
                    {
                        searchedClient = client;
                        break;
                    }
                }
                else if (searchProperty == "NIF")
                {
                    if (client.NIF.ToString() == textBox24.Text)
                    {
                        searchedClient = client;
                        break;
                    }
                }
            }

            if (searchedClient != null)
            {
                FillClientData(searchedClient);
            }
            else
            {
                ShowAllClients();
                textBox24.Text = "";
                MessageBox.Show("Client not found.");
            }
        }

        private void FillClientData(Client client)
        {
            dataGridView1.Rows.Clear();
            int rowId = dataGridView1.Rows.Add();
            DataGridViewRow row = dataGridView1.Rows[rowId];
            row.Cells[0].Value = client.ClientId;
            row.Cells[1].Value = client.Name;
            row.Cells[2].Value = client.NIF;
            row.Cells[3].Value = client.Email;
            row.Cells[4].Value = client.Mobile;
            row.Cells[5].Value = client.Address;
            row.Cells[6].Value = client.City;
            row.Cells[7].Value = client.Country;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
