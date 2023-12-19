using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1102_01
{
    internal class BattleCruiser : IConveyancalbe
    {
        private string name;
        public string Name 
        { 
            get => name; 
            set => Name = value; 
        }

        public void fly()
        {
            throw new NotImplementedException();
        }

        public void run()
        {
            throw new NotImplementedException();
        }

        public void stop()
        {
            throw new NotImplementedException();
        }
    }
}
