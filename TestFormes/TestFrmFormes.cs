using Formes.vue;
using NUnit.Framework;
using System.Windows.Forms;

namespace TestFormes
{
    class TestFrmFormes
    {
        private readonly FrmFormes frmFormes = new FrmFormes();

        [Test]
        public void TestPerimetre()
        {
            TextBox TxtValeur = (TextBox)frmFormes.Controls["GrpForme"].Controls["TxtValeur"];
            TxtValeur.Text = "5";
            RadioButton RdbCarre = (RadioButton)frmFormes.Controls["GrpForme"].Controls["RdbCarre"];
            frmFormes.Visible = true;
            RdbCarre.PerformClick();
            TextBox TxtPerimetre = (TextBox)frmFormes.Controls["GrpMesures"].Controls["TxtPerimetre"];
            double perimetre = double.Parse(TxtPerimetre.Text);
            Assert.AreEqual(20, perimetre);
        }
    }
}
