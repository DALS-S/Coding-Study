using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1102_01
{
    public class Car : IRiderble
    {
        public void run()
        {
            MessageBox.Show("부릉부릉");
        }

        public void stop()
        {
            MessageBox.Show("브레이크!");
        }
    }
}
