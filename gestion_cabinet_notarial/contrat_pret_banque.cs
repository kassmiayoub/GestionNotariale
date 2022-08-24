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
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            //info_contrat.x = 1;
            //info_contrat.dated = dateTimePickerdubet.Text;
            //info_contrat.datef = dateTimePickerfin.Text;
            //info_contrat.type_contrat = label12.Text;
            //info_contrat.useer = "ayoub kassmi";
            //DataGridView dgv = (DataGridView)THEME.detail_dossier_add_contrat.Controls["dataGridViewlist_contrat"];
            //dgv.Rows.Add(info_contrat.type_contrat, info_contrat.dated, info_contrat.datef, info_contrat.useer);

            //this.Close();
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
