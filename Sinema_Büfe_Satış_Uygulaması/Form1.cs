using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sinema_Büfe_Satış_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasa = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int mısır, su, çay, bilet, toplam;
            mısır =Convert.ToInt32 (textBox1.Text);
            su= Convert.ToInt32 (textBox2.Text);
            çay = Convert.ToInt32 (textBox3.Text);
            bilet= Convert.ToInt32 (textBox4.Text);
            toplam = mısır * 4 + su * 1 + çay * 2 + bilet * 8;
            label16.Text = toplam.ToString()+ " TL";
            kasa = kasa + toplam;
            label15.Text = kasa.ToString()+" TL";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
