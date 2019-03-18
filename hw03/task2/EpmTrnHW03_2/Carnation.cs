using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpmTrnHW03_2
{
    class Carnation : Flower
    {
        public override decimal GetCost()
        {
            return 7.7m;
        }

        public override string GetName()
        {
            return "Carnation";
        }
    }
}
