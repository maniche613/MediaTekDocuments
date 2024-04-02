
namespace MediaTekDocuments.view
{
    partial class FrmAuthentification
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.label1 = new System.Windows.Forms.Label();
			this.txbMotDePasse = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txbUtilisateur = new System.Windows.Forms.TextBox();
			this.btnSeConnecter = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 10);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Utilisateur :";
			// 
			// txbMotDePasse
			// 
			this.txbMotDePasse.Location = new System.Drawing.Point(89, 32);
			this.txbMotDePasse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txbMotDePasse.Name = "txbMotDePasse";
			this.txbMotDePasse.Size = new System.Drawing.Size(92, 20);
			this.txbMotDePasse.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 32);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Mot de passe :";
			// 
			// txbUtilisateur
			// 
			this.txbUtilisateur.Location = new System.Drawing.Point(89, 10);
			this.txbUtilisateur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txbUtilisateur.Name = "txbUtilisateur";
			this.txbUtilisateur.Size = new System.Drawing.Size(92, 20);
			this.txbUtilisateur.TabIndex = 3;
			// 
			// btnSeConnecter
			// 
			this.btnSeConnecter.Location = new System.Drawing.Point(9, 54);
			this.btnSeConnecter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnSeConnecter.Name = "btnSeConnecter";
			this.btnSeConnecter.Size = new System.Drawing.Size(172, 19);
			this.btnSeConnecter.TabIndex = 4;
			this.btnSeConnecter.Text = "Se connecter";
			this.btnSeConnecter.UseVisualStyleBackColor = true;
			this.btnSeConnecter.Click += new System.EventHandler(this.btnSeConnecter_Click);
			// 
			// FrmAuthentification
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(196, 84);
			this.Controls.Add(this.btnSeConnecter);
			this.Controls.Add(this.txbUtilisateur);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txbMotDePasse);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "FrmAuthentification";
			this.Text = "FrmAuthentification";
			this.Load += new System.EventHandler(this.FrmAuthentification_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbMotDePasse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbUtilisateur;
        private System.Windows.Forms.Button btnSeConnecter;
    }
}