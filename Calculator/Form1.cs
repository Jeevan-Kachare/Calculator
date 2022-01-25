using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        float res,res1,num,num1,opr,n;
        string s1, s2;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Convert.ToString(0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += Convert.ToString(8);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += Convert.ToString(7);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += Convert.ToString(9);
        }

        private void button14_Click(object sender, EventArgs e)
        {           
            string s1=richTextBox1.Text;
            richTextBox1.Text = "";
            num = float.Parse(s1);      
             n = 1;               
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += Convert.ToString(4);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += Convert.ToString(5);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += Convert.ToString(6);
        }

        private void button15_Click(object sender, EventArgs e)
        {

            string s1 = richTextBox1.Text;
            richTextBox1.Text = "";
            num = float.Parse(s1);
            n = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += Convert.ToString(1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += Convert.ToString(2);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += Convert.ToString(3);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string s1 = richTextBox1.Text;
            richTextBox1.Text = "";
            num = float.Parse(s1);
            n = 3;
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += Convert.ToString(0);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string s1 = richTextBox1.Text;
            richTextBox1.Text += ".";
            num = float.Parse(s1);        
        }

        private void button13_Click(object sender, EventArgs e)
        {

            string s2 = richTextBox1.Text;
            //richTextBox1.Text +=Convert.ToString("+");
            float num1 = float.Parse(s2);
            if (n == 1)
            {
                res = num + num1;
            }
            else if (n == 2)
            {
                res = num - num1;
            }
            else if (n == 3)
            {
                res = num * num1;
            }
            else if (n == 4)
            {
                res = num / num1;
            }
            richTextBox1.Text = Convert.ToString(res);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string s1 = richTextBox1.Text;
            richTextBox1.Text = "";
            num = float.Parse(s1);
            n = 4;
        }
    }
}
