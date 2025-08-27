using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Field : Terrain, ICoverable, ITraversable
    {
        public Field()
        {
            width = 72;
            height = 68;
        }
        public override void Describe()
        {
            Console.WriteLine("Field");
        }
        public override void Activate()
        {
            Cover();
            Console.WriteLine("Traverse : " + Traverse());
        }
        public void Cover()
        {
            Console.WriteLine("You can hide in Field");
        }

        public bool Traverse()
        {
            return true;
        }
    }
}
