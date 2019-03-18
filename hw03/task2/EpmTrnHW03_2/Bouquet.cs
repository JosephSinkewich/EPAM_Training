using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpmTrnHW03_2
{
    class Bouquet
    {
        private HashSet<Flower> _flowers;
        public HashSet<Flower> Fowers
        {
            get
            {
                return _flowers;
            }
        }

        public Bouquet()
        {
            _flowers = new HashSet<Flower>();
        }

        public decimal GetCost()
        {
            decimal result = 0;

            foreach (var item in _flowers)
            {
                result += item.GetCost();
            }

            return result;
        }
    }
}
