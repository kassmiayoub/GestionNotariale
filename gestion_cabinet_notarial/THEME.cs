using Bunifu.UI.WinForms;
using gestion_cabinet_notarial.BL;
using gestion_cabinet_notarial.context;
using gestion_cabinet_notarial.controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_cabinet_notarial
{
    internal static class THEME
    {
        static CLS_BL_LOG LOG = new CLS_BL_LOG();
        // directory files
        public static string clientDirectoryPath = Path.Combine(getExecutableDirectory(), "files", "client");
        public static string dossierDirectoryPath = Path.Combine(getExecutableDirectory(), "files", "dossier");
        public static string contratDirectoryPath = Path.Combine(getExecutableDirectory(), "files", "contrat");

        public static ComboBox client_or_dossier = null;
        public static Panel p = null;
        public static Type T = null;
        public static bool credit = false;
        public static string numdossier = "";
        public static string utilisateur = "";
        public static int id_C = 0;
        public static int id_Client = 0;
        public static string id_user = "";
        public static string id_user_modifier = "";
        public static double prix = 0;
        public static ADD_DOSSIER ADD_DOSSIER { get; set; }
        public static Accueil Accueil { get; set; }
        public static CTL_CREDIT CTL_CREDIT { get; set; }
        public static CTL_PARAMETER_AJOUTER_UTILISATUER AJOUTER_UTILISATUER { get; set; }
        public static DETAIL_CONTRAT DETAIL_CONTRAT { get; set; }
        public static detail_dossier detail_dossier { get; set; }
        public static Panel MainControlPanel { get; set; }
        public static add_client add_Client { get; set; }
        public static LIST_CLIENT LIST_CLIENT { get; set; }
        public static CTL_BANQUE CTL_BANQUE { get; set; }
        public static CTL_NOTE CTL_NOTE { get; set; }
        public static CTL_AGENDA CTL_AGENDA { get; set; }
        public static CTL_LIST_UTILATUER CTL_LIST_UTILATUER { get; set; }
        public static CTL_modifier_compte CTL_modifier_compte { get; set; }        
        public static CTL_DATABASE CTL_DATABASE { get; set; }
        public static CTL_LIST__operation CTL_LIST__operation { get; set; }
        public static List<Control> ControlsList { get; set; } = new List<Control>();
        public static List<string> fonctionnalete { get; set; } = new List<string>();
        private static void AddControlToPanel()
        {
            ControlsList.ForEach(ele => MainControlPanel.Controls.Add(ele));
        }
        public static void add_controls_to_panel()
        {
            create_obj_ctl();
            AddControlsToList();
            ControlsList.ForEach(ele => p.Controls.Add(ele));
        }
        public static void AddControlsToList()
        {
            ControlsList.Add(CTL_AGENDA);
            ControlsList.Add(CTL_LIST__operation);
            ControlsList.Add(CTL_DATABASE);
            ControlsList.Add(CTL_modifier_compte);
            ControlsList.Add(CTL_LIST_UTILATUER);
            ControlsList.Add(AJOUTER_UTILISATUER);
            ControlsList.Add(Accueil);
            ControlsList.Add(CTL_BANQUE);
            ControlsList.Add(CTL_NOTE);
            ControlsList.Add(ADD_DOSSIER);
            ControlsList.Add(CTL_CREDIT);
            ControlsList.Add(DETAIL_CONTRAT);
            ControlsList.Add(detail_dossier);
            ControlsList.Add(add_Client);
            ControlsList.Add(LIST_CLIENT);
        }
            private static void create_obj_ctl()
        {
            ADD_DOSSIER = new ADD_DOSSIER() { Visible = false };
            CTL_LIST__operation = new CTL_LIST__operation() { Visible = false };
            CTL_DATABASE = new CTL_DATABASE() { Visible = false };
            CTL_modifier_compte = new CTL_modifier_compte() { Visible = false };
            CTL_LIST_UTILATUER = new CTL_LIST_UTILATUER() { Visible = false };
            AJOUTER_UTILISATUER = new CTL_PARAMETER_AJOUTER_UTILISATUER() { Visible = false };
            Accueil = new Accueil() { Visible = false };
            CTL_BANQUE = new CTL_BANQUE() { Visible = false };
            CTL_CREDIT = new CTL_CREDIT() { Visible = false };
            DETAIL_CONTRAT = new DETAIL_CONTRAT() { Visible = false };
            detail_dossier = new detail_dossier() { Visible = false };
            add_Client = new add_client() { Visible = false };
            LIST_CLIENT = new LIST_CLIENT() { Visible=false };
            CTL_AGENDA = new CTL_AGENDA() { Visible = false };
            CTL_NOTE = new CTL_NOTE() { Visible = false };

        }
        public static void operation(string text)
        {
            var a = new log();
            a.utilisateur = id_user;
            a.Text = text;
            a.Date = DateTime.Now;
            LOG.Add(a);
        }
        public static void navigat(Type t)
        {
            if(client_or_dossier != null)
                {
                ((Button)ADD_DOSSIER.Controls["ButtonEdit_dossier"]).Enabled = true;
                ((Button)ADD_DOSSIER.Controls["button_detail_dossier"]).Enabled = true;
                ((Button)ADD_DOSSIER.Controls["ButtonAdd_dossier"]).Enabled = true;
                ((Button)add_Client.Controls["bunifuPages1"].Controls["tabPage_CLIENT"].Controls["ButtonEdit"]).Enabled = true;
                ((Button)add_Client.Controls["bunifuPages1"].Controls["tabPage_CLIENT"].Controls["ButtonAdd"]).Enabled = true;
                client_or_dossier = null;
                T = null;
            }
            if (t == typeof(detail_dossier))
            {
                CSL_BL_Client cls = new CSL_BL_Client();
                //BunifuDropdown d = (BunifuDropdown)findControl(detail_dossier, "bunifuDropdownclient");
                BunifuDropdown bunifuDropdownclient = (BunifuDropdown)detail_dossier.Controls["bunifuPages1"].Controls["tabPage1"].Controls["panel2"].Controls["bunifuDropdownclient"];
                var ListDataSource = new List<cliente>();
                ListDataSource = cls.GetAll().Select(ele => new cliente()
                {
                   IDCIENT= ele.idClient,
                   nomcomplet=ele.Nom+" "+ele.Prenom,
                }).ToList();
                bunifuDropdownclient.DataSource= ListDataSource;
                bunifuDropdownclient.DisplayMember = "nomcomplet";
                bunifuDropdownclient.ValueMember= "IDCIENT";
            }
            if (t == typeof(DETAIL_CONTRAT))
            {
                CSL_BL_Client cls = new CSL_BL_Client();
                //BunifuDropdown d = (BunifuDropdown)findControl(detail_dossier, "bunifuDropdownclient");
                ComboBox comboBoxCLIENT_PY = (ComboBox)DETAIL_CONTRAT.Controls["bunifuPages1"].Controls["payeclient"].Controls["comboBoxCLIENT_PY"];
                ComboBox comboBox_banque_PY = (ComboBox)DETAIL_CONTRAT.Controls["bunifuPages1"].Controls["payeclient"].Controls["comboBox_banque_PY"];
                ComboBox comboBox_TYPE_CHARGE = (ComboBox)DETAIL_CONTRAT.Controls["bunifuPages1"].Controls["payeclient"].Controls["comboBox_TYPE_CHARGE"];
                var ListDataSource = new List<cliente>();
                ListDataSource = new cls_bl_partes().GetAll().Where(x => x.numdossier == numdossier).Select(x => new cliente()
                {
                    IDCIENT = x.client.idClient,
                    nomcomplet = $"{x.client.Nom} {x.client.Prenom}"
                }).ToList();
                comboBoxCLIENT_PY.DataSource = ListDataSource;
                comboBoxCLIENT_PY.DisplayMember = "nomcomplet";
                comboBoxCLIENT_PY.ValueMember = "IDCIENT";

                //var ListDataSource1 = new List<cliente>();
               var ListDataSource1 = new cls_bl_banque().GetAll().Where(x => x.Idbanque != 3).ToList();
                comboBox_banque_PY.DataSource = ListDataSource1;
                comboBox_banque_PY.DisplayMember = "Libbele"; 
                comboBox_banque_PY.ValueMember = "Idbanque";
                comboBox_banque_PY.Enabled=false;
                comboBox_TYPE_CHARGE.Items.Add("Enregistrement");
                comboBox_TYPE_CHARGE.Items.Add("Ancfcc");
                comboBox_TYPE_CHARGE.Items.Add("Timbres");
                comboBox_TYPE_CHARGE.Items.Add("Honoraires");
                comboBox_TYPE_CHARGE.Items.Add("CDG");
            }
            p.Controls.Cast<Control>().ToList().ForEach(ele => ele.Visible = false);
            Control c = p.Controls.Cast<Control>().First(ele => ele.GetType() == t);
            c.Width = p.Width;
            c.Height = p.Height;
            c.Visible = true;
        }
        public static void add_btn_to_datagrid(DataGridView dgv,string name ,string text,int index)
        {
            DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
            uninstallButtonColumn.Name = name;
            uninstallButtonColumn.Text = text;
            uninstallButtonColumn.UseColumnTextForButtonValue = true;
            if (dgv.Columns[name] == null)
            {
                dgv.Columns.Insert(index, uninstallButtonColumn);
            }
            else
            {
                dgv.Columns[name].DisplayIndex = dgv.Columns.Count - 1;
            }
        }
        public static void add_checkbox_to_datagrid(DataGridView dgv, string name, int index)
        {
            DataGridViewCheckBoxColumn uninstallButtonColumn = new DataGridViewCheckBoxColumn();
            uninstallButtonColumn.Name = name;
            if (dgv.Columns[name] == null)
            {
                dgv.Columns.Insert(index, uninstallButtonColumn);
            }
        }
        public static Control findControl(Control parent, string controlToFindName)
        {
            if (parent.Name == controlToFindName)
            {
                return parent;
            }
            else
            {
                try
                {
                    foreach (Control c in parent.Controls)
                    {
                        if (c.Name == controlToFindName)
                        {
                            return c;
                        }                      
                        else if (c.Controls.Count > 0)
                        {
                            foreach (Control c2 in c.Controls)
                            {
                                return findControl(c2, controlToFindName);
                            }
                                //return findControl(c, controlToFindName);
                            }
                    }
                }
                catch (Exception)
                {

                    return null;
                }
            }
            return null;

        }
        public static void vider(Control c)
        {
            foreach(Control c2 in c.Controls)
            {
                if(c2 is BunifuTextBox || c2 is TextBox)
                {
                    c2.Text = "";
                }
                else if(c2 is ComboBox || c2 is BunifuDropdown)
                {
                    try
                    {
                        ComboBox cb = (ComboBox)c2;
                        cb.SelectedIndex = -1;
                    }
                    catch
                    {
                        BunifuDropdown cb = (BunifuDropdown)c2;
                        cb.SelectedIndex = -1;
                    }
                }
                else if(c2 is BunifuCheckBox)
                {
                    ((BunifuCheckBox)c2).Checked = false;
                }
                
            }
        }
        public static bool acceder(string condition)
        {
          foreach(string x in fonctionnalete)
            {
                if (x == condition)
                    return true;
            }
          return false;
        }
        // Executable File :
        public static string getExecutableFile()
        {
            return Assembly.GetExecutingAssembly().Location;
        }
        // Executable Directory :
        public static string getExecutableDirectory()
        {
            return Path.GetDirectoryName(getExecutableFile());
        }
        public static string CopyFile(string FilePath, string type ,string id )
        {
            string exeFilesPath = $@"{getExecutableDirectory()}\files";
            string exe_client = $@"{exeFilesPath}\client";
            string exe_dossier = $@"{exeFilesPath}\dossier";
            string exe_contrat = $@"{exeFilesPath}\contrat";
            if (!Directory.Exists(exeFilesPath))
            {
                // create images directory
                Directory.CreateDirectory(exeFilesPath);

                // create Patient directory in images directory
                Directory.CreateDirectory(exe_client);
                Directory.CreateDirectory(exe_dossier);
                Directory.CreateDirectory(exe_contrat);


            }
            DirectoryInfo DirectoryTYPEInfos;
            if (type == "client")
            {
                string client = $@"{exe_client}\{id}";
                if (Directory.Exists(client))
                    DirectoryTYPEInfos = new DirectoryInfo(client);                   
                else 
                {
                    Directory.CreateDirectory(client);
                    DirectoryTYPEInfos = new DirectoryInfo(client);
                }
            }
            else if(type == "dossier")
            {
                string dossier = $@"{exe_dossier}\{id}";
                if (Directory.Exists(dossier))
                    DirectoryTYPEInfos = new DirectoryInfo(dossier);
                else
                {
                    Directory.CreateDirectory(dossier);
                    DirectoryTYPEInfos = new DirectoryInfo(dossier);
                }
            }
            else
            {
                string contrat = $@"{exe_contrat}\{id}";
                if (Directory.Exists(contrat))
                    DirectoryTYPEInfos = new DirectoryInfo(contrat);
                else
                {
                    Directory.CreateDirectory(contrat);
                    DirectoryTYPEInfos = new DirectoryInfo(contrat);
                }
            }
            // info of the patient directory :
            // DirectoryInfo DirectoryClientInfos = new DirectoryInfo(exe_client);
            //// Secutity informations ////
            // info of the images file :
            FileInfo fi = new FileInfo(FilePath);
            FileSecurity fs = fi.GetAccessControl();
            DirectorySecurity ds = DirectoryTYPEInfos.GetAccessControl();
            fs.SetAccessRuleProtection(true, true);
            ds.SetAccessRuleProtection(true, true);
            fi.SetAccessControl(fs);
            DirectoryTYPEInfos.SetAccessControl(ds);
            // Copy the image to the executable directory :
            // Directory for the specified Patient :
            var Name = Path.GetFileName(FilePath);
            MessageBox.Show(FilePath);
            MessageBox.Show(Name);
            //var imageExtension = fi.Extension;
            if (!Directory.Exists($@"{exeFilesPath}\{DirectoryTYPEInfos}\{Name}"))
            {
                fi.CopyTo($@"{DirectoryTYPEInfos}\{Name}", true);
                return Name;
            }
            else
            {
                return "";
            }
                
            
        }
    }
    public class cliente
    {
        [DisplayName("IDCIENT")]
        public int IDCIENT { get; set; }
        [DisplayName("NOMCOMPLET")]
        public string nomcomplet { get; set; }       
    }
}
