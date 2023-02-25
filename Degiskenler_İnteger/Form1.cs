using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Degiskenler_İnteger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kısakenar, uzunkenar, cevre, alan;
            kısakenar = 5;
            uzunkenar = 10;
            cevre = (kısakenar*2)+(uzunkenar*2);
            alan = kısakenar * uzunkenar;

            label1.Text = "Çevre:"+ cevre + " " +"Alan:"+alan;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sınav1, sınav2, sınav3, ort  ;
            sınav1= 50;
            sınav2 = 60;
            sınav3 = 70;
             ort = ((sınav1 + sınav2 + sınav3) / 3);
            label2.Text = ort.ToString();
        

        }
    }
}
