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
        cls_bl_partes_S parte_S = new cls_bl_partes_S();

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
            //  MessageBox.Show(THEME.prix.ToString());
            if (bunifuCheckBoxhonoraire.Checked)
            {
                string h = this.Controls["bunifuPanel1"].Controls["nemurecupdown_with_comma1"].Controls["textBox_porsontage"].Text;
                if (h == "")
                {
                    MessageBox.Show("le champs Honoraires ne doit pas etre vide", "Error : Validations", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
                c.Honoraires = (double.Parse(h)*THEME.prix)/100;
            }
            else
            {
                if (bunifuTextBoxhonoraire.Text == "")
                {
                    MessageBox.Show("le champs Honoraires ne doit pas etre vide", "Error : Validations", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
                c.Honoraires =double.Parse(bunifuTextBoxhonoraire.Text);
            }
            if (bunifuCheckBoxenregistrement.Checked)
            {
                string h = this.Controls["bunifuPanel1"].Controls["nemurecupdown_with_comma2"].Controls["textBox_porsontage"].Text;
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
                string h = this.Controls["bunifuPanel1"].Controls["nemurecupdown_with_comma3"].Controls["textBox_porsontage"].Text;
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
            con.Add(c);
            int idcontrat = con.FindByValues(ele => ele.typecontrat == label12.Text && ele.numdossier == THEME.numdossier).First().Idcontrat;           
            List<Signature> list = new List<Signature>();
            var partes =  new cls_bl_partes().GetAll().Where(x => x.numdossier == THEME.numdossier).Select(x => new {x.Idpartes}).ToList();
            partes.ForEach(x => {
                var s = new gestion_cabinet_notarial.context.Signature();
                s.idpatres = x.Idpartes;
                s.DateSignatur = null;
                s.idcontrat = idcontrat;
                list.Add(s);
                });
            parte_S.AddRange(list);
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
            MessageBox.Show("la contrat ajouter avec succes");
          //  THEME.operation($"AJOUER UN CONTRAT POUR DOSSIER NUMERENT {THEME.numdossier} ET LE TYPE EST {label12.Text}");

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
    }
}
