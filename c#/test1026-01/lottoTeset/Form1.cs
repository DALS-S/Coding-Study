using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lottoTeset
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("로또 번호 생성");
            int[] lotto = new int[6];
            int j = 0;
            int cnt = 0;
            Random rand = new Random();
            cnt = 0;
            while (cnt < 6)
            {
                int r = rand.Next(1, 46);
                for (j = 0; j < cnt; j++)
                {
                    if (lotto[j] == r)
                    {
                        break;
                    }
                }
                if (cnt == j)
                {
                    lotto[cnt++] = r;
                }
            }
            로또번호1.Text = Convert.ToString(lotto[0]);
            로또번호2.Text = Convert.ToString(lotto[1]);
            로또번호3.Text = Convert.ToString(lotto[2]);
            로또번호4.Text = Convert.ToString(lotto[3]);
            로또번호5.Text = Convert.ToString(lotto[4]);
            로또번호6.Text = Convert.ToString(lotto[5]);
        }
    }
}
