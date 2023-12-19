using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1031_04
{
    public partial class Form2 : Form
    {
        int number;
        int time;
        public Form2()
        {
            InitializeComponent();
            number = new Random().Next(1, 11);
            Console.WriteLine(number);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = time.ToString();
            if(time >= 3)
            {
                label2.Text = "TimeOver";
            }
            else
            {
                time++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int answer = int.Parse(textBox1.Text);
            if (number < answer)
            {
                MessageBox.Show("정답 보다 큰 값을 골랐습니다");
            }
            else if (number > answer)
            {
                MessageBox.Show("정답 보다 작은 값을 골랐습니다");
            }
            else
            {
                MessageBox.Show("정답!");
                number = new Random().Next(1, 11);
                Console.WriteLine(number);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
