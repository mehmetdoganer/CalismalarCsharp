using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Öğrenci_Sınav_Notları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            int s1, s2, proje;
            s1 =Convert.ToInt32 (textBox3.Text);
            s2=Convert.ToInt32 (textBox4.Text);
            proje = Convert.ToInt32(textBox5.Text);
            listBox1.Items.Add(ad+" "+soyad+" " +"Ortalama : "+((s1+s2+proje)/3) );
        }
    }
}
