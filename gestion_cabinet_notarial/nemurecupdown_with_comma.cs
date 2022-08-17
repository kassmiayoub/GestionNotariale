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
            double x = double.Parse(textBox1.Text);
            textBox1.Text = (x - 0.01).ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            textBox1.Text = (x + 0.01).ToString();
        }
    }
}
