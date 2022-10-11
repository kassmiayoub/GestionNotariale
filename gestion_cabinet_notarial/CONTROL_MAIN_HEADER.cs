using System;
using System.Windows.Forms;
using gestion_cabinet_notarial.controls;
//using MAZ_Lawyer.PL.PL_THEMES.CUSROM_MESSAGE_BOX;

namespace gestion_cabinet_notarial
{
    public partial class CONTROL_MAIN_HEADER : UserControl
    {
        public CONTROL_MAIN_HEADER()
        {
            InitializeComponent();
            TimerDate.Start();
        }
        private void TimerDate_Tick(object sender, System.EventArgs e)
        {
            LabelDate.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
            if (TimerDate.Interval == 1)
                TimerDate.Interval = 1000;
        }
        private void LabelLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Voulez-vous vous déconnecter de votre compte?",
                                       "Important Question",
                                       MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                THEME.id_C = 0;
                Application.OpenForms["form_main"].Close();
                new login().Show();
            }
        }
        private void CONTROL_MAIN_HEADER_Load(object sender, EventArgs e)
        {
            LabelOfficeName.Text = THEME.utilisateur;
        }
    }
}
