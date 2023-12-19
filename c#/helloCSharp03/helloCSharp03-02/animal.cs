using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloCSharp03_02
{
    public class animal
    {
        public string name { get; set; }
        public int age { get; set; }
        private int id;
        public int Id { get { return id; } set { id = value; } }
       
        private string species;
        public string Species { get => species; set => species = value; }
       
        private string masterName;
        public string gertMasterName()
        {
            return masterName;
        }
        public void setmasterName(string masterName)
        {
            this.masterName = masterName;
        }
    }
}
