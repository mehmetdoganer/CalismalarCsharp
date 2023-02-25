using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YarıÇapı_girilen_Alan_Çevre_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double yc, a,c;
            yc =Convert.ToInt32( textBox1.Text);
            a = 3.14 * (yc * yc);
            label3.Text = a.ToString();
            c = 2 * 3.14 * yc;
            label5.Text = c.ToString();

        }
    }
}
