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
        cls_bl_contrat contrat = new cls_bl_contrat();
        cls_bl_partes partee = new cls_bl_partes();
        CSL_BL_Client cls = new CSL_BL_Client();
        cls_bl_dossier cls_Bl_Dossier = new cls_bl_dossier();
        cls_bl_banque banque = new cls_bl_banque();
        public CTL_CREDIT()
        {
            InitializeComponent();
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
            ListDataSource = ListDataSource.Where(r => BL_credit.Any(c => c.idClient == r.IDCIENT)).ToList() as List<clien>;            
            comboBoxCLIENT_PY.DisplayMember = "NOMCOMPLET";
            comboBoxCLIENT_PY.ValueMember = "IDCIENT";
            comboBoxCLIENT_PY.DataSource = ListDataSource;
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            ListDataSource.ForEach(x => autoCompleteCollection.Add(x.nomcomplet));
            comboBox_banque_PY.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBox_banque_PY.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_banque_PY.AutoCompleteCustomSource = autoCompleteCollection;
            if (comboBoxCLIENT_PY.SelectedValue == null)
            {
                return;
            }
            var contrat_credit = BL_credit.GetAll().Where(ele => ele.idClient == (int)comboBoxCLIENT_PY.SelectedValue).Select(r => new {t = r.contrat.typecontrat, id =r.idcontrat }).ToList();            
            comboBox_contart_paye.DisplayMember = "t";
            comboBox_contart_paye.ValueMember = "id";
            comboBox_contart_paye.DataSource = contrat_credit;
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (bunifuTextBox_MONTANT.Text == "")
                return;
            var p = new payement();
            p.idClient = int.Parse(comboBoxCLIENT_PY.SelectedValue.ToString());
            p.idbanque = RD_ESPECES.Checked ? 3 : int.Parse(comboBox_banque_PY.SelectedValue.ToString());
            p.Montant = double.Parse(bunifuTextBox_MONTANT.Text);
            p.Date = bunifuDatePicker_PAYMENT.Value;            
            p.type = "credit";
            p.idcontrat = int.Parse(comboBox_contart_paye.SelectedValue.ToString());
            if (!RD_ESPECES.Checked)
                p.type_Payement = RDCHEQUE.Checked ? "CHEQUE" : "VERMENT";
            else
                p.type_Payement = "ESPECES";
            paye.Add(p);
            int a = p.idPayement;
           // MessageBox.Show("id payement : "+a.ToString());
            MessageBox.Show("payement avec succes");
            THEME.operation($" payement credit pour contrat id {comboBox_contart_paye.SelectedValue.ToString()}");
        }
        private void comboBoxCLIENT_PY_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCLIENT_PY.SelectedValue == null)
            {
                return;
            }
            var contrat_credit = BL_credit.GetAll().Where(ele => ele.idClient == (int)comboBoxCLIENT_PY.SelectedValue).Select(r => new { t = r.contrat.typecontrat, id = r.idcontrat }).ToList();            
            comboBox_contart_paye.DisplayMember = "t";
            comboBox_contart_paye.ValueMember = "id";
            comboBox_contart_paye.DataSource = contrat_credit;
            var payements = paye.FindByValues(ele => ele.idClient == (int)comboBoxCLIENT_PY.SelectedValue && ele.type == "credit").Select(s => new { s.idPayement, NomCoplete = s.client.Nom + " " + s.client.Prenom, s.contrat.numdossier, s.contrat.typecontrat, s.Montant, s.Date }).ToList();
            bunifuDataGridViewlist_payemant_credit.DataSource = payements;
            THEME.add_btn_to_datagrid(bunifuDataGridViewlist_payemant_credit, "RECU", "RECU", bunifuDataGridViewlist_payemant_credit.ColumnCount);
        }
        private void comboBox_contart_paye_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = int.Parse(comboBox_contart_paye.SelectedValue.ToString());
            var montant_credit = BL_credit.FindByValues(v => v.idcontrat == a).First();
            double montant_credit_paye = paye.GetAll().Where(ele => ele.contrat.Idcontrat == a && ele.type== "credit").Sum(ele => ele.Montant).Value;
            bunifuTextBox_MONTANT.Text = (montant_credit.montant-montant_credit_paye).ToString();
        }
        private void RD_ESPECES_CheckedChanged(object sender, EventArgs e)
        {
            if (RD_ESPECES.Checked)
                comboBox_banque_PY.Enabled = false;
            else
                comboBox_banque_PY.Enabled = true; 
        }
        private void bunifuTextBox_MONTANT_KeyPress(object sender, KeyPressEventArgs e)
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
        private void bunifuDataGridViewlist_payemant_credit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                int idp = int.Parse(dgv.Rows[e.RowIndex].Cells["idPayement"].Value.ToString());
                var p = paye.FindByValues(ele => ele.idPayement == idp).FirstOrDefault();
                //print.client = dgv.Rows[e.RowIndex].Cells["CLIENT"].Value.ToString();
                print.typepaye = p.type_Payement;
                int IDCLIENT = int.Parse(p.idClient.ToString());
                print.idclient = cls.FindByValues(ele => ele.idClient == p.idClient).First().ClientNormale == null ? cls.FindByValues(ele => ele.idClient == p.idClient).First().ClientProfessionnel.ICE : cls.FindByValues(ele => ele.idClient == p.idClient).First().ClientNormale.CIN;
                print.ice_cin = cls.FindByValues(ele => ele.idClient == p.idClient).First().ClientNormale == null ? "ICE " : " CIN";
                print.montant = p.Montant + " DH";
                //print.banque = .;
                print.typecharge = "CREDIT";
                print.date = Convert.ToDateTime(dgv.Rows[e.RowIndex].Cells["Date"].Value).ToString("yyyy-MM-dd");
                print.client = dgv.Rows[e.RowIndex].Cells["NomCoplete"].Value.ToString();
                print.typecontart = print.client = dgv.Rows[e.RowIndex].Cells["typecontrat"].Value.ToString();
                string d = dgv.Rows[e.RowIndex].Cells["numdossier"].Value.ToString();
                print.ndossier = d;
                print.banque = banque.FindByValues(ele => ele.Idbanque == p.idbanque).FirstOrDefault().Libbele;
                print.foncier = cls_Bl_Dossier.FindByValues(ele => ele.Numdossier == d).First().Titrefoncier;
                string[] n = (p.Montant).ToString().Split('.');
                if (n.Length == 1)
                {
                    int a = Convert.ToInt32(n[0]);
                    print.montantp = "elle a payé  " + DATABASE.NumberToWords(a);
                }
                else
                {
                    int a = Convert.ToInt32(n[0]);
                    int b = Convert.ToInt32(n[1]);
                    print.montantp = "elle a payé  " + DATABASE.NumberToWords(a) + " virgule " + DATABASE.NumberToWords(b);
                }
                print p1 = new print();
                p1.Show();
            }
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