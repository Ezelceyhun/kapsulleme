using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kapsulleme
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Class1 Class1 = new Class1();
        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = Class1.id;
            label2.Text = Class1.ad;
            label3.Text = Class1.yas;
            label4.Text = Class1.pozisyon;
        }
    }
}
