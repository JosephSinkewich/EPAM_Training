using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpmTrnHW03_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rose rose1 = new Rose();
            Rose rose2 = new Rose();
            Tulip tulip = new Tulip();
            Carnation carnation = new Carnation();

            Bouquet bouquet = new Bouquet();
            bouquet.Fowers.Add(rose1);
            bouquet.Fowers.Add(rose2);
            bouquet.Fowers.Add(tulip);
            bouquet.Fowers.Add(carnation);

            Console.WriteLine($"Bouquet cost = {bouquet.GetCost()}");
            Console.ReadKey();
        }
    }
}
