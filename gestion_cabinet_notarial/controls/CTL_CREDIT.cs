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
            THEME.client = (ComboBox)this.Controls["comboBox_client_credit"];
            THEME.navigat(typeof(add_client));

        }

        private void CTL_CREDIT_Load(object sender, EventArgs e)
        {
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
            var contrat_credit = BL_credit.GetAll().Where(ele =>  ele.idClient == 7).Select(r => new {t = r.contrat.typecontrat, id =r.idcontrat }).ToList();
            comboBox_contart_paye.DataSource = contrat_credit;
            comboBox_contart_paye.DisplayMember = "t";
            comboBox_contart_paye.ValueMember = "id";
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            THEME.credit = true;
            ((Button)this.Parent.Controls["add_client"].Controls["bunifuPages1"].Controls["tabPage_CLIENT"].Controls["ButtonEdit"]).Enabled = false;
            ((Button)this.Parent.Controls["add_client"].Controls["bunifuPages1"].Controls["tabPage_CLIENT"].Controls["ButtonInit"]).Enabled = false;
            ((Button)this.Parent.Controls["add_client"].Controls["bunifuPages1"].Controls["tabPage_CLIENT"].Controls["ButtonAdd"]).Enabled = false;
            THEME.T = this.GetType();           
            THEME.client = (ComboBox)this.Controls["comboBoxCLIENT_PY"];
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
