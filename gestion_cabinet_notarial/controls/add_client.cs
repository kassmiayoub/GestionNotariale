using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestion_cabinet_notarial.BL;
using Bunifu.UI.WinForms.BunifuButton;
using gestion_cabinet_notarial.context;
using System.Diagnostics;
using System.IO;

namespace gestion_cabinet_notarial
{
    public partial class add_client : UserControl
    {
        cls_bl_credit credit = new cls_bl_credit();
        CSL_BL_Client cls = new CSL_BL_Client();
        CSL_BL_Client_normal cln = new CSL_BL_Client_normal();
        CSL_BL_FICHIER_CLIENT cSL_BL_FICHIER_CLIENT = new CSL_BL_FICHIER_CLIENT();
        cls_bl_dossier cls_Bl_Dossier_client = new cls_bl_dossier();
        cls_bl_partes parte_client = new cls_bl_partes();

        public add_client()
        {
            InitializeComponent();
        }
        public void sete_client(int idc)
        {
            client A = new client();
            A = cls.FindById(idc);
            textBoxIDCLIENT.Text = A.idClient.ToString();
            textBoxemail.Text = A.Email;
            textBoxtel.Text = A.Tele;
            textBox_nom.Text = A.Nom;
            textBox_prenom.Text = A.Prenom;
            textBox_fax.Text = A.Fax;
            if (A.ClientNormale != null)
            {
                comboBoxtype_client.SelectedIndex = 1;
                textBoxCIN.Text = A.ClientNormale.CIN;
            }
            else
            {
                comboBoxtype_client.SelectedIndex = 0;
                textBoxCIN.Text = A.ClientProfessionnel.ICE;
                textBoxIF.Text = A.ClientProfessionnel.IdentifiantFiscale;
            }
        }
        private void add_client_Load(object sender, EventArgs e)
        {
            labelCIN.Visible = false;
            labelIF.Visible = false;
            textBoxCIN.Visible=false;
            textBoxIF.Visible=false;
            comboBoxtype_client.Items.Add("profisionnel");
            comboBoxtype_client.Items.Add("normal");          
        }
        private void ButtonAdd_Click_1(object sender, EventArgs e)
        {
            var a = new client();
            a.Nom = textBox_nom.Text;
            a.Prenom = textBox_prenom.Text;
            a.Email = textBoxemail.Text;
            a.Fax = textBox_fax.Text;
            a.Tele = textBoxtel.Text;
            if (comboBoxtype_client.Text == "normal")
            {
                a.ClientNormale = new ClientNormale() { CIN = textBoxCIN.Text };
            }
            else if (comboBoxtype_client.Text == "profisionnel")
            {
                a.ClientProfessionnel = new ClientProfessionnel() { ICE = textBoxCIN.Text };
                a.ClientProfessionnel = new ClientProfessionnel() { IdentifiantFiscale = textBoxIF.Text };
            }
            cls.Add(a);
            MessageBox.Show("client ajouter avec succes");
        }
        private void comboBoxtype_client_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxtype_client.Text == "normal")
            {
                textBoxCIN.Visible = true;
                labelCIN.Visible = true;
                textBoxIF.Visible = false;
                labelIF.Visible = false;
                labelCIN.Text = "CIN";
            }
            else
            {
                labelCIN.Visible = true;
                labelCIN.Text = "CIE";
                labelIF.Visible = true;
                textBoxCIN.Visible = true;
                textBoxIF.Visible = true;
            }
        }
        private void AJOUTER_CLIENT_Click(object sender, EventArgs e)
        {           
            string name = ((BunifuButton)sender).Name;
            switch (name)
            {
                case "AJOUTER_CLIENT":
                    bunifuPages1.SetPage(tabPage_CLIENT);
                    break;
                case "AJOUTER_FICHIERS":
                    bunifuPages1.SetPage(tabPageFICHIER);
                    break;             
            }
        }
        private void ButtonAdd_FICHIER_Click(object sender, EventArgs e)
        {
            if (textBoxfile.Text == "")
                return;
            var A = new fichiers_client();
            A.idClient = int.Parse(textBoxIDCLIENT.Text);
            A.titre = textBoxtitre.Text;
            A.descreption = textBoxdesc.Text;
            string name_of_file = THEME.CopyFile(textBoxfile.Text, "client", textBoxIDCLIENT.Text);
            if (name_of_file == "")
            {
                MessageBox.Show("Cette fichier existe deja");
                return;
            }
            A.path = name_of_file;
            cSL_BL_FICHIER_CLIENT.Add(A);
        }
        private void AJOUTER_FICHIERS_Click(object sender, EventArgs e)
        {
            //if("AJOUTER FICHIERS CLIENT")
            if (!THEME.acceder("AJOUTER FICHIERS CLIENT"))
            {
                MessageBox.Show("VOUS N'AVEZ PAS LA PERMISSION");
                return;
            }
            if (textBoxIDCLIENT.Text == "") { return; }
            int id = int.Parse(textBoxIDCLIENT.Text);
            if (cls.FindById(id) == null)
                return;
            string name = ((BunifuButton)sender).Name;
            switch (name)
            {
                case "AJOUTER_CLIENT":
                    bunifuPages1.SetPage(tabPage_CLIENT);
                    break;
                case "AJOUTER_FICHIERS":
                    bunifuPages1.SetPage(tabPageFICHIER);
                    break;
            }
            int a = int.Parse(textBoxIDCLIENT.Text);
            var files = cSL_BL_FICHIER_CLIENT.FindByValues(ele => (ele.idClient == a)).Select(ele => new filee()
            {
                IDFILE = (int)ele.idfile,
                TITRE = ele.titre,
                DESCREPTON = ele.descreption,
                FILE = ele.path
            }).ToList();
            bunifuDataGridView_list_file.DataSource = files;
            THEME.add_btn_to_datagrid(bunifuDataGridView_list_file, "sipprision", "supprimer", 4);
            THEME.add_btn_to_datagrid(bunifuDataGridView_list_file, "affichage", "affichier", 5);
        }
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            var ListDataSource = new List<clientserch>();
            if (comboBoxtype_client.Text == "profisionnel")
                    {
                     ListDataSource = cls.FindByValues(ele => (ele.ClientProfessionnel.ICE == textBoxCIN.Text && ele.ClientProfessionnel.IdentifiantFiscale==textBoxIF.Text) || (ele.ClientProfessionnel.ICE  == textBoxCIN.Text && textBoxIF.Text == "") || (ele.ClientProfessionnel.IdentifiantFiscale == textBoxIF.Text && textBoxCIN.Text == "")).Select(ele => new clientserch()
                        {
                                IDCIENT = ele.idClient,
                                nom = ele.Nom,
                                PRENOM = ele.Prenom,
                                EMAIL = ele.Email,
                                TEL = ele.Tele,
                                FAX = ele.Fax
                        }).ToList();
            }
            else if (comboBoxtype_client.Text == "normal")
                    {
                 ListDataSource = cls.FindByValues(ele => ele.ClientNormale.CIN == textBoxCIN.Text).Select(ele => new clientserch()
                {
                    IDCIENT = ele.idClient,
                    nom = ele.Nom,
                    PRENOM = ele.Prenom,
                    EMAIL = ele.Email,
                    TEL = ele.Tele,
                    FAX = ele.Fax
                }).ToList();
            }
            else
            {
                 ListDataSource = cls.GetAll().Select(ele => new clientserch()
                {
                    IDCIENT = ele.idClient,
                    nom = ele.Nom,
                    PRENOM = ele.Prenom,
                    EMAIL = ele.Email,
                    TEL = ele.Tele,
                    FAX = ele.Fax
                }).ToList();
            }
            ListDataSource = textBoxIDCLIENT.Text != "" ?
                ListDataSource.Where(ele => ele.IDCIENT.ToString() == textBoxIDCLIENT.Text).ToList() :
                ListDataSource;
            ListDataSource = textBox_nom.Text != "" ?
                ListDataSource.Where(ele => ele.nom.ToString() == textBox_nom.Text).ToList() :
                ListDataSource;
            ListDataSource = textBox_prenom.Text != "" ?
                ListDataSource.Where(ele => ele.PRENOM.ToString() == textBox_prenom.Text).ToList() :
                ListDataSource;
            ListDataSource = textBoxemail.Text != "" ?
               ListDataSource.Where(ele => ele.EMAIL.ToString() == textBoxemail.Text).ToList() :
               ListDataSource;
            ListDataSource = textBoxtel.Text != "" ?
                ListDataSource.Where(ele => ele.TEL.ToString() == textBoxtel.Text).ToList() :
                ListDataSource;
            ListDataSource = textBox_fax.Text != "" ?
                ListDataSource.Where(ele => ele.FAX.ToString() == textBox_fax.Text).ToList() :
                ListDataSource;
            if (THEME.credit)
            {
                ListDataSource = ListDataSource.Where(r =>  credit.Any(c => c.client.idClient == r.IDCIENT)) as List<clientserch>;                
            }
            bunifuDataGridViewlist_client.DataSource = ListDataSource;                 
          }
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            client A = new client();
            A = cls.FindById(int.Parse(textBoxIDCLIENT.Text));
            if (A == null) return;
            A.Nom = textBox_nom.Text;
            A.Prenom = textBox_prenom.Text;
            A.Email = textBoxemail.Text;
            A.Fax = textBox_fax.Text;
            A.Tele = textBoxtel.Text;
            if (comboBoxtype_client.Text == "profisionnel")
            {
                if(A.ClientNormale != null)
                {
                    A.ClientProfessionnel = new ClientProfessionnel() { idClient = int.Parse(textBoxIDCLIENT.Text), ICE = textBoxCIN.Text, IdentifiantFiscale = textBoxIF.Text };
                    A.ClientNormale = null;
                }
                else
                {
                    A.ClientProfessionnel.ICE = textBoxCIN.Text;
                    A.ClientProfessionnel.IdentifiantFiscale = textBoxIF.Text;
                }
            }
            else if (comboBoxtype_client.Text == "normal")
            {
                if(A.ClientProfessionnel != null)
                {
                    A.ClientNormale = new ClientNormale() { idClient = int.Parse(textBoxIDCLIENT.Text), CIN = textBoxCIN.Text };
                    A.ClientProfessionnel = null;
                }
                else
                {
                    A.ClientNormale.CIN = textBoxCIN.Text;
                }
            }
            cls.SaveChanges();
        }
        private void bunifuDataGridViewlist_client_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sete_client(int.Parse(bunifuDataGridViewlist_client.Rows[e.RowIndex].Cells[0].Value.ToString()));
            if (THEME.client_or_dossier != null)
            {
                THEME.client_or_dossier.SelectedValue = int.Parse(textBoxIDCLIENT.Text);
                THEME.navigat(THEME.T);
                THEME.client_or_dossier = null;
                THEME.T=null;
                ButtonInit.Enabled = true;
                ButtonEdit.Enabled = true;
                ButtonAdd.Enabled = true;
                THEME.credit = false;
            }
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
        private void button1_Click(object sender, EventArgs e)
        {
            var files = cSL_BL_FICHIER_CLIENT.GetAll().Select(ele => new filee()
            {
                IDFILE = (int)ele.idfile,
                TITRE = ele.titre,
                DESCREPTON = ele.descreption,
                FILE = ele.path
            }).ToList() ;
            files = textBoxtitre.Text != "" ?
                files.Where(ele => ele.TITRE.ToString() == textBoxtitre.Text).ToList() :
                files;
            bunifuDataGridView_list_file.DataSource = files;
            THEME.add_btn_to_datagrid(bunifuDataGridView_list_file, "sipprision", "supprimer", 4);
            THEME.add_btn_to_datagrid(bunifuDataGridView_list_file, "affichage", "affichier", 5);
        }
        private void bunifuDataGridView_list_file_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv =(DataGridView)sender;
            if (dgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn )
            {
                string path = THEME.clientDirectoryPath + "/" + textBoxIDCLIENT.Text + "/" + dgv.Rows[e.RowIndex].Cells["FILE"].Value.ToString();
                if (dgv.Columns[e.ColumnIndex].Name == "affichage")
                {
                    Process.Start(path);
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to DELETE this FILE ?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes) {
                        int idfile = int.Parse(dgv.Rows[e.RowIndex].Cells["IDFILE"].Value.ToString());                      
                        fichiers_client a = cSL_BL_FICHIER_CLIENT.FindById(idfile);
                        cSL_BL_FICHIER_CLIENT.Remove(a);
                        cSL_BL_FICHIER_CLIENT.SaveChanges();
                        File.Delete(path);                        
                    }                    
                } 
            }
        }
        private void ButtonInit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.Controls["bunifuPages1"].Controls["tabPage_CLIENT"].Name);
            THEME.vider(this.Controls["bunifuPages1"].Controls["tabPage_CLIENT"]);
        }

        private void bunifuButton_dossier_Click(object sender, EventArgs e)
        {
            if (textBoxIDCLIENT.Text.Trim() == "")
                return;
            var ListDataSource = new List<dossier_client>();
            ListDataSource = parte_client.GetAll().Where(id => id.idClient==int.Parse(textBoxIDCLIENT.Text)).Select(ele =>   new dossier_client()
            {
                N_DOSSIER = ele.dossier.Numdossier,
                DATE_F = ele.dossier.Datefermeture.ToString(),
                DATE_O = ele.dossier.dateouverture.ToString(),
                OBJET = ele.dossier.Objet,
                TITRE_F = ele.dossier.Titrefoncier,
                PRIX = ele.dossier.PRIX_ACQUISITION.ToString()
            }).ToList();
            bunifuDataGridView_list_dossier.DataSource = ListDataSource;
            THEME.add_btn_to_datagrid(bunifuDataGridView_list_dossier, "detail", "detail", 6);
            bunifuPages1.SetPage(tabPage_dossier);
        }
        private void bunifuDataGridView_list_dossier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            THEME.numdossier = bunifuDataGridView_list_dossier.Rows[e.RowIndex].Cells["N_DOSSIER"].Value.ToString();
            THEME.prix = double.Parse(bunifuDataGridView_list_dossier.Rows[e.RowIndex].Cells["PRIX"].Value.ToString());
            MessageBox.Show(THEME.numdossier);
            MessageBox.Show(THEME.prix.ToString());
            THEME.navigat(typeof(detail_dossier));
            //THEME.numdossier = "";
            //THEME.prix = 0;
        }
        private void add_client_VisibleChanged(object sender, EventArgs e)
        {
            if (THEME.id_C == 0)
                return;
            sete_client(THEME.id_C);
        }
    }
    public class clientserch
    {
        [DisplayName("IDCIENT")]
        public int IDCIENT { get; set; }
        [DisplayName("NOM")]
        public string nom { get; set; }
        [DisplayName("PRENOM")]
        public string PRENOM { get; set; }
        [DisplayName("TEL")]
        public string TEL { get; set; }
        [DisplayName("EMAIL")]
        public string EMAIL { get; set; }
        [DisplayName("FAX")]
        public string FAX { get; set; }
    }
    public class filee
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
    public class dossier_client
    {
        [DisplayName("N DOSSIER")]
        public string N_DOSSIER { get; set; }
        [DisplayName("DATE FERMETURE ")]
        public string DATE_F { get; set; }
        [DisplayName("DATE OUVERTURE")]
        public string DATE_O { get; set; }
        [DisplayName("PRIX")]
        public string PRIX { get; set; }
        [DisplayName("OBJET")]
        public string OBJET { get; set; }
        [DisplayName("TITRE FONCIER")]
        public string TITRE_F { get; set; }
    }
}

