using gestion_cabinet_notarial.BL;
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
    public partial class chrat : UserControl
    {
        cls_bl_payement paye = new cls_bl_payement();

        public chrat()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            var list = paye.FindByValues(ele => ele.typecharge == "Honoraires" && ele.type == "charge" ).GroupBy(ele => ele.Date).Select(ele => new
            {   //DEPANCES= ele.Key,              
                Honoraires = ele.Sum(el => el.Montant),
               date = ele.Key.Value.Date.Day.ToString()
            }).ToList();
            chart1.DataSource = list;
            chart1.Series["Honoraires"].YValueMembers = "Honoraires";
            chart1.Series["Honoraires"].XValueMember = "date";
            chart1.Series["Honoraires"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            for (int i = 1; i <= DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month); i++)
            {

            }
        }
    }
}
