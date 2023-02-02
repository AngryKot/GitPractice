using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 7; int b = 0; int c = 0;
        //c = a + b;
        //    d = a - b;
        //    f = a* b;
        //g = a / b;
        //    j = a % b;
        //    m = ++a;
        //    n = --b;
        //    //after reset
        //    Console.WriteLine(c);
        //    Console.WriteLine(d);
        //    Console.WriteLine(f);
        //    Console.WriteLine(g);
        //    Console.WriteLine(j);
        //    Console.WriteLine(m);
        //    Console.WriteLine(n);
        //    Console.ReadLine();
        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = a + b;
            label1.Text = c.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = a - b;
            label1.Text = c.ToString();
        }
    }
}
