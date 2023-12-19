using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1102_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fighter f = new Fighter();
            f.Fight();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string msg = new Fighter().Die();
            MessageBox.Show(msg);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fighter f = new Fighter();
            f.id = textBox1.Text;
            f.Lv = int.Parse(textBox2.Text);
            MessageBox.Show(f.SayHello());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fighter f = new Fighter();
            f.id = textBox1.Text;
            f.Lv = int.Parse(textBox2.Text);
            new Form2(f.SayHello()).Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://naver.com");
        }
    }
}
