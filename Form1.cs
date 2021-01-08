using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        string c;
        double x;
        
        private void button10_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + b.Text;

                
                
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            c= b.Text;
            x = int.Parse(textBox1.Text);
            label1.Text = textBox1.Text + " " + c ;
            textBox1.Clear();


        }

        private void button16_Click(object sender, EventArgs e)
        {
           switch (c)
            {
                case "+":
                    {
                        double y = int.Parse(textBox1.Text);
                        textBox1.Text = (x + y).ToString();
                        label1.Text = "";
                    }
                    break;
                case "-":
                    {
                        double y = int.Parse(textBox1.Text);
                        textBox1.Text = (x - y).ToString();
                        label1.Text = "";
                    }
                    break;
                case "÷":
                    {
                        double y = int.Parse(textBox1.Text);
                        textBox1.Text = (x / y).ToString();
                        label1.Text = "";
                    }
                    break;
                case "×":
                    {
                        double y = int.Parse(textBox1.Text);
                        textBox1.Text = (x * y).ToString();
                        label1.Text = "";
                    }
                    break;
            }


              
                    

               

        }
    }
}
