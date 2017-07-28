using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Rafaela Silveira
 * Date: July 28, 2017
 * Description: subclass GiantPlanet with IHasMoons and IHasRings interfaces
 * Version: 0.2
 */
namespace Abstract_Planets
{
    public class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        // Private Instance Variables -------------
        private string _type;

        // Constructor ---------------
        /// <summary>
        /// Main constructor that takes four parameters (string name, double diameter, double mass, string type)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="type"></param>

        public GiantPlanet (string name, double diameter, double mass, string type)
            : base (name, diameter, mass)
        {
            this._type = type;
        }

        /// <summary>
        /// HasMoons method will return true if the planet has moons
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// HasRings method will return true if the planet has rings
        /// </summary>
        /// <returns></returns>
        public bool HasRings()
        {
            if(RingCount > 0)
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
