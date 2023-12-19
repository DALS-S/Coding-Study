using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1101
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lion l= new Lion();
            l.Sleep();
            l.Eat();
            l.grooming();
            l.hunt();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tiger t = new Tiger();
            t.Name = "춘식보이";
            t.Age = "5";
            t.Sleep();
            t.Eat();
            t.grooming();
            t.hunt();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Domestic_Cat dc = new Domestic_Cat();
            dc.master = "이경민";
            dc.Name = "쭈니";
            dc.Age = "1";
            dc.Sleep();
            dc.Eat();
            dc.grooming();
            dc.hunt();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Korean_short ks = new Korean_short();
            ks.Name = "길냥쓰";
            ks.Age = "2";
            ks.Sleep();
            ks.Eat();
            ks.grooming();
            ks.hunt();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MyForm m = new MyForm();
            m.ShowDialog();             // 모달(modal) 
            // 모달
            // 1. 코드가 멈춤
            // 2. 뒤에 있는 창들 제어 불가
            MessageBox.Show("Test");    // <- 얘도 모달임
        }

        private void circleButton1_Click(object sender, EventArgs e)
        {
            MyForm m = new MyForm();
            m.Show();                   // 모달리스(modaless)
            // 모달리스
            // 뒤에 창 제어 가능하고 코드는 계속 진행됨
            MessageBox.Show("Test");
        }
    }
}
