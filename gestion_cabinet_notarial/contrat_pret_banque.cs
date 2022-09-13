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
            label12.Text = type_contrat;
            bunifuCheckBoxancfcc.Checked = false;
            bunifuCheckBoxenregistrement.Checked = false;
            bunifuCheckBoxhonoraire.Checked = false;
            bunifuTextBoxhonoraire.Enabled = true;
            bunifuTextBoxenregistrement.Enabled = true;
            bunifuTextBoxAncfcc.Enabled = true;
            var ListDataSource = cls.GetAll().Select(ele => new clien()
            {
                IDCIENT = ele.idClient,
                nomcomplet = ele.Nom + " " + ele.Prenom
            }).ToList();
            bunifuDropdown_client.DisplayMember = "NOMCOMPLET";
            bunifuDropdown_client.ValueMember = "IDCIENT";
            bunifuDropdown_client.DataSource = ListDataSource;
            var ListDataSource1 = new cls_bl_banque().GetAll().Where(x => x.Idbanque != 3).ToList();
            bunifuDropdown_banque.DataSource = ListDataSource1;
            bunifuDropdown_banque.DisplayMember = "Libbele";
            bunifuDropdown_banque.ValueMember = "Idbanque";
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var c = new gestion_cabinet_notarial.context.contrat();
            c.dateouverture = Convert.ToDateTime(dateTimePickerdubet.Text);
            c.Datefermeture = Convert.ToDateTime(dateTimePickerfin.Text);
            c.typecontrat = label12.Text;
            c.Timbres = double.Parse(bunifuTextBoxtmbr.Text);
            c.numdossier = THEME.numdossier;
            if (bunifuCheckBoxhonoraire.Checked)
            {
                c.Honoraires = (double.Parse(this.Controls["bunifuPanel1"].Controls["nemurecupdown_with_comma_h"].Controls["textBox_porsontage"].Text) * THEME.prix) / 100;
            }
            else
            {
                c.Honoraires = double.Parse(bunifuTextBoxhonoraire.Text);
            }
            if (bunifuCheckBoxenregistrement.Checked)
            {
                c.Enregistrement = (double.Parse(this.Controls["bunifuPanel1"].Controls["nemurecupdown_with_comma_e"].Controls["textBox_porsontage"].Text) * THEME.prix) / 100;
            }
            else
            {
                c.Enregistrement = double.Parse(bunifuTextBoxenregistrement.Text);
            }
            if (bunifuCheckBoxancfcc.Checked)
            {
                c.Ancfcc = (double.Parse(this.Controls["bunifuPanel1"].Controls["nemurecupdown_with_comma_a"].Controls["textBox_porsontage"].Text) * THEME.prix) / 100;
            }
            else
            {
                c.Ancfcc = double.Parse(bunifuTextBoxAncfcc.Text);
            }
            con.Add(c);
            int idcontrat = con.FindByValues(ele => ele.typecontrat == label12.Text && ele.numdossier == THEME.numdossier).First().Idcontrat;
            var pretBanque =new  Banque_pret();
            pretBanque.idClient = int.Parse(bunifuDropdown_client.SelectedValue.ToString());
            pretBanque.idbanque = int.Parse(bunifuDropdown_banque.SelectedValue.ToString());
            pretBanque.DESCRIPTION = richTextBox_description.Text;
            pretBanque.INTIERET = (double.Parse(this.Controls["bunifuPanel1"].Controls["nemurecupdown_with_comma_intieret"].Controls["textBox_porsontage"].Text));
            pretBanque.PAYE_PAR_MOIS = (double.Parse(this.Controls["bunifuPanel1"].Controls["nemurecupdown_with_comma_paye_par_mois"].Controls["textBox_porsontage"].Text));
            pretBanque.Montant =double.Parse(bunifuTextBox_montant.Text);
            int Days = (Convert.ToDateTime(dateTimePickerfin.Text) - Convert.ToDateTime(dateTimePickerdubet.Text)).Days;
            pretBanque.DERU = Days;
            pretBanque.idcontrat = idcontrat;
            pret.Add(pretBanque);
            THEME.operation($"AJOUER UN CONTRAT POUR DOSSIER NUMERENT {THEME.numdossier} ET LE TYPE EST {label12.Text}");
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

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {
         
        }
    }
}
