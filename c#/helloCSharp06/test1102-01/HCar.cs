using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1102_01
{
    public class HCar : IConveyancalbe
    {
        public string brandName;
        public string Name 
        {
            get { return "현대의 자랑" + brandName; }
            set => brandName = value; 
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
