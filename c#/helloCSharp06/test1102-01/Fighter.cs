using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1102_01
{
    public class Fighter : GameCharacter
    {
        public override void Fight()
        {
            //throw new NotImplementedException();
            MessageBox.Show("주먹으로 때림");
        }
    }
}
