﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sınav_ortalama_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1,s2, s3,ort;
            s1=Convert.ToInt32(textBox1.Text);
            s2=Convert.ToInt32(textBox2.Text);
            s3=Convert.ToInt32(textBox3.Text);
            ort = (s1 + s2 + s3)/3;
            label4.Text=ort.ToString();
        }
    }
}
