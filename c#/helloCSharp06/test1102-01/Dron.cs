using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1102_01
{
    public class Dron : IFlierble
    {
        public void fly()
        {
            MessageBox.Show("위이잉~");
        }
    }
}
