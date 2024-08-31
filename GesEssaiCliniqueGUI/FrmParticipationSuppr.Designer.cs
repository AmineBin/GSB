namespace GesEssaiCliniqueGUI
{
	partial class FrmParticipationSuppr
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
			this.cbxSuppr = new System.Windows.Forms.ComboBox();
			this.btnSuppr = new System.Windows.Forms.Button();
			this.btnAnnul = new System.Windows.Forms.Button();
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cbxSuppr
			// 
			this.cbxSuppr.FormattingEnabled = true;
			this.cbxSuppr.Location = new System.Drawing.Point(247, 39);
			this.cbxSuppr.Name = "cbxSuppr";
			this.cbxSuppr.Size = new System.Drawing.Size(288, 21);
			this.cbxSuppr.TabIndex = 0;
			// 
			// btnSuppr
			// 
			this.btnSuppr.Location = new System.Drawing.Point(271, 345);
			this.btnSuppr.Name = "btnSuppr";
			this.btnSuppr.Size = new System.Drawing.Size(86, 39);
			this.btnSuppr.TabIndex = 1;
			this.btnSuppr.Text = "Supprimer";
			this.btnSuppr.UseVisualStyleBackColor = true;
			// 
			// btnAnnul
			// 
			this.btnAnnul.Location = new System.Drawing.Point(460, 345);
			this.btnAnnul.Name = "btnAnnul";
			this.btnAnnul.Size = new System.Drawing.Size(98, 39);
			this.btnAnnul.TabIndex = 2;
			this.btnAnnul.Text = "Annuler";
			this.btnAnnul.UseVisualStyleBackColor = true;
			// 
			// dtpSignature
			// 
			this.dtpSignature.Location = new System.Drawing.Point(145, 25);
			this.dtpSignature.Name = "dtpSignature";
			this.dtpSignature.Size = new System.Drawing.Size(200, 20);
			this.dtpSignature.TabIndex = 32;
			// 
			// txtMontant
			// 
			this.txtMontant.Location = new System.Drawing.Point(145, 57);
			this.txtMontant.Name = "txtMontant";
			this.txtMontant.Size = new System.Drawing.Size(100, 20);
			this.txtMontant.TabIndex = 31;
			// 
			// lblEvenement
			// 
			this.lblEvenement.AutoSize = true;
			this.lblEvenement.Location = new System.Drawing.Point(72, 151);
			this.lblEvenement.Name = "lblEvenement";
			this.lblEvenement.Size = new System.Drawing.Size(67, 13);
			this.lblEvenement.TabIndex = 30;
			this.lblEvenement.Text = "Evenement :";
			// 
			// lblPatient
			// 
			this.lblPatient.AutoSize = true;
			this.lblPatient.Location = new System.Drawing.Point(93, 124);
			this.lblPatient.Name = "lblPatient";
			this.lblPatient.Size = new System.Drawing.Size(46, 13);
			this.lblPatient.TabIndex = 29;
			this.lblPatient.Text = "Patient :";
			// 
			// lblEssaiClinique
			// 
			this.lblEssaiClinique.AutoSize = true;
			this.lblEssaiClinique.Location = new System.Drawing.Point(62, 93);
			this.lblEssaiClinique.Name = "lblEssaiClinique";
			this.lblEssaiClinique.Size = new System.Drawing.Size(77, 13);
			this.lblEssaiClinique.TabIndex = 28;
			this.lblEssaiClinique.Text = "Essai clinique :";
			// 
			// lblMontant
			// 
			this.lblMontant.AutoSize = true;
			this.lblMontant.Location = new System.Drawing.Point(20, 60);
			this.lblMontant.Name = "lblMontant";
			this.lblMontant.Size = new System.Drawing.Size(119, 13);
			this.lblMontant.TabIndex = 27;
			this.lblMontant.Text = "Montant indemnisation :";
			// 
			// lblSignature
			// 
			this.lblSignature.AutoSize = true;
			this.lblSignature.Location = new System.Drawing.Point(57, 31);
			this.lblSignature.Name = "lblSignature";
			this.lblSignature.Size = new System.Drawing.Size(82, 13);
			this.lblSignature.TabIndex = 26;
			this.lblSignature.Text = "Date signature :";
			// 
			// cbxEvenement
			// 
			this.cbxEvenement.FormattingEnabled = true;
			this.cbxEvenement.Location = new System.Drawing.Point(145, 148);
			this.cbxEvenement.Name = "cbxEvenement";
			this.cbxEvenement.Size = new System.Drawing.Size(272, 21);
			this.cbxEvenement.TabIndex = 25;
			// 
			// cbxPatient
			// 
			this.cbxPatient.FormattingEnabled = true;
			this.cbxPatient.Location = new System.Drawing.Point(145, 121);
			this.cbxPatient.Name = "cbxPatient";
			this.cbxPatient.Size = new System.Drawing.Size(272, 21);
			this.cbxPatient.TabIndex = 24;
			// 
			// cbxEssaiClinique
			// 
			this.cbxEssaiClinique.FormattingEnabled = true;
			this.cbxEssaiClinique.Location = new System.Drawing.Point(145, 90);
			this.cbxEssaiClinique.Name = "cbxEssaiClinique";
			this.cbxEssaiClinique.Size = new System.Drawing.Size(530, 21);
			this.cbxEssaiClinique.TabIndex = 23;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dtpSignature);
			this.panel1.Controls.Add(this.cbxEssaiClinique);
			this.panel1.Controls.Add(this.txtMontant);
			this.panel1.Controls.Add(this.cbxPatient);
			this.panel1.Controls.Add(this.lblEvenement);
			this.panel1.Controls.Add(this.cbxEvenement);
			this.panel1.Controls.Add(this.lblPatient);
			this.panel1.Controls.Add(this.lblSignature);
			this.panel1.Controls.Add(this.lblEssaiClinique);
			this.panel1.Controls.Add(this.lblMontant);
			this.panel1.Location = new System.Drawing.Point(101, 106);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(670, 212);
			this.panel1.TabIndex = 33;
			this.panel1.Visible = false;
			// 
			// FrmParticipationSuppr
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1077, 686);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnAnnul);
			this.Controls.Add(this.btnSuppr);
			this.Controls.Add(this.cbxSuppr);
			this.Name = "FrmParticipationSuppr";
			this.Text = "FrmParticipationSuppr";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox cbxSuppr;
		private System.Windows.Forms.Button btnSuppr;
		private System.Windows.Forms.Button btnAnnul;
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
		private System.Windows.Forms.Panel panel1;
	}
}