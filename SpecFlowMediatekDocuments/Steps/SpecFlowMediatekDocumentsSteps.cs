using System;
using System.Windows.Forms;
using TechTalk.SpecFlow;



namespace SpecFlowMediatekDocuments.Steps
{
	[Binding]
	public class SpecFlowMediatekDocumentsSteps
	{

        private static readonly Utilisateur utilisateur = new Utilisateur("02", "prets", "pwdprets", "02", "Prêts");
        private readonly FrmMediatek frmMediatek = new FrmMediatek(utilisateur);

        [Given(@"je saisis le numéro (.*)")]
        public void GivenJeSaisisLeNumero(string recherche)
        {
            TabControl tabOngletsApplication = (TabControl)frmMediatek.Controls["tabOngletsApplication"];
            frmMediatek.Visible = true;
            tabOngletsApplication.SelectedTab = (TabPage)tabOngletsApplication.Controls["tabLivres"];
            TextBox txbLivresNumRecherche = (TextBox)frmMediatek.Controls["tabOngletsApplication"].Controls["tabLivres"].Controls["grpLivresRecherche"].Controls["txbLivresNumRecherche"];
            txbLivresNumRecherche.Text = recherche;
        }

        [When(@"je clique sur le bouton rechercher")]
        public void WhenJeCliqueSurLeBoutonRechercher()
        {
            Button btnLivresNumRecherche = (Button)frmMediatek.Controls["tabOngletsApplication"].Controls["tabLivres"].Controls["grpLivresRecherche"].Controls["btnLivresNumRecherche"];
            frmMediatek.Visible = true;
            btnLivresNumRecherche.PerformClick();
        }

        [Then(@"txbLivresIsbn\.Text doit être (.*)")]
        public void ThenTxbLivresIsbn_TextDoitEtre(string frmIsbn)
        {
            TextBox txbLivresIsbn = (TextBox)frmMediatek.Controls["tabOngletsApplication"].Controls["tabLivres"].Controls["grpLivresInfos"].Controls["txbLivresIsbn"];
            frmMediatek.Visible = true;
            string isbn = txbLivresIsbn.Text.ToString();
            Assert.AreEqual(frmIsbn, isbn);
        }

        [Given(@"je saisis le titre ""(.*)""")]
        public void GivenJeSaisisLeTitre(string titre)
        {
            TextBox txbLivresTitreRecherche = (TextBox)frmMediatek.Controls["tabOngletsApplication"].Controls["tabLivres"].Controls["grpLivresRecherche"].Controls["txbLivresTitreRecherche"];
            frmMediatek.Visible = true;
            txbLivresTitreRecherche.Text = titre;
        }
        // Le when et given sont le même que pour le précédent

        [When(@"je choisis le genre qui se trouve à la ligne (.*) dans le cbx")]
        public void WhenJeChoisisLeGenreQuiSeTrouveALaLigneDansLeCbx(int p0)
        {
            TabControl tabOngletsApplication = (TabControl)frmMediatek.Controls["tabOngletsApplication"];
            frmMediatek.Visible = true;
            tabOngletsApplication.SelectedTab = (TabPage)tabOngletsApplication.Controls["tabLivres"];
            ComboBox cbxLivresGenres = (ComboBox)frmMediatek.Controls["tabOngletsApplication"].Controls["tabLivres"].Controls["grpLivresRecherche"].Controls["cbxLivresGenres"];
            cbxLivresGenres.SelectedIndex = p0;
        }


        [Then(@"dgvLivresListe comporte (.*) livres")]
        public void ThenDgvLivresListeComporteLivres(int frmNbLivres)
        {
            DataGridView dgvLivresListe = (DataGridView)frmMediatek.Controls["tabOngletsApplication"].Controls["tabLivres"].Controls["grpLivresRecherche"].Controls["dgvLivresListe"];
            int nbLivres = dgvLivresListe.Rows.Count;
            Assert.AreEqual(frmNbLivres, nbLivres);
        }

        [When(@"je choisis le public qui se trouve à la ligne (.*) dans le cbx")]
        public void WhenJeChoisisLePublicQuiSeTrouveALaLigneDansLeCbx(int p0)
        {
            TabControl tabOngletsApplication = (TabControl)frmMediatek.Controls["tabOngletsApplication"];
            frmMediatek.Visible = true;
            tabOngletsApplication.SelectedTab = (TabPage)tabOngletsApplication.Controls["tabLivres"];
            ComboBox cbxLivresPublics = (ComboBox)frmMediatek.Controls["tabOngletsApplication"].Controls["tabLivres"].Controls["grpLivresRecherche"].Controls["cbxLivresPublics"];
            cbxLivresPublics.SelectedIndex = p0;
        }

        [When(@"je choisis le rayon qui se trouve à la ligne (.*) dans le cbx")]
        public void WhenJeChoisisLeRayonQuiSeTrouveALaLigneDansLeCbx(int p0)
        {
            TabControl tabOngletsApplication = (TabControl)frmMediatek.Controls["tabOngletsApplication"];
            frmMediatek.Visible = true;
            tabOngletsApplication.SelectedTab = (TabPage)tabOngletsApplication.Controls["tabLivres"];
            ComboBox cbxLivresRayons = (ComboBox)frmMediatek.Controls["tabOngletsApplication"].Controls["tabLivres"].Controls["grpLivresRecherche"].Controls["cbxLivresRayons"];
            cbxLivresRayons.SelectedIndex = p0;
        }
    }
}
