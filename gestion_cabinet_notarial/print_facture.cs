using gestion_cabinet_notarial.BL;
using gestion_cabinet_notarial.context;
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
        cls_bl_facture cls_Bl_Facture = new cls_bl_facture();
        cls_bl_dossier cls_Bl_Dossier = new cls_bl_dossier();
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
        public print_facture()
        {
            InitializeComponent();
        }
        private void print_facture_Load(object sender, EventArgs e)
        {
            string ndossier = THEME.numdossier;
            facture_report f = new facture_report();
            facture facture = new facture();
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
            f.SetParameterValue("typecontart", typecontart);
            f.SetParameterValue("ndossier", ndossier);
            f.SetParameterValue("paye", paye);
            f.SetParameterValue("reste", reste);
            f.SetParameterValue("etatpayement", etatpayement);
            var dossier = cls_Bl_Dossier.FindByValues(el => el.Numdossier == ndossier).FirstOrDefault();
            if(dossier.typedossier != "change")
            {
                f.SetParameterValue("foncier", foncier);
            }
            else
            {
                f.SetParameterValue("foncier", "");
            }
            if (dossier.typedossier == "vente"|| dossier.typedossier == "location")
            {
                f.SetParameterValue("PRIXVENTE", dossier.PRIX_ACQUISITION);
                f.SetParameterValue("typeprix", $"PRIX DE {dossier.typedossier}");
            }
            else
            {
                f.SetParameterValue("PRIXVENTE", "");
                f.SetParameterValue("typeprix", "");
            }
            string yers = DateTime.Now.ToString("yy");
            string mois = DateTime.Now.ToString("MM");
            string day = DateTime.Now.ToString("dd");
            int count = cls_Bl_Facture.GetAll().Count()+1;
            string Nfacture = yers+ mois+ day+ count.ToString();
            facture.Nfacture = Nfacture;
            facture.utilisatuer = THEME.id_user;
            facture.idcontrat = THEME.id_C;
            facture.date = DateTime.Now.Date;
            facture.ancfcc = paye_Ancfcc;
            facture.enrigestrement = paye_enregitrement;
            facture.tamber = paye_tamber;
            facture.hpnoraires = paye_honorair;
            cls_Bl_Facture.Add(facture);

            crystalReportViewer1.ReportSource = f;

            
        }
    }
   
}

