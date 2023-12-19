using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloCSharp07_01_chap12
{
    public class Weather
    {
        public string Hour { get; set; }
        public string Day { get; set; }
        public string WfKor { get; set; }
        public override string ToString()
        {
            return "시간 : " + Hour + ",날 : " + Day + ",날씨 : " + WfKor;
        }
    }
}
