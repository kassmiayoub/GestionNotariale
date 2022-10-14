using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using gestion_cabinet_notarial.Properties;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;

namespace gestion_cabinet_notarial
{
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ShowTaskBar();           
            mainMenu1.AddTheMenu();
            //ADD_DOSSIER dossier = new ADD_DOSSIER() { Visible = true };
            //dossier.Width = MAINPANEL.Width;
            //dossier.Height = MAINPANEL.Height;
            //MAINPANEL.Controls.Add(dossier);
            THEME.p = MAINPANEL;
            THEME.add_controls_to_panel();
            THEME.navigat(typeof(Accueil));
            //Control c = MAINPANEL.Controls.Cast<Control>().First(ele => ele.GetType() == typeof(ADD_DOSSIER));
            //c.Width = MAINPANEL.Width;
            //c.Height = MAINPANEL.Height;
            //c.Visible = true;
            BunifuDropdown dtypeclient = (BunifuDropdown)THEME.detail_dossier.Controls["bunifuPages1"].Controls["tabPage1"].Controls["panel2"].Controls["bunifuDropdowntypeclient"];
            dtypeclient.Items.Add("VENDUERE");
            dtypeclient.Items.Add("ACHETEURE");
            dtypeclient.Items.Add("modan");
            dtypeclient.Items.Add("modin"); 
            BunifuDropdown typecontrat = (BunifuDropdown)THEME.detail_dossier.Controls["bunifuPages1"].Controls["tabPage2"].Controls["bunifuDropdowntype_contrat"];
            typecontrat.Items.Add("VENTE");
            typecontrat.Items.Add("PROMESE DE VENTE");
            typecontrat.Items.Add("PROMESE DE LOCATION");
            typecontrat.Items.Add("PRET BANQUE");
            typecontrat.Items.Add("credit deux personne");
            typecontrat.Items.Add("ECHANGE");
            typecontrat.Items.Add("LOCATION");
        }
        void ShowTaskBar()
        {
            int x = SystemInformation.WorkingArea.Width;
            int y = SystemInformation.WorkingArea.Height;
            this.Size = new Size(x, y);
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
                if(THEME.BackControls.Count == 0 || THEME.BackControls.Count == 1)
                {
                    return;
                }
                if (THEME.BackControls.Count - 1 > 0)
                {
                    THEME.BackControls.RemoveAt(THEME.BackControls.Count - 1);
                }
                Type C = THEME.BackControls[THEME.BackControls.Count - 1];
                THEME.navigate = 1;
                THEME.navigat(C);
        }
    }
}
