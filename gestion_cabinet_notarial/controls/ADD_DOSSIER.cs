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
    public partial class ADD_DOSSIER : UserControl
    {
        cls_bl_dossier cls_Bl_Dossier = new cls_bl_dossier();
        public ADD_DOSSIER()
        {
            InitializeComponent();
        }
        private void ButtonAdd_dossier_Click(object sender, EventArgs e)
        {
            var a = new dossier();
            a.Numdossier = textBox_N_dossier.Text;
            a.dateouverture = Convert.ToDateTime(bunifuDatePicker_dubet.Text);
            a.Datefermeture = Convert.ToDateTime(bunifuDatePicker_fin.Text);
            a.PRIX_ACQUISITION = double.Parse(textBox_prix.Text);
            a.Titrefoncier=textBox_titre_foncier.Text;
            a.Objet = textBox_obj.Text;
            if(bunifuCheckBox_status.Checked)
                a.Datefermeture = Convert.ToDateTime(bunifuDatePicker_fin.Text);
            else
                a.Datefermeture = null;
            cls_Bl_Dossier.Add(a);
        }

        private void ButtonSearch_dossier_Click(object sender, EventArgs e)
        {
            var ListDataSource = new List<dossierSerche>();
            ListDataSource = cls_Bl_Dossier.GetAll().Select(ele => new dossierSerche()
                {
                    N_DOSSIER=ele.Numdossier,
                    DATE_F=ele.Datefermeture.ToString(),
                    DATE_O=ele.dateouverture.ToString(),
                    OBJET= ele.Objet,
                    TITRE_F=ele.Titrefoncier,
                    PRIX=ele.PRIX_ACQUISITION.ToString()
                }).ToList();
            ListDataSource = textBox_N_dossier.Text != "" ?
                ListDataSource.Where(ele => ele.N_DOSSIER== textBox_N_dossier.Text).ToList() :
                ListDataSource;
            ListDataSource = textBox_obj.Text != "" ?
                ListDataSource.Where(ele => ele.OBJET.ToString() == textBox_obj.Text).ToList() :
                ListDataSource;
            ListDataSource = textBox_titre_foncier.Text != "" ?
                ListDataSource.Where(ele => ele.TITRE_F.ToString() == textBox_titre_foncier.Text).ToList() :
                ListDataSource;
            ListDataSource = textBox_prix.Text != "" ?
               ListDataSource.Where(ele => ele.PRIX.ToString() == textBox_prix.Text).ToList() :
               ListDataSource;
            //ListDataSource = textBoxtel.Text != "" ?
            //    ListDataSource.Where(ele => ele.TEL.ToString() == textBoxtel.Text).ToList() :
            //    ListDataSource;
            //ListDataSource = textBox_fax.Text != "" ?
            //    ListDataSource.Where(ele => ele.FAX.ToString() == textBox_fax.Text).ToList() :
            //    ListDataSource;
            if(THEME.client_or_dossier != null)
            {
                ListDataSource = ListDataSource.Where(r => r.DATE_F == null).ToList();
            }
            bunifuDataGridView_list_dossier.DataSource = ListDataSource;
        }

        private void bunifuDataGridView_list_dossier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // MessageBox.Show(bunifuDataGridView_list_dossier.Rows[e.RowIndex].Cells[0].Value.ToString());
            dossier A = new dossier();
            var x = bunifuDataGridView_list_dossier.Rows[e.RowIndex].Cells[0].Value.ToString();
            A = cls_Bl_Dossier.FindByValues(ele => ele.Numdossier ==x ).First();
            textBox_N_dossier.Text = A.Numdossier;
            textBox_obj.Text = A.Objet;
            textBox_prix.Text = A.PRIX_ACQUISITION.ToString();
            textBox_titre_foncier.Text = A.Titrefoncier;
            bunifuDatePicker_dubet.Value = A.dateouverture.Value;
            bunifuDatePicker_fin.Value = A.Datefermeture.Value;
            if (THEME.client_or_dossier != null)
            {
                THEME.client_or_dossier.SelectedValue = textBox_N_dossier.Text;
                THEME.navigat(THEME.T);
                THEME.client_or_dossier = null;
                THEME.T = null;
                ButtonInit.Enabled = true;
                ButtonAdd_dossier .Enabled = true;
                ButtonEdit_dossier .Enabled = true;
            }
        }

        private void ButtonInit_Click(object sender, EventArgs e)
        {
            THEME.vider(this);
        }

        private void button_detail_dossier_Click(object sender, EventArgs e)
        {
            THEME.numdossier = textBox_N_dossier.Text;
            if (textBox_prix.Text == "")
                return;
            THEME.prix = double.Parse(textBox_prix.Text);
            THEME.navigat(typeof(detail_dossier));
        }

        private void ADD_DOSSIER_Load(object sender, EventArgs e)
        {
            bunifuDatePicker_fin.Enabled = false;
        }

        private void bunifuCheckBox_status_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if(bunifuCheckBox_status.Checked)
                bunifuDatePicker_fin.Enabled = true;
            else
                bunifuDatePicker_fin.Enabled = false;
        }
    }
    public class dossierSerche
    {
        [DisplayName("N DOSSIER")]
        public string N_DOSSIER { get; set; }
        [DisplayName("DATE FERMETURE ")]
        public string DATE_F { get; set; }
        [DisplayName("DATE OUVERTURE")]
        public string DATE_O { get; set; }
        [DisplayName("PRIX")]
        public string PRIX { get; set; }
        [DisplayName("OBJET")]
        public string OBJET { get; set; }
        [DisplayName("TITRE FONCIER")]
        public string TITRE_F { get; set; }
    }
}
