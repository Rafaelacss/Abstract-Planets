using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Rafaela Silveira
 * Date: July 27, 2017
 * Description: Abstract class Planet
 * Version: 0.1
 */

namespace Abstract_Planets
{
    /// <summary>
    /// This is the abstract class Planet
    /// </summary>
    public abstract class Planet
    {
        //private instance variables - fields ---------
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        //public properties ----------
        public double Diameter
        {
            get
            {
                return this._diameter;
            }
        }

        public double Mass
        {
            get
            {
                return this._mass;
            }
        }

        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }
            set
            {
                this._moonCount = value;
            }
        }

        public string Name
        {
            get
            {
                return this._name;
            }
        }

        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }
            set
            {
                this._orbitalPeriod = value;
            }
        }

        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }
        }

        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }
            set
            {
                this._rotationPeriod = value;
            }
        }
            
        //Constructor ----------
        /// <summary>
        /// This is the constructor for the Planet class
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }

        //Public Methods -----------
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
