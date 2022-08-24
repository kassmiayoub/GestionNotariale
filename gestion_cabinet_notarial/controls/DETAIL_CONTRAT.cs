using Bunifu.UI.WinForms.BunifuButton;
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
    public partial class DETAIL_CONTRAT : UserControl
    {
        public DETAIL_CONTRAT()
        {
            InitializeComponent();
        }

        private void PARTES_OF_CONTRAT_Click(object sender, EventArgs e)
        {
           string name = ((BunifuButton)sender).Name;
            switch (name)
            {
                case "PARTES_OF_CONTRAT":
                    bunifuPages1.SetPage(partes);
                    break;
                case "PAYEMENTCLIENT_CONTRAT":
                    bunifuPages1.SetPage(payeclient);
                    break;
                case "NOTAIREVERSEMENT_CONTRAT":
                    bunifuPages1.SetPage(notaireverc);
                    break;
                case "FICHIERJOINT_CONTRAT":
                    bunifuPages1.SetPage(fichierjoint);
                    break;
                case "STATISTIC_CONTRAT":
                    bunifuPages1.SetPage(statistic);
                    break;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
