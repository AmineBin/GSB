namespace GesEssaiCliniqueGUI
{
	partial class FrmParticipationConsult
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
			this.dtgConsult = new System.Windows.Forms.DataGridView();
			this.btnInfo = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dtgConsult)).BeginInit();
			this.SuspendLayout();
			// 
			// dtgConsult
			// 
			this.dtgConsult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgConsult.Location = new System.Drawing.Point(70, 73);
			this.dtgConsult.Name = "dtgConsult";
			this.dtgConsult.Size = new System.Drawing.Size(976, 357);
			this.dtgConsult.TabIndex = 0;
			// 
			// btnInfo
			// 
			this.btnInfo.Location = new System.Drawing.Point(466, 34);
			this.btnInfo.Name = "btnInfo";
			this.btnInfo.Size = new System.Drawing.Size(167, 23);
			this.btnInfo.TabIndex = 1;
			this.btnInfo.Text = "Obtenir la liste";
			this.btnInfo.UseVisualStyleBackColor = true;
			// 
			// FrmParticipationConsult
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1080, 501);
			this.Controls.Add(this.btnInfo);
			this.Controls.Add(this.dtgConsult);
			this.Name = "FrmParticipationConsult";
			this.Text = "FrmParticipationConsult";
			((System.ComponentModel.ISupportInitialize)(this.dtgConsult)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dtgConsult;
		private System.Windows.Forms.Button btnInfo;
	}
}