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
        Double resultValue = 0;
        String operationPerformed = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0")
                textBoxResult.Clear();

            Button button = (Button)sender;
            textBoxResult.Text = textBoxResult.Text + button.Text;
        }

        private void button_click_operator(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = Double.Parse(textBoxResult.Text);

        }

        private void button_click_clear(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            resultValue = 0;
        }

        private void button_click_clear_entry(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
        }

        private void button_click_equal(object sender, EventArgs e)
        {
            switch(operationPerformed)
            {
                case "+":
                    textBoxResult.Text= (resultValue + Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "-":
                    textBoxResult.Text = (resultValue - Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "/":
                    textBoxResult.Text = (resultValue / Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "*":
                    textBoxResult.Text = (resultValue * Double.Parse(textBoxResult.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
