namespace WinFormsAppGEV
{
    partial class OrdersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Orders = new TabControl();
            addOrder = new TabPage();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            changeOrder = new TabPage();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            button3 = new Button();
            button4 = new Button();
            deleteOrder = new TabPage();
            label9 = new Label();
            comboBox1 = new ComboBox();
            label10 = new Label();
            button5 = new Button();
            label11 = new Label();
            button6 = new Button();
            label12 = new Label();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            searchOrder = new TabPage();
            button8 = new Button();
            dataGridView1 = new DataGridView();
            OrderID = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Supplier = new DataGridViewTextBoxColumn();
            Product = new DataGridViewTextBoxColumn();
            button7 = new Button();
            groupBox2 = new GroupBox();
            textBox24 = new TextBox();
            label25 = new Label();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            Orders.SuspendLayout();
            addOrder.SuspendLayout();
            changeOrder.SuspendLayout();
            deleteOrder.SuspendLayout();
            searchOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Orders
            // 
            Orders.Appearance = TabAppearance.FlatButtons;
            Orders.Controls.Add(addOrder);
            Orders.Controls.Add(changeOrder);
            Orders.Controls.Add(deleteOrder);
            Orders.Controls.Add(searchOrder);
            Orders.Location = new Point(2, 1);
            Orders.Name = "Orders";
            Orders.SelectedIndex = 0;
            Orders.Size = new Size(797, 448);
            Orders.TabIndex = 1;
            // 
            // addOrder
            // 
            addOrder.BackColor = SystemColors.ActiveCaption;
            addOrder.Controls.Add(comboBox3);
            addOrder.Controls.Add(comboBox2);
            addOrder.Controls.Add(label2);
            addOrder.Controls.Add(label1);
            addOrder.Controls.Add(button2);
            addOrder.Controls.Add(button1);
            addOrder.Location = new Point(4, 27);
            addOrder.Name = "addOrder";
            addOrder.Padding = new Padding(3);
            addOrder.Size = new Size(789, 417);
            addOrder.TabIndex = 0;
            addOrder.Text = "Add";
            addOrder.Enter += addOrder_Enter;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(126, 67);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(220, 23);
            comboBox3.TabIndex = 14;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(126, 31);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(220, 23);
            comboBox2.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 70);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 12;
            label2.Text = "Product";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 34);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 11;
            label1.Text = "Client";
            // 
            // button2
            // 
            button2.Location = new Point(423, 372);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(301, 372);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // changeOrder
            // 
            changeOrder.BackColor = SystemColors.ActiveCaption;
            changeOrder.Controls.Add(comboBox4);
            changeOrder.Controls.Add(comboBox5);
            changeOrder.Controls.Add(label3);
            changeOrder.Controls.Add(label4);
            changeOrder.Controls.Add(button3);
            changeOrder.Controls.Add(button4);
            changeOrder.Location = new Point(4, 27);
            changeOrder.Name = "changeOrder";
            changeOrder.Padding = new Padding(3);
            changeOrder.Size = new Size(789, 417);
            changeOrder.TabIndex = 1;
            changeOrder.Text = "Change";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(124, 73);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(220, 23);
            comboBox4.TabIndex = 40;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(124, 37);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(220, 23);
            comboBox5.TabIndex = 39;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 76);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 38;
            label3.Text = "Product";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 40);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 37;
            label4.Text = "Client";
            // 
            // button3
            // 
            button3.Location = new Point(422, 372);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 36;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(300, 372);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 35;
            button4.Text = "Save";
            button4.UseVisualStyleBackColor = true;
            // 
            // deleteOrder
            // 
            deleteOrder.BackColor = SystemColors.ActiveCaption;
            deleteOrder.Controls.Add(label9);
            deleteOrder.Controls.Add(comboBox1);
            deleteOrder.Controls.Add(label10);
            deleteOrder.Controls.Add(button5);
            deleteOrder.Controls.Add(label11);
            deleteOrder.Controls.Add(button6);
            deleteOrder.Controls.Add(label12);
            deleteOrder.Controls.Add(textBox9);
            deleteOrder.Controls.Add(textBox10);
            deleteOrder.Controls.Add(textBox11);
            deleteOrder.Location = new Point(4, 27);
            deleteOrder.Name = "deleteOrder";
            deleteOrder.Padding = new Padding(3);
            deleteOrder.Size = new Size(789, 417);
            deleteOrder.TabIndex = 2;
            deleteOrder.Text = "Delete";
            deleteOrder.Enter += deleteOrder_Enter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(52, 151);
            label9.Name = "label9";
            label9.Size = new Size(49, 15);
            label9.TabIndex = 22;
            label9.Text = "Product";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(126, 40);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(262, 23);
            comboBox1.TabIndex = 55;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(51, 115);
            label10.Name = "label10";
            label10.Size = new Size(50, 15);
            label10.TabIndex = 21;
            label10.Text = "Supplier";
            // 
            // button5
            // 
            button5.Location = new Point(435, 375);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 54;
            button5.Text = "Cancel";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(70, 79);
            label11.Name = "label11";
            label11.Size = new Size(31, 15);
            label11.TabIndex = 20;
            label11.Text = "Date";
            // 
            // button6
            // 
            button6.Location = new Point(313, 375);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 53;
            button6.Text = "Delete";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(61, 43);
            label12.Name = "label12";
            label12.Size = new Size(51, 15);
            label12.TabIndex = 19;
            label12.Text = "Order ID";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(126, 148);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(262, 23);
            textBox9.TabIndex = 18;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(126, 112);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(262, 23);
            textBox10.TabIndex = 17;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(126, 76);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(262, 23);
            textBox11.TabIndex = 16;
            // 
            // searchOrder
            // 
            searchOrder.BackColor = SystemColors.ActiveCaption;
            searchOrder.Controls.Add(button8);
            searchOrder.Controls.Add(dataGridView1);
            searchOrder.Controls.Add(button7);
            searchOrder.Controls.Add(groupBox2);
            searchOrder.Controls.Add(groupBox1);
            searchOrder.Location = new Point(4, 27);
            searchOrder.Name = "searchOrder";
            searchOrder.Size = new Size(789, 417);
            searchOrder.TabIndex = 3;
            searchOrder.Text = "Search";
            searchOrder.Enter += searchOrder_Enter;
            // 
            // button8
            // 
            button8.Location = new Point(679, 378);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 5;
            button8.Text = "Exit";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { OrderID, Date, Supplier, Product });
            dataGridView1.Location = new Point(39, 205);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(444, 150);
            dataGridView1.TabIndex = 4;
            // 
            // OrderID
            // 
            OrderID.HeaderText = "OrderID";
            OrderID.Name = "OrderID";
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.Name = "Date";
            // 
            // Supplier
            // 
            Supplier.HeaderText = "Supplier";
            Supplier.Name = "Supplier";
            // 
            // Product
            // 
            Product.HeaderText = "Product";
            Product.Name = "Product";
            // 
            // button7
            // 
            button7.Location = new Point(377, 128);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 3;
            button7.Text = "Search";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox24);
            groupBox2.Controls.Add(label25);
            groupBox2.Location = new Point(39, 103);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(263, 74);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Search by Order ID";
            // 
            // textBox24
            // 
            textBox24.Location = new Point(103, 30);
            textBox24.Name = "textBox24";
            textBox24.Size = new Size(149, 23);
            textBox24.TabIndex = 1;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(27, 33);
            label25.Name = "label25";
            label25.Size = new Size(51, 15);
            label25.TabIndex = 0;
            label25.Text = "Order ID";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(39, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(263, 52);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search by";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(54, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(69, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Order ID";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Click += radioButton1_Click;
            // 
            // OrdersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Orders);
            Name = "OrdersForm";
            Text = "Orders";
            Orders.ResumeLayout(false);
            addOrder.ResumeLayout(false);
            addOrder.PerformLayout();
            changeOrder.ResumeLayout(false);
            changeOrder.PerformLayout();
            deleteOrder.ResumeLayout(false);
            deleteOrder.PerformLayout();
            searchOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Orders;
        private TabPage addOrder;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
        private TabPage changeOrder;
        private Button button3;
        private Button button4;
        private TabPage deleteOrder;
        private ComboBox comboBox1;
        private Button button5;
        private Button button6;
        private TabPage searchOrder;
        private Button button8;
        private DataGridView dataGridView1;
        private Button button7;
        private GroupBox groupBox2;
        private TextBox textBox24;
        private Label label25;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TabPage changeClient;
        private TabPage deleteClient;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private Label label3;
        private Label label4;
        private DataGridViewTextBoxColumn OrderID;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Supplier;
        private DataGridViewTextBoxColumn Product;
    }
}