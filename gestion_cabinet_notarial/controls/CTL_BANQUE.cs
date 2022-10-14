using gestion_cabinet_notarial.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using gestion_cabinet_notarial.context;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_cabinet_notarial.controls
{
    public partial class CTL_BANQUE : UserControl
    {
        cls_bl_banque cls_Bl_Banque = new cls_bl_banque();
        banque ban = new banque();
        public CTL_BANQUE()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void CTL_BANQUE_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                var ListDataSource1 = cls_Bl_Banque.GetAll().Where(x => x.Idbanque != 3).Select(s => new {s.Idbanque,s.Libbele}).ToList();
                bunifuDataGridView_list_banque.DataSource = ListDataSource1;
            }
        }
        private void ButtonAdd_banque_Click(object sender, EventArgs e)
        {
            if (bunifuTextBox_banque.Text.Trim() != ""){
                var banque = new banque();
                banque.Libbele = bunifuTextBox_banque.Text;
                banque.utilisateur = THEME.id_user;
                cls_Bl_Banque.Add(banque);
                THEME.operation($"AJOUTR UN BANQUE");
                MessageBox.Show("la banque ajouter avec seccess");
                var ListDataSource1 = cls_Bl_Banque.GetAll().Where(x => x.Idbanque != 3).Select(s => new { s.Idbanque, s.Libbele }).ToList();
                bunifuDataGridView_list_banque.DataSource = ListDataSource1;
            }
        }
        private void Button_vider_banque_Click(object sender, EventArgs e)
        {
            bunifuTextBox_banque.Text = "";
        }
        private void ButtonEdit_banque_Click(object sender, EventArgs e)
        {
            if (bunifuTextBox_banque.Text.Trim() != "")
                return;
            ban.Libbele = bunifuTextBox_banque.Text;
            cls_Bl_Banque.SaveChanges();
            bunifuTextBox_banque.Text = "";
            MessageBox.Show("la banque modifier avec seccess");
            THEME.operation($"MODIFIER UN BANQUE");
        }
        private void bunifuDataGridView_list_banque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ban = cls_Bl_Banque.FindById(int.Parse(bunifuDataGridView_list_banque.Rows[e.RowIndex].Cells[0].Value.ToString()));
                bunifuTextBox_banque.Text = ban.Libbele;
            }
            catch
            {
                return;
            }        
        }
    }
}
