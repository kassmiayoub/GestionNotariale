using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_cabinet_notarial.controls
{
    public partial class statsitic : UserControl
    {
        public statsitic()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void statsitic_Load(object sender, EventArgs e)
        {
            Point p1 = new Point(182,169);
            Point p2 = new Point(103,166);
            Point p3 = new Point(117,112);
            Point p4 = new Point(126,115);
            Point p5 = new Point(169,136);
            Point p6 = new Point(100,168);
            Point[] pl = { p1, p2, p3, p4, p5,p6 };
            this.CreateGraphics().DrawCurve(Pens.Red, pl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("x = "+Cursor.Position.X+" et y = "+Cursor.Position.Y);
        }

        private void statsitic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("x = " + Cursor.Position.X + " et y = " + Cursor.Position.Y);
        }
    }
}
