using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1102_01
{
    public class Flight : IRiderble, IFlierble
    {
        public void fly()
        {
            MessageBox.Show("행복한 비행 되세요");
        }

        public void run()
        {
            MessageBox.Show("안전띠 꼭 매세요");
        }

        public void stop()
        {
            MessageBox.Show("비행기 멈춘다");
        }
    }
}
