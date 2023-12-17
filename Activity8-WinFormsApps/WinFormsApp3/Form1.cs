namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Arial");
            comboBox1.Items.Add("Times New Roman");
            comboBox1.Items.Add("Verdana");
            comboBox1.Text = "Arial";

            comboBox2.Items.Add("10");
            comboBox2.Items.Add("12");
            comboBox2.Items.Add("14");
            comboBox2.Text = "10";

            comboBox3.Items.Add("Normal");
            comboBox3.Items.Add("Bold");
            comboBox3.Items.Add("Italic");
            comboBox3.Items.Add("Underline");
            comboBox3.Text = "Normal";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        void FormatText()
        {
            string type = comboBox1.Text;
            int size = int.Parse(comboBox2.Text);
            FontStyle fontStyle = new();

            switch (comboBox3.Text)
            {
                case "Normal":
                    fontStyle = FontStyle.Regular;
                    break;
                case "Bold":
                    fontStyle = FontStyle.Bold;
                    break;
                case "Italic":
                    fontStyle = FontStyle.Italic;
                    break;
                case "Underline":
                    fontStyle = FontStyle.Underline;
                    break;
                default:
                    fontStyle = FontStyle.Regular;
                    break;
            }

            richTextBox1.SelectionFont = new Font(type, size, fontStyle);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                FormatText();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                FormatText();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                FormatText();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            FormatText();
        }

        
    }
}
