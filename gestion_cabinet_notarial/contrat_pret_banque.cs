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

namespace gestion_cabinet_notarial
{
    public partial class contrat_pret_banque : Form
    {
        string type_contrat;
        CSL_BL_Client cls = new CSL_BL_Client();
        cls_bl_contrat con = new cls_bl_contrat();
        CSL_BL_pret_banque pret = new CSL_BL_pret_banque();
        bl_creditpersonne creditpersonne = new bl_creditpersonne();
        cls_bl_dossier cls_Bl_Dossier = new cls_bl_dossier();
        cls_bl_partes_S parte_S = new cls_bl_partes_S();
        cls_bl_partes partee = new cls_bl_partes();


        public contrat_pret_banque(string type_contrat)
        {
            InitializeComponent();
            this.type_contrat = type_contrat;
        }
        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('.') || e.KeyChar.Equals(','))
            {
                e.KeyChar = ((System.Globalization.CultureInfo)System.Globalization.CultureInfo.CurrentCulture).NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            if(type_contrat == "pret banque")
            {
                bunifuPanel2.Visible = true;
                bunifuDropdown_banque.Visible = true;
                almodan.Visible = true;
                almodin.Visible = true;
            }
            else
            {
                bunifuPanel2.Visible = false;
                bunifuDropdown_banque.Visible = false;
                almodan.Visible = false;
                almodin.Visible = false;
            }
            label12.Text = type_contrat;
            bunifuCheckBoxancfcc.Checked = false;
            bunifuCheckBoxenregistrement.Checked = false;
            bunifuCheckBoxhonoraire.Checked = false;
            bunifuTextBoxhonoraire.Enabled = true;
            bunifuTextBoxenregistrement.Enabled = true;
            bunifuTextBoxAncfcc.Enabled = true;
            var ListDataSource = partee.FindByValues(ele => ele.numdossier == THEME.numdossier).Select(ele => new clien()
            {
                IDCIENT = ele.client.idClient,
                nomcomplet = ele.client.Nom + " " + ele.client.Prenom
            }).ToList();
            bunifuDropdown_client.DisplayMember = "NOMCOMPLET";
            bunifuDropdown_client.ValueMember = "IDCIENT";
            bunifuDropdown_client.DataSource = ListDataSource;
            if (THEME.prix == 0)
            {
                bunifuCheckBoxhonoraire.Enabled = false;
                bunifuCheckBoxancfcc.Enabled = false;
                bunifuCheckBoxenregistrement.Enabled = false;
            }
            else
            {
                bunifuCheckBoxhonoraire.Enabled = true;
                bunifuCheckBoxancfcc.Enabled = true;
                bunifuCheckBoxenregistrement.Enabled = true;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (bunifuTextBoxtmbr.Text == "")
            {
                MessageBox.Show("le champs Timbres ne doit pas etre vide", "Error : Validations", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            var c = new gestion_cabinet_notarial.context.contrat();
            c.dateouverture = Convert.ToDateTime(dateTimePickerdubet.Text);
            c.Datefermeture = Convert.ToDateTime(dateTimePickerfin.Text);
            c.typecontrat = label12.Text;
            c.Timbres = double.Parse(bunifuTextBoxtmbr.Text);
            c.numdossier = THEME.numdossier;
            c.utilisateur = THEME.id_user;
            if (bunifuCheckBoxhonoraire.Checked)
            {
                string h = this.Controls["bunifuPanel1"].Controls["nemurecupdown_with_comma_h"].Controls["textBox_porsontage"].Text;
                if (h == "")
                {
                    MessageBox.Show("le champs Honoraires ne doit pas etre vide", "Error : Validations", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
                c.Honoraires = (double.Parse(h) * THEME.prix) / 100;
            }
            else
            {
                if (bunifuTextBoxhonoraire.Text == "")
                {
                    MessageBox.Show("le champs Honoraires ne doit pas etre vide", "Error : Validations", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
                c.Honoraires = double.Parse(bunifuTextBoxhonoraire.Text);
            }
            if (bunifuCheckBoxenregistrement.Checked)
            {
                string h = this.Controls["bunifuPanel1"].Controls["nemurecupdown_with_comma_e"].Controls["textBox_porsontage"].Text;
                if (h == "")
                {
                    MessageBox.Show("le champs Enregistrement ne doit pas etre vide", "Error : Validations", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
                c.Enregistrement = (double.Parse(h) * THEME.prix) / 100;
            }
            else
            {
                if (bunifuTextBoxenregistrement.Text == "")
                {
                    MessageBox.Show("le champs Enregistrement ne doit pas etre vide", "Error : Validations", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
                c.Enregistrement = double.Parse(bunifuTextBoxenregistrement.Text);
            }
            if (bunifuCheckBoxancfcc.Checked)
            {
                string h = this.Controls["bunifuPanel1"].Controls["nemurecupdown_with_comma_a"].Controls["textBox_porsontage"].Text;
                if (h == "")
                {
                    MessageBox.Show("le champs Ancfcc ne doit pas etre vide", "Error : Validations", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
                c.Ancfcc = (double.Parse(h) * THEME.prix) / 100;
            }
            else
            {
                if (bunifuTextBoxAncfcc.Text == "")
                {
                    MessageBox.Show("le champs Ancfcc ne doit pas etre vide", "Error : Validations", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
                c.Ancfcc = double.Parse(bunifuTextBoxAncfcc.Text);
            }
            if (bunifuTextBox_montant.Text == "")
            {
                MessageBox.Show("le champs Montant ne doit pas etre vide", "Error : Validations", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            con.Add(c);
            int idcontrat = c.Idcontrat;//con.FindByValues(ele => ele.typecontrat == label12.Text && ele.numdossier == THEME.numdossier).First().Idcontrat;
            
            if (type_contrat == "pret banque")
            {
                var pretBanque = new Banque_pret();
                pretBanque.DESCRIPTION = richTextBox_description.Text;
                pretBanque.INTIERET = (double.Parse(this.Controls["bunifuPanel1"].Controls["bunifuPanel2"].Controls["nemurecupdown_with_comma_intieret"].Controls["textBox_porsontage"].Text));
                pretBanque.PAYE_PAR_MOIS = (double.Parse(this.Controls["bunifuPanel1"].Controls["bunifuPanel2"].Controls["nemurecupdown_with_comma_paye_par_mois"].Controls["textBox_porsontage"].Text));
                pretBanque.Montant = double.Parse(bunifuTextBox_montant.Text);
                int Days = (Convert.ToDateTime(dateTimePickerfin.Text) - Convert.ToDateTime(dateTimePickerdubet.Text)).Days;
                pretBanque.DERU = Days;
                pretBanque.idcontrat = idcontrat;
                pretBanque.utilisateur = THEME.id_user;
                pret.Add(pretBanque);
            }
            else
            {
                var CP = new creditpersonne1();
                CP.descreption = richTextBox_description.Text;
                CP.montant = double.Parse(bunifuTextBox_montant.Text);
                int Days = (Convert.ToDateTime(dateTimePickerfin.Text) - Convert.ToDateTime(dateTimePickerdubet.Text)).Days;
                CP.deru = Days;
                CP.idcontrat = idcontrat;
                CP.utilisatuer = THEME.id_user;
                creditpersonne.Add(CP);
           
                List<Signature> list = new List<Signature>();
                var partes = new cls_bl_partes().GetAll().Where(x => x.numdossier == THEME.numdossier).Select(x => new { x.Idpartes }).ToList();
                partes.ForEach(x => {
                    var s = new gestion_cabinet_notarial.context.Signature();
                    s.idpatres = x.Idpartes;
                    s.DateSignatur = null;
                    s.idcontrat = idcontrat;
                    list.Add(s);
                });
                parte_S.AddRange(list);
            }
            THEME.operation($"AJOUER UN CONTRAT POUR DOSSIER NUMERENT {THEME.numdossier} ET LE TYPE EST {label12.Text}");
            MessageBox.Show("contrat ajouter avec success de type "+ label12.Text);
        }
        private void bunifuCheckBoxhonoraire_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                nemurecupdown_with_comma_h.Enabled = true;
                bunifuTextBoxhonoraire.Enabled = false;
            }
            else
            {
                nemurecupdown_with_comma_h.Enabled = false;
                bunifuTextBoxhonoraire.Enabled = true;
            }
        }
      private void bunifuCheckBoxenregistrement_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                nemurecupdown_with_comma_e.Enabled = true;
                bunifuTextBoxenregistrement.Enabled = false;
            }
            else
            {
                nemurecupdown_with_comma_e.Enabled = false;
                bunifuTextBoxenregistrement.Enabled = true;
            }
        }
        private void bunifuCheckBoxancfcc_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                nemurecupdown_with_comma_a.Enabled = true;
                bunifuTextBoxAncfcc.Enabled = false;
            }
            else
            {
                nemurecupdown_with_comma_a.Enabled = false;
                bunifuTextBoxAncfcc.Enabled = true;
            }
        }
        private void bunifuTextBoxhonoraire_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void bunifuTextBoxenregistrement_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void bunifuTextBoxAncfcc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void bunifuTextBoxtmbr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }
    }
}
