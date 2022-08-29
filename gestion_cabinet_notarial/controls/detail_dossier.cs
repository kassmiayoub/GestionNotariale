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
                    try
                    {
                        THEME.id_C = int.Parse(dgv.Rows[e.RowIndex].Cells[dgv.Columns[0].Name].Value.ToString());
                    }
                    catch
                    {
                        THEME.id_C = int.Parse(dgv.Rows[e.RowIndex].Cells[dgv.Columns[1].Name].Value.ToString());
                    }
                    THEME.navigat(typeof(DETAIL_CONTRAT));
                }              
            }
        }

        private void bunifuDataGridView_list_file_dossier_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    DialogResult dr = MessageBox.Show("VOUS L VRAIMENT SUPPRIMER ?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        int idfile = int.Parse(dgv.Rows[e.RowIndex].Cells["IDFILE"].Value.ToString());
                        csl_Bl_Fichier_dossier.Remove(csl_Bl_Fichier_dossier.FindById(idfile));
                        csl_Bl_Fichier_dossier.SaveChanges();
                    }
                }
            }
        }

        private void PARTES_OF_CONTRAT_Click_1(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(tabPage1);
            var ListDataSource = new List<c>();
            ListDataSource = new cls_bl_partes().GetAll().Where(x => x.numdossier == THEME.numdossier).Select(x => new c()
            {
                TYPECLIENT = x.Typeclient,
                NOMCOMPLET = $"{x.client.Nom} {x.client.Prenom}",
                CONDITION= x.Condition
            }).ToList();
            bunifuDataGridView_list_partes.DataSource=ListDataSource;
        }

        private void CONTRAT_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(tabPage2);
            dataGridViewlist_contrat.DataSource = con.FindByValues(ele => ele.numdossier == THEME.numdossier).Select(ele => new contart()
            {
                IDCONTART = ele.Idcontrat,
                TYPECONTRAT = ele.typecontrat,
                DTFIN = (DateTime)ele.Datefermeture,
                dtov = (DateTime)ele.dateouverture
            }).ToList();
            THEME.add_btn_to_datagrid(dataGridViewlist_contrat, "DETAIL", "DETAIL", 4);
        }

        private void FICHIERJOINT_dossier_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(tabPage3);
            String a = THEME.numdossier ;
            var files = csl_Bl_Fichier_dossier.FindByValues(ele => (ele.numdossier == a)).Select(ele => new file()
            {
                IDFILE = (int)ele.idfile,
                TITRE = ele.titre,
                DESCREPTON = ele.descreption,
                FILE = ele.path
            }).ToList();
            bunifuDataGridView_list_file_dossier.DataSource = files;
            THEME.add_btn_to_datagrid(bunifuDataGridView_list_file_dossier, "sipprision", "supprimer", 4);
            THEME.add_btn_to_datagrid(bunifuDataGridView_list_file_dossier, "affichage", "affichier", 5);

        }

        private void ButtonSavefile_fichier_joint_dossier_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textBoxfile.Text = ofd.FileName;
                }
            }
        }

        private void button8SERCHE_FICHIER_DOSSIER_Click(object sender, EventArgs e)
        {
            var files = csl_Bl_Fichier_dossier.GetAll().Select(ele => new filee()
            {
                IDFILE = (int)ele.idfile,
                TITRE = ele.titre,
                DESCREPTON = ele.descreption,
                FILE = ele.path
            }).ToList();
            files = textBoxtitre.Text != "" ?
                files.Where(ele => ele.TITRE.ToString() == textBoxtitre.Text).ToList() :
                files;
            bunifuDataGridView_list_file_dossier.DataSource = files;
            THEME.add_btn_to_datagrid(bunifuDataGridView_list_file_dossier, "sipprision", "supprimer", 4);
            THEME.add_btn_to_datagrid(bunifuDataGridView_list_file_dossier, "affichage", "affichier", 5);
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
    public class file
    {
        [DisplayName("IDFILE")]
        public int IDFILE { get; set; }
        [DisplayName("TITRE")]
        public string TITRE { get; set; }
        [DisplayName("DESCREPTON")]
        public string DESCREPTON { get; set; }
        [DisplayName("FILE")]
        public string FILE { get; set; }
    }
    public class c
    {       
        [DisplayName("NOMCOMPLET")]
        public string NOMCOMPLET { get; set; }
        [DisplayName("TYPE CLIENT")]
        public string TYPECLIENT { get; set; }
        [DisplayName("CONDITION")]
        public string CONDITION { get; set; }
    }
}
