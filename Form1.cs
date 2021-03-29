using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double input = 0.0, output = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ((String)textBox1.Text!="")
                input = Double.Parse(textBox1.Text);
            else input = 0;
            if ((String)comboBox1.SelectedItem == "USD")
            {
                if ((String)comboBox2.SelectedItem == "USD") output = input;
                else if ((String)comboBox2.SelectedItem == "JPY") output = input * 109.71;
                else if ((String)comboBox2.SelectedItem == "IDR") output = input * 14465.80;
                else if ((String)comboBox2.SelectedItem == "EUR") output = input * 0.85;
                else if ((String)comboBox2.SelectedItem == "RM") output = input * 4.15;
                
            }
            else if ((String)comboBox1.SelectedItem == "JPY")
            {
                if ((String)comboBox2.SelectedItem == "USD") output = input * 0.0091;
                else if ((String)comboBox2.SelectedItem == "JPY") output = input;
                else if ((String)comboBox2.SelectedItem == "IDR") output = input * 131.69;
                else if ((String)comboBox2.SelectedItem == "EUR") output = input * 0.0077;
                else if ((String)comboBox2.SelectedItem == "RM") output = input * 0.038;
            }
            else if ((String)comboBox1.SelectedItem == "IDR")
            {
                if ((String)comboBox2.SelectedItem == "USD") output = input * 0.000069;
                else if ((String)comboBox2.SelectedItem == "JPY") output = input * 0.0076;
                else if ((String)comboBox2.SelectedItem == "IDR") output = input;
                else if ((String)comboBox2.SelectedItem == "EUR") output = input * 0.000059;
                else if ((String)comboBox2.SelectedItem == "RM") output = input * 0.00029;
            }
            else if ((String)comboBox1.SelectedItem == "EUR")
            {
                if ((String)comboBox2.SelectedItem == "USD") output = input * 1.18;
                else if ((String)comboBox2.SelectedItem == "JPY") output = input * 129.13;
                else if ((String)comboBox2.SelectedItem == "IDR") output = input * 17022.57;
                else if ((String)comboBox2.SelectedItem == "EUR") output = input;
                else if ((String)comboBox2.SelectedItem == "RM") output = input * 4.88;
            }
            else
            {
                if ((String)comboBox2.SelectedItem == "USD") output = input * 0.24;
                else if ((String)comboBox2.SelectedItem == "JPY") output = input * 26.48;
                else if ((String)comboBox2.SelectedItem == "IDR") output = input * 3489.29;
                else if ((String)comboBox2.SelectedItem == "EUR") output = input * 0.20;
                else if ((String)comboBox2.SelectedItem == "RM") output = input;
            }
            toBox.Text = output.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void toBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
