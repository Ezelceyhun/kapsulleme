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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Class1 sinif= new Class1();
            sinif.id = textBox1.Text;
            sinif.ad = textBox2.Text;
            sinif.yas = textBox3.Text;
            sinif.pozisyon = textBox4.Text;
            Form2 frm = new Form2();
            frm.Class1 = sinif;
            frm.Show();

           
        }
    }
}
