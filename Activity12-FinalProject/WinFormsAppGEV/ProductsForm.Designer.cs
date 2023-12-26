namespace WinFormsAppGEV
{
    partial class ProductsForm
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
            Products = new TabControl();
            addProduct = new TabPage();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            changeProduct = new TabPage();
            label5 = new Label();
            button3 = new Button();
            label6 = new Label();
            button4 = new Button();
            label7 = new Label();
            textBox8 = new TextBox();
            label8 = new Label();
            textBox7 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            deleteProduct = new TabPage();
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
            searchProduct = new TabPage();
            button8 = new Button();
            dataGridView1 = new DataGridView();
            ProductID = new DataGridViewTextBoxColumn();
            Designation = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            button7 = new Button();
            groupBox2 = new GroupBox();
            textBox24 = new TextBox();
            label25 = new Label();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            Products.SuspendLayout();
            addProduct.SuspendLayout();
            changeProduct.SuspendLayout();
            deleteProduct.SuspendLayout();
            searchProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Products
            // 
            Products.Appearance = TabAppearance.FlatButtons;
            Products.Controls.Add(addProduct);
            Products.Controls.Add(changeProduct);
            Products.Controls.Add(deleteProduct);
            Products.Controls.Add(searchProduct);
            Products.Location = new Point(2, 1);
            Products.Name = "Products";
            Products.SelectedIndex = 0;
            Products.Size = new Size(797, 448);
            Products.TabIndex = 1;
            // 
            // addProduct
            // 
            addProduct.BackColor = SystemColors.ActiveCaption;
            addProduct.Controls.Add(label4);
            addProduct.Controls.Add(label3);
            addProduct.Controls.Add(label2);
            addProduct.Controls.Add(label1);
            addProduct.Controls.Add(button2);
            addProduct.Controls.Add(button1);
            addProduct.Controls.Add(textBox4);
            addProduct.Controls.Add(textBox3);
            addProduct.Controls.Add(textBox2);
            addProduct.Controls.Add(textBox1);
            addProduct.Location = new Point(4, 27);
            addProduct.Name = "addProduct";
            addProduct.Padding = new Padding(3);
            addProduct.Size = new Size(789, 417);
            addProduct.TabIndex = 0;
            addProduct.Text = "Add";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 142);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 14;
            label4.Text = "Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 106);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 13;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 70);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 12;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 34);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 11;
            label1.Text = "Designation";
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
            // textBox4
            // 
            textBox4.Location = new Point(114, 139);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(262, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(114, 103);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(262, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(114, 67);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(262, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(114, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(262, 23);
            textBox1.TabIndex = 0;
            // 
            // changeProduct
            // 
            changeProduct.BackColor = SystemColors.ActiveCaption;
            changeProduct.Controls.Add(label5);
            changeProduct.Controls.Add(button3);
            changeProduct.Controls.Add(label6);
            changeProduct.Controls.Add(button4);
            changeProduct.Controls.Add(label7);
            changeProduct.Controls.Add(textBox8);
            changeProduct.Controls.Add(label8);
            changeProduct.Controls.Add(textBox7);
            changeProduct.Controls.Add(textBox5);
            changeProduct.Controls.Add(textBox6);
            changeProduct.Location = new Point(4, 27);
            changeProduct.Name = "changeProduct";
            changeProduct.Padding = new Padding(3);
            changeProduct.Size = new Size(789, 417);
            changeProduct.TabIndex = 1;
            changeProduct.Text = "Change";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 143);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 22;
            label5.Text = "Amount";
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 107);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 21;
            label6.Text = "Price";
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 71);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 20;
            label7.Text = "Description";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(113, 32);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(262, 23);
            textBox8.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 35);
            label8.Name = "label8";
            label8.Size = new Size(70, 15);
            label8.TabIndex = 19;
            label8.Text = "Designation";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(113, 68);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(262, 23);
            textBox7.TabIndex = 16;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(113, 140);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(262, 23);
            textBox5.TabIndex = 18;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(113, 104);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(262, 23);
            textBox6.TabIndex = 17;
            // 
            // deleteProduct
            // 
            deleteProduct.BackColor = SystemColors.ActiveCaption;
            deleteProduct.Controls.Add(label9);
            deleteProduct.Controls.Add(comboBox1);
            deleteProduct.Controls.Add(label10);
            deleteProduct.Controls.Add(button5);
            deleteProduct.Controls.Add(label11);
            deleteProduct.Controls.Add(button6);
            deleteProduct.Controls.Add(label12);
            deleteProduct.Controls.Add(textBox9);
            deleteProduct.Controls.Add(textBox10);
            deleteProduct.Controls.Add(textBox11);
            deleteProduct.Location = new Point(4, 27);
            deleteProduct.Name = "deleteProduct";
            deleteProduct.Padding = new Padding(3);
            deleteProduct.Size = new Size(789, 417);
            deleteProduct.TabIndex = 2;
            deleteProduct.Text = "Delete";
            deleteProduct.Enter += deleteClient_Enter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(52, 151);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 22;
            label9.Text = "Amount";
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
            label10.Location = new Point(70, 115);
            label10.Name = "label10";
            label10.Size = new Size(33, 15);
            label10.TabIndex = 21;
            label10.Text = "Price";
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
            label11.Location = new Point(36, 79);
            label11.Name = "label11";
            label11.Size = new Size(67, 15);
            label11.TabIndex = 20;
            label11.Text = "Description";
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
            label12.Location = new Point(33, 43);
            label12.Name = "label12";
            label12.Size = new Size(70, 15);
            label12.TabIndex = 19;
            label12.Text = "Designation";
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
            // searchProduct
            // 
            searchProduct.BackColor = SystemColors.ActiveCaption;
            searchProduct.Controls.Add(button8);
            searchProduct.Controls.Add(dataGridView1);
            searchProduct.Controls.Add(button7);
            searchProduct.Controls.Add(groupBox2);
            searchProduct.Controls.Add(groupBox1);
            searchProduct.Location = new Point(4, 27);
            searchProduct.Name = "searchProduct";
            searchProduct.Size = new Size(789, 417);
            searchProduct.TabIndex = 3;
            searchProduct.Text = "Search";
            searchProduct.Enter += searchClient_Enter;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ProductID, Designation, Description, Price, Amount });
            dataGridView1.Location = new Point(39, 205);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(543, 150);
            dataGridView1.TabIndex = 4;
            // 
            // ProductID
            // 
            ProductID.HeaderText = "ProductID";
            ProductID.Name = "ProductID";
            // 
            // Designation
            // 
            Designation.HeaderText = "Designation";
            Designation.Name = "Designation";
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.Name = "Description";
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.Name = "Price";
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.Name = "Amount";
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
            groupBox2.Text = "Search by Designation";
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
            label25.Size = new Size(70, 15);
            label25.TabIndex = 0;
            label25.Text = "Designation";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(39, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(263, 52);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search by";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Checked = true;
            radioButton2.Location = new Point(148, 22);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(85, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Description";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.Click += radioButton2_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(54, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(88, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Designation";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Click += radioButton1_Click;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Products);
            Name = "ProductsForm";
            Text = "Products";
            Products.ResumeLayout(false);
            addProduct.ResumeLayout(false);
            addProduct.PerformLayout();
            changeProduct.ResumeLayout(false);
            changeProduct.PerformLayout();
            deleteProduct.ResumeLayout(false);
            deleteProduct.PerformLayout();
            searchProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Products;
        private TabPage addProduct;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TabPage changeProduct;
        private Button button3;
        private Button button4;
        private TabPage deleteProduct;
        private ComboBox comboBox1;
        private Button button5;
        private Button button6;
        private TabPage searchProduct;
        private Button button8;
        private DataGridView dataGridView1;
        private Button button7;
        private GroupBox groupBox2;
        private TextBox textBox24;
        private Label label25;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox8;
        private Label label8;
        private TextBox textBox7;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn Designation;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Amount;
        private TabPage changeClient;
        private TabPage deleteClient;
    }
}