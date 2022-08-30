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
    public partial class CTL_CREDIT : UserControl
    {
        cls_bl_payement paye = new cls_bl_payement();
        cls_bl_credit BL_credit = new cls_bl_credit();
        cls_bl_contrat con = new cls_bl_contrat();
        cls_bl_partes partee = new cls_bl_partes();
        CSL_BL_Client cls = new CSL_BL_Client();
        cls_bl_dossier cls_Bl_Dossier = new cls_bl_dossier();
        public CTL_CREDIT()
        {
            InitializeComponent();
        }
        private void ButtonSerch_client_Click(object sender, EventArgs e)
        {
            ((Button)this.Parent.Controls["add_client"].Controls["bunifuPages1"].Controls["tabPage_CLIENT"].Controls["ButtonEdit"]).Enabled = false;
            ((Button)this.Parent.Controls["add_client"].Controls["bunifuPages1"].Controls["tabPage_CLIENT"].Controls["ButtonInit"]).Enabled = false;
            ((Button)this.Parent.Controls["add_client"].Controls["bunifuPages1"].Controls["tabPage_CLIENT"].Controls["ButtonAdd"]).Enabled = false;
            THEME.T = this.GetType();
            THEME.client_or_dossier = (ComboBox)this.Controls["comboBox_client_credit"];
            THEME.navigat(typeof(add_client));

        }

        private void CTL_CREDIT_Load(object sender, EventArgs e)
        {
            var ListDataSource1 = new cls_bl_banque().GetAll().Where(x => x.Idbanque != 3).ToList();
            comboBox_banque_PY.DataSource = ListDataSource1;
            comboBox_banque_PY.DisplayMember = "Libbele";
            comboBox_banque_PY.ValueMember = "Idbanque";
            var ListDataSource = new List<clien>();
            ListDataSource = cls.GetAll().Select(ele => new clien()
            {
                IDCIENT = ele.idClient,
                nomcomplet = ele.Nom + " " + ele.Prenom
            }).ToList();
            comboBox_client_credit.DataSource=ListDataSource;
            comboBox_client_credit.DisplayMember = "NOMCOMPLET";
            comboBox_client_credit.ValueMember = "IDCIENT";
            ListDataSource = ListDataSource.Where(r => BL_credit.Any(c => c.idClient == r.IDCIENT)).ToList() as List<clien>;
            comboBoxCLIENT_PY.DataSource=ListDataSource;
            comboBoxCLIENT_PY.DisplayMember = "NOMCOMPLET";
            comboBoxCLIENT_PY.ValueMember = "IDCIENT";
            var contrat_credit = BL_credit.GetAll().Where(ele => ele.idClient == (int)comboBoxCLIENT_PY.SelectedValue).Select(r => new {t = r.contrat.typecontrat, id =r.idcontrat }).ToList();
            comboBox_contart_paye.DataSource = contrat_credit;
            comboBox_contart_paye.DisplayMember = "t";
            comboBox_contart_paye.ValueMember = "id";
            var dossier = cls_Bl_Dossier.GetAll().Select(ele => new { Num = ele.Numdossier }).ToList();
            comboBox_dossier_credit.DataSource = dossier;
            comboBox_dossier_credit.DisplayMember = "Num";
            comboBox_dossier_credit.ValueMember = "Num";
            var dossier_filtrage = con.GetAll().Where(ele => ele.dossier.Numdossier == comboBox_dossier_credit.SelectedValue.ToString()).Select(el => new { t = el.typecontrat, id = el.Idcontrat }).ToList();
            comboBox_contrat_credit.DataSource = dossier_filtrage;
            comboBox_contrat_credit.DisplayMember = "t";
            comboBox_contrat_credit.ValueMember = "id";

        }
        private void button2_Click(object sender, EventArgs e)
        {
            THEME.credit = true;
            ((Button)this.Parent.Controls["add_client"].Controls["bunifuPages1"].Controls["tabPage_CLIENT"].Controls["ButtonEdit"]).Enabled = false;
            ((Button)this.Parent.Controls["add_client"].Controls["bunifuPages1"].Controls["tabPage_CLIENT"].Controls["ButtonInit"]).Enabled = false;
            ((Button)this.Parent.Controls["add_client"].Controls["bunifuPages1"].Controls["tabPage_CLIENT"].Controls["ButtonAdd"]).Enabled = false;
            THEME.T = this.GetType();           
            THEME.client_or_dossier = (ComboBox)this.Controls["comboBoxCLIENT_PY"];
            THEME.navigat(typeof(add_client));         
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var p = new payement();
            p.idClient = int.Parse(comboBoxCLIENT_PY.SelectedValue.ToString());
            p.idbanque = RD_ESPECES.Checked ? 3 : int.Parse(comboBox_banque_PY.SelectedValue.ToString());
            p.Montant = double.Parse(bunifuTextBox_MONTANT.Text);
            p.Date = bunifuDatePicker_PAYMENT.Value;            
            p.type = "credit";
            p.idcontrat = comboBox_contrat_credit.SelectedIndex;
            if (!RD_ESPECES.Checked)
                p.type_Payement = RDCHEQUE.Checked ? "CHEQUE" : "VERMENT";
            else
                p.type_Payement = "ESPECES";
            paye.Add(p);
        }

        private void comboBoxCLIENT_PY_SelectedIndexChanged(object sender, EventArgs e)
        {
            var contrat_credit = BL_credit.GetAll().Where(ele => ele.idClient == (int)comboBoxCLIENT_PY.SelectedValue).Select(r => new { t = r.contrat.typecontrat, id = r.idcontrat }).ToList();
            comboBox_contart_paye.DataSource = contrat_credit;
            comboBox_contart_paye.DisplayMember = "t";
            comboBox_contart_paye.ValueMember = "id";
        }

        private void comboBox_contart_paye_SelectedIndexChanged(object sender, EventArgs e)
        {
            idcontrat.Text = comboBox_contart_paye.SelectedValue.ToString();
            var montant_credit = BL_credit.GetAll().Where(ele => ele.idClient == (int)comboBoxCLIENT_PY.SelectedValue && ele.idcontrat == int.Parse(idcontrat.Text)).First();
            bunifuTextBox_MONTANT.Text = montant_credit.montant.ToString();
        }

        private void buttonserche_dossier_Click(object sender, EventArgs e)
        {
            ((Button)this.Parent.Controls["ADD_DOSSIER"].Controls["ButtonEdit_dossier"]).Enabled = false;
            ((Button)this.Parent.Controls["ADD_DOSSIER"].Controls["button_detail_dossier"]).Enabled = false;
            ((Button)this.Parent.Controls["ADD_DOSSIER"].Controls["ButtonAdd_dossier"]).Enabled = false;
            THEME.T = this.GetType();
            THEME.navigat(typeof(ADD_DOSSIER));
            THEME.client_or_dossier = (ComboBox)this.Controls["comboBox_dossier_credit"];           
        }
        private void comboBox_dossier_credit_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dossier_filtrage = con.GetAll().Where(ele => ele.dossier.Numdossier == comboBox_dossier_credit.SelectedValue.ToString()).Select(el => new {t= el.typecontrat,id=el.Idcontrat}).ToList();
            comboBox_contrat_credit.DataSource = dossier_filtrage;
            comboBox_contrat_credit.DisplayMember = "t";
            comboBox_contrat_credit.ValueMember = "id";
            if(dossier_filtrage.Count == 0)
            {
                comboBox_contrat_credit.Text = "";
                bunifuTextBox_montant_credit.Text = "";
                idc.Text = "";
            }            
        }
        private void button_add_credit_Click(object sender, EventArgs e)
        {
            var credit = new credit();
            credit.idClient = (int)comboBox_client_credit.SelectedValue;
            credit.idcontrat = (int)comboBox_contrat_credit.SelectedValue;
            credit.montant = double.Parse(bunifuTextBox_montant_credit.Text);
            BL_credit.Add(credit);
        }
        private void comboBox_contrat_credit_SelectedIndexChanged(object sender, EventArgs e)
        { 
            idc.Text = comboBox_contrat_credit.SelectedValue.ToString();
            double ListDataSource = new cls_bl_payement().GetAll().Where(x => x.idcontrat == int.Parse(idc.Text)).Sum(ele => ele.Montant).Value;
            var cont = con.FindById(int.Parse(idc.Text));
            double Ancfcc = (double)cont.Ancfcc;
            double Enregistrement = (double)cont.Enregistrement;
            double Honoraires = (double)cont.Honoraires;
            double Timbres = (double)cont.Timbres;
            bunifuTextBox_montant_credit.Text = ((Ancfcc+ Enregistrement+ Honoraires+ Timbres)- ListDataSource).ToString();
        }
    }
    public class clien
    {
        [DisplayName("IDCIENT")]
        public int IDCIENT { get; set; }
        [DisplayName("NOMCOMPLET")]
        public string nomcomplet { get; set; }
    }
    public class payemente
    {
        [DisplayName("CLIENT")]
        public string CLIENT { get; set; }
        [DisplayName("TYPE PAYEMENT")]
        public string TYPEPAYEMENT { get; set; }
        [DisplayName("MONTANT")]
        public string MONTANT { get; set; }
        [DisplayName("BANQUE")]
        public string BANQUE { get; set; }
        [DisplayName("TYPE CHARGE")]
        public string TYPECHARGE { get; set; }
        [DisplayName("DATE")]
        public string DATE { get; set; }
    }
}
