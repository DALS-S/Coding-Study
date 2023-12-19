using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloCSharp07
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public override string ToString()
        {
            return $"ID : {Id}, Name : {Name}, Price : {Price}\n";
        }
    }
}
