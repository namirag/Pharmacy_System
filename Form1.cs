using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Managment_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
s
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 Doctor = new Form2();
            Doctor.Show();
        }
    }
}
