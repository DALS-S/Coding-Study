using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1102_01
{
    public class Magician : GameCharacter
    {
        public override void Fight()
        {
            MessageBox.Show("마법 공격");
        }

        public override string Die()
        {
            return "연기처럼 사라지다";
        }
    }
}
