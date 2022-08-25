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
    public partial class detail_dossier : UserControl
    {
        cls_bl_partes partee = new cls_bl_partes();
        cls_bl_contrat con = new cls_bl_contrat();
        cls_lb_fichier_dossier csl_Bl_Fichier_dossier = new cls_lb_fichier_dossier();
        public detail_dossier()
        {
            InitializeComponent();
        }
        private void PARTES_OF_CONTRAT_Click(object sender, EventArgs e)
        {          
            string name = ((BunifuButton)sender).Name;
            switch (name)
            {
                case "PARTES_OF_CONTRAT":
                    bunifuPages1.SetPage(tabPage1);
                    break;
                case "FICHIERJOINT_dossier":
                    bunifuPages1.SetPage(tabPage3);
                    break;
                case "CONTRAT":
                    bunifuPages1.SetPage(tabPage2);
                    break;
            }
            dataGridViewlist_contrat.DataSource = con.FindByValues(ele=> ele.numdossier==THEME.numdossier).Select(ele => new contart()
            {
                IDCONTART=ele.Idcontrat,
                TYPECONTRAT=ele.typecontrat,
                DTFIN = (DateTime)ele.Datefermeture,
                dtov = (DateTime)ele.dateouverture
            }).ToList();
            THEME.add_btn_to_datagrid(dataGridViewlist_contrat, "DETAIL", "DETAIL", 4);
        }
        private void button_add_contrat_Click(object sender, EventArgs e)
        {
            if (bunifuDropdowntype_contrat.Text == "PRET BANQUE")
            {
                using (contrat_pret_banque f1 = new contrat_pret_banque(bunifuDropdowntype_contrat.Text)) { f1.ShowDialog(); }
            }
            else
            {
                using (contrat f1 = new contrat(bunifuDropdowntype_contrat.Text)) { f1.ShowDialog(); }
            }
        }
        private void button_add__partes_Click(object sender, EventArgs e)
        {
            if (THEME.numdossier == "")
                return;
            var parte = new parte();
            parte.idClient = int.Parse(bunifuDropdownclient.SelectedValue.ToString());
            parte.Typeclient = bunifuDropdowntypeclient.Text;
            parte.Condition = bunifuTextBoxcondition.Text;
            parte.numdossier = THEME.numdossier;
            partee.Add(parte);
        }

        private void ButtonAdd_FICHIER_Click(object sender, EventArgs e)
        {
            if (THEME.numdossier == "")
                return;
            var file = new fichiers_dossier();
            file.titre = textBoxtitre.Text;
            file.path = textBoxfile.Text;
            file.descreption = textBoxdesc.Text;
            file.numdossier = THEME.numdossier;
            csl_Bl_Fichier_dossier.Add(file);
        }

        private void dataGridViewlist_contrat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                if (dgv.Columns[e.ColumnIndex].Name == "DETAIL")
                {
                    THEME.id_C = int.Parse(dgv.Rows[e.RowIndex].Cells[dgv.Columns["ID CONTART"].Name].Value.ToString());
                    THEME.navigat(typeof(DETAIL_CONTRAT),(Panel)this.Parent);
                }              
            }
        }

        private void bunifuDataGridView_list_file_dossier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    public class contart
    {
        [DisplayName("ID CONTART")]
        public int IDCONTART { get; set; }
        [DisplayName("TYPE CONTRAT")]
        public string TYPECONTRAT { get; set; }
        [DisplayName("DATE FERMETURE")]
        public DateTime DTFIN { get; set; }
        [DisplayName("DATE OUVERTURE")]
        public DateTime dtov { get; set; }
    }
}
