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

namespace helloCSharp06_01_chap10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Product> products = new List<Product>();
            products.Add(new Product() { Name = "감자", Price = 100, Description = "맛있는 감자" });
            products.Add(new Product() { Name = "김", Price = 50, Description = "K김" });
            products.Add(new Product() { Name = "김", Price = 10, Description = "맛있는 김" });
            List<Goods> goods = new List<Goods>();
            goods.Add(new Goods() { Name = "양말", Price = 1000, Description = "손흥민이 신던 양말", InfluencerName = "손흥민" });
            goods.Add(new Goods()
            {
                Name = "칫솔",
                Price = 500,
                Description = "아들의 방을 청소할때 쓴 칫솔",
                InfluencerName = "손웅정"
            });

            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            dataGridView1.DataSource = products;
            dataGridView2.DataSource = goods;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBox1.Text);
            number++;
            MessageBox.Show("number 가 1이 증가된 값 : " + number);
            MessageBox.Show("클릭 완료");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(textBox2.Text);
                number++;
                MessageBox.Show("number 가 1이 증가된 값 : " + number);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("textBox2 에 값을 확인하세요");
                MessageBox.Show(ex.Message);                    // 오류 원인
                MessageBox.Show(ex.StackTrace);                 // 오류 위치
            }
            MessageBox.Show("클릭 완료");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(textBox2.Text);
                number++;
                MessageBox.Show("number 가 1이 증가된 값 : " + number);
            }
            catch (Exception ex)
            {
                MessageBox.Show("강제 종료!");
                return;
            }
            MessageBox.Show("클릭 완료");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(textBox2.Text);
                number++;
                MessageBox.Show("number 가 1이 증가된 값 : " + number);
            }
            catch (Exception ex)
            {
                MessageBox.Show("강제 종료!");
                return;
            }
            finally     // DB 연동할때 많이 씀 (예.connection)
            {
                MessageBox.Show("이건 실행하고 꺼야지!");
            }
            MessageBox.Show("클릭 완료");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 두개의 값을 나눈 결과 출력
            // 텍스트 박스에 값을 잘못넣었는지
            // 분모에 문제가 있는지
            // 이도 저도 아닌 오류인지 체크
            try
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                int c = a / b;
                int[] numbers = { 1, 2, 3 };
                MessageBox.Show("c = " + c);
                MessageBox.Show("값 = " + numbers[c]);
            }
            // exception 위에 오기만 하면 나머지들끼린 순서 상관없음
            catch(FormatException ex)
            {
                MessageBox.Show("포맷 오류!");
            }
            catch(ArithmeticException ex)
            {
                MessageBox.Show("산술 오류!");
            }
            catch(Exception ex) // <- 얘가 무조건 맨 아래여야함
            {
                MessageBox.Show("기타 오류!");
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
