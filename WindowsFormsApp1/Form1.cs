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
        public Form1()
        {
            InitializeComponent();
        }

        public static double Sum(double a, double b)
        {
            return a + b;
        }
        public static double Raz(double a, double b)
        {
            return a - b;
        }

        public static double Umn(double a, double b)
        {
            return a * b;
        }

        public static double Del(double a, double b)
        {
            return a / b;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(Sum(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(Raz(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(Umn(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(Del(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }
    }
}
