using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1102_01
{
    public class Dragon : GameCharacter, IRiderble, IFlierble
    {
        public override string Die()
        {
            return "용은 죽지 않는다";
        }
        public override void Fight()
        {
            MessageBox.Show("버프줌!");
        }

        public void fly()
        {
            MessageBox.Show("마나로 난다!");
        }

        public void run()
        {
            return;     // 용은 안뜀
        }

        public void stop()
        {
            MessageBox.Show("조용히 멈춤!");
        }
    }
}
