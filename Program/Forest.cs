using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Forest : Terrain, ICoverable, ITraversable
    {
        public Forest()
        {
            width = 56;
            height = 89;
        }

        public override void Describe()
        {
            Console.WriteLine("Forest");
        }

        public override void Activate()
        {
            Cover();
            Console.WriteLine("Traverse : " + Traverse());
        }

        public void Cover()
        {
            Console.WriteLine("You can hide in Forest");
        }

        public bool Traverse()
        {
            return false;
        }
    }
}
