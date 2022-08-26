using Bunifu.UI.WinForms.BunifuButton;
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
    public partial class DETAIL_CONTRAT : UserControl
    {
        int parte;
        cls_bl_partes_S Signature = new cls_bl_partes_S();
        cls_bl_payement paye = new cls_bl_payement();
        public DETAIL_CONTRAT()
        {
            InitializeComponent();
        }

        private void PARTES_OF_CONTRAT_Click(object sender, EventArgs e)
        {           
            bunifuPages1.SetPage(partes);
            int idc = THEME.id_C;
            bunifuDataGridViewpartes_S.DataSource = Signature.FindByValues(ele => ele.idcontrat == idc).Select(ele => new partesS()
            {
                ID_PARTE = (int)ele.idpatres,
                NOM = ele.parte.client.Nom,
                PRENOM = ele.parte.client.Prenom,
                TYPEPARTE = ele.parte.Typeclient,
                DATE_S = ele.DateSignatur.ToString() != "" ? ele.DateSignatur.ToString() : "NON SINIGTURE",
            }).ToList();
            THEME.add_checkbox_to_datagrid(bunifuDataGridViewpartes_S, "Signatur", 5);
            foreach (DataGridViewRow r in bunifuDataGridViewpartes_S.Rows)
            {
                if (r.Cells[4].Value.ToString() == "NON SINIGTURE")
                {
                    r.Cells["Signatur"].Value = false;
                }
                else
                {
                    r.Cells["Signatur"].Value = true;
                }
            }
        }

        private void bunifuDataGridViewpartes_S_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                try
                {
                    parte = int.Parse(dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
                catch
                {
                    parte = int.Parse(dgv.Rows[e.RowIndex].Cells[1].Value.ToString());
                }
                bunifuDatePicker_date_s.Enabled = true;
                buttonadd_date_s.Enabled = true;
            }
        }

        private void buttonadd_date_s_Click(object sender, EventArgs e)
        {
            var p = new Signature();
            p = Signature.FindByValues(ele => ele.idpatres == parte && ele.idcontrat == THEME.id_C).First();
            p.DateSignatur = Convert.ToDateTime(bunifuDatePicker_date_s.Text);
            Signature.SaveChanges();
            bunifuDatePicker_date_s.Enabled = false;
            buttonadd_date_s.Enabled=false;
        }

        private void PAYEMENTCLIENT_CONTRAT_Click(object sender, EventArgs e)
        {           
           bunifuPages1.SetPage(payeclient);
            var ListDataSource = new cls_bl_payement().GetAll().Where(x => x.idcontrat == THEME.id_C);
            bunifuDataGridView_payement.DataSource = ListDataSource;
            THEME.add_btn_to_datagrid(bunifuDataGridView_payement, "RECU", "RECU", bunifuDataGridView_payement.ColumnCount);
        }
        private void FICHIERJOINT_CONTRAT_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(fichierjoint);
        }

        private void STATISTIC_CONTRAT_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(statistic);
        }

        private void RDCHEQUE_CheckedChanged(object sender, EventArgs e)
        {
            if(RDCHEQUE.Checked)
                comboBox_banque_PY.Enabled = true;
        }

        private void RDVERMENT_CheckedChanged(object sender, EventArgs e)
        {
            if (RDVERMENT.Checked)
                comboBox_banque_PY.Enabled = true;
        }

        private void RD_ESPECES_CheckedChanged(object sender, EventArgs e)
        {
            if (RD_ESPECES.Checked)
                comboBox_banque_PY.Enabled = false;
        }

        private void ButtonAdd_PAYEMENT_Click(object sender, EventArgs e)
        {
            var p = new  payement();
            p.idClient = int.Parse(comboBoxCLIENT_PY.SelectedValue.ToString());
            p.idbanque = RD_ESPECES.Checked ? 3 : int.Parse(comboBox_banque_PY.SelectedValue.ToString());
            p.Montant =double.Parse(bunifuTextBox_MONTANT.Text);
            p.Date = bunifuDatePicker_PAYMENT.Value;
            p.type = comboBox_TYPE_CHARGE.Text;
            p.idcontrat = THEME.id_C;
            if(!RD_ESPECES.Checked)
                p.type_Payement = RDCHEQUE.Checked ? "CHEQUE" : "VERMENT";
            else
                p.type_Payement = "ESPECES";
            paye.Add(p);
        }
        private void payeclient_Click(object sender, EventArgs e)
        {

        }
        private void DETAIL_CONTRAT_Load(object sender, EventArgs e)
        {

        }
    }
    public class partesS
    {
        [DisplayName("ID PARTE")]
        public int ID_PARTE { get; set; }
        [DisplayName("NOM")]
        public string NOM { get; set; }
        [DisplayName("PRENOM")]
        public string PRENOM { get; set; }
        [DisplayName("TYPE PARTE")]
        public string TYPEPARTE { get; set; }
        [DisplayName("DATE SINIGTURE")]
        public string DATE_S { get; set; }
    }
}
