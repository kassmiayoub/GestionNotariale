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
            AutoCompleteStringCollection autoCompleteCollection_dossier = new AutoCompleteStringCollection();
            dossier.ForEach(x => autoCompleteCollection_dossier.Add(x.Num));
            bunifuDropdown_client.AutoCompleteSource = AutoCompleteSource.CustomSource;
            bunifuDropdown_client.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            bunifuDropdown_client.AutoCompleteCustomSource = autoCompleteCollection_dossier;
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
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            ListDataSource.ForEach(x => autoCompleteCollection.Add(x.nomcomplet));
            bunifuDropdown_client.AutoCompleteSource = AutoCompleteSource.CustomSource;
            bunifuDropdown_client.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            bunifuDropdown_client.AutoCompleteCustomSource = autoCompleteCollection;
            bunifuDropdown_client.DisplayMember = "NOMCOMPLET";
            bunifuDropdown_client.ValueMember = "IDCIENT";
            bunifuDropdown_client.DataSource = ListDataSource;
        }

        private void buttonserche_facture_Click(object sender, EventArgs e)
        {
            var factures = cls_Bl_Facture.GetAll().ToList();
            if (bunifuCheckBox_contrat.Checked)
            {
                int idcintrat = (int)bunifuDropdown_contrat.SelectedValue;
                factures = factures.Where(r => r.idcontrat == idcintrat).ToList();
            }
            if (bunifuCheckBox_dossier.Checked)
            {
                string n_dossier = bunifuDropdown_dossier.SelectedValue.ToString();
                factures = factures.Where(r => con.Any(c => c.Idcontrat == r.idcontrat && c.numdossier == n_dossier)).ToList();
            }
            if (bunifuCheckBox_client.Checked)
            {
                int idclient = (int)bunifuDropdown_client.SelectedValue;
                var Numd = partee.FindByValues(ele => ele.client.idClient == idclient).ToList();                
                factures = factures.Where(r => Numd.Any(c => c.dossier.Numdossier == r.contrat.numdossier)).ToList();
            }
            bunifuDataGridView_list_facture.DataSource = factures;
            THEME.add_btn_to_datagrid(bunifuDataGridView_list_facture, "AFICHAGE", "AFICHAGE", 4);
        }
        private void CTL_facture_Load(object sender, EventArgs e)
        {
            var factures = cls_Bl_Facture.GetAll().ToList();
            bunifuDataGridView_list_facture.DataSource = factures;
            THEME.add_btn_to_datagrid(bunifuDataGridView_list_facture, "AFICHAGE", "AFICHAGE", 4);
        }
    }
}
