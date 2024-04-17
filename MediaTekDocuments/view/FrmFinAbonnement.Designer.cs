
namespace MediaTekDocuments.view
{
	partial class FrmFinAbonnement
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
			this.dgvAbonnementsAEcheance = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvAbonnementsAEcheance)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvAbonnementsAEcheance
			// 
			this.dgvAbonnementsAEcheance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAbonnementsAEcheance.Location = new System.Drawing.Point(9, 30);
			this.dgvAbonnementsAEcheance.Margin = new System.Windows.Forms.Padding(2);
			this.dgvAbonnementsAEcheance.Name = "dgvAbonnementsAEcheance";
			this.dgvAbonnementsAEcheance.RowHeadersWidth = 51;
			this.dgvAbonnementsAEcheance.RowTemplate.Height = 24;
			this.dgvAbonnementsAEcheance.Size = new System.Drawing.Size(341, 151);
			this.dgvAbonnementsAEcheance.TabIndex = 0;
			this.dgvAbonnementsAEcheance.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAbonnementsAEcheance_ColumnHeaderMouseClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 11);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(336, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Liste des revues dont l\'abonnement se termine dans moins de 30 jours";
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(9, 186);
			this.btnClose.Margin = new System.Windows.Forms.Padding(2);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(345, 19);
			this.btnClose.TabIndex = 2;
			this.btnClose.Text = "Fermer";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// FrmFinAbonnement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(363, 213);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvAbonnementsAEcheance);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FrmFinAbonnement";
			this.Text = "FrmFinAbonnement";
			this.Load += new System.EventHandler(this.FrmRevues30j_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvAbonnementsAEcheance)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvAbonnementsAEcheance;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnClose;
	}
}