using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1102_01
{
    public class UniCorn : GameCharacter, IRiderble, IFlierble
    {
        public override void Fight()
        {
            MessageBox.Show("발굽찍기!");
        }

        public void fly()
        {
            MessageBox.Show("날기");
        }

        public void run()
        {
            MessageBox.Show("뛴다!");
        }

        public void stop()
        {
            MessageBox.Show("멈춘다!");
        }
    }
}
