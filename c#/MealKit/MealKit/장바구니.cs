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

namespace MealKit
{
    public partial class 장바구니 : Form
    {
        public 장바구니()
        {
            InitializeComponent();
            label1.Text = "결재 금액 : ";
            label2.Text = "0";
            label4.Text = "장바구니";
            button1.Text = "구매";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            메인화면 frm1 = new 메인화면();
            frm1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            회원정보 frm3 = new 회원정보();
            frm3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            구매창 frm9 = new 구매창();
            frm9.Show();
        }
    }
}
