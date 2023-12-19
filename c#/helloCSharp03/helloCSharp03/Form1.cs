using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace helloCSharp03
{
    public partial class Form1 : Form
    {
        string randomText = "가나다라마바사";

        // c#의 list 는 java의 arraylist랑 사실상 똑같음.
        List<string> nameList = new List<string> { "이경민", "일경민", "삼경민" };
        List<int> ageList = new List<int>{29, 30, 31};
        List<int> ageList2 = new List<int>();
        // 자바의 arraylist<object>랑 동일함
        // 즉, 아무거나 다 들어가는 리스트이다.
        ArrayList TmiList = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            Button b = new Button();
            b.Text = "코드로 만든 버튼";
            b.AutoSize = true;
            b.Location = new Point(10, 10);
            // add 코드가 없으면 b는 화면에 보이지 않음
            Controls.Add(b);    // controls : form1 안에 있는 모든 구성요소들(button 등등)
        }

        // btn_test 클릭시 수행할 함수
        private void btn_test_Click(object sender, EventArgs e)
        {
            //checkBox1.Text += Convert.ToString("테스트");
            //checkBox1.Text += "!";
            //Random r = new Random();
            //checkBox2.Text = randomText[r.Next(randomText.Length)].ToString(); 
            if(checkBox1.Checked ) 
            {
                checkBox1.Text = Convert.ToString("체크박스1 활성화");
            }
            else
            {
                return;
            }
        }
    }
}
