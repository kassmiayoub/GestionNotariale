using System;
using System.Collections.Generic;
using System.ComponentModel;
using gestion_cabinet_notarial.reports;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_cabinet_notarial
{
    public partial class print : Form
    {
        static public string montant;
        static public string foncier;
        static public string client;
        static public string date;
        static public string typecharge;
        static public string typepaye;
        static public string banque;
        static public string typecontart;
        static public string idclient;
        static public string ice_cin;
        static public string ndossier ;
        static public string montantp;
        public print()
        {
            InitializeComponent();
        }
        private void print_Load(object sender, EventArgs e)
        {
            recu_report recu = new recu_report();
           // DataSet ds = new DataSet();
           // ds.Tables.Add(DATABASE.getinfocabinet());
           // recu.SetDataSource(ds);
            recu.SetParameterValue("montant", montant);
            recu.SetParameterValue("montantp", montantp);
            recu.SetParameterValue("foncier", foncier);
            recu.SetParameterValue("client", client);
            recu.SetParameterValue("date", date);
            recu.SetParameterValue("typecharge", typecharge);
            recu.SetParameterValue("typepaye", typepaye);
            recu.SetParameterValue("ice_cin", ice_cin);
            recu.SetParameterValue("idclient", idclient);
            recu.SetParameterValue("banque", banque);
            recu.SetParameterValue("typecontart", typecontart);
            recu.SetParameterValue("ndossier", ndossier);
            crystalReportViewer1.ReportSource = recu;            
        }
    }
}
