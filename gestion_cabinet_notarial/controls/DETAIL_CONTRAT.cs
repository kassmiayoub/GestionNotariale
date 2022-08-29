using Bunifu.UI.WinForms.BunifuButton;
using gestion_cabinet_notarial.BL;
using gestion_cabinet_notarial.context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        cls_bl_contrat con = new cls_bl_contrat();
        cls_bl_partes_S Signature = new cls_bl_partes_S();
        csl_bl_fichier_contart cont = new csl_bl_fichier_contart();
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
            var ListDataSource = new cls_bl_payement().GetAll().Where(x => x.idcontrat == THEME.id_C).Select(ele => new payeme()
            {
                CLIENT = $"{ele.client.Nom} {ele.client.Prenom}",
                TYPECHARGE = ele.typecharge,
                TYPEPAYEMENT = ele.type_Payement,
                DATE = ele.Date.Value.ToString(),
                MONTANT = ele.Montant.ToString(),
                BANQUE = ele.banque.Libbele
            }).ToList();
            bunifuDataGridView_payement.DataSource = ListDataSource;
            THEME.add_btn_to_datagrid(bunifuDataGridView_payement, "RECU", "RECU", bunifuDataGridView_payement.ColumnCount);
        }
        private void FICHIERJOINT_CONTRAT_Click(object sender, EventArgs e)
        {
            var files = cont.GetAll().Select(ele => new filee()
            {
                IDFILE = (int)ele.idfile,
                TITRE = ele.titre,
                DESCREPTON = ele.descreption,
                FILE = ele.path
            }).ToList();
            bunifuDataGridView_fichier_contart.DataSource = files;
            bunifuPages1.SetPage(fichierjoint);
        }
        private void STATISTIC_CONTRAT_Click(object sender, EventArgs e)
        {           
            bunifuPages1.SetPage(statistic);
            var list = new List<statis>();
            list = paye.FindByValues(ele => ele.idcontrat == THEME.id_C).GroupBy(ele => ele.typecharge).OrderBy(ele => ele.Key).Select(ele => new statis()
            {   //DEPANCES= ele.Key,
                PAYE = ele.Sum(el => el.Montant).ToString(),
            }).ToList();
            var cont = con.FindById(THEME.id_C);
            double Ancfcc = (double)cont.Ancfcc;
            double Enregistrement = (double)cont.Enregistrement;
            double Honoraires = (double)cont.Honoraires;
            double Timbres = (double)cont.Timbres;
            bunifuDataGridView_statistic.ColumnCount = 5;
            bunifuDataGridView_statistic.Columns[0].Name = "DEPANCES";
            bunifuDataGridView_statistic.Columns[1].Name = "MONTANT";
            bunifuDataGridView_statistic.Columns[2].Name = "PAYE";
            bunifuDataGridView_statistic.Columns[3].Name = "RESTE";
            bunifuDataGridView_statistic.Columns[4].Name = "PORCENTAGE";
            string[] row = new string[] { "", "", "0", "", "" };
            bunifuDataGridView_statistic.Rows.Add(row);
            bunifuDataGridView_statistic.Rows.Add(row);
            bunifuDataGridView_statistic.Rows.Add(row);
            bunifuDataGridView_statistic.Rows.Add(row);
            int i = 0;
            foreach (var item in list)
            {
                bunifuDataGridView_statistic.Rows[i].Cells[2].Value = item.PAYE;
                i++;  
            }
                double montant_paye_Ancfcc = double.Parse(bunifuDataGridView_statistic.Rows[0].Cells[2].Value.ToString());
                bunifuDataGridView_statistic.Rows[0].Cells[0].Value = "Ancfcc";
                bunifuDataGridView_statistic.Rows[0].Cells[1].Value = Ancfcc;
                bunifuDataGridView_statistic.Rows[0].Cells[3].Value = (Ancfcc - montant_paye_Ancfcc).ToString();
                bunifuDataGridView_statistic.Rows[0].Cells[4].Value = ((Ancfcc * 100) / THEME.prix).ToString();
                double montant_paye_Enregistrement = double.Parse(bunifuDataGridView_statistic.Rows[1].Cells[2].Value.ToString());
                bunifuDataGridView_statistic.Rows[1].Cells[0].Value = "Enregistrement";
                bunifuDataGridView_statistic.Rows[1].Cells[1].Value = Enregistrement;
                bunifuDataGridView_statistic.Rows[1].Cells[3].Value = (Enregistrement - montant_paye_Enregistrement).ToString();
                bunifuDataGridView_statistic.Rows[1].Cells[4].Value = ((Enregistrement * 100) / THEME.prix).ToString();           
                double montant_paye_Honoraires = double.Parse(bunifuDataGridView_statistic.Rows[2].Cells[2].Value.ToString());
                bunifuDataGridView_statistic.Rows[2].Cells[0].Value = "Honoraires";
                bunifuDataGridView_statistic.Rows[2].Cells[1].Value = Honoraires;
                bunifuDataGridView_statistic.Rows[2].Cells[3].Value = (Honoraires - montant_paye_Honoraires).ToString();
                bunifuDataGridView_statistic.Rows[2].Cells[4].Value = ((Honoraires * 100) / THEME.prix).ToString();            
                double montant_paye_Timbres = double.Parse(bunifuDataGridView_statistic.Rows[3].Cells[2].Value.ToString());
                bunifuDataGridView_statistic.Rows[3].Cells[0].Value = "Timbres";
                bunifuDataGridView_statistic.Rows[3].Cells[1].Value = Timbres;
                bunifuDataGridView_statistic.Rows[3].Cells[3].Value = (Timbres - montant_paye_Timbres).ToString();
                bunifuDataGridView_statistic.Rows[3].Cells[4].Value = ((Timbres * 100) / THEME.prix).ToString();            
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
            p.typecharge = comboBox_TYPE_CHARGE.Text;
            p.type = "charge";
            p.idcontrat = THEME.id_C;
            if(!RD_ESPECES.Checked)
                p.type_Payement = RDCHEQUE.Checked ? "CHEQUE" : "VERMENT";
            else
                p.type_Payement = "ESPECES";
            paye.Add(p);
        }

        private void ButtonAdd_FICHIER_Click(object sender, EventArgs e)
        {
            if (textBoxfile.Text == "")
                return;
            var A = new fichiers_contrat();
            A.idcontrat = THEME.id_C;
            A.titre = textBoxtitre.Text;
            A.descreption = textBoxdesc.Text;
            A.path = textBoxfile.Text;
            cont.Add(A);
        }

        private void ButtonSaveSettings_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textBoxfile.Text = ofd.FileName;
                }
            }
        }

        private void buttonserche_file_Click(object sender, EventArgs e)
        {
            var files = cont.GetAll().Select(ele => new filee()
            {
                IDFILE = (int)ele.idfile,
                TITRE = ele.titre,
                DESCREPTON = ele.descreption,
                FILE = ele.path
            }).ToList();
            files = textBoxtitre.Text != "" ?
                files.Where(ele => ele.TITRE.ToString() == textBoxtitre.Text).ToList() :
                files;
            bunifuDataGridView_fichier_contart.DataSource = files;
            THEME.add_btn_to_datagrid(bunifuDataGridView_fichier_contart, "sipprision", "supprimer", 4);
            THEME.add_btn_to_datagrid(bunifuDataGridView_fichier_contart, "affichage", "affichier", 5);
        }

        private void bunifuDataGridView_fichier_contart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                if (dgv.Columns[e.ColumnIndex].Name == "affichage")
                {
                    string file = dgv.Rows[e.RowIndex].Cells["FILE"].Value.ToString();
                    Process.Start(file);
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to DELETE this FILE ?", "Confirmation of Form Closure", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        int idfile = int.Parse(dgv.Rows[e.RowIndex].Cells["IDFILE"].Value.ToString());
                        cont.Remove(cont.FindById(idfile));
                    }

                }
            }
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
    public class payeme
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
    public class statistic
    {
        [DisplayName("DEPANCES")]
        public string DEPANCES { get; set; }
        [DisplayName("MONTANT")]
        public string MONTANT { get; set; }
        [DisplayName("PAYE")]
        public string PAYE { get; set; }
        [DisplayName("RESTE")]
        public string RESTE { get; set; }
        [DisplayName("PORCENTAGE")]
        public string PORCENTAGE { get; set; }
    }
    public class statis
    {
        [DisplayName("DEPANCES")]
        public string DEPANCES { get; set; }
        [DisplayName("MONTANT")]
        public string MONTANT { get; set; }
        [DisplayName("PAYE")]
        public string PAYE { get; set; }
        [DisplayName("RESTE")]
        public string RESTE { get; set; }
        [DisplayName("PORCENTAGE")]
        public string PORCENTAGE { get; set; }
    }
}
