using MediaTekDocuments.controller;
using MediaTekDocuments.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTekDocuments.view
{
    public partial class FrmAuthentification : Form
    {
        private readonly FrmMediatekController controller;
        private List<Utilisateur> lesUtilisateurs = new List<Utilisateur>();

        public FrmAuthentification()
        {
            InitializeComponent();
            this.controller = new FrmMediatekController();
            txbUtilisateur.Select();
        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            try
            {
                lesUtilisateurs = controller.GetAllUtilisateurs();
                int k = 0;
                while (lesUtilisateurs[k].Login != txbUtilisateur.Text && lesUtilisateurs[k].Password != txbMotDePasse.Text && k <= lesUtilisateurs.Count)
                {
                    k++;
                }
                if (k <= lesUtilisateurs.Count)
                {
                    VerificationType(lesUtilisateurs[k]);
                }
                else
                {
                    MessageBox.Show("Utilisateur ou mot de passe incorrect", "Erreur");
                }
            }
            catch
            {
                MessageBox.Show("Utilisateur ou mot de passe incorrect", "Erreur");
            }
        }

        private void VerificationType(Utilisateur utilisateur)
        {
            if (utilisateur.Type == "Culture")
            {
                MessageBox.Show("Vous n'avez pas les droits d'accès à l'application.", "Alerte");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Vous êtes connecté", "Information");
                this.Hide();
                FrmMediatek frmMediatek = new FrmMediatek(utilisateur);
                frmMediatek.Show();
            }
        }

		private void FrmAuthentification_Load(object sender, EventArgs e)
		{

		}
	}
}
