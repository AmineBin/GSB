namespace GesEssaiCliniqueGUI
{
	partial class FrmParticipationAjout
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
			this.dtpSignature = new System.Windows.Forms.DateTimePicker();
			this.txtMontant = new System.Windows.Forms.TextBox();
			this.lblEvenement = new System.Windows.Forms.Label();
			this.lblPatient = new System.Windows.Forms.Label();
			this.lblEssaiClinique = new System.Windows.Forms.Label();
			this.lblMontant = new System.Windows.Forms.Label();
			this.lblSignature = new System.Windows.Forms.Label();
			this.cbxEvenement = new System.Windows.Forms.ComboBox();
			this.cbxPatient = new System.Windows.Forms.ComboBox();
			this.cbxEssaiClinique = new System.Windows.Forms.ComboBox();
			this.btnEnreg = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// dtpSignature
			// 
			this.dtpSignature.Location = new System.Drawing.Point(218, 117);
			this.dtpSignature.Name = "dtpSignature";
			this.dtpSignature.Size = new System.Drawing.Size(200, 20);
			this.dtpSignature.TabIndex = 22;
			// 
			// txtMontant
			// 
			this.txtMontant.Location = new System.Drawing.Point(218, 149);
			this.txtMontant.Name = "txtMontant";
			this.txtMontant.Size = new System.Drawing.Size(100, 20);
			this.txtMontant.TabIndex = 21;
			// 
			// lblEvenement
			// 
			this.lblEvenement.AutoSize = true;
			this.lblEvenement.Location = new System.Drawing.Point(145, 243);
			this.lblEvenement.Name = "lblEvenement";
			this.lblEvenement.Size = new System.Drawing.Size(67, 13);
			this.lblEvenement.TabIndex = 20;
			this.lblEvenement.Text = "Evenement :";
			// 
			// lblPatient
			// 
			this.lblPatient.AutoSize = true;
			this.lblPatient.Location = new System.Drawing.Point(166, 216);
			this.lblPatient.Name = "lblPatient";
			this.lblPatient.Size = new System.Drawing.Size(46, 13);
			this.lblPatient.TabIndex = 19;
			this.lblPatient.Text = "Patient :";
			// 
			// lblEssaiClinique
			// 
			this.lblEssaiClinique.AutoSize = true;
			this.lblEssaiClinique.Location = new System.Drawing.Point(135, 185);
			this.lblEssaiClinique.Name = "lblEssaiClinique";
			this.lblEssaiClinique.Size = new System.Drawing.Size(77, 13);
			this.lblEssaiClinique.TabIndex = 18;
			this.lblEssaiClinique.Text = "Essai clinique :";
			// 
			// lblMontant
			// 
			this.lblMontant.AutoSize = true;
			this.lblMontant.Location = new System.Drawing.Point(93, 152);
			this.lblMontant.Name = "lblMontant";
			this.lblMontant.Size = new System.Drawing.Size(119, 13);
			this.lblMontant.TabIndex = 17;
			this.lblMontant.Text = "Montant indemnisation :";
			// 
			// lblSignature
			// 
			this.lblSignature.AutoSize = true;
			this.lblSignature.Location = new System.Drawing.Point(130, 123);
			this.lblSignature.Name = "lblSignature";
			this.lblSignature.Size = new System.Drawing.Size(82, 13);
			this.lblSignature.TabIndex = 16;
			this.lblSignature.Text = "Date signature :";
			// 
			// cbxEvenement
			// 
			this.cbxEvenement.FormattingEnabled = true;
			this.cbxEvenement.Location = new System.Drawing.Point(218, 240);
			this.cbxEvenement.Name = "cbxEvenement";
			this.cbxEvenement.Size = new System.Drawing.Size(272, 21);
			this.cbxEvenement.TabIndex = 15;
			// 
			// cbxPatient
			// 
			this.cbxPatient.FormattingEnabled = true;
			this.cbxPatient.Location = new System.Drawing.Point(218, 213);
			this.cbxPatient.Name = "cbxPatient";
			this.cbxPatient.Size = new System.Drawing.Size(272, 21);
			this.cbxPatient.TabIndex = 14;
			// 
			// cbxEssaiClinique
			// 
			this.cbxEssaiClinique.FormattingEnabled = true;
			this.cbxEssaiClinique.Location = new System.Drawing.Point(218, 182);
			this.cbxEssaiClinique.Name = "cbxEssaiClinique";
			this.cbxEssaiClinique.Size = new System.Drawing.Size(530, 21);
			this.cbxEssaiClinique.TabIndex = 13;
			// 
			// btnEnreg
			// 
			this.btnEnreg.Location = new System.Drawing.Point(383, 310);
			this.btnEnreg.Name = "btnEnreg";
			this.btnEnreg.Size = new System.Drawing.Size(75, 23);
			this.btnEnreg.TabIndex = 12;
			this.btnEnreg.Text = "Enregistrer";
			this.btnEnreg.UseVisualStyleBackColor = true;
			this.btnEnreg.Click += new System.EventHandler(this.btnEnreg_Click);
			// 
			// FrmParticipationAjout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dtpSignature);
			this.Controls.Add(this.txtMontant);
			this.Controls.Add(this.lblEvenement);
			this.Controls.Add(this.lblPatient);
			this.Controls.Add(this.lblEssaiClinique);
			this.Controls.Add(this.lblMontant);
			this.Controls.Add(this.lblSignature);
			this.Controls.Add(this.cbxEvenement);
			this.Controls.Add(this.cbxPatient);
			this.Controls.Add(this.cbxEssaiClinique);
			this.Controls.Add(this.btnEnreg);
			this.Name = "FrmParticipationAjout";
			this.Text = "AjoutParticipation";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dtpSignature;
		private System.Windows.Forms.TextBox txtMontant;
		private System.Windows.Forms.Label lblEvenement;
		private System.Windows.Forms.Label lblPatient;
		private System.Windows.Forms.Label lblEssaiClinique;
		private System.Windows.Forms.Label lblMontant;
		private System.Windows.Forms.Label lblSignature;
		private System.Windows.Forms.ComboBox cbxEvenement;
		private System.Windows.Forms.ComboBox cbxPatient;
		private System.Windows.Forms.ComboBox cbxEssaiClinique;
		private System.Windows.Forms.Button btnEnreg;
	}
}