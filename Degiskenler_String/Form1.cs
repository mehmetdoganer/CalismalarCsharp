﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Degiskenler_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string adsoyad, yas, meslek, cinsiyet;
            adsoyad = textBox1.Text;
            listBox1.Items.Add(adsoyad);
            yas = maskedTextBox1.Text;
            listBox1.Items.Add(yas);
            meslek = textBox3.Text;
            listBox1.Items.Add(meslek);
            cinsiyet = textBox4.Text;
            listBox1.Items.Add(cinsiyet);
            

            
        }
    }
}
