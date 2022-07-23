namespace Formes.modele
{
    /// <summary>
    /// Interface IForme2D : hérite de IForme
    /// force la redéfinition de Perimetre pour les formes 2D
    /// et la redéfinition de Aire
    /// </summary>
    interface IForme2D : IForme
    {
        /// <summary>
        /// Calcul du périmètre
        /// </summary>
        /// <returns>périmètre</returns>
        public double Perimetre();
    }
}
