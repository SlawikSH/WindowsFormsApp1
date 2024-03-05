using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private double num1 = 0;
        private double num2 = 0;
        private string znak = " ";
        private bool hasComma=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            znak = ((Button)sender).Text;
            textBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num2 = Double.Parse(textBox1.Text);
            switch (znak)
            {
                case "*":
                    textBox1.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    if(num1 / num2 == 0)
                    {
                        textBox1.Clear();
                        MessageBox.Show("Попытка деления на ноль.");
                    }
                    textBox1.Text = (num1 / num2).ToString();
                    break;
                case "-":
                    textBox1.Text = (num1 - num2).ToString();
                    break;
                case "+":
                    textBox1.Text += (num1 + num2).ToString();
                    break;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Split('.').Length - 1>= 1 || hasComma)
            {
                return;
            }
            textBox1.Text = textBox1.Text + ",";
            hasComma = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
