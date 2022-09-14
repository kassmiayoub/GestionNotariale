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
    public partial class nouveau_credit : UserControl
    {
        cls_bl_contrat con = new cls_bl_contrat();
        cls_bl_credit BL_credit = new cls_bl_credit();
        cls_bl_partes partee = new cls_bl_partes();
        CSL_BL_Client cls = new CSL_BL_Client();
        cls_bl_dossier cls_Bl_Dossier = new cls_bl_dossier();

        public nouveau_credit()
        {
            InitializeComponent();
        }
        private void ButtonSerch_client_Click(object sender, EventArgs e)
        {
            ((Button)this.Parent.Controls["add_client"].Controls["bunifuPages1"].Controls["tabPage_CLIENT"].Controls["ButtonEdit"]).Enabled = false;
            ((Button)this.Parent.Controls["add_client"].Controls["bunifuPages1"].Controls["tabPage_CLIENT"].Controls["ButtonAdd"]).Enabled = false;
            THEME.T = this.GetType();
            THEME.navigat(typeof(add_client));
            THEME.client_or_dossier = (ComboBox)this.Controls["comboBox_client_credit"];
        }
        private void comboBox_contrat_credit_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idc = int.Parse(comboBox_contrat_credit.SelectedValue.ToString());
            double ListDataSource = new cls_bl_payement().GetAll().Where(x => x.idcontrat == idc).Sum(ele => ele.Montant).Value;
            var cont = con.FindById(idc);
            double Ancfcc = (double)cont.Ancfcc;
            double Enregistrement = (double)cont.Enregistrement;
            double Honoraires = (double)cont.Honoraires;
            double Timbres = (double)cont.Timbres;
            bunifuTextBox_montant_credit.Text = ((Ancfcc + Enregistrement + Honoraires + Timbres) - ListDataSource).ToString();
        }
        private void button_add_credit_Click(object sender, EventArgs e)
        {
            var credit = new credit();
            credit.idClient = (int)comboBox_client_credit.SelectedValue;
            credit.idcontrat = (int)comboBox_contrat_credit.SelectedValue;
            credit.montant = double.Parse(bunifuTextBox_montant_credit.Text);
            BL_credit.Add(credit);
            MessageBox.Show("ajouter credit avec succes");
            THEME.operation($" ajouter nouvaeu credit pour contrat id {comboBox_contrat_credit.SelectedValue.ToString()}");
        }
        private void nouveau_credit_Load(object sender, EventArgs e)
        {
            bunifuTextBox_montant_credit.Enabled = false;
            var ListDataSource = new List<clien>();
            ListDataSource = cls.GetAll().Select(ele => new clien()
            {
                IDCIENT = ele.idClient,
                nomcomplet = ele.Nom + " " + ele.Prenom
            }).ToList();
            comboBox_client_credit.DisplayMember = "NOMCOMPLET";
            comboBox_client_credit.ValueMember = "IDCIENT";
            comboBox_client_credit.DataSource = ListDataSource;
            var dossier = partee.GetAll().Where(r => r.idClient == int.Parse(comboBox_client_credit.SelectedValue.ToString()) && r.dossier.Datefermeture != null).Select(ele => new { Num = ele.dossier.Numdossier}).ToList();           
            comboBox_dossier_credit.DisplayMember = "Num";
            comboBox_dossier_credit.ValueMember = "Num";
            comboBox_dossier_credit.DataSource = dossier;
            var dossier_filtrage = con.GetAll().Where(ele => ele.dossier.Numdossier == comboBox_dossier_credit.SelectedValue.ToString()).Select(el => new {t = el.typecontrat,id = el.Idcontrat}).ToList();
            dossier_filtrage = dossier_filtrage.Where(r => BL_credit.Any(c => c.idcontrat != r.id)).ToList();
            comboBox_contrat_credit.DisplayMember = "t";
            comboBox_contrat_credit.ValueMember = "id";
            comboBox_contrat_credit.DataSource = dossier_filtrage;
        }
        private void comboBox_dossier_credit_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dossier_filtrage = con.GetAll().Where(ele => ele.dossier.Numdossier == comboBox_dossier_credit.SelectedValue.ToString()).Select(el => new { t = el.typecontrat, id = el.Idcontrat }).ToList();
            dossier_filtrage = dossier_filtrage.Where(r => BL_credit.Any(c => c.idcontrat != r.id)).ToList();
            comboBox_contrat_credit.DisplayMember = "t";
            comboBox_contrat_credit.ValueMember = "id";
            comboBox_contrat_credit.DataSource = dossier_filtrage;
            if (dossier_filtrage.Count() == 0)
            {
                comboBox_contrat_credit.Text = "";
                bunifuTextBox_montant_credit.Text = "";
            }           
        }
        private void comboBox_client_credit_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dossier = partee.GetAll().Where(r => r.idClient == int.Parse(comboBox_client_credit.SelectedValue.ToString())).Select(ele => new { Num = ele.dossier.Numdossier }).ToList();           
            comboBox_dossier_credit.DisplayMember = "Num";
            comboBox_dossier_credit.ValueMember = "Num";
            comboBox_dossier_credit.DataSource = dossier;
            int a = int.Parse(comboBox_client_credit.SelectedValue.ToString());
            bunifuDataGridViewlist_credit.DataSource = BL_credit.FindByValues(el => el.idClient == a).Select(s => new { s.idClient, NomCoplete = s.client.Nom +" "+ s.client.Prenom, s.contrat.numdossier, s.contrat.typecontrat,s.montant, s.date }).ToList();
        }
    }

}
