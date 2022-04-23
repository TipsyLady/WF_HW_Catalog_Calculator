using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_CW_Catalog
{
    public partial class Calculator : Form
    {
        double a, b;
        char operation;

        public Calculator()
        {
            InitializeComponent();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            operation = '+';
        }

        private void button13_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            operation = '-';
        }

        private void button14_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            operation = '*';
        }

        private void button16_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            operation = '/';
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Calc(); 
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
            string text = textBox1.Text;
            text = text.Remove(text.Length - 1);
            textBox1.Clear();
            textBox1.Text = text;
            }
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = textBox1.Text + "^";
            operation = '^';
        }

        private void button20_Click(object sender, EventArgs e)
        { 
            a = Convert.ToDouble(textBox1.Text);
            operation = 's';
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Calc()
        {
           
            switch(operation)
            {
               
                case '+':
                    b = a + Convert.ToDouble(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case '-':
                    b = a - Convert.ToDouble(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case '*':
                    b = a * Convert.ToDouble(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case '/':
                    if (Convert.ToDouble(textBox1.Text) <= 0)
                    { textBox1.Text = "деление на ноль невозможно"; }
                    else
                    {
                        b = a / Convert.ToDouble(textBox1.Text);
                        textBox1.Text = b.ToString();
                    }
                    break;
                case '^':
                    b = a * a;
                    textBox1.Text = b.ToString();
                    break;
                case 's':
                    b = Math.Sqrt(a);
                    textBox1.Text = b.ToString();
                    break;
            }
            
        }
    }
}
