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
    public partial class Accueil : UserControl
    {
        CLS_NOTE cLS_NOTE = new CLS_NOTE();
        cls_bl_contrat con = new cls_bl_contrat();
        cls_bl_dossier cls_Bl_Dossier = new cls_bl_dossier();
        cls_bl_partes_S Signature = new cls_bl_partes_S();
        List<dossierSerche> Listdossier = new List<dossierSerche>();
        string contrat_or_dossier = "dossier";
        public Accueil()
        {
            InitializeComponent();
        }
        private void Accueil_VisibleChanged(object sender, EventArgs e)
        {            
            if (this.Visible)
            {
                //bunifuDataGridView_accueil.Columns.Clear();
                label_alert.Text = (cLS_NOTE.GetAll().Where(ele => ele.date_alere == DateTime.Now || ele.date_alere == null).Count()).ToString();
                label_dossiere_encours.Text = (cls_Bl_Dossier.GetAll().Where(cond => cond.Datefermeture == null).Count()).ToString();
                label_dossier_passer.Text= (cls_Bl_Dossier.GetAll().Where(cond => cond.Datefermeture == DateTime.Now).Count()).ToString();
                label_contart.Text = con.FindByValues(ele => ele.dateouverture == DateTime.Now).Count().ToString();
                var documents = Signature.GetAll().Where(condition => condition.DateSignatur == null).ToList();
                label_contrat_pas_signature.Text = documents.GroupBy(x => x.idcontrat).Select(g => g.First()).Count().ToString();
                Listdossier = cls_Bl_Dossier.GetAll().Where(cond => cond.Datefermeture == null).Select(ele => new dossierSerche()
                {
                    N_DOSSIER = ele.Numdossier,
                    DATE_F = ele.Datefermeture.ToString(),
                    DATE_O = ele.dateouverture.ToString(),
                    OBJET = ele.Objet,
                    TITRE_F = ele.Titrefoncier,
                    PRIX = ele.PRIX_ACQUISITION.ToString()
                }).ToList();
                bunifuDataGridView_accueil.DataSource = Listdossier;
                THEME.add_btn_to_datagrid(bunifuDataGridView_accueil, "DETAIL", "DETAIL", 6);
                contrat_or_dossier = "dossier";
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //bunifuDataGridView_accueil.Columns.Clear();
            if (bunifuDataGridView_accueil.Columns["DETAIL"] != null)
            {
                bunifuDataGridView_accueil.Columns.Remove("DETAIL");
            }
            var a = cLS_NOTE.GetAll().Where(ele => ele.date_alere == DateTime.Now || ele.date_alere == null).Select(s => new { s.Idnote,s.Text, Creation = s.date ,s.utilisateur}).ToList();
            bunifuDataGridView_accueil.DataSource = a;
        }
        private void bunifuPanel_dossiers_encour_Click(object sender, EventArgs e)
        {
            //bunifuDataGridView_accueil.Columns.Clear();
            bunifuDataGridView_accueil.DataSource = Listdossier;
            THEME.add_btn_to_datagrid(bunifuDataGridView_accueil, "DETAIL", "DETAIL", 6);
            contrat_or_dossier = "dossier";
        }
        private void bunifuPanel_dossiers_passer_Click(object sender, EventArgs e)
        {
            //bunifuDataGridView_accueil.Columns.Clear();
            var ListDataSource = new List<dossierSerche>();
            ListDataSource = cls_Bl_Dossier.GetAll().Where(cond => cond.Datefermeture == DateTime.Now).Select(ele => new dossierSerche()
            {
                N_DOSSIER = ele.Numdossier,
                DATE_F = ele.Datefermeture.ToString(),
                DATE_O = ele.dateouverture.ToString(),
                OBJET = ele.Objet,
                TITRE_F = ele.Titrefoncier,
                PRIX = ele.PRIX_ACQUISITION.ToString()
            }).ToList();
            bunifuDataGridView_accueil.DataSource = ListDataSource;
            THEME.add_btn_to_datagrid(bunifuDataGridView_accueil, "DETAIL", "DETAIL", 6);
            contrat_or_dossier = "dossier";
        }
        private void bunifuPanel_contarts_j_Click(object sender, EventArgs e)
        {
            //bunifuDataGridView_accueil.Columns.Clear();
            bunifuDataGridView_accueil.DataSource = con.FindByValues(ele => ele.dateouverture== DateTime.Now).Select(ele => new contart()
            {
                IDCONTART = ele.Idcontrat,
                TYPECONTRAT = ele.typecontrat,
                DTFIN = (DateTime)ele.Datefermeture,
                dtov = (DateTime)ele.dateouverture
            }).ToList();
            contrat_or_dossier = "contart";
            THEME.add_btn_to_datagrid(bunifuDataGridView_accueil, "DETAIL", "DETAIL", 4);
        }
        private void bunifuDataGridView_accueil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             DataGridView dgv = (DataGridView)sender;
            if (dgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                if (dgv.Columns[e.ColumnIndex].Name == "DETAIL")
                {
                    if (contrat_or_dossier == "contart")
                    {
                        THEME.id_C = int.Parse(dgv.Rows[e.RowIndex].Cells[dgv.Columns["IDCONTART"].Name].Value.ToString());
                        THEME.prix = con.FindByValues(ele => ele.Idcontrat == THEME.id_C).Select(s => s.dossier.PRIX_ACQUISITION).First().Value;
                        THEME.navigat(typeof(DETAIL_CONTRAT));
                    }
                    else
                    {                      
                        THEME.numdossier = dgv.Rows[e.RowIndex].Cells[dgv.Columns["N_DOSSIER"].Name].Value.ToString();
                        THEME.prix =Convert.ToDouble(dgv.Rows[e.RowIndex].Cells[dgv.Columns["PRIX"].Name].Value.ToString());
                        THEME.navigat(typeof(detail_dossier));
                    }
                }               
            }
        }
        private void bunifuPanelcontrat_non_signature_Click(object sender, EventArgs e)
        {
            bunifuDataGridView_accueil.DataSource = Signature.GetAll().Where(condition => condition.DateSignatur == null).GroupBy(x => x.idcontrat).Select(g => g.First()).Select(ele => new contart()
            {
                IDCONTART = ele.contrat.Idcontrat,
                TYPECONTRAT = ele.contrat.typecontrat,
                DTFIN = (DateTime)ele.contrat.Datefermeture,
                dtov = (DateTime)ele.contrat.dateouverture
            }).ToList();
            contrat_or_dossier = "contart";
            THEME.add_btn_to_datagrid(bunifuDataGridView_accueil, "DETAIL", "DETAIL", 4);           
        }
    }
}