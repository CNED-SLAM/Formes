using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formes
{
    public partial class FrmFormes : Form
    {
        public FrmFormes()
        {
            InitializeComponent();
            RdbCarre_CheckedChanged(null, null);
        }

        private double recupValeur()
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

        private void RdbCarre_CheckedChanged(object sender, EventArgs e)
        {
            LblValeur.Text = "côté";
            double valeur = recupValeur();
            Carre carre = new Carre(valeur);
            TxtPerimetre.Text = carre.perimetre().ToString();
            TxtAire.Text = carre.aire().ToString();
            TxtVolume.Text = "";
        }

        private void RdbCube_CheckedChanged(object sender, EventArgs e)
        {
            LblValeur.Text = "côté";
            double valeur = recupValeur();
            Cube cube = new Cube(valeur);
            TxtPerimetre.Text = "";
            TxtAire.Text = cube.aire().ToString();
            TxtVolume.Text = cube.volume().ToString();
        }

        private void RdbCercle_CheckedChanged(object sender, EventArgs e)
        {
            LblValeur.Text = "rayon";
            double valeur = recupValeur();
            Cercle cercle = new Cercle(valeur);
            TxtPerimetre.Text = cercle.perimetre().ToString();
            TxtAire.Text = cercle.aire().ToString();
            TxtVolume.Text = "";
        }

        private void RdbSphere_CheckedChanged(object sender, EventArgs e)
        {
            LblValeur.Text = "rayon";
            double valeur = recupValeur();
            Sphere sphere = new Sphere(valeur);
            TxtPerimetre.Text = "";
            TxtAire.Text = sphere.aire().ToString();
            TxtVolume.Text = sphere.volume().ToString();
        }

        private void TxtValeur_TextChanged(object sender, EventArgs e)
        {
            double valeur = recupValeur();
            if (RdbCarre.Checked)
            {
                Carre carre = new Carre(valeur);
                TxtPerimetre.Text = carre.perimetre().ToString();
                TxtAire.Text = carre.aire().ToString();
                TxtVolume.Text = "";
            }
            else if (RdbCube.Checked)
            {
                Cube cube = new Cube(valeur);
                TxtPerimetre.Text = "";
                TxtAire.Text = cube.aire().ToString();
                TxtVolume.Text = cube.volume().ToString();
            }
            else if (RdbCercle.Checked)
            {
                Cercle cercle = new Cercle(valeur);
                TxtPerimetre.Text = cercle.perimetre().ToString();
                TxtAire.Text = cercle.aire().ToString();
                TxtVolume.Text = "";
            }
            else
            {
                Sphere sphere = new Sphere(valeur);
                TxtPerimetre.Text = "";
                TxtAire.Text = sphere.aire().ToString();
                TxtVolume.Text = sphere.volume().ToString();
            }
        }
    }
}
