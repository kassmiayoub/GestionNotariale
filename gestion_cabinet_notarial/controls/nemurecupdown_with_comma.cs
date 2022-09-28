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
    public partial class nemurecupdown_with_comma : UserControl
    {
        public nemurecupdown_with_comma()
        {
            InitializeComponent();
        }
        private void PictureBoxArrow_Click(object sender, EventArgs e)
        {
            if (double.Parse(textBox_porsontage.Text) == 0)
                return;
            double x = double.Parse(textBox_porsontage.Text);
            textBox_porsontage.Text = (x - 0.01).ToString();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox_porsontage.Text);
            textBox_porsontage.Text = (x + 0.01).ToString();
        }
        private void textBox_porsontage_KeyPress(object sender, KeyPressEventArgs e)
        {
            string[] n = textBox_porsontage.Text.Split('.');
            if (n.Length == 2)
            {
                if (n[1].Length == 3)
                {                   
                   e.Handled = true;
                   return;
                }
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}
