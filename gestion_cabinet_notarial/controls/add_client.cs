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
using gestion_cabinet_notarial.Validators;
using FluentValidation.Results;
using System.Text.RegularExpressions;

namespace gestion_cabinet_notarial
{
    public partial class add_client : UserControl
    {
        cls_bl_credit credit = new cls_bl_credit();
        CSL_BL_Client cls = new CSL_BL_Client();
        CSL_BL_Client_normal cln = new CSL_BL_Client_normal();
        CSL_BL_Client_Professionnel clp = new CSL_BL_Client_Professionnel();
        CSL_BL_FICHIER_CLIENT cSL_BL_FICHIER_CLIENT = new CSL_BL_FICHIER_CLIENT();
        cls_bl_dossier cls_Bl_Dossier_client = new cls_bl_dossier();
        cls_bl_partes parte_client = new cls_bl_partes();

        public add_client()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
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
            textBox_adress.Text = A.adress;
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
            textBoxfile.Enabled = false;
            labelCIN.Visible = false;
            labelIF.Visible = false;
            textBoxCIN.Visible=false;
            textBoxIF.Visible=false;
            textBoxIDCLIENT.Enabled = false;
            comboBoxtype_client.Items.Add("profisionnel");
            comboBoxtype_client.Items.Add("normal");
            comboBoxtype_client.SelectedIndex = 0;
        }
        private void ButtonAdd_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show(this.Name);
            var a = new client();
            a.Nom = textBox_nom.Text;
            a.Prenom = textBox_prenom.Text;
            a.Email = textBoxemail.Text;
            a.Fax = textBox_fax.Text;
            a.Tele = textBoxtel.Text;
            a.adress = textBox_adress.Text;
            clientValidator validationRules = new clientValidator();
            ValidationResult validationResult = validationRules.Validate(a);
            IList<ValidationFailure> errors = validationResult.Errors;
            if (!validationResult.IsValid)
            {
                MessageBox.Show("" + errors[0].ErrorMessage, "Error : Validations", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            if(textBoxemail.Text != "")
            {
                if (!new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").IsMatch(textBoxemail.Text))
                {
                    MessageBox.Show("le champs EMAIL doit etre correct", "Error : Validations", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
            }
            string op = "";
            if (comboBoxtype_client.Text == "normal")
            {
                op = "NORMAL CIN EST " + textBoxCIN.Text;
                a.ClientNormale = new ClientNormale() { CIN = textBoxCIN.Text };
                if (! new Regex(@"^[A-Z]{1,2}\d{4,5}$").IsMatch(textBoxCIN.Text))
                {
                    MessageBox.Show("le champs CIN doit etre correct", "Error : Validations", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }               
            }
            else if (comboBoxtype_client.Text == "profisionnel")
            {
                op = "PROFISIONNEL ICE EST " + textBoxCIN.Text;
                a.ClientProfessionnel = new ClientProfessionnel() { ICE = textBoxCIN.Text };
                if (textBoxCIN.Text == "")
                {
                    MessageBox.Show("le champs ICE ne doit pas etre vide", "Error : Validations", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
                a.ClientProfessionnel = new ClientProfessionnel() { IdentifiantFiscale = textBoxIF.Text };
                if (textBoxIF.Text == "")
                {
                    MessageBox.Show("le champs IF ne doit pas etre vide", "Error : Validations", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
            }            
             cls.Add(a);
             THEME.operation($"AJOUTER UN CLIENT {op}");
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
            var A = new fichiers_client();
            fichier_client_validator validationRules = new fichier_client_validator();
            ValidationResult validationResult = validationRules.Validate(A);
            IList<ValidationFailure> errors = validationResult.Errors;
            if (!validationResult.IsValid)
            {
                MessageBox.Show("" + errors[0].ErrorMessage, "Error : Validations", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
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
            THEME.operation($"AJOUTER UN FICHIER DE CLIENT ID {int.Parse(textBoxIDCLIENT.Text)}");
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
                     ListDataSource = clp.GetAll().Select(ele => new clientserch()
                        {
                                IDCIENT = ele.idClient,
                                nom = ele.client.Nom,
                                PRENOM = ele.client.Prenom,
                                EMAIL = ele.client.Email,
                                TEL = ele.client.Tele,
                                FAX = ele.client.Fax,
                               TYPECLIENT = "profisionnel",
                               CIN = ele.ICE,
                               IF = ele.IdentifiantFiscale
                     }).ToList();
                ListDataSource = textBoxCIN.Text != "" ?
                ListDataSource.Where(ele => ele.CIN.ToString() == textBoxCIN.Text).ToList() :
                ListDataSource;
                ListDataSource = textBoxIF.Text != "" ?
                    ListDataSource.Where(ele => ele.IF.ToString() == textBoxIF.Text).ToList() :
                    ListDataSource;
            }
            else if (comboBoxtype_client.Text == "normal")
                    {
                 ListDataSource = cln.GetAll().Select(ele => new clientserch()
                {
                    IDCIENT = ele.idClient,
                    nom = ele.client.Nom,
                    PRENOM = ele.client.Prenom,
                    EMAIL = ele.client.Email,
                    TEL = ele.client.Tele,
                    FAX = ele.client.Fax,
                    TYPECLIENT = "normal",
                    CIN = ele.CIN
                 }).ToList();
                ListDataSource = textBoxCIN.Text != "" ?
                ListDataSource.Where(ele => ele.CIN.ToString() == textBoxCIN.Text).ToList() :
                ListDataSource;
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
                    FAX = ele.Fax,
                    TYPECLIENT = clp.Any(el => el.idClient == ele.idClient)  ? "profisionnel" : "normal",
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
                ListDataSource = ListDataSource.Where(r => credit.Any(c => c.client.idClient == r.IDCIENT)) as List<clientserch>;
            }
            bunifuDataGridViewlist_client.DataSource = ListDataSource;
            bunifuDataGridViewlist_client.Columns["IF"].Visible = false;
            bunifuDataGridViewlist_client.Columns["CIN"].Visible = false;
        }
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxIDCLIENT.Text=="")
                return;
            client A = new client();
            A = cls.FindById(int.Parse(textBoxIDCLIENT.Text));
            if (A == null) return;
            A.Nom = textBox_nom.Text;
            A.Prenom = textBox_prenom.Text;
            A.Email = textBoxemail.Text;
            A.Fax = textBox_fax.Text;
            A.adress = textBox_adress.Text;
            A.Tele = textBoxtel.Text;
            clientValidator validationRules = new clientValidator();
            ValidationResult validationResult = validationRules.Validate(A);
            IList<ValidationFailure> errors = validationResult.Errors;
            if (!validationResult.IsValid)
            {
                MessageBox.Show("" + errors[0].ErrorMessage, "Error : Validations", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            if (textBoxemail.Text != "")
            {
                if (!new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").IsMatch(textBoxemail.Text))
                {
                    MessageBox.Show("le champs EMAIL doit etre correct", "Error : Validations", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
            }
            if (comboBoxtype_client.Text == "profisionnel")
            {
                if (textBoxCIN.Text == "")
                {
                    MessageBox.Show("le champs ICE ne doit pas etre vide", "Error : Validations", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
                if (textBoxIF.Text == "")
                {
                    MessageBox.Show("le champs IF ne doit pas etre vide", "Error : Validations", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
                if (A.ClientNormale != null)
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
                if (!new Regex(@"^[A-Z]{1,2}\d{4,5}$").IsMatch(textBoxCIN.Text))
                {
                    MessageBox.Show("le champs CIN doit etre correct", "Error : Validations", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
                if (A.ClientProfessionnel != null)
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
            THEME.operation($"MODIFIER UN CLIENT ID {int.Parse(textBoxIDCLIENT.Text)}");
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
            THEME.operation($"CHERCHER FICHIER CLIENT");

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
                    THEME.operation($"AFFICHER FICHIER DE CLIENT LE NOM DE FICHIER EST {dgv.Rows[e.RowIndex].Cells["FILE"].Value.ToString()}");
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
                    THEME.operation($"SUPRIMER FICHIER DE CLIENT LE NOM DE FICHIER EST {dgv.Rows[e.RowIndex].Cells["FILE"].Value.ToString()}");
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
            THEME.operation($"CONSULTER DES DOSSIERS DE CLIENT ID {textBoxIDCLIENT.Text}");
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
            
           var ListDataSource = cls.GetAll().Select(ele => new clientserch()
            {
                IDCIENT = ele.idClient,
                nom = ele.Nom,
                PRENOM = ele.Prenom,
                EMAIL = ele.Email,
                TEL = ele.Tele,
                FAX = ele.Fax,
                TYPECLIENT = clp.Any(el => el.idClient == ele.idClient) ? "profisionnel" : "normal",
           }).ToList();
            if(this.Visible)
                THEME.operation($"CONSULTER DES CLIENT");
            bunifuDataGridViewlist_client.DataSource = ListDataSource;
            bunifuDataGridViewlist_client.Columns["IF"].Visible = false;
            bunifuDataGridViewlist_client.Columns["CIN"].Visible = false;
            if (THEME.id_Client == 0)
                return;
            sete_client(THEME.id_Client);
        }

        private void tabPage_CLIENT_Click(object sender, EventArgs e)
        {

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
        public string FAX  { get; set; }
        [DisplayName("TYPE CLIENT")]
        public string TYPECLIENT { get; set; }
        [DisplayName("CIN")]
        public string CIN { get; set; }
        [DisplayName("IF")]
        public string IF { get; set; }
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

