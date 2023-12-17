using System.Diagnostics;
using System.IO;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Value = 1;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            DirectoryInfo imageDirectory = new("./images");
            FileInfo[] files = imageDirectory.GetFiles();
            int numberOfFiles = files.Length;
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = numberOfFiles;
            int numberOfChosenFile = (int)numericUpDown1.Value - 1;
            string pathToChosenFile = files[numberOfChosenFile].FullName;

            try
            {
                pictureBox1.BackgroundImage = Image.FromFile(pathToChosenFile);
                toolTip1.SetToolTip(pictureBox1, pathToChosenFile);
            }
            catch
            {
                pictureBox1.BackgroundImage = null;
                toolTip1.SetToolTip(pictureBox1, "Image not available");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
