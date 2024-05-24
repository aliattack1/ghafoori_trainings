using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trainingcalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void addtext(string text)
        {
            if (button16.Enabled == true) {this.textBox1.Text = this.textBox1.Text + text;}
            else {
                this.textBox1.Text = text;
            }
            
        }

        public void ntheme()
        {
            if (this.BackColor == Color.White || this.BackColor == Color.Coral)
            {
                this.button1.BackColor = Color.SkyBlue;
                this.button2.BackColor = Color.SkyBlue;
                this.button3.BackColor = Color.SkyBlue;
                this.button4.BackColor = Color.SkyBlue;
                this.button5.BackColor = Color.SkyBlue;
                this.button6.BackColor = Color.SkyBlue;
                this.button7.BackColor = Color.SkyBlue;
                this.button8.BackColor = Color.SkyBlue;
                this.button9.BackColor = Color.SkyBlue;
                this.button10.BackColor = Color.SkyBlue;
                this.button11.BackColor = Color.SkyBlue;
                this.button12.BackColor = Color.SkyBlue;
                this.button13.BackColor = Color.SkyBlue;
                this.button14.BackColor = Color.SkyBlue;
                this.button15.BackColor = Color.SkyBlue;
                this.button16.BackColor = Color.SkyBlue;
                this.button17.BackColor = Color.SkyBlue;
                textBox1.BackColor = Color.LightBlue;
                this.BackColor = Color.LightCyan;
            }
            else if (this.BackColor == Color.LightCyan)
            {
                this.button1.BackColor = Color.LightGreen;
                this.button2.BackColor = Color.LightGreen;
                this.button3.BackColor = Color.LightGreen;
                this.button4.BackColor = Color.LightGreen;
                this.button5.BackColor = Color.LightGreen;
                this.button6.BackColor = Color.LightGreen;
                this.button7.BackColor = Color.LightGreen;
                this.button8.BackColor = Color.LightGreen;
                this.button9.BackColor = Color.LightGreen;
                this.button10.BackColor = Color.LightGreen;
                this.button11.BackColor = Color.LightGreen;
                this.button12.BackColor = Color.LightGreen;
                this.button13.BackColor = Color.LightGreen;
                this.button14.BackColor = Color.LightGreen;
                this.button15.BackColor = Color.LightGreen;
                this.button16.BackColor = Color.LightGreen;
                this.button17.BackColor = Color.LightGreen;
                textBox1.BackColor = Color.GreenYellow;
                this.BackColor = Color.DarkGreen;
            }
            else if (this.BackColor == Color.DarkGreen)
            {
                this.button1.BackColor = Color.Orange;
                this.button2.BackColor = Color.Orange;
                this.button3.BackColor = Color.Orange;
                this.button4.BackColor = Color.Orange;
                this.button5.BackColor = Color.Orange;
                this.button6.BackColor = Color.Orange;
                this.button7.BackColor = Color.Orange;
                this.button8.BackColor = Color.Orange;
                this.button9.BackColor = Color.Orange;
                this.button10.BackColor = Color.Orange;
                this.button11.BackColor = Color.Orange;
                this.button12.BackColor = Color.Orange;
                this.button13.BackColor = Color.Orange;
                this.button14.BackColor = Color.Orange;
                this.button15.BackColor = Color.Orange;
                this.button16.BackColor = Color.Orange;
                this.button17.BackColor = Color.Orange;
                textBox1.BackColor = Color.LightCoral;
                this.BackColor = Color.Coral;
            }

        }

        public void operation(string operation)
        {
            this.button16.Enabled = false;
            this.button15.Enabled = false;
            this.button14.Enabled = false;
            this.button13.Enabled = false;
            this.button12.Enabled = true;
            this.label1.Text = this.textBox1.Text;
            this.label2.Text = operation;
            this.textBox1.Text = "";
        }

        public string op()
        {
            switch (this.label2.Text)
            {
                case"+":
                    {
                        return (int.Parse(this.label1.Text) + int.Parse(this.textBox1.Text)).ToString();
                        break;
                    }
                case "-":
                    {
                        return (int.Parse(this.label1.Text) - int.Parse(this.textBox1.Text)).ToString();
                        break;
                    }
                case "/":
                    {
                        return (int.Parse(this.label1.Text) / int.Parse(this.textBox1.Text)).ToString();
                        break;
                    }
                case "*":
                    {
                        return (int.Parse(this.label1.Text) * int.Parse(this.textBox1.Text)).ToString();
                        break;
                    }
            }
            return "";
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.button12.Enabled = false;
            ntheme();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addtext("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addtext("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addtext("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addtext("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addtext("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addtext("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            addtext("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            addtext("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            addtext("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            addtext("0");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            addtext(".");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operation("+");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            operation("-");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operation("/");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            operation("*");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = op();
            this.label1.Text = "";
            this.label2.Text = "";
            this.button13.Enabled = true;
            this.button14.Enabled = true;
            this.button15.Enabled = true;
            this.button16.Enabled = true;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            ntheme();
        }
    }
}
