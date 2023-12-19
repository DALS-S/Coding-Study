using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1031_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button b = new Button();
            b.Location = new Point(100, 100);
            b.Text = "OK";
            b.Click += B_Click;
            Controls.Add(b);
        }

        private void B_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test: " + Fibonacci(10));
        }

        Dictionary<int, long> num = new Dictionary<int, long>();
        long Fibonacci(int i)
        {
            // 기본 값
            if (i < 0)
            {
                return 0;
            }
            if (i == 1)
            {
                return 1;
            }

            // 이미 계산 했던 값인지 확인
            if (num.ContainsKey(i))
            {
                return num[i];
            }
            // 계산하지 않았다면 계산
            else
            {
                long value = Fibonacci(i - 2) + Fibonacci(i - 1);
                num[i] = value;
                return value;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int num);
            label1.Text = Fibonacci(num) + "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("yyyy년MM월dd일HH시mm분ss초");
        }
    }
}
