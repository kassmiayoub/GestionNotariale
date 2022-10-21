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
using System.Windows.Forms.DataVisualization.Charting;

namespace gestion_cabinet_notarial.controls
{
    public partial class CTL_STATISTIC : UserControl
    {
        CSL_BL_Client_Professionnel clp = new CSL_BL_Client_Professionnel();
        CSL_BL_Client_normal cln = new CSL_BL_Client_normal();
        cls_bl_payement paye = new cls_bl_payement();
        cls_bl_credit BL_credit = new cls_bl_credit();
        cls_bl_contrat contrat = new cls_bl_contrat();
        DateTime dtm = Convert.ToDateTime(DateTime.Now.ToString("MM/dd/yy"));

        public CTL_STATISTIC()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
           
        }
        public void chart(DateTime dateD,DateTime dateF)
        {
            var list = paye.FindByValues(ele => ele.type == "charge" && ele.Date >= dateD && ele.Date <= dateF).GroupBy(ele =>  ele.Date ).Select(ele => new
            {   //DEPANCES= ele.Key,              
                Honoraires = ele.Sum(el => el.Montant),
                date = ele.Key.Value.Date.ToString("MM/dd/yy")
            }).ToList();
            var contrats_chart = contrat.FindByValues(el => el.dateouverture >= dateD && el.dateouverture <= dateF).GroupBy(ele => ele.dateouverture ).Select(el => new
            {
                Contrats = el.Count(),
                date = el.Key.Value.Date.ToString("MM/dd/yy")
            });
            chart1.DataSource = list;
            chart1.Series["Honoraires"].YValueMembers = "Honoraires";
            chart1.Series["Honoraires"].XValueMember = "date";
            chart1.Series["Honoraires"].YValueType = ChartValueType.Int32;

            chart_contrats.DataSource = contrats_chart;
            chart_contrats.Series["Contrats"].YValueMembers = "Contrats";
            chart_contrats.Series["Contrats"].XValueMember = "date";
            chart_contrats.Series["Contrats"].YValueType = ChartValueType.Int32;
        }
        private void CTL_STATISTIC_Load(object sender, EventArgs e)
        {
            DateTime dt = Convert.ToDateTime(DateTime.Now.ToString("MM/01/yy"));
            chart(dt.Date, dt.AddMonths(1).Date);
            var list = paye.FindByValues(ele => ele.typecharge == "Honoraires" && ele.Date == dtm).GroupBy(ele => ele.idcontrat).Select(ele => new
            {   //DEPANCES= ele.Key,              
                Honoraires = ele.Sum(el => el.Montant).ToString(),
                TVA = ((ele.Sum(el => el.Montant)) * 10) / 100,
                CONTRAT = ele.First(el => el.typecharge == "Honoraires").contrat.typecontrat,
                DOSSIER = ele.First(el => el.typecharge == "Honoraires").contrat.dossier.Numdossier,
                DATEOUVERTURE = ele.First(el => el.typecharge == "Honoraires").contrat.dateouverture
            }).ToList();
            //bunifuDataGridView_statistic.DataSource = list;

            //bunifuDataGridView_T.ColumnCount = 2;
            //bunifuDataGridView_T.Columns[0].Name = "T. HONORAIRES";
            //bunifuDataGridView_T.Columns[1].Name = "T. TVA";
            //bunifuDataGridView_T.Rows.Clear();
            string[] row = new string[] { "", "" };
            //bunifuDataGridView_T.Rows.Add(row);

        }
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            chart(Convert.ToDateTime(bunifuDatePicker_D.Value), Convert.ToDateTime(bunifuDatePicker_F.Value));
            //if (radioButton_CREDIT.Checked)
            //{
            //    if (radioButton_now.Checked)
            //    {
            //        var list = paye.FindByValues(ele => ele.type == "credit" && ele.Date == dtm).GroupBy(ele => ele.idcontrat).Select(ele => new
            //        {   //DEPANCES= ele.Key,              
            //            CREDIT = ele.Sum(el => el.Montant).ToString(),
            //            TVA = ((ele.Sum(el => el.Montant)) * 10) / 100,
            //            CONTRAT = ele.First(el => el.type == "credit").contrat.typecontrat,
            //            DOSSIER = ele.First(el => el.type == "credit").contrat.dossier.Numdossier,
            //            DATEOUVERTURE = ele.First(el => el.type == "credit").contrat.dateouverture
            //        }).ToList();
            //        bunifuDataGridView_T.Columns[0].Name = "T. CREDIT";
            //        bunifuDataGridView_statistic.DataSource = list;
            //    }
            //    else if (radioButton_filtrage.Checked)
            //    {
            //        var list = paye.FindByValues(ele => ele.type == "credit" && ele.Date >= bunifuDatePicker_D.Value && ele.Date <= bunifuDatePicker_F.Value).GroupBy(ele => ele.idcontrat).Select(ele => new
            //        {   //DEPANCES= ele.Key,              
            //            CREDIT = ele.Sum(el => el.Montant).ToString(),
            //            TVA = ((ele.Sum(el => el.Montant)) * 10) / 100,
            //            CONTRAT = ele.First(el => el.type == "credit").contrat.typecontrat,
            //            DOSSIER = ele.First(el => el.type == "credit").contrat.dossier.Numdossier,
            //            DATEOUVERTURE = ele.First(el => el.type == "credit").contrat.dateouverture
            //        }).ToList();
            //        bunifuDataGridView_statistic.DataSource = list;
            //        bunifuDataGridView_T.Columns[0].Name = "T. CREDIT";
            //    }
            //    else
            //    {
            //        var list = paye.FindByValues(ele => ele.type == "credit").GroupBy(ele => ele.idcontrat).Select(ele => new
            //        {   //DEPANCES= ele.Key,              
            //            CREDIT = ele.Sum(el => el.Montant).ToString(),
            //            TVA = ((ele.Sum(el => el.Montant)) * 10) / 100,
            //            CONTRAT = ele.First(el => el.type == "credit").contrat.typecontrat,
            //            DOSSIER = ele.First(el => el.type == "credit").contrat.dossier.Numdossier,
            //            DATEOUVERTURE = ele.First(el => el.type == "credit").contrat.dateouverture
            //        }).ToList();
            //        bunifuDataGridView_statistic.DataSource = list;
            //        bunifuDataGridView_T.Columns[0].Name = "T. CREDIT";
            //    }
            //}
            //else if (radioButton_H.Checked)
            //{
            //    if (radioButton_now.Checked)
            //    {
            //        var list = paye.FindByValues(ele => ele.typecharge == "Honoraires" && ele.type == "charge" && ele.Date == dtm).GroupBy(ele => ele.idcontrat).Select(ele => new
            //        {   //DEPANCES= ele.Key,              
            //            Honoraires = ele.Sum(el => el.Montant).ToString(),
            //            TVA = ((ele.Sum(el => el.Montant)) * 10) / 100,
            //            CONTRAT = ele.First(el => el.typecharge == "Honoraires").contrat.typecontrat,
            //            DOSSIER = ele.First(el => el.typecharge == "Honoraires").contrat.dossier.Numdossier,
            //            DATEOUVERTURE = ele.First(el => el.typecharge == "Honoraires").contrat.dateouverture
            //        }).ToList();
            //       bunifuDataGridView_statistic.DataSource = list;
            //        bunifuDataGridView_T.Columns[0].Name = "T. HONORAIRES";

