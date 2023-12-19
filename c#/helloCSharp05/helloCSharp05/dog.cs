using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloCSharp05
{
    public class dog : animal
    {
        public dog() 
        {
            Born();
        }
        public string Color
        {  
            get; 
            set;
        } 
        public void Bark() 
        {
            Console.WriteLine("멍멍");
        }
    }
}
