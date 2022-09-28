using System;
using System.Windows.Forms;
using gestion_cabinet_notarial.Properties;

namespace gestion_cabinet_notarial
{
    public partial class CONTROL_CONTROL_BOX : UserControl
    {
        public CONTROL_CONTROL_BOX()
        {
            InitializeComponent();
        }

        private void ClosePictureBox_MouseHover(object sender, EventArgs e) => ClosePictureBox.Image = Resources.CloseButtonMouseHover;

        private void ClosePictureBox_MouseLeave(object sender, EventArgs e) => ClosePictureBox.Image = Resources.CloseButtonMouseLeave;

        private void ClosePictureBox_Click(object sender, EventArgs e) => ParentForm.Close();

        private void MinimizePictureBox_MouseHover(object sender, EventArgs e) => MinimizePictureBox.Image =Resources.MinimizeButtonMouseHover;

        private void MinimizePictureBox_MouseLeave(object sender, EventArgs e) => MinimizePictureBox.Image =Resources.MinimizeButtonMouseLeave;

        private void MinimizePictureBox_Click(object sender, EventArgs e) => ParentForm.WindowState = FormWindowState.Minimized;
    }
}
