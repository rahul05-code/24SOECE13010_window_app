﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24SOECE13010_window_app
{
    public partial class Form3 : Form
    {
        double num1, num2, result;
        string op = " ";
        public Form3()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
        
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "2";
            }
            else
            {
                richTextBox1.Text += "2";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = " ";
            op = "%";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "6";
            }
            else
            {
                richTextBox1.Text += "6";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "8";
            }
            else
            {
                richTextBox1.Text += "8";
            }
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "1";
            }
            else
            {
                richTextBox1.Text += "1";
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "3";
            }
            else
            {
                richTextBox1.Text += "3";
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "4";
            }
            else
            {
                richTextBox1.Text += "4";
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "5";
            }
            else
            {
                richTextBox1.Text += "5";
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "7";
            }
            else
            {
                richTextBox1.Text += "7";
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "9";
            }
            else
            {
                richTextBox1.Text += "9";
            }
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = ".";
            }
            else
            {
                richTextBox1.Text += ".";
            }

        }

        private void clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            num1 = 0;
            num2 = 0;
            result = 0;
        }

        private void clearall_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            num1 = 0;
            num2 = 0;
            result = 0;
        }

        private void edition_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = " ";
            op = "+";
        }

        private void substract_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = " ";
            op = "-";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(richTextBox1.Text);
           
            if(op=="+")
            {
                result = num1 + num2;
                richTextBox1.Text = result.ToString();
            }
            if(op=="-")
            {
                result = num1 - num2;
                richTextBox1.Text = result.ToString();
            }
            if(op=="*")
            {
                result = num1 * num2;
                richTextBox1.Text = result.ToString();
            }
            if(op=="/")
            {
                if(num2 == 0)
                {
                    richTextBox1.Text = "Cannot divide by zero";
                }
                else
                {
                    result = num1 / num2;
                    richTextBox1.Text = result.ToString();
                }
            }
            if(op == "%")
            {
                if(num2 == 0)
                {
                    richTextBox1.Text = "Cannot divide by zero";
                }
                else
                {
                    result = num1 % num2;
                    richTextBox1.Text = result.ToString();
                }
            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = " ";
            op = "/";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = " ";
            op = "*";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "0";
            }
            else
            {
                richTextBox1.Text += "0";
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
