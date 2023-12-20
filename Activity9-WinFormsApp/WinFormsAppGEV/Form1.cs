using System.Diagnostics;
using System.Windows.Forms;

namespace WinFormsAppGEV
{
    public partial class FormGEV : Form
    {
        ClientsForm clientForm = new();
        ProductsForm productsForm = new();
        SuppliersForm suppliersForm = new();
        SalesForm salesForm = new();
        OrdersForm ordersForm = new();
        Printing printing = new();
        public FormGEV()
        {
            InitializeComponent();
            clientForm.MdiParent = this;
            productsForm.MdiParent = this;
            richTextBox1.SendToBack();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void insertClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabControl tc = (TabControl)clientForm.Controls["Clients"];
            TabPage tp = tc.TabPages["addClient"];
            tc.SelectedTab = tp;
            clientForm.Show();
            richTextBox1.SendToBack();
        }

        private void changeClientInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabControl tc = (TabControl)clientForm.Controls["Clients"];
            TabPage tp = tc.TabPages["changeClient"];
            tc.SelectedTab = tp;
            clientForm.Show();
            richTextBox1.SendToBack();
        }

        private void deleteClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabControl tc = (TabControl)clientForm.Controls["Clients"];
            TabPage tp = tc.TabPages["deleteClient"];
            tc.SelectedTab = tp;
            clientForm.Show();
            richTextBox1.SendToBack();
        }

        private void searchClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabControl tc = (TabControl)clientForm.Controls["Clients"];
            TabPage tp = tc.TabPages["searchClient"];
            tc.SelectedTab = tp;
            clientForm.Show();
            richTextBox1.SendToBack();
        }

        private void printClientsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Client> clients = ClientsForm.ClientsList;
            richTextBox1.BringToFront();
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

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabControl tc = (TabControl)productsForm.Controls["Products"];
            TabPage tp = tc.TabPages["addProduct"];
            tc.SelectedTab = tp;
            productsForm.Show();
            richTextBox1.SendToBack();
        }

        private void changeProduct_Click(object sender, EventArgs e)
        {
            TabControl tc = (TabControl)productsForm.Controls["Products"];
            TabPage tp = tc.TabPages["changeProduct"];
            Debug.Write(tp);
            tc.SelectedTab = tp;
            productsForm.Show();
            richTextBox1.SendToBack();
        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            TabControl tc = (TabControl)productsForm.Controls["Products"];
            TabPage tp = tc.TabPages["deleteProduct"];
            tc.SelectedTab = tp;
            productsForm.Show();
            richTextBox1.SendToBack();
        }

        private void searchProduct_Click(object sender, EventArgs e)
        {
            TabControl tc = (TabControl)productsForm.Controls["Products"];
            TabPage tp = tc.TabPages["searchProduct"];
            tc.SelectedTab = tp;
            productsForm.Show();
            richTextBox1.SendToBack();
        }

        private void printProduct_Click(object sender, EventArgs e)
        {
            List<Product> products = ProductsForm.ProductsList;
            richTextBox1.BringToFront();
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

        private void addSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabControl tc = (TabControl)suppliersForm.Controls["Suppliers"];
            TabPage tp = tc.TabPages["addSupplier"];
            tc.SelectedTab = tp;
            suppliersForm.Show();
            richTextBox1.SendToBack();
        }

        private void changeSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabControl tc = (TabControl)productsForm.Controls["Products"];
            TabPage tp = tc.TabPages["changeSupplier"];
            tc.SelectedTab = tp;
            suppliersForm.Show();
            richTextBox1.SendToBack();
        }

        private void deleteSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabControl tc = (TabControl)productsForm.Controls["Products"];
            TabPage tp = tc.TabPages["deleteSupplier"];
            tc.SelectedTab = tp;
            suppliersForm.Show();
            richTextBox1.SendToBack();
        }

        private void searchSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabControl tc = (TabControl)productsForm.Controls["Products"];
            TabPage tp = tc.TabPages["searchSupplier"];
            tc.SelectedTab = tp;
            suppliersForm.Show();
            richTextBox1.SendToBack();
        }

        private void printSuppliersListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Supplier> suppliers = SuppliersForm.SuppliersList;
            richTextBox1.BringToFront();
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

        private void addSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabControl tc = (TabControl)salesForm.Controls["Sales"];
            TabPage tp = tc.TabPages["addSale"];
            tc.SelectedTab = tp;
            salesForm.Show();
            richTextBox1.SendToBack();
        }

        private void changeSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabControl tc = (TabControl)salesForm.Controls["Sales"];
            TabPage tp = tc.TabPages["changeSale"];
            tc.SelectedTab = tp;
            salesForm.Show();
            richTextBox1.SendToBack();
        }

        private void deleteSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabControl tc = (TabControl)salesForm.Controls["Sales"];
            TabPage tp = tc.TabPages["deleteSale"];
            tc.SelectedTab = tp;
            salesForm.Show();
            richTextBox1.SendToBack();
        }

        private void searchSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabControl tc = (TabControl)salesForm.Controls["Sales"];
            TabPage tp = tc.TabPages["searchSale"];
            tc.SelectedTab = tp;
            salesForm.Show();
            richTextBox1.SendToBack();
        }

        private void printSalesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Sale> sales = SalesForm.SalesList;
            richTextBox1.BringToFront();
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

        private void addOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabControl tc = (TabControl)ordersForm.Controls["Orders"];
            TabPage tp = tc.TabPages["addOrder"];
            tc.SelectedTab = tp;
            ordersForm.Show();
            richTextBox1.SendToBack();
        }

        private void changeOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabControl tc = (TabControl)ordersForm.Controls["Orders"];
            TabPage tp = tc.TabPages["changeOrder"];
            tc.SelectedTab = tp;
            ordersForm.Show();
            richTextBox1.SendToBack();
        }

        private void deleteOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabControl tc = (TabControl)ordersForm.Controls["Orders"];
            TabPage tp = tc.TabPages["deleteOrder"];
            tc.SelectedTab = tp;
            ordersForm.Show();
            richTextBox1.SendToBack();
        }

        private void searchOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabControl tc = (TabControl)ordersForm.Controls["Orders"];
            TabPage tp = tc.TabPages["searchOrder"];
            tc.SelectedTab = tp;
            ordersForm.Show();
            richTextBox1.SendToBack();
        }

        private void printOrdersListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Order> orders = OrdersForm.OrdersList;
            richTextBox1.BringToFront();
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

        private void chooseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printing.Show();
            richTextBox1.SendToBack();
        }
    }
}
