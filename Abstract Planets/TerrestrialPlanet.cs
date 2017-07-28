using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Rafaela Silveira
 * Date: July 28, 2017
 * Description: TerrestrialPlanet subclass of Planet class.
 * Version: 0.2
 */

namespace Abstract_Planets
{
    class TerrestrialPlanet : Planet
    {
        // Private instance variable
        private bool _oxygen;

        // Constructor
        /// <summary>
        /// Main constructor that takes four parameters (string name, double diameter, double mass, bool oxygen)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
            : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }

    }
}
