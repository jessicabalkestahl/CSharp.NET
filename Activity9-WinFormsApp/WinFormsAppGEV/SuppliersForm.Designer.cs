namespace WinFormsAppGEV
{
    partial class SuppliersForm
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
            Suppliers = new TabControl();
            addSupplier = new TabPage();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            changeSupplier = new TabPage();
            button3 = new Button();
            button4 = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            textBox13 = new TextBox();
            textBox14 = new TextBox();
            textBox15 = new TextBox();
            textBox16 = new TextBox();
            deleteSupplier = new TabPage();
            comboBox1 = new ComboBox();
            button5 = new Button();
            button6 = new Button();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            textBox17 = new TextBox();
            textBox18 = new TextBox();
            textBox19 = new TextBox();
            textBox20 = new TextBox();
            textBox21 = new TextBox();
            textBox22 = new TextBox();
            textBox23 = new TextBox();
            searchSupplier = new TabPage();
            button8 = new Button();
            dataGridView1 = new DataGridView();
            SupplierID = new DataGridViewTextBoxColumn();
            Designation = new DataGridViewTextBoxColumn();
            NIF = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Mobile = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            Country = new DataGridViewTextBoxColumn();
            button7 = new Button();
            groupBox2 = new GroupBox();
            textBox24 = new TextBox();
            label25 = new Label();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            Suppliers.SuspendLayout();
            addSupplier.SuspendLayout();
            changeSupplier.SuspendLayout();
            deleteSupplier.SuspendLayout();
            searchSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Suppliers
            // 
            Suppliers.Appearance = TabAppearance.FlatButtons;
            Suppliers.Controls.Add(addSupplier);
            Suppliers.Controls.Add(changeSupplier);
            Suppliers.Controls.Add(deleteSupplier);
            Suppliers.Controls.Add(searchSupplier);
            Suppliers.Location = new Point(0, 1);
            Suppliers.Name = "Suppliers";
            Suppliers.SelectedIndex = 0;
            Suppliers.Size = new Size(797, 448);
            Suppliers.TabIndex = 0;
            // 
            // addSupplier
            // 
            addSupplier.BackColor = SystemColors.ActiveCaption;
            addSupplier.Controls.Add(label8);
            addSupplier.Controls.Add(label7);
            addSupplier.Controls.Add(label6);
            addSupplier.Controls.Add(label5);
            addSupplier.Controls.Add(label4);
            addSupplier.Controls.Add(label3);
            addSupplier.Controls.Add(label2);
            addSupplier.Controls.Add(label1);
            addSupplier.Controls.Add(button2);
            addSupplier.Controls.Add(button1);
            addSupplier.Controls.Add(textBox8);
            addSupplier.Controls.Add(textBox7);
            addSupplier.Controls.Add(textBox6);
            addSupplier.Controls.Add(textBox5);
            addSupplier.Controls.Add(textBox4);
            addSupplier.Controls.Add(textBox3);
            addSupplier.Controls.Add(textBox2);
            addSupplier.Controls.Add(textBox1);
            addSupplier.Location = new Point(4, 27);
            addSupplier.Name = "addSupplier";
            addSupplier.Padding = new Padding(3);
            addSupplier.Size = new Size(789, 417);
            addSupplier.TabIndex = 0;
            addSupplier.Text = "Add";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(41, 286);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 18;
            label8.Text = "Country";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 250);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 17;
            label7.Text = "Post Code";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(60, 214);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 16;
            label6.Text = "City";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 178);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 15;
            label5.Text = "Mobile";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 142);
            label4.Name = "label4";
            label4.Size = new Size(25, 15);
            label4.TabIndex = 14;
            label4.Text = "NIF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 106);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 13;
            label3.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 70);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 12;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 34);
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
            // textBox8
            // 
            textBox8.Location = new Point(114, 283);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(262, 23);
            textBox8.TabIndex = 7;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(114, 247);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(262, 23);
            textBox7.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(114, 211);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(262, 23);
            textBox6.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(114, 175);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(262, 23);
            textBox5.TabIndex = 4;
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
            // changeSupplier
            // 
            changeSupplier.BackColor = SystemColors.ActiveCaption;
            changeSupplier.Controls.Add(button3);
            changeSupplier.Controls.Add(button4);
            changeSupplier.Controls.Add(label9);
            changeSupplier.Controls.Add(label10);
            changeSupplier.Controls.Add(label11);
            changeSupplier.Controls.Add(label12);
            changeSupplier.Controls.Add(label13);
            changeSupplier.Controls.Add(label14);
            changeSupplier.Controls.Add(label15);
            changeSupplier.Controls.Add(label16);
            changeSupplier.Controls.Add(textBox9);
            changeSupplier.Controls.Add(textBox10);
            changeSupplier.Controls.Add(textBox11);
            changeSupplier.Controls.Add(textBox12);
            changeSupplier.Controls.Add(textBox13);
            changeSupplier.Controls.Add(textBox14);
            changeSupplier.Controls.Add(textBox15);
            changeSupplier.Controls.Add(textBox16);
            changeSupplier.Location = new Point(4, 27);
            changeSupplier.Name = "changeSupplier";
            changeSupplier.Padding = new Padding(3);
            changeSupplier.Size = new Size(789, 417);
            changeSupplier.TabIndex = 1;
            changeSupplier.Text = "Change";
            // 
            // button3
            // 
            button3.Location = new Point(422, 372);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 36;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = true;
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(40, 286);
            label9.Name = "label9";
            label9.Size = new Size(50, 15);
            label9.TabIndex = 34;
            label9.Text = "Country";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(29, 250);
            label10.Name = "label10";
            label10.Size = new Size(61, 15);
            label10.TabIndex = 33;
            label10.Text = "Post Code";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(59, 214);
            label11.Name = "label11";
            label11.Size = new Size(28, 15);
            label11.TabIndex = 32;
            label11.Text = "City";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(43, 178);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 31;
            label12.Text = "Mobile";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(62, 142);
            label13.Name = "label13";
            label13.Size = new Size(25, 15);
            label13.TabIndex = 30;
            label13.Text = "NIF";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(43, 106);
            label14.Name = "label14";
            label14.Size = new Size(49, 15);
            label14.TabIndex = 29;
            label14.Text = "Address";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(56, 70);
            label15.Name = "label15";
            label15.Size = new Size(36, 15);
            label15.TabIndex = 28;
            label15.Text = "Email";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(22, 34);
            label16.Name = "label16";
            label16.Size = new Size(70, 15);
            label16.TabIndex = 27;
            label16.Text = "Designation";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(113, 283);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(262, 23);
            textBox9.TabIndex = 26;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(113, 247);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(262, 23);
            textBox10.TabIndex = 25;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(113, 211);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(262, 23);
            textBox11.TabIndex = 24;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(113, 175);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(262, 23);
            textBox12.TabIndex = 23;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(113, 139);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(262, 23);
            textBox13.TabIndex = 22;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(113, 103);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(262, 23);
            textBox14.TabIndex = 21;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(113, 67);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(262, 23);
            textBox15.TabIndex = 20;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(113, 31);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(262, 23);
            textBox16.TabIndex = 19;
            // 
            // deleteSupplier
            // 
            deleteSupplier.BackColor = SystemColors.ActiveCaption;
            deleteSupplier.Controls.Add(comboBox1);
            deleteSupplier.Controls.Add(button5);
            deleteSupplier.Controls.Add(button6);
            deleteSupplier.Controls.Add(label17);
            deleteSupplier.Controls.Add(label18);
            deleteSupplier.Controls.Add(label19);
            deleteSupplier.Controls.Add(label20);
            deleteSupplier.Controls.Add(label21);
            deleteSupplier.Controls.Add(label22);
            deleteSupplier.Controls.Add(label23);
            deleteSupplier.Controls.Add(label24);
            deleteSupplier.Controls.Add(textBox17);
            deleteSupplier.Controls.Add(textBox18);
            deleteSupplier.Controls.Add(textBox19);
            deleteSupplier.Controls.Add(textBox20);
            deleteSupplier.Controls.Add(textBox21);
            deleteSupplier.Controls.Add(textBox22);
            deleteSupplier.Controls.Add(textBox23);
            deleteSupplier.Location = new Point(4, 27);
            deleteSupplier.Name = "deleteSupplier";
            deleteSupplier.Padding = new Padding(3);
            deleteSupplier.Size = new Size(789, 417);
            deleteSupplier.TabIndex = 2;
            deleteSupplier.Text = "Delete";
            deleteSupplier.Enter += deleteSupplier_Enter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(126, 34);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(262, 23);
            comboBox1.TabIndex = 55;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
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
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(53, 320);
            label17.Name = "label17";
            label17.Size = new Size(50, 15);
            label17.TabIndex = 52;
            label17.Text = "Country";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(42, 284);
            label18.Name = "label18";
            label18.Size = new Size(61, 15);
            label18.TabIndex = 51;
            label18.Text = "Post Code";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(72, 248);
            label19.Name = "label19";
            label19.Size = new Size(28, 15);
            label19.TabIndex = 50;
            label19.Text = "City";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(56, 212);
            label20.Name = "label20";
            label20.Size = new Size(44, 15);
            label20.TabIndex = 49;
            label20.Text = "Mobile";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(75, 176);
            label21.Name = "label21";
            label21.Size = new Size(25, 15);
            label21.TabIndex = 48;
            label21.Text = "NIF";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(56, 140);
            label22.Name = "label22";
            label22.Size = new Size(49, 15);
            label22.TabIndex = 47;
            label22.Text = "Address";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(69, 104);
            label23.Name = "label23";
            label23.Size = new Size(36, 15);
            label23.TabIndex = 46;
            label23.Text = "Email";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(42, 37);
            label24.Name = "label24";
            label24.Size = new Size(70, 15);
            label24.TabIndex = 45;
            label24.Text = "Designation";
            // 
            // textBox17
            // 
            textBox17.Location = new Point(126, 317);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(262, 23);
            textBox17.TabIndex = 44;
            // 
            // textBox18
            // 
            textBox18.Location = new Point(126, 281);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(262, 23);
            textBox18.TabIndex = 43;
            // 
            // textBox19
            // 
            textBox19.Location = new Point(126, 245);
            textBox19.Name = "textBox19";
            textBox19.Size = new Size(262, 23);
            textBox19.TabIndex = 42;
            // 
            // textBox20
            // 
            textBox20.Location = new Point(126, 209);
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(262, 23);
            textBox20.TabIndex = 41;
            // 
            // textBox21
            // 
            textBox21.Location = new Point(126, 173);
            textBox21.Name = "textBox21";
            textBox21.Size = new Size(262, 23);
            textBox21.TabIndex = 40;
            // 
            // textBox22
            // 
            textBox22.Location = new Point(126, 137);
            textBox22.Name = "textBox22";
            textBox22.Size = new Size(262, 23);
            textBox22.TabIndex = 39;
            // 
            // textBox23
            // 
            textBox23.Location = new Point(126, 101);
            textBox23.Name = "textBox23";
            textBox23.Size = new Size(262, 23);
            textBox23.TabIndex = 38;
            // 
            // searchSupplier
            // 
            searchSupplier.BackColor = SystemColors.ActiveCaption;
            searchSupplier.Controls.Add(button8);
            searchSupplier.Controls.Add(dataGridView1);
            searchSupplier.Controls.Add(button7);
            searchSupplier.Controls.Add(groupBox2);
            searchSupplier.Controls.Add(groupBox1);
            searchSupplier.Location = new Point(4, 27);
            searchSupplier.Name = "searchSupplier";
            searchSupplier.Size = new Size(789, 417);
            searchSupplier.TabIndex = 3;
            searchSupplier.Text = "Search";
            searchSupplier.Enter += searchSupplier_Enter;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { SupplierID, Designation, NIF, Email, Mobile, Address, City, Country });
            dataGridView1.Location = new Point(39, 205);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(715, 150);
            dataGridView1.TabIndex = 4;
            // 
            // SupplierID
            // 
            SupplierID.HeaderText = "SupplierID";
            SupplierID.Name = "SupplierID";
            // 
            // Designation
            // 
            Designation.HeaderText = "Designation";
            Designation.Name = "Designation";
            // 
            // NIF
            // 
            NIF.HeaderText = "NIF";
            NIF.Name = "NIF";
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // Mobile
            // 
            Mobile.HeaderText = "Mobile";
            Mobile.Name = "Mobile";
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.Name = "Address";
            // 
            // City
            // 
            City.HeaderText = "City";
            City.Name = "City";
            // 
            // Country
            // 
            Country.HeaderText = "Country";
            Country.Name = "Country";
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
            groupBox2.Text = "Search by NIF";
            // 
            // textBox24
            // 
            textBox24.Location = new Point(124, 30);
            textBox24.Name = "textBox24";
            textBox24.Size = new Size(133, 23);
            textBox24.TabIndex = 1;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(15, 33);
            label25.Name = "label25";
            label25.Size = new Size(25, 15);
            label25.TabIndex = 0;
            label25.Text = "NIF";
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
            radioButton2.Location = new Point(156, 22);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(43, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "NIF";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.Click += radioButton2_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(48, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(88, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Designation";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Click += radioButton1_Click;
            // 
            // SuppliersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Suppliers);
            Name = "SuppliersForm";
            Text = "Suppliers";
            Suppliers.ResumeLayout(false);
            addSupplier.ResumeLayout(false);
            addSupplier.PerformLayout();
            changeSupplier.ResumeLayout(false);
            changeSupplier.PerformLayout();
            deleteSupplier.ResumeLayout(false);
            deleteSupplier.PerformLayout();
            searchSupplier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Suppliers;
        private TabPage addSupplier;
        private TabPage changeSupplier;
        private TabPage deleteSupplier;
        private TabPage searchSupplier;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private Button button2;
        private Button button1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
        private Button button4;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBox14;
        private TextBox textBox15;
        private TextBox textBox16;
        private ComboBox comboBox1;
        private Button button5;
        private Button button6;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private TextBox textBox17;
        private TextBox textBox18;
        private TextBox textBox19;
        private TextBox textBox20;
        private TextBox textBox21;
        private TextBox textBox22;
        private TextBox textBox23;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private GroupBox groupBox2;
        private TextBox textBox24;
        private Label label25;
        private RadioButton radioButton2;
        private Button button7;
        private Button button8;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn SupplierID;
        private DataGridViewTextBoxColumn Designation;
        private DataGridViewTextBoxColumn NIF;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Mobile;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn Country;
    }
}