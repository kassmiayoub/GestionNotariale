﻿using Bunifu.UI.WinForms.BunifuButton;
using gestion_cabinet_notarial.BL;
using gestion_cabinet_notarial.context;
using gestion_cabinet_notarial.controls;
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
    public partial class detail_dossier : UserControl
    {
        cls_bl_partes partee = new cls_bl_partes();
        cls_bl_contrat con = new cls_bl_contrat();
        cls_lb_fichier_dossier csl_Bl_Fichier_dossier = new cls_lb_fichier_dossier();
        CLS_OBJET CLS_OBJET_BL = new CLS_OBJET();
        CSL_BL_Client cls = new CSL_BL_Client();
        cls_bl_dossier cls_Bl_Dossier = new cls_bl_dossier();
        public detail_dossier()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        private void button_add_contrat_Click(object sender, EventArgs e)
        {
            if(partee.FindByValues(ele => ele.numdossier == THEME.numdossier).ToList().Count < 2)
            {
                MessageBox.Show("les partes doit etre minimum deux");
                return;
            }
            if (!THEME.acceder("AJOUTER CONTART"))
            {
                MessageBox.Show("VOUS N'AVEZ PAS LA PERMISSION");
                return;
            }
            if (bunifuDropdowntype_contrat.SelectedIndex == -1)
            {
                MessageBox.Show("la selection de type contrat est vide", "Error : Validations", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            if (bunifuDropdowntype_contrat.Text == "PRET BANQUE" || bunifuDropdowntype_contrat.Text == "CREDIT DEUX PERSONNES")
            {
                using (contrat_pret_banque f1 = new contrat_pret_banque(bunifuDropdowntype_contrat.Text)) { f1.ShowDialog(); }
            }
            else
            {
                using (contrat f1 = new contrat(bunifuDropdowntype_contrat.Text)) { f1.ShowDialog(); }
            }
        }
        private void button_add__partes_Click(object sender, EventArgs e)
        {
            int idclient = int.Parse(bunifuDropdownclient.SelectedValue.ToString());
            if (bunifuButton_CDG.Visible == false)
            {                
                var pa = partee.FindByValues(el => el.idClient == idclient && el.numdossier == THEME.numdossier).FirstOrDefault();
                pa.Condition = bunifuTextBoxcondition.Text;
                partee.SaveChanges();
                MessageBox.Show("la condition ajouter avec success");
                return;
            }
            if (THEME.numdossier == "")
                return;
            var parte = new parte();
            var pa1 = partee.FindByValues(el => el.idClient == idclient && el.numdossier == THEME.numdossier).ToList();
            if(pa1.Any(ele => ele.idClient == idclient))
            {
                MessageBox.Show("Cette parte il est deja existe");
                return;
            }
            parte.idClient = int.Parse(bunifuDropdownclient.SelectedValue.ToString());
            parte.Typeclient = bunifuDropdowntypeclient.Text;
            parte.Condition = bunifuTextBoxcondition.Text;
            //parte.utilisateur = THEME.id_user;
            parte.numdossier = THEME.numdossier;
            partee.Add(parte);
            THEME.operation($"AJOTER UN PARTE POUR DOSSIER DE NUMERO{THEME.numdossier}");
            MessageBox.Show("le parte ajouter avec success");
        }
        private void ButtonAdd_FICHIER_Click(object sender, EventArgs e)
        {
            if (!THEME.acceder("AJOUTER FICHIER DOSSIER"))
            {
                MessageBox.Show("VOUS N'AVEZ PAS LA PERMISSION");
                return;
            }
            if (THEME.numdossier == "")
                return;          
            var file = new fichiers_dossier();
            file.titre = textBoxtitre.Text;
            file.utilisateur = THEME.id_user;
            string name_of_file = THEME.CopyFile(textBoxfile.Text, "dossier", THEME.numdossier);
            if (name_of_file == "")
            {
                MessageBox.Show("Cette fichier existe deja");
                return;
            }
            file.path = name_of_file;
            file.descreption = textBoxdesc.Text;
            file.numdossier = THEME.numdossier;
            csl_Bl_Fichier_dossier.Add(file);
            THEME.operation($"AJOTER UN FICHIER POUR DOSSIER DE NUMERO {THEME.numdossier}");
            MessageBox.Show("le fichier ajouter avec success");
        }
        private void dataGridViewlist_contrat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
            DataGridView dgv = (DataGridView)sender;
            if (e.RowIndex >=0 && dgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                if (!THEME.acceder("CONTARTS DOSSIER"))
                {
                    MessageBox.Show("VOUS N'AVEZ PAS LA PERMISSION");
                    return;
                }
                if (dgv.Columns[e.ColumnIndex].Name == "DETAIL")
                {
                    THEME.id_C = int.Parse(dgv.Rows[e.RowIndex].Cells[dgv.Columns["IDCONTART"].Name].Value.ToString());                    
                    var dossier = cls_Bl_Dossier.FindByValues(ele => ele.Numdossier == THEME.numdossier).FirstOrDefault();
                    if (dossier.typedossier == "vente")
                    {
                        THEME.prix = con.FindByValues(ele => ele.Idcontrat == THEME.id_C).Select(s => s.dossier.PRIX_ACQUISITION).First().Value;
                    }
                    THEME.navigat(typeof(DETAIL_CONTRAT));
                    THEME.operation($"CONSULTER DETAILS DE CONTRAT ID {THEME.id_C} DE DOSSIER DE NUMERO {THEME.numdossier}");
                }
            }
        }
        private void bunifuDataGridView_list_file_dossier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                string path = THEME.dossierDirectoryPath + "/"+THEME.numdossier+"/" + dgv.Rows[e.RowIndex].Cells["FILE"].Value.ToString();
                if (dgv.Columns[e.ColumnIndex].Name == "affichage")
                {                    
                    Process.Start(path);
                    THEME.operation($"AFFICHIER FICHIER DE DOSSIER DE NUMERENT {THEME.numdossier}");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("VOUS L VRAIMENT SUPPRIMER ?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        int idfile = int.Parse(dgv.Rows[e.RowIndex].Cells["IDFILE"].Value.ToString());
                        if(Directory.Exists(path))                            
                            File.Delete(path);                            
                        csl_Bl_Fichier_dossier.Remove(csl_Bl_Fichier_dossier.FindById(idfile));
                        csl_Bl_Fichier_dossier.SaveChanges();
                        THEME.operation($"SIPRIMER FICHIER DE DOSSIER DE NUMERO {THEME.numdossier}");
                    }
                }
            }
        }
        private void PARTES_OF_CONTRAT_Click_1(object sender, EventArgs e)
        {
            if (!THEME.acceder("PARTES DOSSIER"))
            {
                MessageBox.Show("VOUS N'AVEZ PAS LA PERMISSION");
                return;
            }
            bunifuPages1.SetPage(tabPage1);
            var ListDataSource = new List<c>();
            ListDataSource = new cls_bl_partes().GetAll().Where(x => x.numdossier == THEME.numdossier).Select(x => new c()
            {
                TYPECLIENT = x.Typeclient,
                NOMCOMPLET = $"{x.client.Nom} {x.client.Prenom}",
                CONDITION= x.Condition
            }).ToList();
            bunifuDataGridView_list_partes.DataSource=ListDataSource;
            THEME.operation($"CONSULTER DES PARTES DE DOSSIER DE NUMERO {THEME.numdossier}");
        }
        private void CONTRAT_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(tabPage2);
            dataGridViewlist_contrat.DataSource = con.FindByValues(ele => ele.numdossier == THEME.numdossier).Select(ele => new contart()
            {
                IDCONTART = ele.Idcontrat,
                TYPECONTRAT = ele.typecontrat,
                DTFIN = (DateTime)ele.Datefermeture,
                dtov = (DateTime)ele.dateouverture
            }).ToList();
            THEME.add_btn_to_datagrid(dataGridViewlist_contrat, "DETAIL", "DETAIL", 4);
            THEME.operation($"CONSULTER DES CONTARTS DE DOSSIER DE NUMERO {THEME.numdossier}");
        }
        private void FICHIERJOINT_dossier_Click(object sender, EventArgs e)
        {
            if (!THEME.acceder("FICHIERS DOSSIER"))
            {
                MessageBox.Show("VOUS N'AVEZ PAS LA PERMISSION");
                return;
            }
            bunifuPages1.SetPage(tabPage3);
            String a = THEME.numdossier ;
            var files = csl_Bl_Fichier_dossier.FindByValues(ele => (ele.numdossier == a)).Select(ele => new file()
            {
                IDFILE = (int)ele.idfile,
                TITRE = ele.titre,
                DESCREPTON = ele.descreption,
                FILE = ele.path
            }).ToList();
            bunifuDataGridView_list_file_dossier.DataSource = files;
            THEME.add_btn_to_datagrid(bunifuDataGridView_list_file_dossier, "sipprision", "supprimer", 4);
            THEME.add_btn_to_datagrid(bunifuDataGridView_list_file_dossier, "affichage", "affichier", 5);
            THEME.operation($"CONSULTER DES FICHIERS DE DOSSIER DE NUMERO {THEME.numdossier}");
        }

        private void ButtonSavefile_fichier_joint_dossier_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textBoxfile.Text = ofd.FileName;
                }
            }
        }
        private void button8SERCHE_FICHIER_DOSSIER_Click(object sender, EventArgs e)
        {
            var files = csl_Bl_Fichier_dossier.GetAll().Select(ele => new filee()
            {
                IDFILE = (int)ele.idfile,
                TITRE = ele.titre,
                DESCREPTON = ele.descreption,
                FILE = ele.path
            }).ToList();
            files = textBoxtitre.Text != "" ?
                files.Where(ele => ele.TITRE.ToString() == textBoxtitre.Text).ToList() :
                files;
            bunifuDataGridView_list_file_dossier.DataSource = files;
            THEME.add_btn_to_datagrid(bunifuDataGridView_list_file_dossier, "sipprision", "supprimer", 4);
            THEME.add_btn_to_datagrid(bunifuDataGridView_list_file_dossier, "affichage", "affichier", 5);
            THEME.operation($"CHERCHER DES FICHIERS DE DOSSIER DE NUMERO {THEME.numdossier}");
        }

        private void detail_dossier_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                DOSSIER.Text = THEME.numdossier;
                var ListDataSource = new List<clien>();
                var partcontratechange = partee.FindByValues(ele => ele.numdossier == THEME.numdossier).Select(s => new { idc = s.idClient }).ToList();
                ListDataSource = cls.GetAll().Select(ele => new clien()
                {
                    IDCIENT = ele.idClient,
                    nomcomplet = ele.Nom + " " + ele.Prenom
                }).ToList();
                var obj = CLS_OBJET_BL.FindByValues(ele => ele.numdossier == THEME.numdossier).FirstOrDefault();
                if(obj != null)
                {
                    bunifuButton_CDG.Visible = false;
                    bunifuDropdowntypeclient.Enabled = false;
                    button1.Visible = false; 
                    ListDataSource = ListDataSource.Where(r => partcontratechange.Any(c => c.idc == r.IDCIENT)).ToList();
                    CONTRAT.PerformClick();
                }
                else
                {
                   
                    button1.Visible = true;
                    bunifuButton_CDG.Visible = true;
                    bunifuDropdowntypeclient.Enabled = true;
                }
                bunifuDropdownclient.DisplayMember = "NOMCOMPLET";
                    bunifuDropdownclient.ValueMember = "IDCIENT";
                bunifuDropdownclient.DataSource = ListDataSource;
                if (add_client.idclient != 0)
                {
                    PARTES_OF_CONTRAT.PerformClick();
                    bunifuDropdownclient.SelectedValue = add_client.idclient;
                    add_client.idclient = 0;
                }
                else
                {
                    CONTRAT.PerformClick();
                }
                // FICHIERJOINT_dossier.PerformClick();                
                THEME.operation($"CONSULTER DES CONTARTS DE DOSSIER DE NUMERO {THEME.numdossier}");
                //PARTES_OF_CONTRAT.PerformClick();
            }
        }
        private void detail_dossier_Load(object sender, EventArgs e)
        {
            var typedossier = cls_Bl_Dossier.FindByValues(el => el.Numdossier == THEME.numdossier).First().typedossier;
            bunifuDropdowntype_contrat.Items.Clear();
            if(typedossier == "location")
            {
                bunifuDropdowntype_contrat.Items.Add("CONTRAT DE LOCATION");
                bunifuDropdowntype_contrat.Items.Add("PROMESE DE LOCATION");
                bunifuDropdowntype_contrat.Items.Add("PRET BANQUE");
            }
            else if(typedossier == "vente")
            {
                bunifuDropdowntype_contrat.Items.Add("CONTRAT DE VENTE");
                bunifuDropdowntype_contrat.Items.Add("PROMESE DE VENTE");
                bunifuDropdowntype_contrat.Items.Add("PRET BANQUE");
            }
            else if(typedossier == "change")
            {
                bunifuDropdowntype_contrat.Items.Add("ECHANGE");
            }
            else
            {
                bunifuDropdowntype_contrat.Items.Add("CREDIT DEUX PERSONNES");
            }
        }

        private void bunifuButton_CDG_Click(object sender, EventArgs e)
        {
            if (!THEME.acceder("AFFICHIER LA LIST CDG"))
            {
                MessageBox.Show("VOUS N'AVEZ PAS LA PERMISSION");
                return;
            }
            THEME.TPI = "TPI";
            THEME.navigat(typeof(CTL_CDG));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ((Button)this.Parent.Controls["add_client"].Controls["bunifuPages1"].Controls["tabPage_CLIENT"].Controls["ButtonEdit"]).Enabled = false;
            THEME.T = this.GetType();
            THEME.navigat(typeof(add_client));
            THEME.client_or_dossier = (ComboBox)this.Controls["bunifuPages1"].Controls["tabPage1"].Controls["panel2"].Controls["bunifuDropdownclient"];
        }
    }
    public class contart
    {
        [DisplayName("ID CONTART")]
        public int IDCONTART { get; set; }
        [DisplayName("TYPE CONTRAT")]
        public string TYPECONTRAT { get; set; }
        [DisplayName("DATE FERMETURE")]
        public DateTime DTFIN { get; set; }
        [DisplayName("DATE OUVERTURE")]
        public DateTime dtov { get; set; }
    }
    public class file
    {
        [DisplayName("IDFILE")]
        public int IDFILE { get; set; }
        [DisplayName("TITRE")]
        public string TITRE { get; set; }
        [DisplayName("DESCREPTON")]
        public string DESCREPTON { get; set; }
        [DisplayName("FILE")]
        public string FILE { get; set; }
    }
    public class c
    {       
        [DisplayName("NOMCOMPLET")]
        public string NOMCOMPLET { get; set; }
        [DisplayName("TYPE CLIENT")]
        public string TYPECLIENT { get; set; }
        [DisplayName("CONDITION")]
        public string CONDITION { get; set; }
    }
}