            //    }
            //    else if (radioButton_filtrage.Checked)
            //    {
            //        var list = paye.FindByValues(ele => ele.typecharge == "Honoraires" && ele.type == "charge" && ele.Date >= bunifuDatePicker_D.Value && ele.Date <= bunifuDatePicker_F.Value).GroupBy(ele => ele.idcontrat).Select(ele => new
            //        {   //DEPANCES= ele.Key,              
            //            Honoraires = ele.Sum(el => el.Montant).ToString(),
            //            TVA = ((ele.Sum(el => el.Montant)) * 10) / 100,
            //            CONTRAT = ele.First(el => el.typecharge == "Honoraires").contrat.typecontrat,
            //            DOSSIER = ele.First(el => el.typecharge == "Honoraires").contrat.dossier.Numdossier,
            //            DATEOUVERTURE = ele.First(el => el.typecharge == "Honoraires").contrat.dateouverture
            //        }).ToList();
            //        bunifuDataGridView_statistic.DataSource = list;
            //        bunifuDataGridView_T.Columns[0].Name = "T. HONORAIRES";

            //    }
            //    else
            //    {
            //        var list = paye.FindByValues(ele => ele.typecharge == "Honoraires" && ele.type == "charge").GroupBy(ele => ele.idcontrat).Select(ele => new
            //        {   //DEPANCES= ele.Key,              
            //            Honoraires = ele.Sum(el => el.Montant).ToString(),
            //            TVA = ((ele.Sum(el => el.Montant)) * 10) / 100,
            //            CONTRAT = ele.First(el => el.typecharge == "Honoraires").contrat.typecontrat,
            //            DOSSIER = ele.First(el => el.typecharge == "Honoraires").contrat.dossier.Numdossier,
            //            DATEOUVERTURE = ele.First(el => el.typecharge == "Honoraires").contrat.dateouverture
            //        }).ToList();
            //        bunifuDataGridView_statistic.DataSource = list;
            //        bunifuDataGridView_T.Columns[0].Name = "T. HONORAIRES";

