using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealKit
{
    public partial class 메인화면 : Form
    {
        public 메인화면()
        {
            InitializeComponent();
            label1.Text = "신규 가입 회원 이벤트";
            label2.Text = "30%";
            label3.Text = "할인 중";
            label4.Text = "11월 9일 ~ 11월 27일 까지";
            label5.Text = "양식";
            label6.Text = "한식";
            label7.Text = "중식";
            label8.Text = "일식";          
            label14.Text = "회원명 : ";
            label15.Text = "등급 : ";
            label16.Text = "적립 포인트 : ";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            장바구니 frm2 = new 장바구니();
            frm2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            회원정보 frm3 = new 회원정보();
            frm3.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            양식 frm4 = new 양식();
            frm4.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            한식 frm5 = new 한식();
            frm5.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            중식 frm6 = new 중식();
            frm6.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            일식 frm7 = new 일식();
            frm7.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            로그인 frm7 = new 로그인();
            frm7.Show();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            광고 pictureShow = new 광고();
            pictureShow.Picture = this.pictureBox1.Image;
            pictureShow.Show();
        }

        private void panel14_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.kb.or.kr/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            검색결과창 frm8 = new 검색결과창();
            frm8.Show();
        }
    }
}
