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
        Double value = 0;
        String opt= "";
        bool press = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (textBox1.Text == "0" || press == true)
            {
                textBox1.Clear();
                press = false;
            }

         
         
          
            if (b.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + b.Text ;
            }
            else
            {
                textBox1.Text = textBox1.Text + b.Text;
            }
           // textBox1.Text = textBox1.Text + b.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {   
            textBox1.Text = "0";
            value = 0;
            opt = "";
        }
         
        private void opt_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            opt = b.Text;
            value = Double.Parse(textBox1.Text);
            press = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (opt == "")
                textBox1.Text = "Invalid";
            
            switch (opt) {
                case "+":
                    textBox1.Text = (value + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                   // if (Double.Parse(textBox1.Text) - value > 0)
                    //{
                       // textBox1.Text = "-";
                     //   textBox1.Text = textBox1.Text + (Double.Parse(textBox1.Text) - value).ToString();
                    //}
                  //  else
                        textBox1.Text = (value - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (value * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    if (Double.Parse(textBox1.Text) == 0)
                        textBox1.Text = "NaN";
                    textBox1.Text = (value/Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;

            }
        
            press = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
    }
}
