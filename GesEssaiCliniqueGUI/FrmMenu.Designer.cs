namespace GesEssaiCliniqueGUI
{
	partial class FrmMenu
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnAjoutParticipation = new System.Windows.Forms.Button();
			this.btnConsultParticipation = new System.Windows.Forms.Button();
			this.btnSuppParticip = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnAjoutParticipation
			// 
			this.btnAjoutParticipation.Location = new System.Drawing.Point(288, 77);
			this.btnAjoutParticipation.Name = "btnAjoutParticipation";
			this.btnAjoutParticipation.Size = new System.Drawing.Size(166, 83);
			this.btnAjoutParticipation.TabIndex = 1;
			this.btnAjoutParticipation.Text = "Ajout participation";
			this.btnAjoutParticipation.UseVisualStyleBackColor = true;
			this.btnAjoutParticipation.Click += new System.EventHandler(this.btnAjoutParticipation_Click);
			// 
			// btnConsultParticipation
			// 
			this.btnConsultParticipation.Location = new System.Drawing.Point(77, 77);
			this.btnConsultParticipation.Name = "btnConsultParticipation";
			this.btnConsultParticipation.Size = new System.Drawing.Size(167, 83);
			this.btnConsultParticipation.TabIndex = 2;
			this.btnConsultParticipation.Text = "Consultation de participation";
			this.btnConsultParticipation.UseVisualStyleBackColor = true;
			this.btnConsultParticipation.Click += new System.EventHandler(this.btnConsultParticipation_Click);
			// 
			// btnSuppParticip
			// 
			this.btnSuppParticip.Location = new System.Drawing.Point(496, 77);
			this.btnSuppParticip.Name = "btnSuppParticip";
			this.btnSuppParticip.Size = new System.Drawing.Size(166, 83);
			this.btnSuppParticip.TabIndex = 3;
			this.btnSuppParticip.Text = "Supprimer de participation";
			this.btnSuppParticip.UseVisualStyleBackColor = true;
			this.btnSuppParticip.Click += new System.EventHandler(this.btnSuppParticip_Click);
			// 
			// FrmMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnSuppParticip);
			this.Controls.Add(this.btnConsultParticipation);
			this.Controls.Add(this.btnAjoutParticipation);
			this.Name = "FrmMenu";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnAjoutParticipation;
		private System.Windows.Forms.Button btnConsultParticipation;
		private System.Windows.Forms.Button btnSuppParticip;
	}
}

