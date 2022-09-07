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
    public partial class CTL_LIST_UTILATUER : UserControl
    {
        CSL_BL_UTILISATUER user = new CSL_BL_UTILISATUER();
        CSL_BL_FUNCTION FUNC = new CSL_BL_FUNCTION();
        public CTL_LIST_UTILATUER()
        {
            InitializeComponent();
        }
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
             var ListDataSource = user.GetAll().Select(ele => new 
            {
               UTILISATUER = ele.utilisateur1,
               NOM = ele.Nom,
               PRENOM = ele.Prenom
            }).ToList();
            ListDataSource = bunifuTextBox_USER.Text.Trim() != "" ?
               ListDataSource.Where(ele => ele.UTILISATUER.ToString() == bunifuTextBox_USER.Text).ToList() :
               ListDataSource;
            ListDataSource = bunifuTextBox_NOM.Text.Trim() != "" ?
               ListDataSource.Where(ele => ele.NOM.ToString() == bunifuTextBox_NOM.Text).ToList() :
               ListDataSource;            
            ListDataSource = bunifuTextBox_PRENOM.Text.Trim() != "" ?
               ListDataSource.Where(ele => ele.PRENOM.ToString() == bunifuTextBox_PRENOM.Text).ToList() :
               ListDataSource;
            bunifuDataGridView_list_utilisatuer.DataSource = ListDataSource;
        }
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            THEME.id_user_modifier = bunifuTextBox_USER.Text;
            THEME.navigat(typeof(CTL_PARAMETER_AJOUTER_UTILISATUER));
        }
        private void bunifuDataGridView_list_utilisatuer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bunifuTextBox_USER.Text = bunifuDataGridView_list_utilisatuer.Rows[e.RowIndex].Cells[0].Value.ToString();
                bunifuTextBox_NOM.Text = bunifuDataGridView_list_utilisatuer.Rows[e.RowIndex].Cells[1].Value.ToString();
                bunifuTextBox_PRENOM.Text = bunifuDataGridView_list_utilisatuer.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch
            {
                return;
            }
        }
        private void ButtonInit_Click(object sender, EventArgs e)
        {
            THEME.vider(this);
        }
    }
}
