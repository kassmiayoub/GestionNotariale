﻿using Bunifu.UI.WinForms.BunifuButton;
using gestion_cabinet_notarial.BL;
using gestion_cabinet_notarial.context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_cabinet_notarial
{
    public partial class DETAIL_CONTRAT : UserControl
    {
        int parte = 0;
        double montant_reste;
        cls_bl_contrat con = new cls_bl_contrat();
        cls_bl_partes_S Signature = new cls_bl_partes_S();
        csl_bl_fichier_contart fichier_con = new csl_bl_fichier_contart();
        cls_bl_dossier dossier = new cls_bl_dossier();
        cls_bl_payement paye = new cls_bl_payement();
        CSL_BL_Client c = new CSL_BL_Client();
        cls_bl_credit BL_credit = new cls_bl_credit();
        CSL_BL_pret_banque pb = new CSL_BL_pret_banque();
        cls_bl_creditpersonne creditpersonne = new cls_bl_creditpersonne();

        double Timbres;
        double Honoraires;
        double Enregistrement;
        double Ancfcc;
        double montant_paye_Timbres;
        double montant_paye_Honoraires;
        double montant_paye_Enregistrement;
        double montant_paye_Ancfcc;
        public DETAIL_CONTRAT()
        {            
            InitializeComponent(); 
            this.Dock = DockStyle.Fill;
        }

        private void PARTES_OF_CONTRAT_Click(object sender, EventArgs e)
        {
            int idc = THEME.id_C;
            var pret = pb.FindByValues(ele => ele.idcontrat == idc).FirstOrDefault();
            if (pret != null)
            {
                var date_d_f = con.FindByValues(ele => ele.Idcontrat == idc).First();
                bunifuTextBoxMONTANT.Text = pret.Montant.ToString();
                bunifuTextBoxCLINET.Text = pret.client.Nom + " " + pret.client.Prenom;
                bunifuTextBoxBANQUE.Text = pret.banque.Libbele;
                DERU.Text= pret.DERU.ToString() + "jours";
                PAYEPARMOINS.Text = pret.PAYE_PAR_MOIS.ToString() + "%";
                richTextBox_description.Text = pret.DESCRIPTION;
                INTIERET.Text = pret.INTIERET.ToString()+ "%";
                dateTimePickerdubet.Value = Convert.ToDateTime(date_d_f.dateouverture);
                dateTimePickerfin.Value = Convert.ToDateTime(date_d_f.Datefermeture);
                bunifuPages1.SetPage(pretbanquedetails);
                PARTES_OF_CONTRAT.Text = "DETAIL";

                return;
            }
            var cp = creditpersonne.FindByValues(ele => ele.idcontrat == idc).FirstOrDefault();
            if (cp != null)
            {
                var date_d_f = con.FindByValues(ele => ele.Idcontrat == idc).First();
                dateTimePickerdubet.Value = Convert.ToDateTime(date_d_f.dateouverture);
                dateTimePickerfin.Value = Convert.ToDateTime(date_d_f.Datefermeture);
                DERU.Text = cp.deru + "jours";
                bunifuPages1.SetPage(pretbanquedetails);
                PARTES_OF_CONTRAT.Text = "DETAIL";
                bunifuTextBoxMONTANT.Text = cp.montant.ToString();
                richTextBox_description.Text = cp.descreption;
                return;
            }
            bunifuPages1.SetPage(partes);
            PARTES_OF_CONTRAT.Text = "PARTES";
            bunifuDataGridViewpartes_S.DataSource = Signature.FindByValues(ele => ele.idcontrat == idc).Select(ele => new partesS()
            {
                ID_PARTE = (int)ele.idpatres,
                NOM = ele.parte.client.Nom,
                PRENOM = ele.parte.client.Prenom,
                TYPEPARTE = ele.parte.Typeclient,
                DATE_S = ele.DateSignatur.ToString() != "" ? ele.DateSignatur.ToString() : "NON SINIGTURE",
            }).ToList();
            THEME.add_checkbox_to_datagrid(bunifuDataGridViewpartes_S, "Signatur", 5);
            foreach (DataGridViewRow r in bunifuDataGridViewpartes_S.Rows)
            {
                if (r.Cells["DATE_S"].Value.ToString() == "NON SINIGTURE")
                {
                    r.Cells["Signatur"].Value = false;
                }
                else
                {
                    r.Cells["Signatur"].Value = true;
                }
            }
        }
        private void buttonadd_date_s_Click(object sender, EventArgs e)
        {
            if (!THEME.acceder("SIGNATURE CONTART"))
            {
                MessageBox.Show("VOUS N'AVEZ PAS LA PERMISSION");
                return;
            }
            if(parte == 0)
            {
                MessageBox.Show("VOUS N'AVEZ PAS cocher un parte");
                return;
            }
            var p = new Signature();
            p = Signature.FindByValues(ele => ele.idpatres == parte && ele.idcontrat == THEME.id_C).First();
            p.DateSignatur = Convert.ToDateTime(bunifuDatePicker_date_s.Text);
            Signature.SaveChanges();
            THEME.operation($"AJOUTER UN SIGNATURE DE CONTRAT ID = {THEME.id_C}");
            parte = 0;
            MessageBox.Show($"client {p.parte.client.Nom} {p.parte.client.Prenom} signie avec seccess");
        }
        private void PAYEMENTCLIENT_CONTRAT_Click(object sender, EventArgs e)
        {
           bunifuTextBox_MONTANT.Enabled = false;        
           bunifuPages1.SetPage(payeclient);
            var ListDataSource = new cls_bl_payement().GetAll().Where(x => x.idcontrat == THEME.id_C && x.type =="charge").Select(ele => new payeme()
            {
                CLIENT = $"{ele.client.Nom} {ele.client.Prenom}",
                TYPECHARGE = ele.typecharge,
                TYPEPAYEMENT = ele.type_Payement,
                DATE = ele.Date.Value.ToString(),
                MONTANT = ele.Montant.ToString(),
                BANQUE = ele.banque.Libbele
            }).ToList();
            bunifuDataGridView_payement.DataSource = ListDataSource;
            THEME.add_btn_to_datagrid(bunifuDataGridView_payement, "RECU", "RECU", bunifuDataGridView_payement.ColumnCount);
        }
        private void FICHIERJOINT_CONTRAT_Click(object sender, EventArgs e)
        {
            if (!THEME.acceder("FICHIERS CONTART"))
            {
                MessageBox.Show("VOUS N'AVEZ PAS LA PERMISSION");
                return;
            }
            var files = fichier_con.FindByValues(ele => ele.idcontrat == THEME.id_C).Select(ele => new filee()
            {
                IDFILE = (int)ele.idfile,
                TITRE = ele.titre,
                DESCREPTON = ele.descreption,
                FILE = ele.path
            }).ToList();
            bunifuDataGridView_fichier_contart.DataSource = files;
            THEME.add_btn_to_datagrid(bunifuDataGridView_fichier_contart, "sipprision", "supprimer", 4);
            THEME.add_btn_to_datagrid(bunifuDataGridView_fichier_contart, "affichage", "affichier", 5);
            bunifuPages1.SetPage(fichierjoint);
        }
        private void STATISTIC_CONTRAT_Click(object sender, EventArgs e)
        {
            if (THEME.id_C == 0)
                return;
            if (!THEME.acceder("STATISTIC CONTART"))
            {
                MessageBox.Show("VOUS N'AVEZ PAS LA PERMISSION");
                return;
            }
            bunifuPages1.SetPage(statistic);
            var list = new List<statis>();
            list = paye.FindByValues(ele => ele.idcontrat == THEME.id_C && ele.type =="charge").GroupBy(ele => ele.typecharge).OrderBy(ele => ele.Key).Select(ele => new statis()
            {   //DEPANCES= ele.Key,
                PAYE = ele.Sum(el => el.Montant).ToString(),
                DEPANCES = ele.Key
            }).ToList();
            var cont = con.FindById(THEME.id_C);
             Ancfcc = (double)cont.Ancfcc;
             Enregistrement = (double)cont.Enregistrement;
             Honoraires = (double)cont.Honoraires;
             Timbres = (double)cont.Timbres;
            bunifuDataGridView_statistic.ColumnCount = 5;
            bunifuDataGridView_statistic.Columns[0].Name = "DEPANCES";
            bunifuDataGridView_statistic.Columns[1].Name = "MONTANT";
            bunifuDataGridView_statistic.Columns[2].Name = "PAYE";
            bunifuDataGridView_statistic.Columns[3].Name = "RESTE";
            bunifuDataGridView_statistic.Columns[4].Name = "PORCENTAGE";
            bunifuDataGridView_statistic.Rows.Clear();
            string[] row = new string[] { "", "", "0", "", "" };
                bunifuDataGridView_statistic.Rows.Add(row);
                bunifuDataGridView_statistic.Rows.Add(row);
                bunifuDataGridView_statistic.Rows.Add(row);
                bunifuDataGridView_statistic.Rows.Add(row);    
                bunifuDataGridView_statistic.Rows[0].Cells[0].Value = "Ancfcc";
                bunifuDataGridView_statistic.Rows[1].Cells[0].Value = "Enregistrement";
                bunifuDataGridView_statistic.Rows[2].Cells[0].Value = "Honoraires";
                bunifuDataGridView_statistic.Rows[3].Cells[0].Value = "Timbres";
            int i = 0;
            foreach (var item in list)
            {
                if (item.DEPANCES == "Ancfcc")
                    bunifuDataGridView_statistic.Rows[0].Cells[2].Value = item.PAYE;
                if (item.DEPANCES == "Enregistrement")
                    bunifuDataGridView_statistic.Rows[1].Cells[2].Value = item.PAYE; 
                if (item.DEPANCES == "Honoraires")
                    bunifuDataGridView_statistic.Rows[2].Cells[2].Value = item.PAYE; 
                if (item.DEPANCES == "Timbres")
                    bunifuDataGridView_statistic.Rows[3].Cells[2].Value = item.PAYE;
                i++;  
            }            
                montant_paye_Ancfcc = double.Parse(bunifuDataGridView_statistic.Rows[0].Cells[2].Value.ToString());
                bunifuDataGridView_statistic.Rows[0].Cells[1].Value = Ancfcc;
                bunifuDataGridView_statistic.Rows[0].Cells[3].Value = (Ancfcc - montant_paye_Ancfcc).ToString();
                montant_paye_Enregistrement = double.Parse(bunifuDataGridView_statistic.Rows[1].Cells[2].Value.ToString());
                bunifuDataGridView_statistic.Rows[1].Cells[1].Value = Enregistrement;
                bunifuDataGridView_statistic.Rows[1].Cells[3].Value = (Enregistrement - montant_paye_Enregistrement).ToString();
                montant_paye_Honoraires = double.Parse(bunifuDataGridView_statistic.Rows[2].Cells[2].Value.ToString());
                bunifuDataGridView_statistic.Rows[2].Cells[1].Value = Honoraires;
                bunifuDataGridView_statistic.Rows[2].Cells[3].Value = (Honoraires - montant_paye_Honoraires).ToString();
                montant_paye_Timbres = double.Parse(bunifuDataGridView_statistic.Rows[3].Cells[2].Value.ToString());
                bunifuDataGridView_statistic.Rows[3].Cells[1].Value = Timbres;
                bunifuDataGridView_statistic.Rows[3].Cells[3].Value = (Timbres - montant_paye_Timbres).ToString();
            double montant = (Ancfcc) + (Enregistrement) + (Honoraires) + (Timbres);
            double payement = (montant_paye_Ancfcc + montant_paye_Enregistrement + montant_paye_Honoraires + montant_paye_Timbres);
            string[] r = new string[] { "TOTAL", montant.ToString(), (payement).ToString(), (montant - payement).ToString() };
            bunifuDataGridView_statistic.Rows.Add(r);
            bunifuDataGridView_statistic.Rows[4].Cells[0].Style.Font = new Font("Arial", 15, FontStyle.Bold);
            if (THEME.prix != 0)
            {
                bunifuDataGridView_statistic.Rows[3].Cells[4].Value = ((Timbres * 100) / THEME.prix).ToString();
                bunifuDataGridView_statistic.Rows[2].Cells[4].Value = ((Honoraires * 100) / THEME.prix).ToString();
                bunifuDataGridView_statistic.Rows[1].Cells[4].Value = ((Enregistrement * 100) / THEME.prix).ToString();
                bunifuDataGridView_statistic.Rows[0].Cells[4].Value = ((Ancfcc * 100) / THEME.prix).ToString();
                bunifuDataGridView_statistic.Rows[4].Cells[4].Value = ((montant * 100) / THEME.prix).ToString();
            }
            tva.Text = ((Honoraires*10)/100).ToString();   
        }
        private void RDCHEQUE_CheckedChanged(object sender, EventArgs e)
        {
            if(RDCHEQUE.Checked)
                comboBox_banque_PY.Enabled = true;
        }

        private void RDVERMENT_CheckedChanged(object sender, EventArgs e)
        {
            if (RDVERMENT.Checked)
                comboBox_banque_PY.Enabled = true;           
        }

        private void RD_ESPECES_CheckedChanged(object sender, EventArgs e)
        {
            if (RD_ESPECES.Checked)
                comboBox_banque_PY.Enabled = false;
        }

        private void ButtonAdd_PAYEMENT_Click(object sender, EventArgs e)
        {
            if (!THEME.acceder("PAIEMENT CONTART"))
            {
                MessageBox.Show("VOUS N'AVEZ PAS LA PERMISSION");
                return;
            }
            var credit = BL_credit.FindByValues(el => el.idcontrat == THEME.id_C).FirstOrDefault();
            if(credit != null)
            {
                MessageBox.Show("cette contrat il est credit");
                return;
            }
            if (montant_reste < double.Parse(bunifuTextBox_MONTANT.Text) || montant_reste == 0 || double.Parse(bunifuTextBox_MONTANT.Text) == 0 || bunifuTextBox_MONTANT.Text=="")
                return;
            var p = new  payement();
            p.idClient = int.Parse(comboBoxCLIENT_PY.SelectedValue.ToString());
            p.idbanque = RD_ESPECES.Checked ? 3 : int.Parse(comboBox_banque_PY.SelectedValue.ToString());
            p.Montant =double.Parse(bunifuTextBox_MONTANT.Text);
            p.Date = bunifuDatePicker_PAYMENT.Value;
            MessageBox.Show(comboBox_TYPE_CHARGE.Text);
            p.typecharge = comboBox_TYPE_CHARGE.Text;
            p.utilisateur = THEME.id_user;
            p.type = "charge";
            p.idcontrat = THEME.id_C;
            if(!RD_ESPECES.Checked)
                p.type_Payement = RDCHEQUE.Checked ? "CHEQUE" : "VERMENT";
            else
                p.type_Payement = "ESPECES";
            paye.Add(p);
            THEME.operation($"AJOUTER UN PAYEMENT DE CONTRAT ID = {THEME.id_C}");
            MessageBox.Show("payement avec success");
        }

        private void ButtonAdd_FICHIER_Click(object sender, EventArgs e)
        {
            if (!THEME.acceder("AJOUTER FICHIER CONTRAT"))
            {
                MessageBox.Show("VOUS N'AVEZ PAS LA PERMISSION");
                return;
            }
            if (textBoxfile.Text == "")
                return;
            var A = new fichiers_contrat();
            A.idcontrat = THEME.id_C;
            A.titre = textBoxtitre.Text;
            A.descreption = textBoxdesc.Text;
            A.utilisateur = THEME.id_user;
            string name_of_file = THEME.CopyFile(textBoxfile.Text, "contrat", THEME.id_C.ToString());
            if (name_of_file == "")
            {
                MessageBox.Show("Cette fichier existe deja");
                return;
            }
            A.path = name_of_file;
            fichier_con.Add(A);
            THEME.operation($"AJOUTER FICHIER DE CONTRAT ID = {THEME.id_C}");
            MessageBox.Show("fichier ajouter  avec success");
        }

        private void ButtonSaveSettings_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textBoxfile.Text = ofd.FileName;
                }
            }
        }
        private void buttonserche_file_Click(object sender, EventArgs e)
        {
            var files = fichier_con.FindByValues(ele => ele.idcontrat == THEME.id_C).Select(ele => new filee()
            {
                IDFILE = (int)ele.idfile,
                TITRE = ele.titre,
                DESCREPTON = ele.descreption,
                FILE = ele.path
            }).ToList();
            files = textBoxtitre.Text != "" ?
                files.Where(ele => ele.TITRE.ToString() == textBoxtitre.Text).ToList() :
                files;
            bunifuDataGridView_fichier_contart.DataSource = files;
            THEME.add_btn_to_datagrid(bunifuDataGridView_fichier_contart, "sipprision", "supprimer", 4);
            THEME.add_btn_to_datagrid(bunifuDataGridView_fichier_contart, "affichage", "affichier", 5);
            THEME.operation($"CHERCHER SUR LE FICHIER DE CONTRAT ID = {THEME.id_C}");
        }
        private void bunifuDataGridView_fichier_contart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridView dgv = (DataGridView)sender;
            if (e.RowIndex >= 0 && dgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                string path = THEME.contratDirectoryPath + "/"+THEME.id_C.ToString()+"/" + dgv.Rows[e.RowIndex].Cells["FILE"].Value.ToString();
                if (dgv.Columns[e.ColumnIndex].Name == "affichage")
                {                   
                    Process.Start(path);
                    THEME.operation($"AFFICHAGE FICHIER DE CONTRAT ID = {THEME.id_C} ET LE NOM DE FICHIER EST {dgv.Rows[e.RowIndex].Cells["FILE"].Value.ToString()}");

                }
                else
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to DELETE this FILE ?", "Vous voullez vreiment supprimer", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        int idfile = int.Parse(dgv.Rows[e.RowIndex].Cells["IDFILE"].Value.ToString());
                        if(File.Exists(path))
                            File.Delete(path);
                        fichier_con.Remove(fichier_con.FindById(idfile));
                        fichier_con.SaveChanges();
                        THEME.operation($"SUPRIMMER FICHIER DE CONTRAT ID = {THEME.id_C} ET LE NOM DE FICHIER EST {dgv.Rows[e.RowIndex].Cells["FILE"].Value.ToString()}");
                    }
                }
            }
        }
        private void comboBox_TYPE_CHARGE_SelectedIndexChanged(object sender, EventArgs e)
        {           
            if (comboBox_TYPE_CHARGE.Text == "Enregistrement")
            {
                bunifuTextBox_MONTANT.Text = (Enregistrement - montant_paye_Enregistrement).ToString();
            }
            else if (comboBox_TYPE_CHARGE.Text == "Ancfcc")
            {
                bunifuTextBox_MONTANT.Text = (Ancfcc - montant_paye_Ancfcc).ToString();
            }
            else if (comboBox_TYPE_CHARGE.Text == "Timbres")
            {
                bunifuTextBox_MONTANT.Text = (Timbres - montant_paye_Timbres).ToString();
            }
            else if (comboBox_TYPE_CHARGE.Text == "Honoraires")
            {
                bunifuTextBox_MONTANT.Text = (Honoraires - montant_paye_Honoraires).ToString();
            }
            montant_reste = double.Parse(bunifuTextBox_MONTANT.Text);
            bunifuTextBox_MONTANT.Enabled = true;
        }
        private void DETAIL_CONTRAT_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                buttonadd_date_s.Enabled = true;
                bunifuDatePicker_date_s.Enabled = true;
                PARTES_OF_CONTRAT.PerformClick();
                THEME.operation($"CONSULTER STATISTIQUE DE CONTRAT ID = {THEME.id_C}");
                int idc = THEME.id_C;
                var c = con.FindByValues(el => el.Idcontrat == idc).FirstOrDefault();
                BLBCONTRAT.Text = c.typecontrat + "  DOSSIER  " + THEME.numdossier;
                var pret = pb.FindByValues(ele => ele.idcontrat == idc).FirstOrDefault();
                var cp = creditpersonne.FindByValues(ele => ele.idcontrat == idc).FirstOrDefault();
                if (pret != null)
                {
                    panelcacher.Visible = true;
                    PARTES_OF_CONTRAT.Text = "DETAIL";
                    bunifuButtonCP.Visible = false;
                }
                else if(cp != null)
                {
                    panelcacher.Visible = false;
                    PARTES_OF_CONTRAT.Text = "DETAIL";
                    bunifuButtonCP.Visible = true;
                }
                else
                {
                    PARTES_OF_CONTRAT.Text = "PARTES";
                    bunifuButtonCP.Visible = false;
                }
                //PARTES_OF_CONTRAT.PerformClick();
                //PAYEMENTCLIENT_CONTRAT.PerformClick();
                //FICHIERJOINT_CONTRAT.PerformClick();
            }
        }
        private void partes_Click(object sender, EventArgs e)
        {
                
        }
        private void bunifuButton_print_Load(object sender, EventArgs e)
        {
            
        }
        private void bunifuDataGridView_payement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (e.RowIndex >= 0 && dgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                print.client = dgv.Rows[e.RowIndex].Cells["CLIENT"].Value.ToString();
                print.typepaye = dgv.Rows[e.RowIndex].Cells["TYPEPAYEMENT"].Value.ToString();
                int IDCLIENT = int.Parse(comboBoxCLIENT_PY.SelectedValue.ToString());
                print.idclient = c.FindByValues(ele => ele.idClient == IDCLIENT).First().ClientNormale == null ? c.FindByValues(ele => ele.idClient == IDCLIENT).First().ClientProfessionnel.ICE : c.FindByValues(ele => ele.idClient == IDCLIENT).First().ClientNormale.CIN;
                print.ice_cin = c.FindByValues(ele => ele.idClient == IDCLIENT).First().ClientNormale == null ? "ICE " : " CIN";
                print.montant = dgv.Rows[e.RowIndex].Cells["MONTANT"].Value.ToString()+" DH";
                print.banque = dgv.Rows[e.RowIndex].Cells["BANQUE"].Value.ToString();
                print.typecharge = dgv.Rows[e.RowIndex].Cells["TYPECHARGE"].Value.ToString();
                print.date = Convert.ToDateTime( dgv.Rows[e.RowIndex].Cells["DATE"].Value).ToString("yyyy-MM-dd");
                print.client = dgv.Rows[e.RowIndex].Cells["CLIENT"].Value.ToString();
                print.typecontart = con.FindByValues(ele => ele.Idcontrat == THEME.id_C).First().typecontrat;
                print.foncier = dossier.FindByValues(ele => ele.Numdossier == THEME.numdossier).First().Titrefoncier;
                print.ndossier = THEME.numdossier;
                string[] n = dgv.Rows[e.RowIndex].Cells["MONTANT"].Value.ToString().Split('.');
                if (n.Length == 1)
                {
                    print.montantp = "elle a payé  " + DATABASE.NumberToWords(Convert.ToInt32(n[0]));
                }
                else
                {
                    print.montantp = "elle a payé  " + DATABASE.NumberToWords(Convert.ToInt32(n[0])) + " virgule " + DATABASE.NumberToWords(Convert.ToInt32(n[1]));
                }
                print p = new print();
                p.Show();
            }
        }
        private void bunifuButton_print_Click(object sender, EventArgs e)
        {
            print_facture.montant_Ancfcc = Ancfcc;
            print_facture.montant_enregitrement = Enregistrement;
            print_facture.montant_honorair = Honoraires;
            print_facture.montant_tamber = Timbres;
            print_facture.typecontart = con.FindByValues(ele => ele.Idcontrat == THEME.id_C).First().typecontrat;
            print_facture.foncier = dossier.FindByValues(ele => ele.Numdossier == THEME.numdossier).First().Titrefoncier;
            print_facture.paye_enregitrement = montant_paye_Enregistrement;
            print_facture.paye_Ancfcc = montant_paye_Ancfcc;
            print_facture.paye_honorair = montant_paye_Honoraires;
            print_facture.paye_tamber = montant_paye_Timbres;
            if(double.Parse(bunifuDataGridView_statistic.Rows[4].Cells[3].Value.ToString()) > 0)
            {               
                print_facture.etatpayement = "La facture n’a pas encore été payée,";
            }
            else
            {
                print_facture.etatpayement = "La facture a été payée, ";
            }
            string paye = bunifuDataGridView_statistic.Rows[4].Cells[2].Value.ToString();
            string[] n = paye.Split('.');
            if(n.Length == 1)
            {
                print_facture.paye = "elle a payé  " + DATABASE.NumberToWords(int.Parse(n[0]));
            }
            else
            {
                print_facture.paye = "elle a payé  " + DATABASE.NumberToWords(int.Parse(n[0])) + " virgule " + DATABASE.NumberToWords(int.Parse(n[1]));
            }
            
            string reste = bunifuDataGridView_statistic.Rows[4].Cells[3].Value.ToString();
            string[] n1 = reste.Split('.');
            if(n1.Length == 1)
            {
                print_facture.reste = "et le reste est " + DATABASE.NumberToWords(int.Parse(n1[0]));
            }
            else
            {
                print_facture.reste = "et le reste est " + DATABASE.NumberToWords(int.Parse(n1[0])) + " virgule " + DATABASE.NumberToWords(int.Parse(n1[1]));
            }           
            print_facture f = new print_facture();
            f.Show();
        }
        private void pretbanquedetails_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDataGridViewpartes_S_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.Rows[e.RowIndex].Cells[5].Value == null)
                dgv.Rows[e.RowIndex].Cells[5].Value = false;
            dgv.Rows[e.RowIndex].Cells["Signatur"].Value = !(bool)dgv.Rows[e.RowIndex].Cells["Signatur"].Value;
            if (dgv.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {               
                parte = int.Parse(dgv.Rows[e.RowIndex].Cells["ID_PARTE"].Value.ToString());
            }
        }

        private void bunifuButtonCP_Click(object sender, EventArgs e)
        {
            int idc = THEME.id_C;
            bunifuPages1.SetPage(partes);
            bunifuDataGridViewpartes_S.DataSource = Signature.FindByValues(ele => ele.idcontrat == idc).Select(ele => new partesS()
            {
                ID_PARTE = (int)ele.idpatres,
                NOM = ele.parte.client.Nom,
                PRENOM = ele.parte.client.Prenom,
                TYPEPARTE = ele.parte.Typeclient,
                DATE_S = ele.DateSignatur.ToString() != "" ? ele.DateSignatur.ToString() : "NON SINIGTURE",
            }).ToList();
            THEME.add_checkbox_to_datagrid(bunifuDataGridViewpartes_S, "Signatur", 5);
            foreach (DataGridViewRow r in bunifuDataGridViewpartes_S.Rows)
            {
                if (r.Cells["DATE_S"].Value.ToString() == "NON SINIGTURE")
                {
                    r.Cells["Signatur"].Value = false;
                }
                else
                {
                    r.Cells["Signatur"].Value = true;
                }
            }
        }
    }
    public class partesS
    {
        [DisplayName("ID PARTE")]
        public int ID_PARTE { get; set; }
        [DisplayName("NOM")]
        public string NOM { get; set; }
        [DisplayName("PRENOM")]
        public string PRENOM { get; set; }
        [DisplayName("TYPE PARTE")]
        public string TYPEPARTE { get; set; }
        [DisplayName("DATE SINIGTURE")]
        public string DATE_S { get; set; }
    }
    public class payeme
    {
        [DisplayName("CLIENT")]
        public string CLIENT { get; set; }
        [DisplayName("TYPE PAYEMENT")]
        public string TYPEPAYEMENT { get; set; }
        [DisplayName("MONTANT")]
        public string MONTANT { get; set; }
        [DisplayName("BANQUE")]
        public string BANQUE { get; set; }
        [DisplayName("TYPE CHARGE")]
        public string TYPECHARGE { get; set; }
        [DisplayName("DATE")]
        public string DATE { get; set; }
    }
    public class statis
    {
        [DisplayName("DEPANCES")]
        public string DEPANCES { get; set; }
        [DisplayName("MONTANT")]
        public string MONTANT { get; set; }
        [DisplayName("PAYE")]
        public string PAYE { get; set; }
        [DisplayName("RESTE")]
        public string RESTE { get; set; }
        [DisplayName("PORCENTAGE")]
        public string PORCENTAGE { get; set; }
    }
}
