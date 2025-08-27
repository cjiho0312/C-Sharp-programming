using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Sea : Terrain
    {
        public Sea()
        {
            width = 113;
            height = 97;
        }
        public override void Describe()
        {
            Console.WriteLine("Sea");
        }

        public override void Activate()
        {
        }
    }
}
