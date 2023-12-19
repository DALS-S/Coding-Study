using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace test1031_04
{
    public partial class Form3 : Form
    {
        int limitTime;      // 제한시간
        int answer;         //정답
        int nowTime;        // 경과시간
        public Form3()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nowTime++;   // 경과시간 증가
            if(nowTime > limitTime)
            {
                label2.Text = "게임오버";
                nowTime = 0;
                timer1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = false; // 일단 타이머 멈춤
            // textbox1에 숫자가 아닌 다른 값을 넣었을 경우
            if(int.TryParse(textBox1.Text,out limitTime) == false)
            {
                MessageBox.Show("제한 시간을 제대로 입력하세요");
                return;
            }
            label2.Text = "게임시작";
            answer = new Random().Next(1, 26);
            Console.WriteLine("정답=" + answer);
            int count = 1;          // 순차적으로 버튼 위에 쓸 텍스트
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Button b = new Button();
                    Point p = new Point();
                    p.X = 15 + 100 * j;
                    p.Y = 15 + 15 + 25 * i;
                    b.Location = p;
                    b.Click += B_Click;
                    b.Text = Convert.ToString(count);
                    count++;
                    Controls.Add(b);
                }
            }
            nowTime = 0;            // 경과시간 초기화
            timer1.Enabled = true;  // 타이머 시작
        }

        private void B_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            // sender : 이벤트 발생시킨 주체 = 버튼
            Button temp = (Button)sender;
            if(temp.Text.Equals(answer.ToString()))
            {
                label2.Text = "승리";
                nowTime = 0;
                timer1.Enabled = false;
            }
            else
            {
                label2.Text = "보물이 아닙니다";
            }
        }
    }
}
