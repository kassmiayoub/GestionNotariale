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
        cls_bl_partes parte = new cls_bl_partes();
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
        }
    }
}
