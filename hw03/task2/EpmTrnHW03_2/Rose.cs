using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpmTrnHW03_2
{
    class Rose : Flower
    {
        public override decimal GetCost()
        {
            return 25.3m;
        }

        public override string GetName()
        {
            return "Rose";
        }
    }
}
