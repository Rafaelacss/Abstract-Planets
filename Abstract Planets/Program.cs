using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Rafaela Silveira
 * Date: July 28, 2017
 * Version: 0.1
 */

namespace Abstract_Planets
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("Jupiter", 69911, 317.8, "Gas");
            Console.WriteLine(giantPlanet.ToString());

            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Earth", 40075.017, 5.97237, true);
            Console.WriteLine(terrestrialPlanet.ToString());

            WaitForAnyKey();
        }

        public static void WaitForAnyKey()
        {
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
