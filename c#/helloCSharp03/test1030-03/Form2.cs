using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1030_03
{
    public partial class Form2 : Form
    {
        int number;
        public Form2()
        {
            InitializeComponent();
            number = new Random().Next(1, 11);
            Console.WriteLine(number);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int answer1 = int.Parse(textBox1.Text);
            if (number < answer1)
            {
                MessageBox.Show("정답 보다 큰 값을 골랐습니다");
            }
            else if (number > answer1) 
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
    }
}
