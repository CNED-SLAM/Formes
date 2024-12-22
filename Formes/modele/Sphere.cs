using System;

namespace Formes.modele
{
    /// <summary>
    /// Classe Sphere implémente IForme3D
    /// </summary>
    public class Sphere : IForme3D
    {
        /// <summary>
        /// rayon de la sphère
        /// </summary>
        private double rayon;

        /// <summary>
        /// Constructeur : valorise rayon
        /// </summary>
        /// <param name="rayon">rayon</param>
        public Sphere(double rayon)
        {
            this.rayon = rayon;
        }

        /// <summary>
        /// Calcul de l'aire
        /// </summary>
        /// <returns>aire</returns>
        public double Aire()
        {
            return 4 * Math.PI * Math.Pow(rayon, 2);
        }

        /// <summary>
        /// Calcul du volume
        /// </summary>
        /// <returns>volume</returns>
        public double Volume()
        {
            return (4 * Math.PI * Math.Pow(rayon, 3)) / 3;
        }
    }
}
