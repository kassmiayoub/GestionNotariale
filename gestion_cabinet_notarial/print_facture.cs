using gestion_cabinet_notarial.reports;
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
    public partial class print_facture : Form
    {
        static public string foncier;
        static public string typecontart;
        static public string paye;
        static public string reste;
        static public double montant_enregitrement;
        static public double paye_enregitrement;
        static public double montant_honorair;
        static public double paye_honorair;
        static public double montant_tamber;
        static public double paye_tamber;
        static public double montant_Ancfcc;
        static public double paye_Ancfcc;
        static public string etatpayement;
        static public string ndossier = THEME.numdossier;
        public print_facture()
        {
            InitializeComponent();
        }
        private void print_facture_Load(object sender, EventArgs e)
        {
            facture f = new facture();
            DataSet1 ds = new DataSet1();

            DATABASE.getinfocabinet().Fill(ds.DataTable1);
            f.SetDataSource(ds);
            f.SetParameterValue("montant_enregitrement", montant_enregitrement);
            f.SetParameterValue("paye_enregitrement", paye_enregitrement);
            f.SetParameterValue("montant_honorair", montant_honorair);
            f.SetParameterValue("paye_honorair", paye_honorair);
            f.SetParameterValue("montant_tamber", montant_tamber);
            f.SetParameterValue("paye_tamber", paye_tamber);
            f.SetParameterValue("montant_Ancfcc", montant_Ancfcc);
            f.SetParameterValue("paye_Ancfcc", paye_Ancfcc);
            //recu.SetParameterValue("client", client);
            //recu.SetParameterValue("date", date);
            //recu.SetParameterValue("typecharge", typecharge);
            //recu.SetParameterValue("typepaye", typepaye);
            //recu.SetParameterValue("ice_cin", ice_cin);
            //recu.SetParameterValue("idclient", idclient);
            //recu.SetParameterValue("banque", banque);
            f.SetParameterValue("foncier", foncier);
            f.SetParameterValue("typecontart", typecontart);
            f.SetParameterValue("ndossier", ndossier);
            f.SetParameterValue("paye", paye);
            f.SetParameterValue("reste", reste);
            f.SetParameterValue("etatpayement", etatpayement);
            f.SetParameterValue("PRIXVENTE",THEME.prix) ;
            crystalReportViewer1.ReportSource = f;
            //crystalReportViewer1.Refresh();
        }
    }
   
}

