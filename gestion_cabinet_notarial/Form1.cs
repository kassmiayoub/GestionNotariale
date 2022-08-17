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

namespace gestion_cabinet_notarial
{
    public partial class Form1 : Form
    {
        public Form1()
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
            THEME.add_controls_to_panel(MAINPANEL);
            Control c = MAINPANEL.Controls.Cast<Control>().First(ele => ele.GetType() == typeof(ADD_DOSSIER));
            c.Width = MAINPANEL.Width;
            c.Height = MAINPANEL.Height;
            c.Visible = true;

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
