using System;
using TechTalk.SpecFlow;
using Formes.vue;
using System.Windows.Forms;

namespace SpecFlowFormes.StepDefinitions
{
    [Binding]
    public class FormesStepDefinitions
    {
        private readonly FrmFormes frmFormes = new FrmFormes();

        [Given(@"je saisis la valeur (.*)")]
        public void GivenJeSaisiLaValeur(double valeur)
        {
            TextBox TxtValeur = (TextBox)frmFormes.Controls["GrpForme"].Controls["TxtValeur"];
            TxtValeur.Text = valeur.ToString();
        }

        [When(@"je clic sur le bouton radio (.*)")]
        public void WhenJeClicSurLeBoutonRadioCarre(string rdbName)
        {
            RadioButton rdb = (RadioButton)frmFormes.Controls["GrpForme"].Controls[rdbName];
            frmFormes.Visible = true;
            rdb.PerformClick();
        }

        [Then(@"le resultat est (.*) dans (.*)")]
        public void ThenLePerimetreEst(double resultatAttendu, string txtName)
        {
            TextBox txt = (TextBox)frmFormes.Controls["GrpMesures"].Controls[txtName];
            double resultatObtenu = double.Parse(txt.Text);
            Assert.AreEqual(resultatAttendu, resultatObtenu, 0.01d);
        }
    }
}
