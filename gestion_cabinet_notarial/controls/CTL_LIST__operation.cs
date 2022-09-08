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
    public partial class CTL_LIST__operation : UserControl
    {
        CSL_BL_UTILISATUER user = new CSL_BL_UTILISATUER();
        static CLS_BL_LOG LOG = new CLS_BL_LOG();
        public CTL_LIST__operation()
        {
            InitializeComponent();
        }

        private void checkBox_filter_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_filter.Checked)
                panel_filter.Enabled = true;
            else
                panel_filter.Enabled = false;
        }

        private void CTL_LIST_UTILISATUER_VisibleChanged(object sender, EventArgs e)
        {
            var A = new List<users>();
            A = user.GetAll().Select(ele => new users()
            {
                USER =  ele.utilisateur1,
                NOMCOMPLET = ele.Nom + " " + ele.Prenom                      
            }).ToList();
            bunifuDropdown_users.DataSource = A;
            bunifuDropdown_users.DisplayMember = "NOMCOMPLET";
            bunifuDropdown_users.ValueMember = "USER";
        }

        private void ButtonSearch_operation_Click(object sender, EventArgs e)
        {
            var A = LOG.GetAll().Where(ele => ele.utilisateur == bunifuDropdown_users.SelectedValue.ToString()); 
            if (checkBox_filter.Checked)
            {
              A = A.Where(ele => ele.Date >= Convert.ToDateTime(bunifuDatePicker_D.Value) && ele.Date <= Convert.ToDateTime(bunifuDatePicker_F.Value));
            }
            bunifuDataGridView_list_operation.DataSource = A;
        }
    }
    public class users
    {
        [DisplayName("USER")]
        public string USER { get; set; }
        [DisplayName("NOMCOMPLET")]
        public string NOMCOMPLET { get; set; }
    }
}
