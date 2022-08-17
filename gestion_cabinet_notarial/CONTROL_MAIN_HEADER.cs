using System;
using System.Windows.Forms;
//using Avocat_Maroc.PL.CONTROLS;
//using MAZ_Lawyer.PL.PL_THEMES.CUSROM_MESSAGE_BOX;

namespace Avocat_Maroc.PL
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
            //if (MessageBox.Show("خـروج ؟", "هـل تريـد الخـروج مـن حسابـك ؟", MessageBoxIcon.Question, MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    PanelLogOut.Visible = false;
            //    //THEME.Theme.LOGNED_USER = null;
            //    //THEME.Theme.FRM_MAIN.MainMenu.Visible = false;
            //    //THEME.Theme.Navigate(typeof(CTL_LOGIN));
            //}
        }
    }
}
