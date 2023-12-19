using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace helloCSharp06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 사번이 문자열일 경우
            Sawon<string> dj = new Sawon<string>();
            dj.Number = textBox1.Text;
            label1.Text = "사번은 " + dj.Number + " 입니다.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 사번이 숫자일 경우
            Sawon<int> sh = new Sawon<int>();
            int.TryParse(textBox2.Text, out int num);
            sh.Number = num;
            label2.Text = "사번은 " + sh.Number + " 입니다.";
        }

        // 이 함수가 실행되면서 out 키워드가 붙은건 함수 밖에 있는 변수인데 그것의 값이 바뀐다.
        // c 언어의 포인터나 C#의 ref랑 마찬가지
        // ref : 참조자, 함수에서 값이 바뀌면 밖에서도 바뀜
        // out : 참조자, 함수에서 값이 바뀌면 밖에서도 바뀜, 반드시 대입문 필요
        // 여기선 rx = 0, ry = 0; 이런거라도 넣어줘야함
        void NextPosition(int x, int y, int vx, int vy, out int rx, out int ry)
        {
            // 다음 위치 = 현재 위치 + 현재 속도
            // 값 할당이 의무! 필수!
            rx = x + vx;
            ry = y + vy;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            string nowPos = $"현재 위치 : ({x},{y}) " + Environment.NewLine;
            int movePos = int.Parse(textBox3.Text); // 속도에 영할 주는 변수
            NextPosition(x, y, movePos + 10, movePos + 20, out x, out y);
            nowPos += $"이동 후 위치 : ({x},{y}) " + Environment.NewLine;
            label3.Text = nowPos;
        }

        List<Product> products = new List<Product>();
        private void button4_Click(object sender, EventArgs e)
        {
            // 제품 추가 및 출력 버튼
            products.Add(new Product() { Name = textBox4.Text });
            products.Last().Price = int.Parse(textBox5.Text);
            //products[0].Price = int.Parse(textBox5.Text);

            string prices = "";
            foreach (var item in products)
            {
                prices += item + Environment.NewLine;   // 오버라이드 해야 쓸 수 있음.
                label4.Text = prices;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 제품을 가격순으로 출력할 버튼
            label4.Text = "";
            products.Sort();    // 컴페어투 구현해야 사용가능(프로덕트에 아이컴페어러블 상속 후)
            foreach (var item in products)
            {
                label4.Text += item + Environment.NewLine;
            }
            // 인터페이스도 다형성 적용
            // 추상클래스와 마찬가지로 단독으로 인스턴스 생성 불가능
            // IComparable ic = new IComparable();  
            IComparable<Product> i = new Product();
        }
    }
}
