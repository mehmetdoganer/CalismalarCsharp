using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Udemy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("merhaba dünya");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "mehmet";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = "Mehmet";
            label6.Text = "Doğaner";
            label7.Text = "İşçi";

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label9.Text = textBox1.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label10.Text = textBox2.Text;
            label11.Text = textBox3.Text;
            label12.Text = textBox4.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label10.Text = " ";
            label11.Text = " ";
            label12.Text = " ";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Antalya");
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox5.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Kasiyer");
            listBox1.Items.Add("Muhasebeci");
            listBox1.Items.Add("Futbolcu");


        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox6.Text);
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox6.Text+" "+textBox7.Text+" "+textBox8.Text+" "+textBox9.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox10.Text);
            listBox2.Items.Add(maskedTextBox1.Text);
            listBox2.Items.Add(maskedTextBox2.Text);
            listBox2.Items.Add(comboBox2.Text);
            listBox2.Items.Add(maskedTextBox1.Text);
            listBox2.Items.Add(dateTimePicker1.Text);




        }

        private void button13_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();        }
    }
}
