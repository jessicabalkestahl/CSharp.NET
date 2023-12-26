namespace WinFormsAppGEV
{
    partial class FormGEV
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            clientsToolStripMenuItem = new ToolStripMenuItem();
            insertClientToolStripMenuItem = new ToolStripMenuItem();
            changeClientInfoToolStripMenuItem = new ToolStripMenuItem();
            deleteClientToolStripMenuItem = new ToolStripMenuItem();
            searchClientToolStripMenuItem = new ToolStripMenuItem();
            printClientsListToolStripMenuItem = new ToolStripMenuItem();
            productsToolStripMenuItem = new ToolStripMenuItem();
            addProduct = new ToolStripMenuItem();
            changeProduct = new ToolStripMenuItem();
            deleteProduct = new ToolStripMenuItem();
            searchProduct = new ToolStripMenuItem();
            printProduct = new ToolStripMenuItem();
            suppliersToolStripMenuItem = new ToolStripMenuItem();
            addSupplierToolStripMenuItem = new ToolStripMenuItem();
            changeSupplierToolStripMenuItem = new ToolStripMenuItem();
            deleteSupplierToolStripMenuItem = new ToolStripMenuItem();
            searchSupplierToolStripMenuItem = new ToolStripMenuItem();
            printSuppliersListToolStripMenuItem = new ToolStripMenuItem();
            ordersToolStripMenuItem = new ToolStripMenuItem();
            addOrderToolStripMenuItem = new ToolStripMenuItem();
            changeOrderToolStripMenuItem = new ToolStripMenuItem();
            deleteOrderToolStripMenuItem = new ToolStripMenuItem();
            searchOrderToolStripMenuItem = new ToolStripMenuItem();
            printOrdersListToolStripMenuItem = new ToolStripMenuItem();
            salesToolStripMenuItem = new ToolStripMenuItem();
            addSaleToolStripMenuItem = new ToolStripMenuItem();
            changeSaleToolStripMenuItem = new ToolStripMenuItem();
            deleteSaleToolStripMenuItem = new ToolStripMenuItem();
            searchSaleToolStripMenuItem = new ToolStripMenuItem();
            printSalesListToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            printingToolStripMenuItem = new ToolStripMenuItem();
            chooseToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { clientsToolStripMenuItem, productsToolStripMenuItem, suppliersToolStripMenuItem, ordersToolStripMenuItem, salesToolStripMenuItem, printingToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1212, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // clientsToolStripMenuItem
            // 
            clientsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { insertClientToolStripMenuItem, changeClientInfoToolStripMenuItem, deleteClientToolStripMenuItem, searchClientToolStripMenuItem, printClientsListToolStripMenuItem });
            clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            clientsToolStripMenuItem.Size = new Size(55, 20);
            clientsToolStripMenuItem.Text = "Clients";
            // 
            // insertClientToolStripMenuItem
            // 
            insertClientToolStripMenuItem.Name = "insertClientToolStripMenuItem";
            insertClientToolStripMenuItem.Size = new Size(173, 22);
            insertClientToolStripMenuItem.Text = "Add Client";
            insertClientToolStripMenuItem.Click += insertClientToolStripMenuItem_Click;
            // 
            // changeClientInfoToolStripMenuItem
            // 
            changeClientInfoToolStripMenuItem.Name = "changeClientInfoToolStripMenuItem";
            changeClientInfoToolStripMenuItem.Size = new Size(173, 22);
            changeClientInfoToolStripMenuItem.Text = "Change Client Info";
            changeClientInfoToolStripMenuItem.Click += changeClientInfoToolStripMenuItem_Click;
            // 
            // deleteClientToolStripMenuItem
            // 
            deleteClientToolStripMenuItem.Name = "deleteClientToolStripMenuItem";
            deleteClientToolStripMenuItem.Size = new Size(173, 22);
            deleteClientToolStripMenuItem.Text = "Delete Client";
            deleteClientToolStripMenuItem.Click += deleteClientToolStripMenuItem_Click;
            // 
            // searchClientToolStripMenuItem
            // 
            searchClientToolStripMenuItem.Name = "searchClientToolStripMenuItem";
            searchClientToolStripMenuItem.Size = new Size(173, 22);
            searchClientToolStripMenuItem.Text = "Search Client";
            searchClientToolStripMenuItem.Click += searchClientToolStripMenuItem_Click;
            // 
            // printClientsListToolStripMenuItem
            // 
            printClientsListToolStripMenuItem.Name = "printClientsListToolStripMenuItem";
            printClientsListToolStripMenuItem.Size = new Size(173, 22);
            printClientsListToolStripMenuItem.Text = "Print Clients List";
            printClientsListToolStripMenuItem.Click += printClientsListToolStripMenuItem_Click;
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addProduct, changeProduct, deleteProduct, searchProduct, printProduct });
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new Size(66, 20);
            productsToolStripMenuItem.Text = "Products";
            // 
            // addProduct
            // 
            addProduct.Name = "addProduct";
            addProduct.Size = new Size(170, 22);
            addProduct.Text = "Add Product";
            addProduct.Click += addProductToolStripMenuItem_Click;
            // 
            // changeProduct
            // 
            changeProduct.Name = "changeProduct";
            changeProduct.Size = new Size(170, 22);
            changeProduct.Text = "Change Product";
            changeProduct.Click += changeProduct_Click;
            // 
            // deleteProduct
            // 
            deleteProduct.Name = "deleteProduct";
            deleteProduct.Size = new Size(170, 22);
            deleteProduct.Text = "Delete Product";
            deleteProduct.Click += deleteProduct_Click;
            // 
            // searchProduct
            // 
            searchProduct.Name = "searchProduct";
            searchProduct.Size = new Size(170, 22);
            searchProduct.Text = "Search Product";
            searchProduct.Click += searchProduct_Click;
            // 
            // printProduct
            // 
            printProduct.Name = "printProduct";
            printProduct.Size = new Size(170, 22);
            printProduct.Text = "Print Products List";
            printProduct.Click += printProduct_Click;
            // 
            // suppliersToolStripMenuItem
            // 
            suppliersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addSupplierToolStripMenuItem, changeSupplierToolStripMenuItem, deleteSupplierToolStripMenuItem, searchSupplierToolStripMenuItem, printSuppliersListToolStripMenuItem });
            suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            suppliersToolStripMenuItem.Size = new Size(67, 20);
            suppliersToolStripMenuItem.Text = "Suppliers";
            // 
            // addSupplierToolStripMenuItem
            // 
            addSupplierToolStripMenuItem.Name = "addSupplierToolStripMenuItem";
            addSupplierToolStripMenuItem.Size = new Size(171, 22);
            addSupplierToolStripMenuItem.Text = "Add Supplier";
            addSupplierToolStripMenuItem.Click += addSupplierToolStripMenuItem_Click;
            // 
            // changeSupplierToolStripMenuItem
            // 
            changeSupplierToolStripMenuItem.Name = "changeSupplierToolStripMenuItem";
            changeSupplierToolStripMenuItem.Size = new Size(171, 22);
            changeSupplierToolStripMenuItem.Text = "Change Supplier";
            changeSupplierToolStripMenuItem.Click += changeSupplierToolStripMenuItem_Click;
            // 
            // deleteSupplierToolStripMenuItem
            // 
            deleteSupplierToolStripMenuItem.Name = "deleteSupplierToolStripMenuItem";
            deleteSupplierToolStripMenuItem.Size = new Size(171, 22);
            deleteSupplierToolStripMenuItem.Text = "Delete Supplier";
            deleteSupplierToolStripMenuItem.Click += deleteSupplierToolStripMenuItem_Click;
            // 
            // searchSupplierToolStripMenuItem
            // 
            searchSupplierToolStripMenuItem.Name = "searchSupplierToolStripMenuItem";
            searchSupplierToolStripMenuItem.Size = new Size(171, 22);
            searchSupplierToolStripMenuItem.Text = "Search Supplier";
            searchSupplierToolStripMenuItem.Click += searchSupplierToolStripMenuItem_Click;
            // 
            // printSuppliersListToolStripMenuItem
            // 
            printSuppliersListToolStripMenuItem.Name = "printSuppliersListToolStripMenuItem";
            printSuppliersListToolStripMenuItem.Size = new Size(171, 22);
            printSuppliersListToolStripMenuItem.Text = "Print Suppliers List";
            printSuppliersListToolStripMenuItem.Click += printSuppliersListToolStripMenuItem_Click;
            // 
            // ordersToolStripMenuItem
            // 
            ordersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addOrderToolStripMenuItem, changeOrderToolStripMenuItem, deleteOrderToolStripMenuItem, searchOrderToolStripMenuItem, printOrdersListToolStripMenuItem });
            ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            ordersToolStripMenuItem.Size = new Size(54, 20);
            ordersToolStripMenuItem.Text = "Orders";
            // 
            // addOrderToolStripMenuItem
            // 
            addOrderToolStripMenuItem.Name = "addOrderToolStripMenuItem";
            addOrderToolStripMenuItem.Size = new Size(180, 22);
            addOrderToolStripMenuItem.Text = "Add Order";
            addOrderToolStripMenuItem.Click += addOrderToolStripMenuItem_Click;
            // 
            // changeOrderToolStripMenuItem
            // 
            changeOrderToolStripMenuItem.Name = "changeOrderToolStripMenuItem";
            changeOrderToolStripMenuItem.Size = new Size(180, 22);
            changeOrderToolStripMenuItem.Text = "Change Order";
            changeOrderToolStripMenuItem.Click += changeOrderToolStripMenuItem_Click;
            // 
            // deleteOrderToolStripMenuItem
            // 
            deleteOrderToolStripMenuItem.Name = "deleteOrderToolStripMenuItem";
            deleteOrderToolStripMenuItem.Size = new Size(180, 22);
            deleteOrderToolStripMenuItem.Text = "Delete Order";
            deleteOrderToolStripMenuItem.Click += deleteOrderToolStripMenuItem_Click;
            // 
            // searchOrderToolStripMenuItem
            // 
            searchOrderToolStripMenuItem.Name = "searchOrderToolStripMenuItem";
            searchOrderToolStripMenuItem.Size = new Size(180, 22);
            searchOrderToolStripMenuItem.Text = "Search Order";
            searchOrderToolStripMenuItem.Click += searchOrderToolStripMenuItem_Click;
            // 
            // printOrdersListToolStripMenuItem
            // 
            printOrdersListToolStripMenuItem.Name = "printOrdersListToolStripMenuItem";
            printOrdersListToolStripMenuItem.Size = new Size(180, 22);
            printOrdersListToolStripMenuItem.Text = "Print Orders List";
            printOrdersListToolStripMenuItem.Click += printOrdersListToolStripMenuItem_Click;
            // 
            // salesToolStripMenuItem
            // 
            salesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addSaleToolStripMenuItem, changeSaleToolStripMenuItem, deleteSaleToolStripMenuItem, searchSaleToolStripMenuItem, printSalesListToolStripMenuItem });
            salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            salesToolStripMenuItem.Size = new Size(45, 20);
            salesToolStripMenuItem.Text = "Sales";
            // 
            // addSaleToolStripMenuItem
            // 
            addSaleToolStripMenuItem.Name = "addSaleToolStripMenuItem";
            addSaleToolStripMenuItem.Size = new Size(149, 22);
            addSaleToolStripMenuItem.Text = "Add Sale";
            addSaleToolStripMenuItem.Click += addSaleToolStripMenuItem_Click;
            // 
            // changeSaleToolStripMenuItem
            // 
            changeSaleToolStripMenuItem.Name = "changeSaleToolStripMenuItem";
            changeSaleToolStripMenuItem.Size = new Size(149, 22);
            changeSaleToolStripMenuItem.Text = "Change Sale";
            changeSaleToolStripMenuItem.Click += changeSaleToolStripMenuItem_Click;
            // 
            // deleteSaleToolStripMenuItem
            // 
            deleteSaleToolStripMenuItem.Name = "deleteSaleToolStripMenuItem";
            deleteSaleToolStripMenuItem.Size = new Size(149, 22);
            deleteSaleToolStripMenuItem.Text = "Delete Sale";
            deleteSaleToolStripMenuItem.Click += deleteSaleToolStripMenuItem_Click;
            // 
            // searchSaleToolStripMenuItem
            // 
            searchSaleToolStripMenuItem.Name = "searchSaleToolStripMenuItem";
            searchSaleToolStripMenuItem.Size = new Size(149, 22);
            searchSaleToolStripMenuItem.Text = "Search Sale";
            searchSaleToolStripMenuItem.Click += searchSaleToolStripMenuItem_Click;
            // 
            // printSalesListToolStripMenuItem
            // 
            printSalesListToolStripMenuItem.Name = "printSalesListToolStripMenuItem";
            printSalesListToolStripMenuItem.Size = new Size(149, 22);
            printSalesListToolStripMenuItem.Text = "Print Sales List";
            printSalesListToolStripMenuItem.Click += printSalesListToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.ForeColor = Color.Red;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(38, 20);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.AppWorkspace;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(31, 48);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(417, 747);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // printingToolStripMenuItem
            // 
            printingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { chooseToolStripMenuItem });
            printingToolStripMenuItem.Name = "printingToolStripMenuItem";
            printingToolStripMenuItem.Size = new Size(61, 20);
            printingToolStripMenuItem.Text = "Printing";
            // 
            // chooseToolStripMenuItem
            // 
            chooseToolStripMenuItem.Name = "chooseToolStripMenuItem";
            chooseToolStripMenuItem.Size = new Size(180, 22);
            chooseToolStripMenuItem.Text = "Choose Print";
            chooseToolStripMenuItem.Click += chooseToolStripMenuItem_Click;
            // 
            // FormGEV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 807);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormGEV";
            Text = "Gestor de Encomendas e Vendas";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem clientsToolStripMenuItem;
        private ToolStripMenuItem insertClientToolStripMenuItem;
        private ToolStripMenuItem changeClientInfoToolStripMenuItem;
        private ToolStripMenuItem deleteClientToolStripMenuItem;
        private ToolStripMenuItem searchClientToolStripMenuItem;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem suppliersToolStripMenuItem;
        private ToolStripMenuItem ordersToolStripMenuItem;
        private ToolStripMenuItem salesToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem printClientsListToolStripMenuItem;
        private RichTextBox richTextBox1;
        private ToolStripMenuItem addProduct;
        private ToolStripMenuItem changeProduct;
        private ToolStripMenuItem deleteProduct;
        private ToolStripMenuItem searchProduct;
        private ToolStripMenuItem printProduct;
        private ToolStripMenuItem addSupplierToolStripMenuItem;
        private ToolStripMenuItem changeSupplierToolStripMenuItem;
        private ToolStripMenuItem deleteSupplierToolStripMenuItem;
        private ToolStripMenuItem searchSupplierToolStripMenuItem;
        private ToolStripMenuItem printSuppliersListToolStripMenuItem;
        private ToolStripMenuItem addSaleToolStripMenuItem;
        private ToolStripMenuItem changeSaleToolStripMenuItem;
        private ToolStripMenuItem deleteSaleToolStripMenuItem;
        private ToolStripMenuItem searchSaleToolStripMenuItem;
        private ToolStripMenuItem printSalesListToolStripMenuItem;
        private ToolStripMenuItem addOrderToolStripMenuItem;
        private ToolStripMenuItem changeOrderToolStripMenuItem;
        private ToolStripMenuItem deleteOrderToolStripMenuItem;
        private ToolStripMenuItem searchOrderToolStripMenuItem;
        private ToolStripMenuItem printOrdersListToolStripMenuItem;
        private ToolStripMenuItem printingToolStripMenuItem;
        private ToolStripMenuItem chooseToolStripMenuItem;
    }
}
