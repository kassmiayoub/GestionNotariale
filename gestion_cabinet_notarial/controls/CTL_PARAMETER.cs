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
        List<fonction> func_modifier = new List<fonction>();
        string id_user_mod = "";
        public CTL_PARAMETER_AJOUTER_UTILISATUER()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        public void seting()
        {
            List<fonction> list_func = new List<fonction>();

            foreach (Control c in panel_check_box.Controls)
            {
                var a = new fonction();
                if (c is BunifuCheckBox && ((BunifuCheckBox)c).Checked)
                {
                    a.utilisateur = bunifuTextBox_USER.Text;
                    a.fonction1 = c.Tag.ToString();
                    list_func.Add(a);
                }
            }
            FUNC.AddRange(list_func);
        }
        private void ButtonAdd_utilisatuer_Click(object sender, EventArgs e)
        {
            if (ButtonAdd_utilisatuer.Text == "AJOUTER")
            {
                var A = new utilisateur();
                A.utilisateur1 = bunifuTextBox_USER.Text;
                A.Password = bunifuTextBox_PASS.Text;
                A.Nom = bunifuTextBox_NOM.Text;
                A.Prenom = bunifuTextBox_PRENOM.Text;
                if(bunifuTextBox_USER.Text.Trim() == "" || bunifuTextBox_PASS.Text.Trim() == "" || bunifuTextBox_NOM.Text.Trim() == "" || bunifuTextBox_PRENOM.Text.Trim() == "")
                {
                    MessageBox.Show("Remplire tout les champs");
                    return;
                }
                user.Add(A);
                seting();
                MessageBox.Show("AJOUTER AVEC SUCCESS");
                THEME.operation($"AJOUER UN UTILISATEUR");
            }
            else
            {
                FUNC.RemoveRange(func_modifier);
                seting();
                ButtonAdd_utilisatuer.Text = "AJOUTER";
                ButtonAdd_utilisatuer.Image = global::gestion_cabinet_notarial.Properties.Resources.Add;
                bunifuTextBox_USER.Enabled = true;
                bunifuTextBox_PASS.Enabled = true;
                MessageBox.Show("MODIFIER AVEC SUCCESS");
                THEME.operation($"MODIFIER UN UTILISATEUR");
            }
        }
        private void bunifuCheckBox_parameter_CheckedChanged(object sender, BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (THEME.id_user_modifier == "")
            {
                if (bunifuCheckBox_parameter.Checked)
                {
                    bunifuCheckBox_ajputer_utilisatuer.Checked = true;
                    bunifuCheckBox_list_utilisatuer.Checked = true;
                    bunifuCheckBox_suprimer_utilisatuer.Checked = true;
                    bunifuCheckBox_list_operation.Checked = true;
                    bunifuCheckBox_basedonnee.Checked = true;
                    bunifuCheckBox_modifier_info_cabinet.Checked = true;
                    bunifuCheckBox_info_cabinet.Checked = true;
                    bunifuCheckBox_COMPTE.Checked = true;
                }
                else
                {
                    bunifuCheckBox_ajputer_utilisatuer.Checked = false;
                    bunifuCheckBox_list_utilisatuer.Checked = false;
                    bunifuCheckBox_suprimer_utilisatuer.Checked = false;
                    bunifuCheckBox_list_operation.Checked = false;
                    bunifuCheckBox_basedonnee.Checked = false;
                    bunifuCheckBox_modifier_info_cabinet.Checked = false;
                    bunifuCheckBox_info_cabinet.Checked = false;
                    bunifuCheckBox_COMPTE.Checked = false;
                }
            }
        }

        private void bunifuCheckBox_rdv_CheckedChanged(object sender, BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (THEME.id_user_modifier == "")
            {
                if (bunifuCheckBox_rdv.Checked)
                {
                    bunifuCheckBox_rdv_ajouter.Checked = true;
                    bunifuCheckBox_rdv_passer.Checked = true;
                    bunifuCheckBox_rdv_suprimer.Checked = true;
                }
                else
                {
                    bunifuCheckBox_rdv_ajouter.Checked = false;
                    bunifuCheckBox_rdv_passer.Checked = false;
                    bunifuCheckBox_rdv_suprimer.Checked = false;
                }
            }
        }

        private void bunifuCheckBox_client_CheckedChanged(object sender, BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (THEME.id_user_modifier == "")
            {
                if (bunifuCheckBox_client.Checked)
                {
                    bunifuCheckBox_client_ajouter.Checked = true;
                    bunifuCheckBox_client_modifier.Checked = true;
                    bunifuCheckBox_client_fichier.Checked = true;
                    bunifuCheckBox_client_dossier.Checked = true;
                    bunifuCheckBox_ditails_dossier_client.Checked = true;
                    bunifuCheckBox_affichier_fichier_client.Checked = true;
                }
                else
                {
                    bunifuCheckBox_client_ajouter.Checked = false;
                    bunifuCheckBox_client_modifier.Checked = false;
                    bunifuCheckBox_client_fichier.Checked = false;
                    bunifuCheckBox_client_dossier.Checked = false;
                    bunifuCheckBox_ditails_dossier_client.Checked = false;
                    bunifuCheckBox_affichier_fichier_client.Checked = false;
                }
            }
        }

        private void bunifuCheckBox_contart_CheckedChanged(object sender, BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (THEME.id_user_modifier == "")
            {
                if (bunifuCheckBox_contart.Checked)
                {
                    bunifuCheckBox_contart_ajouter.Checked = true;
                    bunifuCheckBox_contart_detail.Checked = true;
                    bunifuCheckBox_contart_paiement.Checked = true;
                    bunifuCheckBox_contart_fichier.Checked = true;
                    bunifuCheckBox_contart_signature.Checked = true;
                    bunifuCheckBox_contart_statistic.Checked = true;
                    bunifuCheckBox_ajouter_fichier_contrat.Checked = true;

                }
                else
                {
                    bunifuCheckBox_contart_ajouter.Checked = false;
                    bunifuCheckBox_contart_detail.Checked = false;
                    bunifuCheckBox_contart_paiement.Checked = false;
                    bunifuCheckBox_contart_fichier.Checked = false;
                    bunifuCheckBox_contart_signature.Checked = false;
                    bunifuCheckBox_contart_statistic.Checked = false;
                    bunifuCheckBox_ajouter_fichier_contrat.Checked = false;
                }
            }
        }

        private void bunifuCheckBox_dossier_CheckedChanged(object sender, BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (THEME.id_user_modifier == "")
            {
                if (bunifuCheckBox_dossier.Checked)
                {
                    bunifuCheckBox_dossier_ajouter.Checked = true;
                    bunifuCheckBox_dossier_modifier.Checked = true;
                    bunifuCheckBox__dossier_detail.Checked = true;
                    bunifuCheckBox__dossier_fichier.Checked = true;
                    bunifuCheckBox_dossier_contart.Checked = true;
                    bunifuCheckBox_dossier_parte.Checked = true;
                    bunifuCheckBox_ajouter_fichier_dossier.Checked = true;
                }
                else
                {
                    bunifuCheckBox_dossier_ajouter.Checked = false;
                    bunifuCheckBox_dossier_modifier.Checked = false;
                    bunifuCheckBox__dossier_detail.Checked = false;
                    bunifuCheckBox__dossier_fichier.Checked = false;
                    bunifuCheckBox_dossier_contart.Checked = false;
                    bunifuCheckBox_ajouter_fichier_dossier.Checked = false;
                    bunifuCheckBox_dossier_parte.Checked = false;
                }
            }
        }
        private void CTL_PARAMETER_AJOUTER_UTILISATUER_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible && THEME.id_user_modifier != "")
            {
                id_user_mod = THEME.id_user_modifier;
                ButtonAdd_utilisatuer.Text = "VALIDER";
                ButtonAdd_utilisatuer.Image = global::gestion_cabinet_notarial.Properties.Resources.Edit;
                var user_modifier = new utilisateur();
                func_modifier = FUNC.FindByValues(ele => ele.utilisateur == id_user_mod).ToList();
                user_modifier = user.FindByValues(ele => ele.utilisateur1 == id_user_mod).SingleOrDefault();
                bunifuTextBox_USER.Text = user_modifier.utilisateur1;
                bunifuTextBox_USER.Enabled = false;
                bunifuTextBox_PASS.Enabled = false;
                bunifuTextBox_NOM.Text = user_modifier.Nom;
                bunifuTextBox_PRENOM.Text = user_modifier.Prenom;
                foreach (Control c in panel_check_box.Controls)
                {
                    if (c is BunifuCheckBox)
                    {
                        ((BunifuCheckBox)c).Checked = false;
                        func_modifier.ForEach(ele =>
                        {
                            if (ele.fonction1 == c.Tag.ToString())
                            {
                                ((BunifuCheckBox)c).Checked = true;
                            }
                        });
                    }
                }
                THEME.id_user_modifier = "";
            }
            else
            {
                ButtonAdd_utilisatuer.Text = "AJOUTER";
                ButtonAdd_utilisatuer.Image = global::gestion_cabinet_notarial.Properties.Resources.Add;
                id_user_mod = "";
                THEME.id_user_modifier = "";
                bunifuTextBox_USER.Enabled = true;
                bunifuTextBox_PASS.Enabled = true;
            }
        }

        private void ButtonInit_Click(object sender, EventArgs e)
        {
            THEME.vider(this);
        }

        private void panel_check_box_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCheckBox_credit_CheckedChanged(object sender, BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (THEME.id_user_modifier == "")
            {
                if (bunifuCheckBox_credit.Checked)
                {
                    bunifuCheckBox_affichier_paye.Checked = true;
                    bunifuCheckBox_paye_credit.Checked = true;
                    bunifuCheckBox_ajouter_credit.Checked = true;
                    bunifuCheckBox_affichier_credits.Checked = true;
                }
                else
                {
                    bunifuCheckBox_affichier_paye.Checked = false;
                    bunifuCheckBox_paye_credit.Checked = false;
                    bunifuCheckBox_ajouter_credit.Checked = false;
                    bunifuCheckBox_affichier_credits.Checked = false;

                }
            }
        }

        private void bunifuSeparator9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCheckBox_CDG_CheckedChanged(object sender, BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (THEME.id_user_modifier == "")
            {
                if (bunifuCheckBox_CDG.Checked)
                {
                    bunifuCheckBox_AJOUTER_CDG.Checked = true;
                    bunifuCheckBox_LIST_CDG.Checked = true;
                }
                else
                {
                    bunifuCheckBox_AJOUTER_CDG.Checked = false;
                    bunifuCheckBox_LIST_CDG.Checked = false;
                }
            }
        }

        private void CTL_PARAMETER_AJOUTER_UTILISATUER_Load(object sender, EventArgs e)
        {
            
        }

        private void bunifuCheckBox_STATISTIQUE_CheckedChanged(object sender, BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (THEME.id_user_modifier == "")
            {
                if (bunifuCheckBox_STATISTIQUE.Checked)
                {
                    bunifuCheckBox_STATISTIQUE.Checked = true;
                }
                else
                {
                    bunifuCheckBox_STATISTIQUE.Checked = false;
                }
            }            
        }
    } 
}
