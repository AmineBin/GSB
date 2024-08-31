using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using GesEssaiCliniqueBLL;
using GesEssaiCliniqueBO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesEssaiCliniqueGUI
{
	public partial class FrmParticipationConsult : Form
	{
		public FrmParticipationConsult()
		{
			InitializeComponent();

			List<Participation> lesParticipations = ParticipationManager.GetInstance().GetParticipations();
			dtgConsult.DataSource = lesParticipations;

			dtgConsult.Columns["id"].Visible = false;

			dtgConsult.Columns["dateSignatureAccord"].Visible = true;
			dtgConsult.Columns["montantIndemnisation"].Visible = true;

			dtgConsult.Columns["InfoEssaiClinique"].Visible = true;
			dtgConsult.Columns["EssaiClinique"].Visible = false;

			dtgConsult.Columns["InfoPatient"].Visible = true;
			dtgConsult.Columns["Patient"].Visible = false;

			dtgConsult.Columns["InfoEvenement"].Visible = true;
			dtgConsult.Columns["Evenement"].Visible = false;
		}
	}
}
