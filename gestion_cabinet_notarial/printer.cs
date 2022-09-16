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
    public partial class _ : Form
    {
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;

        public _()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(912, 491);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // _
            // 
            this.ClientSize = new System.Drawing.Size(912, 491);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "_";
            this.Load += new System.EventHandler(this.@__Load);
            this.ResumeLayout(false);

        }

        private void __Load(object sender, EventArgs e)
        {

        }
    }
}
