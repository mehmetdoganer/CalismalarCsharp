using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Karar_yapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            if ( a % 2 == 0 || a >= 10)
            {
                label1.Text = "Sayı çift veya 10'dan büyük";
            }
            else
            {
                label1.Text = "Sayı çift değil veya 10'dan büyük değil";
            }
        }
    }
}
