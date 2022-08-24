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
    public partial class LIST_CLIENT : UserControl
    {
        public LIST_CLIENT()
        {
            InitializeComponent();
        }

        private void LIST_CLIENT_Load(object sender, EventArgs e)
        {
            labelCIN.Visible = false;
            labelIF.Visible = false;
            textBoxCIN.Visible = false;
            textBoxIF.Visible = false;
            comboBoxtype_client.Items.Add("profisionnel");
            comboBoxtype_client.Items.Add("normal");
        }

        private void comboBoxtype_client_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (comboBoxtype_client.Text == "normal")
            {
                textBoxCIN.Visible = true;
                labelCIN.Visible = true;
                textBoxIF.Visible = false;
                labelIF.Visible = false;
                labelCIN.Text = "CIN";
            }
            else
            {
                labelCIN.Visible = true;
                labelCIN.Text = "CIE";
                labelIF.Visible = true;
                textBoxCIN.Visible = true;
                textBoxIF.Visible = true;
            }
        }
    }
}
