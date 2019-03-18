using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpmTrnHW03_2
{
    class Tulip : Flower
    {
        public override decimal GetCost()
        {
            return 11.45m;
        }

        public override string GetName()
        {
            return "Tulip";
        }
    }
}
