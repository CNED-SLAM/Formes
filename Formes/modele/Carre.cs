namespace Formes.modele
{
    /// <summary>
    /// Classe Carre implémente IForme2D
    /// </summary>
    public class Carre : IForme2D
    {
        /// <summary>
        /// côté du carré
        /// </summary>
        private double cote;

        /// <summary>
        /// Constructeur : valorise cote
        /// </summary>
        /// <param name="cote">côté</param>
        public Carre(double cote)
        {
            this.cote = cote;
        }

        /// <summary>
        /// Calcul du périmètre
        /// </summary>
        /// <returns>périmètre</returns>
        public double Perimetre()
        {
            return cote * 4;
        }

        /// <summary>
        /// Calcul de l'aire
        /// </summary>
        /// <returns>aire</returns>
        public double Aire()
        {
            return cote * cote;
        }
    }
}