            //    }
            //}

            //double h = 0;
            //double t = 0;
            //foreach (DataGridViewRow r in bunifuDataGridView_statistic.Rows)
            //{
            //    h += double.Parse(r.Cells[0].Value.ToString());
            //    t += double.Parse(r.Cells[1].Value.ToString());
            //}
            //bunifuDataGridView_T.Rows[0].Cells[0].Value = h;
            //bunifuDataGridView_T.Rows[0].Cells[1].Value = t;
        }
        private void CTL_STATISTIC_VisibleChanged(object sender, EventArgs e)
        {           
            //TYPECLIENT = clp.Any(el => el.idClient == ele.idClient) ? "profisionnel" : "normal",
            if (this.Visible == true)
            {
                int client_n = cln.GetAll().Count();
                int client_p = clp.GetAll().Count();
                string[] x = new string[2];
                int[] y = new int[2];
                x[0] = "NORMAL";
                x[1] = "PROFESIONEL";
                y[0] = client_n;
                y[1] = client_p;
                chart_client.Series[0].Points.DataBindXY(x, y);
                chart_client.Series[0].IsValueShownAsLabel = true;               
                //chart_client.Series[0].ChartType = 
                double Tcredit =  BL_credit.GetAll().Sum(ele => ele.montant).Value;
                double Pcredit = paye.FindByValues(el => el.type == "credit").Sum(ell => ell.Montant).Value;
                double Thonoraires = contrat.GetAll().Where(r => BL_credit.Any(el => el.idcontrat != r.Idcontrat)).Sum(ele => ele.Honoraires).Value;
                double Phonoraires = paye.FindByValues(ele => ele.typecharge == "Honoraires").Sum(el => el.Montant).Value;
                //bunifuDataGridView_T_credit_honoraires.Rows[0].Cells[0].Value = Thonoraires - Phonoraires;
                //bunifuDataGridView_T_credit_honoraires.Rows[0].Cells[1].Value = Tcredit - Pcredit;
            }
        }
        public class lisi_chart
        {
            [DisplayName("date")]
            public string date { get; set; }
            [DisplayName("Honoraires")]
            public double Honoraires { get; set; }
            [DisplayName("Contrats")]
            public int Contrats { get; set; }
            
        }  
        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                chart_contrats.Visible = true;

            }
            else
            {
                chart_contrats.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                chart_contrats.Visible = true;

            }
            else
            {
                chart_contrats.Visible = false;
            }
        }
    }
}