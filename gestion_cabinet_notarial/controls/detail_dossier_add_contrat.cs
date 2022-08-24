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
    public partial class detail_dossier_add_contrat : UserControl
    {
        public detail_dossier_add_contrat()
        {
            InitializeComponent();
        }

        private void detail_dossier_add_contrat_Load(object sender, EventArgs e)
        {
            comboBoxtype_contrat.Items.Add("vente");
            comboBoxtype_contrat.Items.Add("promese");
            comboBoxtype_contrat.Items.Add("pret banque");
            if (info_contrat.x == 1)
            {
                dataGridViewlist_contrat.Rows.Add(info_contrat.type_contrat, info_contrat.dated, info_contrat.datef, info_contrat.useer);
            }
            info_contrat.x=0;
        }

        private void ButtonAdd_vontrat_Click(object sender, EventArgs e)
        {
            if(comboBoxtype_contrat.Text== "pret banque")
            {
                using (contrat_pret_banque f1 = new contrat_pret_banque(comboBoxtype_contrat.Text)) { f1.ShowDialog(); }
                
            }
            else
            {
                using (contrat f1 = new contrat(comboBoxtype_contrat.Text)) { f1.ShowDialog(); }

            }
        }

        private void dataGridViewlist_contrat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                THEME.navigat(typeof(DETAIL_CONTRAT), (Panel)this.Parent);
            }
        }

        private void ButtonAdd_partes_Click(object sender, EventArgs e)
        {

        }
    }
}
