using System;
using System.Collections.Generic;
using System.Text;

namespace Formes
{
    public class Carre : Forme
    {
        private double cote;

        public Carre(double cote)
        {
            this.cote = cote;
        }

        public double perimetre()
        {
            return cote * 4;
        }

        public double aire()
        {
            return cote * cote;
        }

        public double volume()
        {
            throw new NotImplementedException();
        }
    }
}
