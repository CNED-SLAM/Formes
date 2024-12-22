using System;
using System.Collections.Generic;
using System.Text;

namespace Formes
{
    public class Cube : Forme
    {
        private double cote;

        public Cube(double cote)
        {
            this.cote = cote;
        }

        public double perimetre()
        {
            throw new NotImplementedException();
        }

        public double aire()
        {
            return Math.Pow(cote, 2) * 6;
        }

        public double volume()
        {
            return Math.Pow(cote, 3);
        }
    }
}
