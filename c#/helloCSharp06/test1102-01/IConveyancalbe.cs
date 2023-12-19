using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1102_01
{
    // 인터페이스는 상속 받을 수 있음
    // 속성도 추가가 가능
    public interface IConveyancalbe : IRiderble, IFlierble
    {
        string Name { get; set; }

    }
}
