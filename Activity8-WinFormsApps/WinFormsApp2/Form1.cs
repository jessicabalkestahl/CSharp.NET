using System.Diagnostics;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            int day, month, year;
            string dateAsString;
            DateTime date;

            if (maskedTextBox1.MaskCompleted == true)
            {
                dateAsString = maskedTextBox1.Text;
                day = int.Parse(dateAsString.Substring(0, 2));
                month = int.Parse(dateAsString.Substring(3, 2));
                year = int.Parse(dateAsString.Substring(6, 4));

                try
                {
                    date = DateTime.Parse(day + "-" + month + "-" + year);
                    dateTimePicker1.Value = date;
                    monthCalendar1.SelectionStart = date;
                }
                catch
                {
                    MessageBox.Show("Incorrect date!", "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateTimePicker1.Value = monthCalendar1.SelectionStart;
            string dateAsString = monthCalendar1.SelectionStart.ToShortDateString();
            string[] separatedDateElements = dateAsString.Split('/');
            string day = separatedDateElements[0].Length == 1 ? "0" + separatedDateElements[0] : separatedDateElements[0];
            string month = separatedDateElements[1].Length == 1 ? "0" + separatedDateElements[1] : separatedDateElements[1];
            string dateParsed = day + "/" + month + "/" + separatedDateElements[2];
            maskedTextBox1.Text = dateParsed;
        }
    }
}
