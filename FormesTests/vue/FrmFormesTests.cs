using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace Formes.vue.Tests
{
    [TestClass()]
    public class FrmFormesTests
    {
        private FrmFormes frm = new FrmFormes();

        [TestMethod()]
        public void FrmFormesTest()
        {
            TextBox TxtValeur = (TextBox)frm.Controls["GrpForme"].Controls["TxtValeur"];
            TxtValeur.Text = "5";
            RadioButton RdbCarre = (RadioButton)frm.Controls["GrpForme"].Controls["RdbCarre"];
            frm.Visible = true;
            RdbCarre.PerformClick();
            TextBox TxtPerimetre = (TextBox)frm.Controls["GrpMesures"].Controls["TxtPerimetre"];
            double perimetre = double.Parse(TxtPerimetre.Text);
            Assert.AreEqual(20, perimetre);
        }

    }
}