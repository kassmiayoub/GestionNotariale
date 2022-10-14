using FluentValidation.Results;
using gestion_cabinet_notarial.BL;
using gestion_cabinet_notarial.context;
using gestion_cabinet_notarial.Validators;
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
    public partial class ADD_DOSSIER : UserControl
    {
        cls_bl_dossier cls_Bl_Dossier = new cls_bl_dossier();
        cls_bl_partes partee = new cls_bl_partes();
        CLS_OBJET CLS_OBJET_BL = new CLS_OBJET();
        string typeprix = "";
        public ADD_DOSSIER()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        private void ButtonAdd_dossier_Click(object sender, EventArgs e)
        {
            if (textBox_N_dossier.Text == "")
                return;
            if (!THEME.acceder("FICHIERS DOSSIER"))
            {
                MessageBox.Show("VOUS N'AVEZ PAS LA PERMISSION");
                return;
            }
            var a = new dossier();
            a.Numdossier = textBox_N_dossier.Text;
            a.dateouverture = Convert.ToDateTime(bunifuDatePicker_dubet.Text);
           // a.Datefermeture = Convert.ToDateTime(bunifuDatePicker_fin.Text);
            if (THEME.objs.Count == 0 && typeprix != "change")
            {
                a.Titrefoncier = textBox_titre_foncier.Text;
                a.Objet = textBox_obj.Text;

            }
            else if (typeprix == "vente" || typeprix == "location")
            {
                if (textBox_prix.Text == "")
                {
                    MessageBox.Show("le prix doit pas vider", "Error : validation", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
                if (typeprix == "vente")
                {
                    if (textBox_anne_achat.Text == "" || textBox_anne_vente.Text == "" || textBoxPRIX_ACHAT.Text == "")
                    {
                        MessageBox.Show("Anne d'achat et Anne de vent et le prix d'achat doit pas vider", "Error : validation", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    a.anne_achat = int.Parse(textBox_anne_achat.Text);
                    a.anne_vente = int.Parse(textBox_anne_vente.Text);
                    a.prixachat = double.Parse(textBoxPRIX_ACHAT.Text);
                }
                else
                {
                    if(textBox_anne_achat.Text == "")
                        a.anne_achat = int.Parse(textBox_anne_achat.Text);
                }
                a.typedossier = typeprix;
                a.PRIX_ACQUISITION = double.Parse(textBox_prix.Text);
            }
            else if (typeprix == "change")
            {
                a.typedossier = "change";
            }
            a.utilisateur = THEME.id_user;
            if (bunifuCheckBox_status.Checked)
                a.Datefermeture = Convert.ToDateTime(bunifuDatePicker_fin.Text);
            else
                a.Datefermeture = null;
            //dossierValidator validationRules = new dossierValidator();
            //ValidationResult validationResult = validationRules.Validate(a);
            //IList<ValidationFailure> errors = validationResult.Errors;
            //if (!validationResult.IsValid)
            //{
            //    MessageBox.Show("" + errors[0].ErrorMessage, "Error : Validations", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            //    return;
            //}
            if (typeprix != "")
            {           
            DialogResult dr = MessageBox.Show($"vraiment cette dossier pour {typeprix} ?", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                cls_Bl_Dossier.Add(a);
            }
            else
            {
                return;
            }
                
            }
            else
            {
                cls_Bl_Dossier.Add(a);
            }
            if (THEME.objs.Count != 0 && typeprix == "change")
            {
                var parte = new parte();
                var s_parte = new Signature();
                parte.Condition = "";
                parte.Typeclient = "echangeur";
                parte.numdossier = textBox_N_dossier.Text;
                //parte.utilisateur = THEME.id_user;
                THEME.objs.ForEach(ele =>
                {
                    parte.idClient = ele.idclient;
                    ele.numdossier = textBox_N_dossier.Text;
                    var clinet = partee.FindByValues(el => el.numdossier == textBox_N_dossier.Text && el.idClient == ele.idclient).FirstOrDefault();
                    if (clinet == null)
                    {
                        partee.Add(parte);
                    }
                });
                CLS_OBJET_BL.AddRange(THEME.objs);
                THEME.objs.Clear();
            }
            THEME.operation($"AJOUTER DOSSIER NUMERANT = {textBox_N_dossier.Text}");
            var ListDataSource = new List<dossierSerche>();
            ListDataSource = cls_Bl_Dossier.GetAll().Select(ele => new dossierSerche()
            {
                N_DOSSIER = ele.Numdossier,
                DATE_F = ele.Datefermeture.ToString(),
                DATE_O = ele.dateouverture.ToString(),
                OBJET = ele.Objet,
                TITRE_F = ele.Titrefoncier,
                PRIX = ele.PRIX_ACQUISITION.ToString()
            }).ToList();
            bunifuDataGridView_list_dossier.DataSource = ListDataSource;
        }
        private void ButtonSearch_dossier_Click(object sender, EventArgs e)
        {
            var ListDataSource = new List<dossierSerche>();
            ListDataSource = cls_Bl_Dossier.GetAll().Select(ele => new dossierSerche()
                {
                    N_DOSSIER=ele.Numdossier,
                    DATE_F=ele.Datefermeture.ToString(),
                    DATE_O=ele.dateouverture.ToString(),
                    OBJET= ele.Objet,
                    TITRE_F=ele.Titrefoncier,
                    PRIX=ele.PRIX_ACQUISITION.ToString()
                }).ToList();
            ListDataSource = textBox_N_dossier.Text != "" ?
                ListDataSource.Where(ele => ele.N_DOSSIER== textBox_N_dossier.Text).ToList() :
                ListDataSource;
            ListDataSource = textBox_obj.Text != "" ?
                ListDataSource.Where(ele => ele.OBJET.ToString() == textBox_obj.Text).ToList() :
                ListDataSource;
            ListDataSource = textBox_titre_foncier.Text != "" ?
                ListDataSource.Where(ele => ele.TITRE_F.ToString() == textBox_titre_foncier.Text).ToList() :
                ListDataSource;
            ListDataSource = textBox_prix.Text != "" ?
               ListDataSource.Where(ele => ele.PRIX.ToString() == textBox_prix.Text).ToList() :
               ListDataSource;
            //ListDataSource = textBoxtel.Text != "" ?
            //    ListDataSource.Where(ele => ele.TEL.ToString() == textBoxtel.Text).ToList() :
            //    ListDataSource;
            //ListDataSource = textBox_fax.Text != "" ?
            //    ListDataSource.Where(ele => ele.FAX.ToString() == textBox_fax.Text).ToList() :
            //    ListDataSource;
            if(THEME.client_or_dossier != null)
            {
                ListDataSource = ListDataSource.Where(r => r.DATE_F == null).ToList();
            }
            bunifuDataGridView_list_dossier.DataSource = ListDataSource;
            THEME.operation($"CHERCHER DOSSIERS");
        }
        private void bunifuDataGridView_list_dossier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(bunifuDataGridView_list_dossier.Rows[e.RowIndex].Cells[0].Value.ToString());
            dossier A = new dossier();
            
            var x = bunifuDataGridView_list_dossier.Rows[e.RowIndex].Cells[0].Value.ToString();
            A = cls_Bl_Dossier.FindByValues(ele => ele.Numdossier ==x ).First();
            textBox_N_dossier.Text = A.Numdossier;
            textBox_obj.Text = A.Objet;
            textBox_prix.Text = A.PRIX_ACQUISITION.ToString();
            textBox_titre_foncier.Text = A.Titrefoncier;
            bunifuDatePicker_dubet.Value = A.dateouverture.Value;
            if(A.Datefermeture!=null)
                bunifuDatePicker_fin.Value = A.Datefermeture.Value;
            bunifuDatePicker_fin.Value = DateTime.Now;
            if (THEME.client_or_dossier != null)
            {
                THEME.client_or_dossier.SelectedValue = textBox_N_dossier.Text;
                THEME.navigat(THEME.T);
                THEME.client_or_dossier = null;
                THEME.T = null;
                ButtonInit.Enabled = true;
                ButtonAdd_dossier .Enabled = true;
                ButtonEdit_dossier .Enabled = true;
            }
        }
        private void ButtonInit_Click(object sender, EventArgs e)
        {
            THEME.vider(this);
            
        }
        private void button_detail_dossier_Click(object sender, EventArgs e)
        {
            if (!THEME.acceder("DETAIL DOSSIER"))
            {
                MessageBox.Show("VOUS N'AVEZ PAS LA PERMISSION");
                return;
            }
            var dossier = cls_Bl_Dossier.FindByValues(ele => ele.Numdossier == textBox_N_dossier.Text).FirstOrDefault();
            if (dossier == null)
            {
                MessageBox.Show("Cette dossier ne pas trover");
                return;
            }
            if (textBox_N_dossier.Text == "")
                return;
            //var obj = CLS_OBJET_BL.FindByValues(ele => ele.numdossier == textBox_N_dossier.Text).FirstOrDefault();
            //if (obj == null && textBox_prix.Text == "")
            //{
            //    return;
            //}
            else if(dossier.typedossier == "vente")
            {
                THEME.prix = double.Parse(dossier.PRIX_ACQUISITION.ToString());
            }
            THEME.operation($"CONSULTER DETAILS DE DOSSIER NUMERENT {textBox_N_dossier.Text}");            
           
                
            THEME.numdossier = textBox_N_dossier.Text;
            THEME.navigat(typeof(detail_dossier));
        }
        private void ADD_DOSSIER_Load(object sender, EventArgs e)
        {
            bunifuDatePicker_fin.Enabled = false;
        }
        private void bunifuCheckBox_status_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if(bunifuCheckBox_status.Checked)
                bunifuDatePicker_fin.Enabled = true;
            else
                bunifuDatePicker_fin.Enabled = false;
        }
        private void ButtonEdit_dossier_Click(object sender, EventArgs e)
        {
            if (!THEME.acceder("MODIFIER DOSSIER"))
            {
                MessageBox.Show("VOUS N'AVEZ PAS LA PERMISSION");
                return;
            }
            if (textBox_N_dossier.Text == "")
            {
                MessageBox.Show("ENTRE NUMERENT DE DOSSIER");
                return;
            }                
            dossier d= (dossier)cls_Bl_Dossier.FindByValues(v => v.Numdossier == textBox_N_dossier.Text);
            if(bunifuCheckBox_status.Checked)
                d.Datefermeture = Convert.ToDateTime(bunifuDatePicker_fin.Value);
            else
                return;
            cls_Bl_Dossier.SaveChanges();
            THEME.operation($"MODIFIER DATE DE DOSSIER NUMERENT = {textBox_N_dossier.Text} POUR FIRMER");
        }
        private void ADD_DOSSIER_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                bunifuCheckBox_status.Checked = false;
                var ListDataSource = new List<dossierSerche>();
                ListDataSource = cls_Bl_Dossier.GetAll().Select(ele => new dossierSerche()
                {
                    N_DOSSIER = ele.Numdossier,
                    DATE_F = ele.Datefermeture.ToString(),
                    DATE_O = ele.dateouverture.ToString(),
                    OBJET = ele.Objet,
                    TITRE_F = ele.Titrefoncier,
                    PRIX = ele.PRIX_ACQUISITION.ToString()
                }).ToList();
                bunifuDataGridView_list_dossier.DataSource = ListDataSource;
                textBox_anne_vente.Text = DateTime.Now.Year.ToString();

                THEME.operation($"COSULTER DES DOSSIERS");
            }
        }
        private void textBox_prix_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if(typeprix == "")
            {
                e.Handled = true;
                Point p = new Point(Cursor.Position.X, Cursor.Position.Y);
                contextMenuStrip_vente_location.Show(p);
            }
            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
        private void textBox_titre_foncier_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBox_anne_vente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBox_anne_achat_KeyPress(object sender, KeyPressEventArgs e)
        {
        //    if ((textBox_anne_achat.Text.Length+1 == 4) && e.KeyChar == (char)Keys.Delete)
        //        e.Handled = false;
        //    if ((textBox_anne_achat.Text.Length+1 == 4))
        //        e.Handled = true;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                    e.Handled = true;
            }
        }
        private void buttonadd_add_objs_Click_1(object sender, EventArgs e)
        {
            if (textBox_N_dossier.Text != "")
            { 
                THEME.numdossierobj = textBox_N_dossier.Text;
                var d = cls_Bl_Dossier.FindByValues(ele => ele.Numdossier == textBox_N_dossier.Text).FirstOrDefault();
                var objs = CLS_OBJET_BL.FindByValues(ele => ele.numdossier == textBox_N_dossier.Text).FirstOrDefault();
                if (objs == null && d != null)
                {
                    THEME.numdossierobj = "";
                    return;
                }
                if (objs == null && d == null)
                {
                    THEME.numdossierobj = "";                    
                }
                else if (objs != null && d != null)
                {
                    new ADD_OBJ().Show();
                    return;
                }
            }
            DialogResult dr = MessageBox.Show("VOULEZ VOUS REDACTION CONTRAT D'ECHANGE ?", "Confirmation", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    new ADD_OBJ().Show();
                    textBox_obj.Enabled = false;
                    typeprix = "change";
                }
                else
                {
                    textBox_obj.Enabled = true;
                    THEME.numdossierobj = "";
                    THEME.objs.Clear();
                    typeprix = "";
                }
        }
        private void textBox_prix_Click(object sender, EventArgs e)
        {
            Point p = new Point(Cursor.Position.X, Cursor.Position.Y);
            contextMenuStrip_vente_location.Show(p);
        }
        private void pourVenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            typeprix = "vente";
            label_vent_location.Text = "ANNE DE VENTE :";
        }
        private void pourLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            typeprix = "location";
            label_vent_location.Text = "LA DERU (MOINS) :";
        }

        private void annulerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            typeprix = "";
            label_vent_location.Text = "ANNE DE VENTE :";
        }

        private void textBox_anne_achat_TextChanged(object sender, EventArgs e)
        {

        }

        private void annulerToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
    public class dossierSerche
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
