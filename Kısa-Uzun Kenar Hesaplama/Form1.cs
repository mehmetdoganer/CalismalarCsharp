using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kısa_Uzun_Kenar_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k, u,a,c;   
            k = Convert.ToInt32(textBox1.Text);
            u = Convert.ToInt32(textBox2.Text);
            a = k * u;
            label5.Text= a.ToString();  
            c = (u*2) +  (k*2);
            label6.Text= c.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();   
        }
    }
}
