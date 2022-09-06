using Bunifu.UI.WinForms;
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
    public partial class CTL_PARAMETER_AJOUTER_UTILISATUER : UserControl
    {
        CSL_BL_UTILISATUER user = new CSL_BL_UTILISATUER();
        CSL_BL_FUNCTION FUNC = new CSL_BL_FUNCTION();
        public CTL_PARAMETER_AJOUTER_UTILISATUER()
        {
            InitializeComponent();
        }
        public void seting()
        {
            List<fonction> list_func = new List<fonction>();
            
            foreach(Control c in panel_check_box.Controls)
            {          
                var a = new fonction();     
                if(c is BunifuCheckBox && ((BunifuCheckBox)c).Checked)
                {
                    a.utilisateur = bunifuTextBox_USER.Text;
                    MessageBox.Show(c.Tag.ToString());
                    a.fonction1 = c.Tag.ToString();
                    list_func.Add(a);
                }
            }
            FUNC.AddRange(list_func);
        } 
        private void ButtonAdd_utilisatuer_Click(object sender, EventArgs e)
        {
           var A = new utilisateur();
            A.utilisateur1 = bunifuTextBox_USER.Text;
            A.Password = bunifuTextBox_PASS.Text;
            A.Nom = bunifuTextBox_NOM.Text;
            A.Prenom = bunifuTextBox_PRENOM.Text;
            user.Add(A);
            seting();
        }

        private void bunifuCheckBox_parameter_CheckedChanged(object sender, BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox_parameter.Checked)
            {
                bunifuCheckBox_ajputer_utilisatuer.Checked = true;
                bunifuCheckBox_list_utilisatuer.Checked = true;
                bunifuCheckBox_suprimer_utilisatuer.Checked=true;
                bunifuCheckBox_list_operation.Checked = true;
                bunifuCheckBox_basedonnee.Checked = true;
            }
            else
            {
                bunifuCheckBox_ajputer_utilisatuer.Checked = false;
                bunifuCheckBox_list_utilisatuer.Checked = false;
                bunifuCheckBox_suprimer_utilisatuer.Checked = false;
                bunifuCheckBox_list_operation.Checked = false;
                bunifuCheckBox_basedonnee.Checked = false;
            }
        }

        private void bunifuCheckBox_rdv_CheckedChanged(object sender, BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox_rdv.Checked)
            {
                bunifuCheckBox_rdv_ajouter.Checked = true;
                bunifuCheckBox_rdv_passer.Checked= true;
                bunifuCheckBox_rdv_suprimer.Checked = true;
            }
            else
            {
                bunifuCheckBox_rdv_ajouter.Checked = false;
                bunifuCheckBox_rdv_passer.Checked = false;
                bunifuCheckBox_rdv_suprimer.Checked = false;
            }
        }

        private void bunifuCheckBox_client_CheckedChanged(object sender, BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox_client.Checked)
            {
                bunifuCheckBox_client_ajouter.Checked=true;
                bunifuCheckBox_client_modifier.Checked=true;
                bunifuCheckBox_client_fichier.Checked=true;
                bunifuCheckBox_client_dossier.Checked=true;
            }
            else
            {
                bunifuCheckBox_client_ajouter.Checked = false;
                bunifuCheckBox_client_modifier.Checked = false;
                bunifuCheckBox_client_fichier.Checked = false;
                bunifuCheckBox_client_dossier.Checked = false;
            }
        }

        private void bunifuCheckBox_contart_CheckedChanged(object sender, BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox_contart.Checked)
            {
                bunifuCheckBox_contart_ajouter.Checked=true;
                bunifuCheckBox_contart_detail.Checked=true;
                bunifuCheckBox_contart_paiement.Checked=true;
                bunifuCheckBox_contart_fichier.Checked = true;
                bunifuCheckBox_contart_signature.Checked=true;
                bunifuCheckBox_contart_statistic.Checked=true;
            }
            else
            {
                bunifuCheckBox_contart_ajouter.Checked = false;
                bunifuCheckBox_contart_detail.Checked = false;
                bunifuCheckBox_contart_paiement.Checked = false;
                bunifuCheckBox_contart_fichier.Checked = false;
                bunifuCheckBox_contart_signature.Checked = false;
                bunifuCheckBox_contart_statistic.Checked = false;
            }
        }

        private void bunifuCheckBox_dossier_CheckedChanged(object sender, BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox_dossier.Checked)
            {
                bunifuCheckBox_dossier_ajouter.Checked=true;
                bunifuCheckBox_dossier_modifier.Checked=true;
                bunifuCheckBox__dossier_detail.Checked=true;
                bunifuCheckBox__dossier_fichier.Checked=true;
                bunifuCheckBox_dossier_contart.Checked=true;
                bunifuCheckBox_dossier_parte.Checked=true;
            }
            else
            {
                bunifuCheckBox_dossier_ajouter.Checked = false;
                bunifuCheckBox_dossier_modifier.Checked = false;
                bunifuCheckBox__dossier_detail.Checked = false;
                bunifuCheckBox__dossier_fichier.Checked = false;
                bunifuCheckBox_dossier_contart.Checked = false;
                bunifuCheckBox_dossier_parte.Checked = false;
            }
        }
    }
}
