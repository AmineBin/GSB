using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesEssaiCliniqueGUI
{
	public partial class FrmMenu : Form
	{
		public FrmMenu()
		{
			InitializeComponent();
		}

		private void btnAjoutParticipation_Click(object sender, EventArgs e)
		{
			FrmParticipationAjout LeFormProd = new FrmParticipationAjout();

			LeFormProd.Show();
		}

		private void btnConsultParticipation_Click(object sender, EventArgs e)
		{
			FrmParticipationConsult LeFormProd = new FrmParticipationConsult();

			LeFormProd.Show();
		}

		private void btnSuppParticip_Click(object sender, EventArgs e)
		{
			FrmParticipationSuppr LeFormProd = new FrmParticipationSuppr();

			LeFormProd.Show();
		}
	}
}