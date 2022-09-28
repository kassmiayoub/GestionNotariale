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
    public partial class CTL_CDG : UserControl
    {
        CSL_BL_Client cls = new CSL_BL_Client();
        cls_bl_partes partee = new cls_bl_partes();
        cls_bl_dossier cls_Bl_Dossier = new cls_bl_dossier();
        cls_CDG cls_CDG = new cls_CDG();
        List<CDGS> cdgs;
        double TPI;
        public CTL_CDG()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void CTL_CDG_Load(object sender, EventArgs e)
        {
            bunifuTextBox_PRIXACHAT.Enabled = false;
            bunifuTextBox_PRIXVENTE.Enabled = false;
           // var ListDataSource = new List<clien>();
           // var ListDataSource = cls.GetAll().Select(ele => new { nomcomplet = ele.Nom + " " + ele.Prenom, IDCIENT = ele.idClient }).ToList();
            //{
            //    IDCIENT = ele.idClient,
            //    nomcomplet = ele.Nom + " " + ele.Prenom
            //}).ToList();
            //AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            //ListDataSource.ForEach(x => autoCompleteCollection.Add(x.nomcomplet));
            //bunifuDropdown_CLIENT.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //bunifuDropdown_CLIENT.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //bunifuDropdown_CLIENT.DisplayMember = "NOMCOMPLET";
            //bunifuDropdown_CLIENT.ValueMember = "IDCIENT";
            //bunifuDropdown_CLIENT.DataSource = ListDataSource;           
            //bunifuDropdown_CLIENT.AutoCompleteCustomSource = autoCompleteCollection;
            if (THEME.TPI == "")
            {
                var dossier = cls_Bl_Dossier.GetAll().Select(ele => new { Num = ele.Numdossier }).ToList();
                bunifuDropdown_DOSSIER.DisplayMember = "Num";
                bunifuDropdown_DOSSIER.ValueMember = "Num";
                bunifuDropdown_DOSSIER.DataSource = dossier;
            }              
            else
            {
                var dossier = cls_Bl_Dossier.GetAll().Select(ele => new { Num = ele.Numdossier }).ToList();
                bunifuDropdown_DOSSIER.DisplayMember = "Num";
                bunifuDropdown_DOSSIER.ValueMember = "Num";
                bunifuDropdown_DOSSIER.DataSource = dossier;
                THEME.TPI = "";
            }          
            bunifuTextBox_PRIXVENTE.Text = cls_Bl_Dossier.FindByValues(ele => ele.Numdossier == bunifuDropdown_DOSSIER.SelectedValue.ToString()).FirstOrDefault().PRIX_ACQUISITION.ToString();
        }

        private void bunifuDropdown_CLIENT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (THEME.TPI != "")
            {        
                return;
            }               
            var dossier = cls_Bl_Dossier.GetAll().Select(ele => new { Num = ele.Numdossier }).ToList();
            bunifuDropdown_DOSSIER.DisplayMember = "Num";
            bunifuDropdown_DOSSIER.ValueMember = "Num";
            bunifuDropdown_DOSSIER.DataSource = dossier;
        }
        private void bunifuDropdown_DOSSIER_SelectedIndexChanged(object sender, EventArgs e)
        {
            dossier d = cls_Bl_Dossier.FindByValues(ele => ele.Numdossier == bunifuDropdown_DOSSIER.SelectedValue.ToString()).FirstOrDefault();
            ANNE.Text = d.anne_achat.ToString();
            bunifuTextBox_PRIXVENTE.Text = d.PRIX_ACQUISITION.ToString();
            bunifuTextBox_PRIXACHAT.Text = d.prixachat.ToString();

        }
        private void CTL_CDG_VisibleChanged(object sender, EventArgs e)
        {
            if(THEME.numdossier != "")
            {
                bunifuDropdown_DOSSIER.SelectedValue = THEME.numdossier;
            }
            cdgs = cls_CDG.GetAll().Select(ele => new CDGS()
            {
                N_DOSSIER = ele.numdossier,
                TYPE = ele.type,
                TPI = ele.TPI.ToString(),
                MONTANT = ele.Montant.ToString(),
                DATE = ele.Date.ToString(),
                COEFFICIENT = ele.COEFFICIENT.ToString(),
                user = ele.utilisateur1.Nom+" "+ele.utilisateur1.Prenom                
            }).ToList();
            bunifuDataGridView_cdg.DataSource = cdgs;
        }
        private void button_CALC_Click(object sender, EventArgs e)
        {
            if (COEFFICIENT.Controls["textBox_porsontage"].Text == "" || COEFFICIENT.Controls["textBox_porsontage"].Text == "0.00")
                return;
            double TPI1;
            double TPI2;
            int anne_vente = int.Parse(cls_Bl_Dossier.FindByValues(ele => ele.Numdossier == bunifuDropdown_DOSSIER.SelectedValue.ToString()).FirstOrDefault().anne_vente.ToString());
            if ((anne_vente - int.Parse(ANNE.Text)) <=6)
            {
                double COEFFICIENTfoiPRIXACHAT = double.Parse(bunifuTextBox_PRIXACHAT.Text) * (double.Parse(COEFFICIENT.Controls["textBox_porsontage"].Text));
                double a = (double.Parse(bunifuTextBox_PRIXVENTE.Text) - ((COEFFICIENTfoiPRIXACHAT * 15) / 100));
                TPI1 = (a*20)/100;
                TPI2 = (double.Parse(bunifuTextBox_PRIXVENTE.Text) * 3) / 100;
                if(TPI1 > TPI2)
                {
                    TPI = TPI1;
                    lblTPI.Text = TPI1.ToString();
                }
                else
                {
                    TPI = TPI2;
                    lblTPI.Text = TPI2.ToString();
                }
            }
            else if( (double.Parse(bunifuTextBox_PRIXVENTE.Text) >= 4000000) )
            {
                TPI = (double.Parse(bunifuTextBox_PRIXVENTE.Text) * 3) / 100;
                lblTPI.Text = TPI.ToString();
            }
            else
            {
                TPI = 00.00;
                lblTPI.Text = TPI.ToString();
            }
        }
        private void ButtonAdd_CDG_Click(object sender, EventArgs e)
        {
            if (!THEME.acceder("AJOUTER MONTANT DANS CDG"))
            {
                MessageBox.Show("VOUS N'AVEZ PAS LA PERMISSION");
                return;
            }
            if (COEFFICIENT.Controls["textBox_porsontage"].Text == "0.00" )
            {
                MessageBox.Show("COEFFICIENT DOIT EST PAS VIDE");
                return;
            }
            var cdg = new CDG();
            cdg.COEFFICIENT = COEFFICIENT.Controls["textBox_porsontage"].Text;
            cdg.utilisateur = THEME.id_user;
            cdg.Date = bunifuDatePicker_CDG.Value;
            if (lblTPI.Text == "TPI")
            {
                MessageBox.Show("doit calculer lA TPI");
                return ;
            }
            cdg.TPI = TPI;
            cdg.numdossier = THEME.numdossier;
            cdg.Montant = double.Parse(bunifuTextBox_PRIXVENTE.Text);
            if (radioButton_CREDIT.Checked)
                cdg.type = "credit";
            else if (radioButton_Immobilier.Checked)
                cdg.type = "immobilier";
            else
            {
                MessageBox.Show("vous voulez coche credit ou immobilier");
                return;
            }
            cls_CDG.Add(cdg);
            MessageBox.Show("ajouter avec success");
        }
        private void buttonserche_CDG_Click(object sender, EventArgs e)
        {
            string type = "";
            string dossier = "";
                cdgs = cls_CDG.GetAll().Select(ele => new CDGS()
                {
                    N_DOSSIER = ele.numdossier,
                    TYPE = ele.type,
                    TPI = ele.TPI.ToString(),
                    MONTANT = ele.Montant.ToString(),
                    DATE = ele.Date.ToString(),
                    COEFFICIENT = ele.COEFFICIENT.ToString(),
                    user = ele.utilisateur1.Nom + " " + ele.utilisateur1.Prenom
                }).ToList();
              // bunifuDataGridView_cdg.DataSource = cdgs;
            
           
            if (radioButton_CREDIT.Checked)
                type = "credit";
            else if (radioButton_Immobilier.Checked)
                type = "immobilier";
            if (bunifuCheckBox_dossier.Checked)
                dossier = bunifuDropdown_DOSSIER.SelectedValue.ToString();
            cdgs = dossier != "" ?
                cdgs.Where(ele => ele.N_DOSSIER == dossier).ToList() :
                cdgs;
            cdgs = type != "" ?
                cdgs.Where(ele => ele.TYPE == type).ToList() :
                cdgs;
            bunifuDataGridView_cdg.DataSource = cdgs;
        }

        private void ButtonSerch_client_Click(object sender, EventArgs e)
        {
            //((Button)this.Parent.Controls["add_client"].Controls["bunifuPages1"].Controls["tabPage_CLIENT"].Controls["ButtonEdit"]).Enabled = false;
            //((Button)this.Parent.Controls["add_client"].Controls["bunifuPages1"].Controls["tabPage_CLIENT"].Controls["ButtonAdd"]).Enabled = false;
            //THEME.T = this.GetType();
            //THEME.navigat(typeof(add_client));
            //THEME.client_or_dossier = (ComboBox)this.Controls["bunifuDropdown_CLIENT"];
        }
    }
    public class CDGS
    {
        [DisplayName("N DOSSIER")]
        public string N_DOSSIER { get; set; }
        [DisplayName("DATE Dépôt")]
        public string DATE { get; set; }
        [DisplayName("MONTANT Dépôt")]
        public string MONTANT { get; set; }
        [DisplayName("TPI")]
        public string TPI { get; set; }
        [DisplayName("COEFFICIENT")]
        public string COEFFICIENT { get; set; }
        [DisplayName("TYPE Dépôt")]
        public string TYPE { get; set; }
        [DisplayName("UTILISATUER")]
        public string user { get; set; }
    }
}
