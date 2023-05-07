using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCareerApp
{
    public partial class Test : Form
    {
        private string speciality;

        public Test(string speciality)
        {
            InitializeComponent();
            this.speciality = speciality;
        }

        private void Test_Load(object sender, EventArgs e)
        {
            groupBox1.Text = speciality;
        }
    }
}
