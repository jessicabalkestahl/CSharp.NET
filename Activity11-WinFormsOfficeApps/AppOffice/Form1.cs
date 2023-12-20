using Microsoft.Office.Interop.Excel;

namespace AppOffice
{
    public partial class Form1 : Form
    {
        string studentName;
        int grade1, grade2;
        float averageGrade;
        string hasPassed;

        Microsoft.Office.Interop.Excel.Application excelApp;
        string excelBookPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Excel";
            textBox1.Text = null;

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox1.Items.Add("");
            comboBox2.Items.Add("");

            for (int grade = 1; grade <= 20; grade++)
            {
                comboBox1.Items.Add(grade);
                comboBox2.Items.Add(grade);
            }

            comboBox1.Text = null;
            comboBox2.Text = null;
            textBox2.Text = null;
            textBox2.ReadOnly = true;

            StartExcel();

            if (VerifyFile() == false)
            {
                CreateFile();
            }
            else
            {
                OpenFile();
            }
        }

        private void StartExcel()
        {
            excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = true;
        }

        private bool VerifyFile()
        {
            excelBookPath = excelApp.StartupPath + "/students.xlsx";
            if (System.IO.File.Exists(excelBookPath))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void CreateFile()
        {
            excelApp.Workbooks.Add();
            excelApp.Sheets["Sheet1"].Select();

            excelApp.Range["A1"].Value = "Name";
            excelApp.Range["B1"].Value = "Grade 1";
            excelApp.Range["C1"].Value = "Grade 2";
            excelApp.Range["D1"].Value = "Average";
            excelApp.Range["E1"].Value = "Situation";

            FormatFile();
        }

        private void OpenFile()
        {
            excelApp.Workbooks.Open(excelBookPath);
        }

        private void FormatFile()
        {
            excelApp.Range["A1:E1"].Font.Bold = true;
            excelApp.Range["A1:E1"].Interior.Color = Constants.xlGray50;
            excelApp.Range["A1:E1"].HorizontalAlignment = Constants.xlCenter;

            excelApp.Columns["A:A"].ColumnWidth = 30;
            excelApp.Columns["B:B"].ColumnWidth = 10;
            excelApp.Columns["C:C"].ColumnWidth = 10;
            excelApp.Columns["D:D"].ColumnWidth = 10;
            excelApp.Columns["E:E"].ColumnWidth = 20;

            if (VerifyFile() == false)
            {
                SaveFileAs();
            }
            else
            {
                SaveFile();
            }
        }

        private void SaveFileAs()
        {
            excelApp.ActiveWorkbook.SaveAs(excelBookPath);
        }

        private void SaveFile()
        {
            excelApp.ActiveWorkbook.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateData() == true)
            {
                CalculateGradesAverage();
            }
        }

        private bool ValidateData()
        {
            if (textBox1.Text.Length < 2)
            {
                MessageBox.Show("Enter the student name: ");
                textBox1.SelectAll();
                textBox1.Focus();
                return false;
            }
            if (comboBox1.Text.Length == 0)
            {
                MessageBox.Show("Select Grade 1");
                comboBox1.Focus();
                return false;
            }
            if (comboBox2.Text.Length == 0)
            {
                MessageBox.Show("Select Grade 2");
                comboBox2.Focus();
                return false;
            }

            return true;
        }

        private void CalculateGradesAverage()
        {
            studentName = textBox1.Text;
            grade1 = int.Parse(comboBox1.Text);
            grade2 = int.Parse(comboBox2.Text);
            averageGrade = (grade1 + grade2) / 2;

            if (grade1 < 8 && grade2 < 8)
            {
                hasPassed = "Failed";
            }
            else if (grade1 < 8 && grade2 >= 8)
            {
                hasPassed = "Repeat Test 1";
            }

            else if (grade2 < 8 && grade1 >= 8)
            {
                hasPassed = "Repeat Test 2";
            }
            else if (grade1 >= 8 && grade2 >= 8)
            {
                if (averageGrade >= 9.5)
                {
                    hasPassed = "Passed";
                }
                else
                {
                    hasPassed = "Oral";
                }
            }

            textBox2.Text = averageGrade + "(" + hasPassed + ")";
            ExportExcel();
        }

        private void ExportExcel()
        {
            excelApp.Sheets["Sheet1"].Select();
            int exceline = 2;
            bool value = true;

            while (value)
            {
                if (excelApp.Range["A" + exceline].Value != null)
                {
                    value = true;
                    exceline++;
                }
                else
                {
                    value = false;
                }
            }

            excelApp.Range["A" + exceline].Value = studentName;
            excelApp.Range["B" + exceline].Value = grade1;
            excelApp.Range["C" + exceline].Value = grade2;
            excelApp.Range["D" + exceline].Value = averageGrade;
            excelApp.Range["E" + exceline].Value = hasPassed;
            FormatFile();
            Colour();
        }

        private void Colour()
        {
            excelApp.Sheets["Sheet1"].Select();
            int excelLine = 2;
            bool value = true;
            string hasPassed;

            while (value)
            {
                if (excelApp.Range["E" + excelLine].Value != null)
                {
                    hasPassed = excelApp.Range["E" + excelLine].Value;
                    switch (hasPassed)
                    {
                        case "Passed":
                            excelApp.Range["A" + excelLine + ":" + "E" + excelLine].Interior.Color = Color.FromArgb(0, 255, 0);
                            excelApp.Range["A" + excelLine + ":" + "E" + excelLine].Font.Color = Color.FromArgb(0, 0, 0);
                            break;
                        case "Failed":
                            excelApp.Range["A" + excelLine + ":" + "E" + excelLine].Interior.Color = Color.FromArgb(255, 0, 0);
                            excelApp.Range["A" + excelLine + ":" + "E" + excelLine].Font.Color = Color.FromArgb(255, 255, 255);
                            break;
                        case "Oral":
                            excelApp.Range["A" + excelLine + ":" + "E" + excelLine].Interior.Color = Color.FromArgb(255, 255, 0);
                            excelApp.Range["A" + excelLine + ":" + "E" + excelLine].Font.Color = Color.FromArgb(0, 0, 0);
                            break;
                        default:
                            excelApp.Range["A" + excelLine + ":" + "E" + excelLine].Interior.Color = Constants.xlNone;
                            excelApp.Range["A" + excelLine + ":" + "E" + excelLine].Font.Color = Color.FromArgb(0, 0, 0);
                            break;
                    }
                    value = true;
                    excelLine++;
                }
                else
                {
                    value = false;
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveFile();
            excelApp.Quit();
        }
    }
}
