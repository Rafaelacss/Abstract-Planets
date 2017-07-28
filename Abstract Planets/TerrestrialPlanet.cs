using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Rafaela Silveira
 * Date: July 28, 2017
 * Description: TerrestrialPlanet subclass of Planet class withBIHasMoons and IHabitable interfaces.
 * Version: 0.4
 */

namespace Abstract_Planets
{
    class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        // Private instance variable -----------
        private bool _oxygen;

        // Constructor ---------------
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

        // Public Methods ----------------------------
        // HasMoons method - returns true if the planet has moons
        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        // Habitable method - returns true if the planet has oxygen
        public bool Habitable()
        {
            if (_oxygen)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
