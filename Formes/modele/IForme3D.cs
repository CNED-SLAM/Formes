namespace Formes.modele
{
    /// <summary>
    /// Interface IForme3D : hérite de IForme
    /// force la redéfinition de Volume pour les formes 3D
    /// et la redéfinition de Aire
    /// </summary>
    public interface IForme3D : IForme
    {
        /// <summary>
        /// Calcul du volume
        /// </summary>
        /// <returns>volume</returns>
        double Volume();
    }
}
