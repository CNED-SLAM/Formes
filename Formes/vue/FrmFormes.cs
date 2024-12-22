using System;
using System.Windows.Forms;
using Formes.modele;

namespace Formes.vue
{
    public partial class FrmFormes : Form
    {
        /// <summary>
        /// texte du label si la forme est de type carré ou cube
        /// </summary>
        private const string COTE = "côté";
        /// <summary>
        /// texte du label si la forme est de type cercle ou sphère
        /// </summary>
        private const string RAYON = "rayon";

        /// <summary>
        /// Constructeur : initialise les composants graphiques 
        /// </summary>
        public FrmFormes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Récupère la valeur saisie (côté ou rayon) ou 0 si zone vide
        /// </summary>
        /// <returns>la valeur au format double</returns>
        private double RecupValeur()
        {
            try
            {
                return double.Parse(TxtValeur.Text);
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Valorise TxtPerimetre
        /// </summary>
        /// <param name="forme">forme de type IForme2D</param>
        private void MajTxtPerimetre(IForme2D forme)
        {
            TxtPerimetre.Text = forme.Perimetre().ToString();
        }

        /// <summary>
        /// Valorise TxtVolume
        /// </summary>
        /// <param name="forme">forme de type IForme3D</param>
        private void MajTxtVolume(IForme3D forme)
        {
            TxtVolume.Text = forme.Volume().ToString();
        }

        /// <summary>
        /// Valorise TxtAire
        /// </summary>
        /// <param name="forme">forme quelconque</param>
        private void MajTxtAire(IForme forme)
        {
            TxtAire.Text = forme.Aire().ToString();
        }

        /// <summary>
        /// Traitements si le choix concerne une forme 2D
        /// </summary>
        /// <param name="forme">forme de type IForme2D</param>
        private void Choix2D(IForme2D forme)
        {
            MajTxtPerimetre(forme);
            MajTxtAire(forme);
            TxtVolume.Text = "";
        }

        /// <summary>
        /// Traitements si le choix concerne une forme 3D
        /// </summary>
        /// <param name="forme">forme du type IForme3D</param>
        private void Choix3D(IForme3D forme)
        {
            MajTxtAire(forme);
            MajTxtVolume(forme);
            TxtPerimetre.Text = "";
        }

        /// <summary>
        /// Evénement clic sur RdbCarre
        /// Demande d'affichage des mesures
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RdbCarre_CheckedChanged(object sender, EventArgs e)
        {
            LblValeur.Text = COTE;
            Choix2D(new Carre(RecupValeur()));
        }

        /// <summary>
        /// Evénement clic sur RdbCube
        /// Demande d'affichage des mesures
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RdbCube_CheckedChanged(object sender, EventArgs e)
        {
            LblValeur.Text = COTE;
            Choix3D(new Cube(RecupValeur()));
        }

        /// <summary>
        /// Evénement clic sur RdbCercle
        /// Demande d'affichage des mesures
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RdbCercle_CheckedChanged(object sender, EventArgs e)
        {
            LblValeur.Text = RAYON;
            Choix2D(new Cercle(RecupValeur()));
        }

        /// <summary>
        /// Evénement clic sur RdbSphere
        /// Demande d'affichage des mesures
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RdbSphere_CheckedChanged(object sender, EventArgs e)
        {
            LblValeur.Text = RAYON;
            Choix3D(new Sphere(RecupValeur()));
        }

        /// <summary>
        /// Appel de l'événement correspondant au bouton radio sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtValeur_TextChanged(object sender, EventArgs e)
        {
            if (RdbCarre.Checked)
            {
                RdbCarre_CheckedChanged(null, null);
            }
            else if (RdbCube.Checked)
            {
                RdbCube_CheckedChanged(null, null);
            }
            else if (RdbCercle.Checked)
            {
                RdbCercle_CheckedChanged(null, null);
            }
            else
            {
                RdbSphere_CheckedChanged(null, null);
            }
        }
    }
}
