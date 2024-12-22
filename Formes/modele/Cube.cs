using System;

namespace Formes.modele
{
    /// <summary>
    /// Classe Cube implémente IForme3D
    /// </summary>
    public class Cube : IForme3D
    {
        /// <summary>
        /// côté du cube
        /// </summary>
        private double cote;

        /// <summary>
        /// Constructeur : valorise cote
        /// </summary>
        /// <param name="cote">côté</param>
        public Cube(double cote)
        {
            this.cote = cote;
        }

        /// <summary>
        /// Calcul de l'aire
        /// </summary>
        /// <returns>aire</returns>
        public double Aire()
        {
            return Math.Pow(cote, 2) * 6;
        }

        /// <summary>
        /// Calcul du volume
        /// </summary>
        /// <returns>volume</returns>
        public double Volume()
        {
            return Math.Pow(cote, 3);
        }
    }
}
