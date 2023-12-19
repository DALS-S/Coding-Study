using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1102_01
{
    public abstract class GameCharacter
    {
        public string id {  get; set; }
        public int Lv { get; set; }
        public abstract void Fight();   // 오버라이딩 필수
        public virtual string Die()     // 오버라이딩이 가능함(오버라이딩 필수)
        {
            return "YOU DIE";
        }
        public string SayHello()        // 오버라이딩 안됨.
        {
            string introduce = "안녕 내 소개를 할게"+Environment.NewLine;
            introduce += "ID : " + id + Environment.NewLine;
            introduce += "Lv : " + Lv + Environment.NewLine;
            return introduce;
        }
    }
}
