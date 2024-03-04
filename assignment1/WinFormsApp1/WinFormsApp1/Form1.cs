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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(textBox1.Text);
            float num2 = float.Parse(textBox3.Text);
            char c= ' ';
            if (radioButton1.Checked)   c = char.Parse(radioButton1.Text);
            if (radioButton2.Checked)   c = char.Parse(radioButton2.Text);
            if (radioButton3.Checked)   c = char.Parse(radioButton3.Text);
            if (radioButton4.Checked)   c = char.Parse(radioButton4.Text);
            float s=0;
            bool flag=true;
            switch (c)
            {
                case '+':s = num1 + num2;break;
                case '-':s = num1 - num2;break;
                case '*':s = num1 * num2;break;
                case '/':
                    if (num2 == 0) flag=false;
                    else s = num1 / num2; 
                    break;
                default: flag=false; break;
            }
            string str = s.ToString("0.00");
            if (flag) textBox4.Text = str;
            else textBox4.Text = "input error";
        }
    }
}
