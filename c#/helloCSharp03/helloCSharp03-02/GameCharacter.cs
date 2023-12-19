using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloCSharp03_02
{
    public class GameCharacter
    {
        public string Id {  get; set; }
        public static int theNumberOfUser = 0;
        public GameCharacter()
        {
            theNumberOfUser++;
        } 
        public GameCharacter(string id)
        {
            this.Id = id;
            theNumberOfUser++;
        }
    }
}
