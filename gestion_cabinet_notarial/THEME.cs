using Bunifu.UI.WinForms;
using gestion_cabinet_notarial.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_cabinet_notarial
{
    internal static class THEME
    {

        public static string numdossier = "";
        public static double prix =0;
        public static ADD_DOSSIER ADD_DOSSIER { get; set; }
        public static CTL_CREDIT CTL_CREDIT { get; set; }
        public static DETAIL_CONTRAT DETAIL_CONTRAT { get; set; }
        public static detail_dossier detail_dossier { get; set; }
        public static Panel MainControlPanel { get; set; }
        public static add_client add_Client { get; set; }
        public static LIST_CLIENT LIST_CLIENT { get; set; }
        public static List<Control> ControlsList { get; set; } = new List<Control>();
        private static void AddControlToPanel()
        {
            ControlsList.ForEach(ele => MainControlPanel.Controls.Add(ele));
        }
        public static void add_controls_to_panel(Panel p)
        {
            create_obj_ctl();
            AddControlsToList();
            ControlsList.ForEach(ele => p.Controls.Add(ele));
        }
        public static void AddControlsToList()
        {
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
            CTL_CREDIT = new CTL_CREDIT() { Visible = false };
            DETAIL_CONTRAT = new DETAIL_CONTRAT() { Visible = false };
            detail_dossier = new detail_dossier() { Visible = false };
            add_Client = new add_client() { Visible = false };
            LIST_CLIENT = new LIST_CLIENT() { Visible=false };
        }
        public static void navigat(Type t, Panel p)
        {
            if (t == typeof(detail_dossier))
            {
                CSL_BL_Client cls = new CSL_BL_Client();
                //BunifuDropdown d = (BunifuDropdown)findControl(detail_dossier, "bunifuDropdownclient");
                BunifuDropdown d = (BunifuDropdown)detail_dossier.Controls["bunifuPages1"].Controls["tabPage1"].Controls["panel2"].Controls["bunifuDropdownclient"];
                //string a = detail_dossier.Controls["bunifuPages1"].Controls[0].Controls["bunifuDropdownclient"].Name;
                //BunifuDropdown d= (BunifuDropdown)detail_dossier.Controls["bunifuDropdownclient"];
                var ListDataSource = new List<cliente>();
                ListDataSource = cls.GetAll().Select(ele => new cliente()
                {
                   IDCIENT= ele.idClient,
                   nomcomplet=ele.Nom+" "+ele.Prenom,
                }).ToList();
                d.DataSource= ListDataSource;
                d.DisplayMember = "nomcomplet";
                d.ValueMember= "IDCIENT";
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
    }
    public class cliente
    {
        [DisplayName("IDCIENT")]
        public int IDCIENT { get; set; }
        [DisplayName("NOMCOMPLET")]
        public string nomcomplet { get; set; }       
    }
}
