using System;

namespace Formes.modele
{
    /// <summary>
    /// Classe Cercle implémente IForme2D
    /// </summary>
    public class Cercle : IForme2D
    {
        /// <summary>
        /// rayon du cercle
        /// </summary>
        private double rayon;

        /// <summary>
        /// Constructeur : valorise rayon
        /// </summary>
        /// <param name="rayon">rayon</param>
        public Cercle(double rayon)
        {
            this.rayon = rayon;
        }

        /// <summary>
        /// Calcul du périmètre
        /// </summary>
        /// <returns>périmètre</returns>
        public double Perimetre()
        {
            return 2 * Math.PI * rayon;
        }

        /// <summary>
        /// Calcul de l'aire
        /// </summary>
        /// <returns>aire</returns>
        public double Aire()
        {
            return Math.PI * Math.Pow(rayon, 2);
        }
    }
}
