using gestion_cabinet_notarial.BL;
using gestion_cabinet_notarial.context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_cabinet_notarial.controls
{
    public partial class CTL_modifier_compte : UserControl
    {
        CSL_BL_UTILISATUER user = new CSL_BL_UTILISATUER();
        public CTL_modifier_compte()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        public utilisateur compte_user()
        {
            var A = new utilisateur();
            A = user.FindByValues(ele => ele.utilisateur1 == THEME.id_user).SingleOrDefault();
            bunifuTextBox_USER.Text = A.utilisateur1;
            bunifuTextBox_PASS.Text = A.Password;
            bunifuTextBox_NOM.Text = A.Nom;
            bunifuTextBox_PRENOM.Text = A.Prenom;
            bunifuTextBox_USER.Enabled = false;
            return A;
        }
        private void CTL_modifier_compte_VisibleChanged(object sender, EventArgs e)
        {
            compte_user();
        }
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            var A = new utilisateur();
            A = user.FindByValues(ele => ele.utilisateur1 == THEME.id_user).SingleOrDefault();
            A.Nom = bunifuTextBox_NOM.Text;
            A.Prenom = bunifuTextBox_PRENOM.Text;
           // A.utilisateur1 = bunifuTextBox_USER.Text;
            A.Password = bunifuTextBox_PASS.Text;
            if (bunifuTextBox_USER.Text.Trim() == "" || bunifuTextBox_PASS.Text.Trim() == "" || bunifuTextBox_NOM.Text.Trim() == "" || bunifuTextBox_PRENOM.Text.Trim() == "")
            {
                MessageBox.Show("Remplire tout les champs");
                return;
            }
            user.SaveChanges();
            THEME.operation($"MODIFIER COMPTE CETTE UTILISATEUR");
            MessageBox.Show("modification le compte avec success");

        }
        private void ButtonInit_Click(object sender, EventArgs e)
        {
            compte_user();
        }
    }
}
