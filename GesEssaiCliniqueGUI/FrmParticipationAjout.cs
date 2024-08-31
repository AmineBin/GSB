using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using GesEssaiCliniqueDAL;
using GesEssaiCliniqueBLL;
using GesEssaiCliniqueBO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesEssaiCliniqueGUI
{
	public partial class FrmParticipationAjout : Form
	{
		public FrmParticipationAjout()
		{
			InitializeComponent();

			cbxEvenement.ValueMember = "id";

			cbxEvenement.DisplayMember = "DateCategorie";

			cbxEvenement.DataSource = EvenementManager.GetInstance().GetEvenements();
			

			cbxEssaiClinique.ValueMember = "numEudract";

			cbxEssaiClinique.DisplayMember = "DateCategMedicament";

			cbxEssaiClinique.DataSource = EssaiCliniqueManager.GetInstance().GetEssaiclinique();
			

			cbxPatient.ValueMember = "id";

			cbxPatient.DisplayMember = "InfoPatient";

			cbxPatient.DataSource = PatientManager.GetInstance().GetPatients();



		}

		private void btnEnreg_Click(object sender, EventArgs e)
		{
			if (txtMontant.Text == "")
			{

				ParticipationManager.GetInstance().CreerParticipation(dtpSignature.Value, Decimal.Parse(txtMontant.Text), (string)cbxEssaiClinique.SelectedValue, (int)cbxPatient.SelectedValue, (int)cbxEvenement.SelectedValue);
				MessageBox.Show("L'évènement a été ajouté", "Message Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{

			}
		}
	}
}
