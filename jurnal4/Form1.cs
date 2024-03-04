using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace jurnal4
{
    
    public partial class Form1 : Form
    {
        static int hasil = 0;
        static int hasil2 = 0;
        static string output = " ";
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button2.Text;
            output = output + button2.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            textBox1.Text = textBox1.Text + button1.Text;
            output = output + button1.Text;

        }

        private void button10_Click(object sender, EventArgs e)
        {   
            
            textBox1.Text = textBox1.Text + button10.Text;
            hasil2 = int.Parse(output);
            hasil = hasil + hasil2;
            hasil2 = 0;
            output = "";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button3.Text;
            output = output + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button4.Text;
            output = output + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Text;
            output = output + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Text;
            output = output + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button7.Text;
            output = output + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button8.Text;
            output = output + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Text;
            output = output + button9.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button11.Text;
            output = output + button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            hasil2 = int.Parse(output);
            hasil = hasil + hasil2;
            string keluar = Convert.ToString(hasil);
            textBox1.Text = keluar;
            hasil2 = 0;
            output = "0";
        }
    }
}
