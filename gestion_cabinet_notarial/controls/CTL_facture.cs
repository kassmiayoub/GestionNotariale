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
    public partial class CTL_facture : UserControl
    {
        cls_bl_facture cls_Bl_Facture = new cls_bl_facture();
        cls_bl_contrat con = new cls_bl_contrat();
        cls_bl_partes partee = new cls_bl_partes();
        CSL_BL_Client cls = new CSL_BL_Client();
        cls_bl_dossier cls_Bl_Dossier = new cls_bl_dossier();
        public CTL_facture()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

        }

        private void lbldossier_Click(object sender, EventArgs e)
        {

        }

        private void CTL_facture_VisibleChanged(object sender, EventArgs e)
        {
            var dossier = cls_Bl_Dossier.GetAll().Select(el => new
            {
                Num = el.Numdossier
            }).ToList();
            //AutoCompleteStringCollection autoCompleteCollection_dossier = new AutoCompleteStringCollection();
            //dossier.ForEach(x => autoCompleteCollection_dossier.Add(x.Num));
            //bunifuDropdown_dossier.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //bunifuDropdown_dossier.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //bunifuDropdown_dossier.AutoCompleteCustomSource = autoCompleteCollection_dossier;
            bunifuDropdown_dossier.ValueMember = "Num";
            bunifuDropdown_dossier.DisplayMember = "Num";
            bunifuDropdown_dossier.DataSource = dossier;
            var dossier_filtrage = con.GetAll().Where(ele => ele.dossier.Numdossier == bunifuDropdown_dossier.SelectedValue.ToString()).Select(el => new { t = el.typecontrat, id = el.Idcontrat }).ToList();
            bunifuDropdown_contrat.SelectedValue = dossier_filtrage;
            bunifuDropdown_contrat.ValueMember = "id";
            bunifuDropdown_contrat.DisplayMember = "t";
            bunifuDropdown_contrat.DataSource = dossier_filtrage;
            var ListDataSource = cls.GetAll().Select(ele => new
            {
                IDCIENT = ele.idClient,
                nomcomplet = ele.Nom + " " + ele.Prenom
            }).ToList();
            //AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            //ListDataSource.ForEach(x => autoCompleteCollection.Add(x.nomcomplet));
            //bunifuDropdown_client.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //bunifuDropdown_client.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //bunifuDropdown_client.AutoCompleteCustomSource = autoCompleteCollection;
            bunifuDropdown_client.DisplayMember = "NOMCOMPLET";
            bunifuDropdown_client.ValueMember = "IDCIENT";
            bunifuDropdown_client.DataSource = ListDataSource;
        }

        private void buttonserche_facture_Click(object sender, EventArgs e)
        {
            var factures = cls_Bl_Facture.GetAll().Select(ele => new {
                Nfacture = ele.Nfacture,
                idcontrat = ele.idcontrat,
                typecontrat = ele.contrat.typecontrat,
                Ndossier = ele.contrat.numdossier,
                datefacture = ele.date
            }).ToList();
            if (bunifuCheckBox_contrat.Checked && bunifuDropdown_contrat.SelectedValue != null)
            {
                int idcintrat = (int)bunifuDropdown_contrat.SelectedValue;
                factures = factures.Where(r => r.idcontrat == idcintrat).ToList();
            }
            if (bunifuCheckBox_dossier.Checked && bunifuDropdown_dossier.SelectedValue != null)
            {
                string n_dossier = bunifuDropdown_dossier.SelectedValue.ToString();
                factures = factures.Where(r => con.Any(c => c.Idcontrat == r.idcontrat && c.numdossier == n_dossier)).ToList();
            }
            if (bunifuCheckBox_client.Checked && bunifuDropdown_client.SelectedValue != null)
            {
                int idclient = (int)bunifuDropdown_client.SelectedValue;
                var Numd = partee.FindByValues(ele => ele.client.idClient == idclient).ToList();
                factures = factures.Where(r => Numd.Any(c => c.dossier.Numdossier == r.Ndossier)).ToList();
            }
            bunifuDataGridView_list_facture.DataSource = factures;
            THEME.add_btn_to_datagrid(bunifuDataGridView_list_facture, "AFICHAGE", "AFICHAGE", 5);
            factures = factures.Distinct().ToList();
        }
        private void CTL_facture_Load(object sender, EventArgs e)
        {
            var factures = cls_Bl_Facture.GetAll().Select(ele => new {
                Nfacture = ele.Nfacture,
                idcontrat = ele.idcontrat,
                typecontrat = ele.contrat.typecontrat,
                Ndossier = ele.contrat.numdossier,
                datefacture = ele.date
            }).ToList();           
            bunifuDataGridView_list_facture.DataSource = factures;
            THEME.add_btn_to_datagrid(bunifuDataGridView_list_facture, "AFICHAGE", "AFICHAGE", 5);
        }

        private void bunifuDataGridView_list_facture_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (e.RowIndex >= 0 && dgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                //if (!THEME.acceder("CONTARTS DOSSIER"))
                //{
                //    MessageBox.Show("VOUS N'AVEZ PAS LA PERMISSION");
                //    return;
                //}
                if (dgv.Columns[e.ColumnIndex].Name == "AFICHAGE")
                {
                   int idcontrat = int.Parse(dgv.Rows[e.RowIndex].Cells[dgv.Columns["idcontrat"].Name].Value.ToString());
                    THEME.id_C = idcontrat;
                   var contrat = con.FindById(idcontrat);
                   double Ancfcc_c = (double)contrat.Ancfcc;
                   double Enregistrement_c = (double)contrat.Enregistrement;
                   double Honoraires_c = (double)contrat.Honoraires;
                   double Timbres_c = (double)contrat.Timbres;
                   string idfacture = dgv.Rows[e.RowIndex].Cells[dgv.Columns["Nfacture"].Name].Value.ToString();
                    var facture = cls_Bl_Facture.FindByValues(ele => ele.Nfacture == idfacture).First();
                    double Ancfcc_f = (double)facture.ancfcc;
                    double Enregistrement_f = (double)facture.enrigestrement;
                    double Honoraires_f = (double)facture.hpnoraires;
                    double Timbres_f = (double)facture.tamber;


                    THEME.numdossier = dgv.Rows[e.RowIndex].Cells[dgv.Columns["Ndossier"].Name].Value.ToString();
                    print_facture.montant_Ancfcc = Ancfcc_c;
                    print_facture.montant_enregitrement = Enregistrement_c;
                    print_facture.montant_honorair = Honoraires_c;
                    print_facture.montant_tamber = Timbres_c;
                    double montant = Ancfcc_c + Enregistrement_c + Honoraires_c + Timbres_c;
                    print_facture.typecontart = con.FindByValues(ele => ele.Idcontrat == idcontrat).First().typecontrat;
                    print_facture.foncier = cls_Bl_Dossier.FindByValues(ele => ele.Numdossier == THEME.numdossier).First().Titrefoncier;
                    print_facture.paye_enregitrement = Enregistrement_f;
                    print_facture.paye_Ancfcc = Ancfcc_f;
                    print_facture.paye_honorair = Honoraires_f;
                    print_facture.paye_tamber = Timbres_f;
                    double payement = Ancfcc_f + Enregistrement_f + Timbres_f+ Honoraires_f;
                    if (montant - payement > 0)
                    {
                        print_facture.etatpayement = "La facture n’a pas encore été payée,";
                    }
                    else
                    {
                        print_facture.etatpayement = "La facture a été payée, ";
                    }
                    string paye =payement.ToString();
                    string[] n = paye.Split('.');
                    if (n.Length == 1)
                    {
                        print_facture.paye = "elle a payé  " + DATABASE.NumberToWords(int.Parse(n[0]));
                    }
                    else
                    {
                        print_facture.paye = "elle a payé  " + DATABASE.NumberToWords(int.Parse(n[0])) + " virgule " + DATABASE.NumberToWords(int.Parse(n[1]));
                    }

                    string reste = (montant - payement).ToString();
                    string[] n1 = reste.Split('.');
                    if (n1.Length == 1)
                    {
                        print_facture.reste = "et le reste est " + DATABASE.NumberToWords(int.Parse(n1[0]));
                    }
                    else
                    {
                        print_facture.reste = "et le reste est " + DATABASE.NumberToWords(int.Parse(n1[0])) + " virgule " + DATABASE.NumberToWords(int.Parse(n1[1]));
                    }
                    print_facture f = new print_facture();
                    f.Show();
                }
            }
        }

        private void bunifuDropdown_dossier_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dossier_filtrage = con.GetAll().Where(ele => ele.dossier.Numdossier == bunifuDropdown_dossier.SelectedValue.ToString()).Select(el => new { t = el.typecontrat, id = el.Idcontrat }).ToList();
            bunifuDropdown_contrat.SelectedValue = dossier_filtrage;
            bunifuDropdown_contrat.ValueMember = "id";
            bunifuDropdown_contrat.DisplayMember = "t";
            bunifuDropdown_contrat.DataSource = dossier_filtrage;
        }

        private void bunifuSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
