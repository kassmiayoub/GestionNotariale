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
        private void button2_Click(object sender, EventArgs e)
        {
            THEME.numdossier = textBox_N_dossier.Text;
            THEME.prix =double.Parse(textBox_prix.Text);
            THEME.navigat(typeof(detail_dossier), (Panel)this.Parent);           
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
            a.Status = 1;
            cls_Bl_Dossier.Add(a);
        }
    }
}
