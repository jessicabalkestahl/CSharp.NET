using System.Data;
using System.Data.SqlClient;

namespace WinFormsAppBD
{
    public partial class Form1 : Form
    {
        SqlConnection sql = new SqlConnection("Data Source=.;Initial Catalog=Exemplo;Integrated Security=true;");
        SqlCommand cmd = new();
        SqlDataAdapter adapter;
        int id = 0;
        public Form1()
        {
            InitializeComponent();
            ShowData();
        }

        private void ShowData()
        {
            sql.Open();
            DataTable dt = new();
            adapter = new("select * from RegistoPessoal", sql);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            sql.Close();
        }

        private void CleanData()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            id = 0;
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                cmd = new SqlCommand("INSERT INTO RegistoPessoal(Nome, Profissao) VALUES(@nome,@prof)", sql);
                sql.Open();
                cmd.Parameters.AddWithValue("@nome", textBox1.Text);
                cmd.Parameters.AddWithValue("@prof", textBox2.Text);
                cmd.ExecuteNonQuery();
                sql.Close();
                MessageBox.Show("Inserted successfully");
                ShowData();
                CleanData();
            }
            else
            {
                MessageBox.Show("Please fill out the details");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                cmd = new SqlCommand("UPDATE RegistoPessoal SET Nome=@nome, Profissao=@prof WHERE ID=@id", sql);
                sql.Open();
                cmd.Parameters.AddWithValue("@nome", id);
                cmd.Parameters.AddWithValue("@nome", textBox1.Text);
                cmd.Parameters.AddWithValue("@prof", textBox2.Text);
                cmd.ExecuteNonQuery();
                sql.Close();
                MessageBox.Show("Updated successfully");
                ShowData();
                CleanData();
            }
            else
            {
                MessageBox.Show("Please select a field to update");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                cmd = new SqlCommand("DELETE RegistoPessoal WHERE ID=@id", sql);
                sql.Open();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                sql.Close();
                MessageBox.Show("Deleted successfully");
                ShowData(); 
                CleanData();
            }
            else
            {
                MessageBox.Show("Please select a field to delete");
            }
        }
    }
}
