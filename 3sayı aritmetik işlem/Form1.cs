using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3sayı_aritmetik_işlem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c,t,cı,ca;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = Convert.ToInt32(textBox3.Text);
            t = a + b + c;
            label1.Text=t.ToString();
            cı = a - b - c;
            label2.Text=cı.ToString();
            ca = a * b * c;
            label3.Text=ca.ToString();


        }
    }
}
