namespace Formes.modele
{
    /// <summary>
    /// Interface IForme
    /// force la redéfinition de Aire pour toutes les formes
    /// </summary>
    public interface IForme
    {
        /// <summary>
        /// Calcul de l'aire d'une forme
        /// </summary>
        /// <returns>aire</returns>
        public double Aire();
    }
}
