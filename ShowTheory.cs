using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyCareerApp
{
    public partial class ShowTheory : Form
    {
        public ShowTheory()
        {
            InitializeComponent();
        }

        private void ShowTheory_Load(object sender, EventArgs e)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Theory\\softwareDeveloper.txt");
            string fileText = File.ReadAllText(filePath);
            richTextBox1.Text = fileText;
            label1.Text = TheoryForm.speciality;

        }

       
    }
}
