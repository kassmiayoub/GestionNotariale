﻿using Bunifu.UI.WinForms;
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
        public static ComboBox client_or_dossier = null;
        public static Panel p = null;
        public static Type T = null;
        public static bool credit = false;
        public static string numdossier = "";
        public static int id_C = 0;
        public static double prix = 0;
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
        public static void add_controls_to_panel()
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
        public static void navigat(Type t)
        {
            if(client_or_dossier != null)
                {
                ((Button)ADD_DOSSIER.Controls["ButtonEdit_dossier"]).Enabled = true;
                ((Button)ADD_DOSSIER.Controls["button_detail_dossier"]).Enabled = true;
                ((Button)ADD_DOSSIER.Controls["ButtonAdd_dossier"]).Enabled = true;
                ((Button)add_Client.Controls["bunifuPages1"].Controls["tabPage_CLIENT"].Controls["ButtonEdit"]).Enabled = true;
                ((Button)add_Client.Controls["bunifuPages1"].Controls["tabPage_CLIENT"].Controls["ButtonInit"]).Enabled = true;
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
    }
    public class cliente
    {
        [DisplayName("IDCIENT")]
        public int IDCIENT { get; set; }
        [DisplayName("NOMCOMPLET")]
        public string nomcomplet { get; set; }       
    }
}
