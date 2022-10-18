using gestion_cabinet_notarial.BL;
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
    public partial class CTL_STATISTIC : UserControl
    {
        cls_bl_payement paye = new cls_bl_payement();
        cls_bl_credit BL_credit = new cls_bl_credit();
        cls_bl_contrat contrat = new cls_bl_contrat();
        DateTime dtm = Convert.ToDateTime(DateTime.Now.ToString("MM/dd/yy"));

        public CTL_STATISTIC()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
           
        }

        private void CTL_STATISTIC_Load(object sender, EventArgs e)
        {
            var list = paye.FindByValues(ele => ele.typecharge == "Honoraires" && ele.Date == dtm).GroupBy(ele => ele.idcontrat).Select(ele => new
            {   //DEPANCES= ele.Key,              
                Honoraires = ele.Sum(el => el.Montant).ToString(),
                TVA = ((ele.Sum(el => el.Montant)) * 10) / 100,
                CONTRAT = ele.First(el => el.typecharge == "Honoraires").contrat.typecontrat,
                DOSSIER = ele.First(el => el.typecharge == "Honoraires").contrat.dossier.Numdossier,
                DATEOUVERTURE = ele.First(el => el.typecharge == "Honoraires").contrat.dateouverture
            }).ToList();
            bunifuDataGridView_statistic.DataSource = list;

            bunifuDataGridView_T.ColumnCount = 2;
            bunifuDataGridView_T.Columns[0].Name = "T. HONORAIRES";
            bunifuDataGridView_T.Columns[1].Name = "T. TVA";
            bunifuDataGridView_T.Rows.Clear();
            string[] row = new string[] { "", "" };
            bunifuDataGridView_T.Rows.Add(row);

            bunifuDataGridView_T_credit_honoraires.ColumnCount = 2;
            bunifuDataGridView_T_credit_honoraires.Columns[0].Name = "HONORAIRES";
            bunifuDataGridView_T_credit_honoraires.Columns[1].Name = "CREDIT";
            bunifuDataGridView_T_credit_honoraires.Rows.Clear();
            bunifuDataGridView_T_credit_honoraires.Rows.Add(row);
        }
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (radioButton_CREDIT.Checked)
            {
                if (radioButton_now.Checked)
                {
                    var list = paye.FindByValues(ele => ele.type == "credit" && ele.Date == dtm).GroupBy(ele => ele.idcontrat).Select(ele => new
                    {   //DEPANCES= ele.Key,              
                        CREDIT = ele.Sum(el => el.Montant).ToString(),
                        TVA = ((ele.Sum(el => el.Montant)) * 10) / 100,
                        CONTRAT = ele.First(el => el.type == "credit").contrat.typecontrat,
                        DOSSIER = ele.First(el => el.type == "credit").contrat.dossier.Numdossier,
                        DATEOUVERTURE = ele.First(el => el.type == "credit").contrat.dateouverture
                    }).ToList();
                    bunifuDataGridView_T.Columns[0].Name = "T. CREDIT";
                    bunifuDataGridView_statistic.DataSource = list;
                }
                else if (radioButton_filtrage.Checked)
                {
                    var list = paye.FindByValues(ele => ele.type == "credit" && ele.Date >= bunifuDatePicker_D.Value && ele.Date <= bunifuDatePicker_F.Value).GroupBy(ele => ele.idcontrat).Select(ele => new
                    {   //DEPANCES= ele.Key,              
                        CREDIT = ele.Sum(el => el.Montant).ToString(),
                        TVA = ((ele.Sum(el => el.Montant)) * 10) / 100,
                        CONTRAT = ele.First(el => el.type == "credit").contrat.typecontrat,
                        DOSSIER = ele.First(el => el.type == "credit").contrat.dossier.Numdossier,
                        DATEOUVERTURE = ele.First(el => el.type == "credit").contrat.dateouverture
                    }).ToList();
                    bunifuDataGridView_statistic.DataSource = list;
                    bunifuDataGridView_T.Columns[0].Name = "T. CREDIT";
                }
                else
                {
                    var list = paye.FindByValues(ele => ele.type == "credit").GroupBy(ele => ele.idcontrat).Select(ele => new
                    {   //DEPANCES= ele.Key,              
                        CREDIT = ele.Sum(el => el.Montant).ToString(),
                        TVA = ((ele.Sum(el => el.Montant)) * 10) / 100,
                        CONTRAT = ele.First(el => el.type == "credit").contrat.typecontrat,
                        DOSSIER = ele.First(el => el.type == "credit").contrat.dossier.Numdossier,
                        DATEOUVERTURE = ele.First(el => el.type == "credit").contrat.dateouverture
                    }).ToList();
                    bunifuDataGridView_statistic.DataSource = list;
                    bunifuDataGridView_T.Columns[0].Name = "T. CREDIT";
                }
            }
            else if (radioButton_H.Checked)
            {
                if (radioButton_now.Checked)
                {
                    var list = paye.FindByValues(ele => ele.typecharge == "Honoraires" && ele.type == "charge" && ele.Date == dtm).GroupBy(ele => ele.idcontrat).Select(ele => new
                    {   //DEPANCES= ele.Key,              
                        Honoraires = ele.Sum(el => el.Montant).ToString(),
                        TVA = ((ele.Sum(el => el.Montant)) * 10) / 100,
                        CONTRAT = ele.First(el => el.typecharge == "Honoraires").contrat.typecontrat,
                        DOSSIER = ele.First(el => el.typecharge == "Honoraires").contrat.dossier.Numdossier,
                        DATEOUVERTURE = ele.First(el => el.typecharge == "Honoraires").contrat.dateouverture
                    }).ToList();
                    bunifuDataGridView_statistic.DataSource = list;
                    bunifuDataGridView_T.Columns[0].Name = "T. HONORAIRES";

                }
                else if (radioButton_filtrage.Checked)
                {
                    var list = paye.FindByValues(ele => ele.typecharge == "Honoraires" && ele.type == "charge" && ele.Date >= bunifuDatePicker_D.Value && ele.Date <= bunifuDatePicker_F.Value).GroupBy(ele => ele.idcontrat).Select(ele => new
                    {   //DEPANCES= ele.Key,              
                        Honoraires = ele.Sum(el => el.Montant).ToString(),
                        TVA = ((ele.Sum(el => el.Montant)) * 10) / 100,
                        CONTRAT = ele.First(el => el.typecharge == "Honoraires").contrat.typecontrat,
                        DOSSIER = ele.First(el => el.typecharge == "Honoraires").contrat.dossier.Numdossier,
                        DATEOUVERTURE = ele.First(el => el.typecharge == "Honoraires").contrat.dateouverture
                    }).ToList();
                    bunifuDataGridView_statistic.DataSource = list;
                    bunifuDataGridView_T.Columns[0].Name = "T. HONORAIRES";

                }
                else
                {
                    var list = paye.FindByValues(ele => ele.typecharge == "Honoraires" && ele.type == "charge").GroupBy(ele => ele.idcontrat).Select(ele => new
                    {   //DEPANCES= ele.Key,              
                        Honoraires = ele.Sum(el => el.Montant).ToString(),
                        TVA = ((ele.Sum(el => el.Montant)) * 10) / 100,
                        CONTRAT = ele.First(el => el.typecharge == "Honoraires").contrat.typecontrat,
                        DOSSIER = ele.First(el => el.typecharge == "Honoraires").contrat.dossier.Numdossier,
                        DATEOUVERTURE = ele.First(el => el.typecharge == "Honoraires").contrat.dateouverture
                    }).ToList();
                    bunifuDataGridView_statistic.DataSource = list;
                    bunifuDataGridView_T.Columns[0].Name = "T. HONORAIRES";

                }
            }

            double h = 0;
            double t = 0;
            foreach(DataGridViewRow r in bunifuDataGridView_statistic.Rows)
            {
                h += double.Parse(r.Cells[0].Value.ToString());
                t += double.Parse(r.Cells[1].Value.ToString());
            }
            bunifuDataGridView_T.Rows[0].Cells[0].Value = h;
            bunifuDataGridView_T.Rows[0].Cells[1].Value = t;
        }
        private void CTL_STATISTIC_VisibleChanged(object sender, EventArgs e)
        {
            //TYPECLIENT = clp.Any(el => el.idClient == ele.idClient) ? "profisionnel" : "normal",
            if (this.Visible == true)
            {
                double Tcredit =  BL_credit.GetAll().Sum(ele => ele.montant).Value;
                double Pcredit = paye.FindByValues(el => el.type == "credit").Sum(ell => ell.Montant).Value;
                double Thonoraires = contrat.GetAll().Where(r => BL_credit.Any(el => el.idcontrat != r.Idcontrat)).Sum(ele => ele.Honoraires).Value;
                double Phonoraires = paye.FindByValues(ele => ele.typecharge == "Honoraires").Sum(el => el.Montant).Value;
                bunifuDataGridView_T_credit_honoraires.Rows[0].Cells[0].Value = Thonoraires - Phonoraires;
                bunifuDataGridView_T_credit_honoraires.Rows[0].Cells[1].Value = Tcredit - Pcredit;
            }
        }
    }
}