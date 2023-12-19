using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloCSharp06
{
    public class Product : IComparable<Product>
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public int CompareTo(Product other)
        {
            //throw new NotImplementedException();
            return Price.CompareTo(other.Price);
            
        }

        public override string ToString()
        {
            //return base.ToString();
            return "제품명 : " + Name + ", 가격 : " + Price;
        }
    }
}
