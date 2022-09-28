using gestion_cabinet_notarial.BL;
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
    public partial class login : Form
    {
        CSL_BL_FUNCTION FUNC = new CSL_BL_FUNCTION();
        CSL_BL_UTILISATUER user = new CSL_BL_UTILISATUER();
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {            
        }

        private void bunifuButton_LOGIN_Click(object sender, EventArgs e)
        {
            THEME.fonctionnalete.Clear();
            var func = FUNC.FindByValues(ele => ele.utilisateur == bunifuTextBox_user.Text).ToList();
            func.ForEach(f =>
            {
                THEME.fonctionnalete.Add(f.fonction1);
            });
            THEME.id_user = bunifuTextBox_user.Text;           
            var user_connecte = user.FindByValues(ele => ele.utilisateur1 == bunifuTextBox_user.Text && ele.Password==bunifuTextBox_passe.Text).FirstOrDefault();
            if (user_connecte == null)
                return;
            THEME.utilisateur = user_connecte.Nom + " " + user_connecte.Prenom;
            new form_main().Show();
            this.Hide();
        }
    }
}
