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
        }

        private void mainMenu1_Load(object sender, EventArgs e)
        {
            
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
            //Control c = MAINPANEL.Controls.Cast<Control>().First(ele => ele.GetType() == typeof(ADD_DOSSIER));
            //c.Width = MAINPANEL.Width;
            //c.Height = MAINPANEL.Height;
            //c.Visible = true;
            MessageBox.Show(THEME.detail_dossier.Controls.Count+"");
            BunifuDropdown dtypeclient = (BunifuDropdown)THEME.detail_dossier.Controls["bunifuPages1"].Controls["tabPage1"].Controls["panel2"].Controls["bunifuDropdowntypeclient"];
            dtypeclient.Items.Add("VENDUERE");
            dtypeclient.Items.Add("ACHETEURE");        
            BunifuDropdown typecontrat = (BunifuDropdown)THEME.detail_dossier.Controls["bunifuPages1"].Controls["tabPage2"].Controls["bunifuDropdowntype_contrat"];
            typecontrat.Items.Add("VENTE");
            typecontrat.Items.Add("PROMESE");
            typecontrat.Items.Add("PRET BANQUE");
            MessageBox.Show(MAINPANEL.Controls.Count.ToString());

        }
        void ShowTaskBar()
        {
            int x = SystemInformation.WorkingArea.Width;
            int y = SystemInformation.WorkingArea.Height;
            this.Size = new Size(x, y);
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
    }
}
