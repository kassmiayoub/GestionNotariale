using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestion_cabinet_notarial.BL;
using gestion_cabinet_notarial.context;

namespace gestion_cabinet_notarial
{
    public partial class contrat : Form
    {
        cls_bl_contrat con = new cls_bl_contrat();
        cls_bl_payement paye = new cls_bl_payement();

        string type_contrat;
        public contrat(string type_contrat)
        {
            InitializeComponent();
            this.type_contrat = type_contrat;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label12.Text = type_contrat;
            bunifuCheckBoxancfcc.Checked = false;
            bunifuCheckBoxenregistrement.Checked = false;
            bunifuCheckBoxhonoraire.Checked = false;
            bunifuTextBoxhonoraire.Enabled = true;
            bunifuTextBoxenregistrement.Enabled = true;
            bunifuTextBoxAncfcc.Enabled = true;
        }
        private void ButtonAdd_Click_1(object sender, EventArgs e)
        {
            var c = new gestion_cabinet_notarial.context.contrat();
            c.dateouverture = Convert.ToDateTime(dateTimePickerdubet.Text);
            c.Datefermeture = Convert.ToDateTime(dateTimePickerfin.Text);
            c.typecontrat = label12.Text;
            c.Timbres = double.Parse(bunifuTextBoxtmbr.Text);
            c.numdossier = THEME.numdossier;
            MessageBox.Show(THEME.prix.ToString());
            if (bunifuCheckBoxhonoraire.Checked)
            {
                c.Honoraires = (double.Parse(this.Controls["bunifuPanel1"].Controls["nemurecupdown_with_comma1"].Controls["textBox_porsontage"].Text)*THEME.prix)/100;
            }
            else
            {
                c.Honoraires =double.Parse(bunifuTextBoxhonoraire.Text);
            }
            if (bunifuCheckBoxenregistrement.Checked)
            {
                c.Enregistrement = (double.Parse(this.Controls["bunifuPanel1"].Controls["nemurecupdown_with_comma2"].Controls["textBox_porsontage"].Text) * THEME.prix) / 100;
            }
            else
            {
                c.Enregistrement = double.Parse(bunifuTextBoxenregistrement.Text);
            }
            if (bunifuCheckBoxancfcc.Checked)
            {
                c.Ancfcc = (double.Parse(this.Controls["bunifuPanel1"].Controls["nemurecupdown_with_comma3"].Controls["textBox_porsontage"].Text) * THEME.prix) / 100;
            }
            else
            {
                c.Ancfcc = double.Parse(bunifuTextBoxAncfcc.Text);
            }
            con.Add(c);
            //DataGridView dgv = (DataGridView)THEME.detail_dossier.Controls["bunifuPages1"].Controls["tabPage2"].Controls["bunifuDropdowntype_contrat"];
            //dgv.Refresh();
            //var p = new payement();
            //p.idClient = null;
            //p.idbanque = null;
            //p.Montant = 0;
            //p.Date = null;
            //p.typecharge = Timb;
            //p.type = "charge";
            //p.idcontrat = THEME.id_C;
            //if (!RD_ESPECES.Checked)
            //    p.type_Payement = RDCHEQUE.Checked ? "CHEQUE" : "VERMENT";
            //else
            //    p.type_Payement = "ESPECES";
            //paye.Add(p);
            MessageBox.Show("ajouter avec succes");
            this.Close();
        }

        private void bunifuCheckBoxhonoraire_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                nemurecupdown_with_comma1.Enabled = true;
                bunifuTextBoxhonoraire.Enabled = false;
            }
            else
            {
                nemurecupdown_with_comma1.Enabled = false;
                bunifuTextBoxhonoraire.Enabled = true;
            }                
        }
        private void bunifuCheckBoxenregistrement_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                nemurecupdown_with_comma2.Enabled = true;
                bunifuTextBoxenregistrement.Enabled = false;
            }
            else
            {
                nemurecupdown_with_comma2.Enabled = false;
                bunifuTextBoxenregistrement.Enabled = true;
            }
        }

        private void bunifuCheckBoxancfcc_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                nemurecupdown_with_comma3.Enabled = true;
                bunifuTextBoxAncfcc.Enabled = false;
            }
            else
            {
                nemurecupdown_with_comma3.Enabled = false;
                bunifuTextBoxAncfcc.Enabled = true;
            }
        }
    }
}
