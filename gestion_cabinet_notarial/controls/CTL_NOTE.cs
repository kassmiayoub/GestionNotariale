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
    public partial class CTL_NOTE : UserControl
    {
        CLS_NOTE cLS_NOTE = new CLS_NOTE();
        public CTL_NOTE()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        private void checkBox_filter_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_filter.Checked)
                panel_filter.Enabled = true;
            else
                panel_filter.Enabled = false;
        }
        private void CTL_NOTE_Load(object sender, EventArgs e)
        {
            panel_filter.Enabled = false;
        }
        private void ButtonAdd_note_Click(object sender, EventArgs e)
        {
            if (richTextBox_text.Text.Trim() == "")
                return;
            var note = new note();
            note.Text = richTextBox_text.Text;
            note.date = DateTime.Now;
            if (!checkBox_tout_j.Checked)
                note.date_alere = Convert.ToDateTime(bunifuDatePicker_date_alert.Value);
            cLS_NOTE.Add(note);
            richTextBox_text.Text = "";
            THEME.operation($"AJOUTER UN NOTE");
        }
        private void Button_vider_note_Click(object sender, EventArgs e)
        {
            richTextBox_text.Text = "";
        }
        private void CTL_NOTE_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                bunifuDataGridView_list_note.DataSource = cLS_NOTE.GetAll();
            }
        }
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            bunifuDataGridView_list_note.DataSource = cLS_NOTE.GetAll().Where(ele => ele.date >=Convert.ToDateTime(bunifuDatePicker_D.Value) && ele.date <= Convert.ToDateTime(bunifuDatePicker_F.Value));
        }
    }
}
