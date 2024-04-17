

using MediaTekDocuments.controller;
using MediaTekDocuments.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MediaTekDocuments.view
{

    /// <summary>
    /// Classe d'affichage de l'alerte de fin d'abonnement
    /// </summary>
    public partial class FrmFinAbonnement : Form
    {
        private readonly FrmMediatekController controller;
        private readonly BindingSource bdgAbonnementsAEcheance = new BindingSource();
        private List<Abonnement> lesAbonnementsAEcheance = new List<Abonnement>();

        /// <summary>
        /// Constructeur : création du contrôleur lié à ce formulaire
        /// </summary>
        /// <param name="controller">Controller</param>
        public FrmFinAbonnement()
        {
            InitializeComponent();
            this.controller = new FrmMediatekController();
            lesAbonnementsAEcheance = AbonnementsAEcheance();
            RemplirAbonnementsAEcheance(lesAbonnementsAEcheance);
        }
        /// <summary>
        /// Remplissage de la grille des abonnements qui se terminent
        /// </summary>
        /// <param name="lesAbonnementsAEcheance">Liste des abonnements à échéance</param>
        private void RemplirAbonnementsAEcheance(List<Abonnement> lesAbonnementsAEcheance)
        {
            bdgAbonnementsAEcheance.DataSource = lesAbonnementsAEcheance;
            dgvAbonnementsAEcheance.DataSource = bdgAbonnementsAEcheance;
            dgvAbonnementsAEcheance.Columns["dateCommande"].Visible = false;
            dgvAbonnementsAEcheance.Columns["montant"].Visible = false;
            dgvAbonnementsAEcheance.Columns["idRevue"].Visible = false;
            dgvAbonnementsAEcheance.Columns["id"].Visible = false;
            dgvAbonnementsAEcheance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAbonnementsAEcheance.Columns[0].HeaderCell.Value = "Date de fin d'abonnement";
            dgvAbonnementsAEcheance.Columns[1].HeaderCell.Value = "Titre";
        }

        /// <summary>
        /// Liste des abonnements arrivés à échéance
        /// </summary>
        /// <returns></returns>
        private List<Abonnement> AbonnementsAEcheance()
        {
            List<Abonnement> lesAbonnements = controller.GetAbonnements();
            DateTime trenteJours = DateTime.Now.AddDays(-30);
            foreach (Abonnement abonnement in lesAbonnements)
            {
                if (abonnement.DateFinAbonnement > trenteJours)
                {
                    lesAbonnementsAEcheance.Add(abonnement);
                }
            }
            return lesAbonnementsAEcheance;
        }

        /// <summary>
        /// Tri sur les colonnes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvAbonnementsAEcheance_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string titreColonne = dgvAbonnementsAEcheance.Columns[e.ColumnIndex].HeaderText;
            List<Abonnement> sortedList = new List<Abonnement>();
            switch (titreColonne)
            {
                case "Titre":
                    sortedList = lesAbonnementsAEcheance.OrderBy(o => o.Titre).ToList();
                    break;
                case "Date de fin d'abonnement":
                    sortedList = lesAbonnementsAEcheance.OrderBy(o => o.DateFinAbonnement).Reverse().ToList();
                    break;
            }
            RemplirAbonnementsAEcheance(sortedList);
        }

        /// <summary>
        /// Fermeture de la fenêtre d'alerte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void FrmRevues30j_Load(object sender, EventArgs e)
		{

		}
	}
}