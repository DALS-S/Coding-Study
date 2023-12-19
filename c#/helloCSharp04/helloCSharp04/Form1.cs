using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace helloCSharp04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            product p = new product();
            p.price = 100;
            // p.name 을 쓰려면 public 붙여야함

            // dictionary 쓰면 구조가 유연해짐
            Dictionary<string, string> student = new Dictionary<string, string>();
            student["학번"] = "21402417";
            student["이름"] = "이경민";
            student["성별"] = "남자";
            student["탈모여부"] = "없음";
            MessageBox.Show(student["학번"]);
            MessageBox.Show(student.ContainsKey("결혼여부") + "");
            MessageBox.Show(student.ContainsKey("탈모여부") + "");

            // list 같은 경우엔 인덱스 라는게 있다.
            // 따지고 보면 키가 숫자인  딕셔너리 라고 볼 수도 있다
            
            // arraylist 같은 경우에도 인덱스 가 있다.
            // 다만, 안에 들어가는 데이터의 형태를 제한하지 않는다.
        }

        void change(int num)
        {
            num = 1000;
            // a의 값을 복사만 해왔음
            // a랑 위치도 다르고 완전 별개의 존재
        }

        void change(product p)
        {
            p.price = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 10;
            int b = a;
            b = 200;
            // b 의 값이 바뀌었다해서 a의 값이 바뀌지않음
            label1.Text = "a=" + a + Environment.NewLine;
            label1.Text += "b=" + b + Environment.NewLine;
            // 이 메소드는 a의 값을 복사만 한것, 원본이랑 관계없음
            change(a);
            label1.Text += "a=" + a + Environment.NewLine;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            product p = new product();
            p.price = 100;
            product p2 = p;
            p2.price = 999;
            label2.Text = "product의 price : " + p.price + "\n";
            change(p);
            label2.Text += "product의 price : " + p.price + "\n";

        }

        // ref 키워드 = 참조자
        // 해당 변수의 값뿐 아니라 그 변수의 위치도 같이 가져오는 것
        // 따라서 swap 에서 값이 바뀌면 swap 바깥에 있는 원본의 값이 바뀐다
        void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private void button_swap_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox_1.Text);
            int b = int.Parse(textBox_2.Text);
            MessageBox.Show("a=" + a + ",b=" + b);
            swap(ref a, ref b);
            label_1.Text = a + "";
            label_2.Text = b + "";
        }
    }
}
