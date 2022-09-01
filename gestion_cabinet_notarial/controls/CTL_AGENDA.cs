using gestion_cabinet_notarial.BL;
using gestion_cabinet_notarial.context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace gestion_cabinet_notarial
{
    public partial class CTL_AGENDA : UserControl
    {
        cls_bl_rendez_vous rv = new cls_bl_rendez_vous();
        CSL_BL_Client cls = new CSL_BL_Client();
        private string[] Months = { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };       
        private int NavigationMonth = DateTime.Now.Month - 1;
        public int SelectedDay { get; set; } = DateTime.Now.Day;
        public int Selectedyear { get; set; } = DateTime.Now.Year;
        public int Selectedmonth { get; set; } = DateTime.Now.Month;
        private bool FirstLoad = false;
        private bool curent = false;
        public string time_d = null;
        public string time_fin = null;
        public List<string> tm = new List<string>();
        public int curentmonth { get; set; } = DateTime.Now.Month;
        public CTL_AGENDA()
        {
            InitializeComponent();
            ChangeMonth();
        }
        public void time_reserve()
        {
            var dt = rv.GetAll().Where(ele => ele.datee == Convert.ToDateTime(CTL_DAY_ITEM.datecomlet)).ToList();
            foreach (DataGridViewRow r in bunifuDataGridView_list_times.Rows)
            {
                foreach (DataGridViewCell cell in r.Cells)
                {
                    DataGridViewButtonCell b = (DataGridViewButtonCell)cell;
                        b.Style.BackColor = Color.Green;
                }
            }
            dt.ForEach(rdv =>
            {
                foreach (DataGridViewRow r in bunifuDataGridView_list_times.Rows)
                {
                    foreach (DataGridViewCell cell in r.Cells)
                    {
                        DataGridViewButtonCell b = (DataGridViewButtonCell)cell;
                        if (rdv.Timedebut == cell.Value.ToString())
                        {
                            b.Style.BackColor = Color.Red;
                            b.Tag=b.Value+"|"+rdv.idClient.ToString();  
                        }                            
                    }
                }
            });
        }
        public void ChangeMonth()
        {
            MessageBox.Show((NavigationMonth + 1).ToString());
            Selectedmonth = NavigationMonth + 1;
            if (curent)
                NavigationMonth = curentmonth - 1;
            LabelMonth.Text = Months[NavigationMonth];
            LoadData();
        }
        private void LoadData()
        {
            PanelDays.Controls.Clear();
            for (int i = 1; i <= DateTime.DaysInMonth(DateTime.Now.Year, NavigationMonth + 1); i++)
            {
                CTL_DAY_ITEM CTL_TMP = null;
                //if (1==1)
                //{
                //    var CTL = new CTL_DAY_ITEM(i, DAY_ITEM_STATE.NOTIFICATIONS) {Agenda = this};
                //    CTL_TMP = CTL;
                //    PanelDays.Controls.Add(CTL);
                //}
                //else
                //{
                var CTL = new CTL_DAY_ITEM(i, DAY_ITEM_STATE.EMPTY) { Agenda = this };
                CTL_TMP = CTL;
                PanelDays.Controls.Add(CTL);
                // }
                if (!FirstLoad && i == DateTime.Now.Day)
                {
                    Selectedmonth = DateTime.Now.Month;
                    SelectedDay = DateTime.Now.Day;
                    Selectedyear = DateTime.Now.Year;
                    CTL_TMP.CTL_DAY_ITEM_Click(null, null);
                    FirstLoad = true;
                }
            }
        }
        private void ButtonNextMonth_Click(object sender, EventArgs e)
        {
            NavigationMonth++;
            if (NavigationMonth > 11)
                NavigationMonth = 0;
            ChangeMonth();
            time_reserve();
        }
        private void ButtonPrevMonth_Click(object sender, EventArgs e)
        {
            NavigationMonth--;
            if (NavigationMonth < 0)
                NavigationMonth = 11;
            ChangeMonth();
            time_reserve();
        }
        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            curent = true;
            yers.Text = DateTime.Now.Year.ToString(); 
            FirstLoad = false;       
            ChangeMonth();
            curent = false;
            time_reserve();
        }
        private void CTL_AGENDA_Load(object sender, EventArgs e)
        {
            yers.Text = Selectedyear.ToString();
            string[] row = new string[] { };
            bunifuDataGridView_list_times.Rows.Add(row);
            bunifuDataGridView_list_times.Rows.Add(row);
            bunifuDataGridView_list_times.Rows.Add(row);
            bunifuDataGridView_list_times.Rows.Add(row);
            bunifuDataGridView_list_times.Rows.Add(row);
            bunifuDataGridView_list_times.Rows.Add(row);
            bunifuDataGridView_list_times.Rows.Add(row);
            bunifuDataGridView_list_times.Rows.Add(row);
            bunifuDataGridView_list_times.Rows[0].Cells[0].Value = "08:00";
            bunifuDataGridView_list_times.Rows[0].Cells[1].Value = "10:00";
            bunifuDataGridView_list_times.Rows[0].Cells[2].Value = "12:00";
            bunifuDataGridView_list_times.Rows[0].Cells[3].Value = "14:00";
            bunifuDataGridView_list_times.Rows[0].Cells[4].Value = "16:00";
            bunifuDataGridView_list_times.Rows[1].Cells[0].Value = "08:15";
            bunifuDataGridView_list_times.Rows[1].Cells[1].Value = "10:15";
            bunifuDataGridView_list_times.Rows[1].Cells[2].Value = "12:15";
            bunifuDataGridView_list_times.Rows[1].Cells[3].Value = "14:15";
            bunifuDataGridView_list_times.Rows[1].Cells[4].Value = "16:15";
            bunifuDataGridView_list_times.Rows[2].Cells[0].Value = "08:30";
            bunifuDataGridView_list_times.Rows[2].Cells[1].Value = "10:30";
            bunifuDataGridView_list_times.Rows[2].Cells[2].Value = "12:30";
            bunifuDataGridView_list_times.Rows[2].Cells[3].Value = "14:30";
            bunifuDataGridView_list_times.Rows[2].Cells[4].Value = "16:30";
            bunifuDataGridView_list_times.Rows[3].Cells[0].Value = "08:45";
            bunifuDataGridView_list_times.Rows[3].Cells[1].Value = "10:45";
            bunifuDataGridView_list_times.Rows[3].Cells[2].Value = "12:45";
            bunifuDataGridView_list_times.Rows[3].Cells[3].Value = "14:45";
            bunifuDataGridView_list_times.Rows[3].Cells[4].Value = "16:45";
            bunifuDataGridView_list_times.Rows[4].Cells[0].Value = "09:00";
            bunifuDataGridView_list_times.Rows[4].Cells[1].Value = "11:00";
            bunifuDataGridView_list_times.Rows[4].Cells[2].Value = "13:00";
            bunifuDataGridView_list_times.Rows[4].Cells[3].Value = "15:00";
            bunifuDataGridView_list_times.Rows[4].Cells[4].Value = "17:00";
            bunifuDataGridView_list_times.Rows[5].Cells[0].Value = "09:15";
            bunifuDataGridView_list_times.Rows[5].Cells[1].Value = "11:15";
            bunifuDataGridView_list_times.Rows[5].Cells[2].Value = "13:15";
            bunifuDataGridView_list_times.Rows[5].Cells[3].Value = "15:15";
            bunifuDataGridView_list_times.Rows[5].Cells[4].Value = "17:15";
            bunifuDataGridView_list_times.Rows[6].Cells[0].Value = "09:30";
            bunifuDataGridView_list_times.Rows[6].Cells[1].Value = "11:30";
            bunifuDataGridView_list_times.Rows[6].Cells[2].Value = "13:30";
            bunifuDataGridView_list_times.Rows[6].Cells[3].Value = "15:30";
            bunifuDataGridView_list_times.Rows[6].Cells[4].Value = "17:30";
            bunifuDataGridView_list_times.Rows[7].Cells[0].Value = "09:45";
            bunifuDataGridView_list_times.Rows[7].Cells[1].Value = "11:45";
            bunifuDataGridView_list_times.Rows[7].Cells[2].Value = "13:45";
            bunifuDataGridView_list_times.Rows[7].Cells[3].Value = "15:45";
            bunifuDataGridView_list_times.Rows[7].Cells[4].Value = "17:45";
            foreach (DataGridViewRow r in bunifuDataGridView_list_times.Rows)
            {
                //MessageBox.Show(r.Cells[0].Value);
                DataGridViewButtonCell time1 = (DataGridViewButtonCell)r.Cells[0];
                time1.FlatStyle = FlatStyle.Popup;
                time1.Style.BackColor = Color.Green;
                DataGridViewButtonCell time2 = (DataGridViewButtonCell)r.Cells[1];
                time2.FlatStyle = FlatStyle.Popup;
                time2.Style.BackColor = Color.Green;
                DataGridViewButtonCell time3 = (DataGridViewButtonCell)r.Cells[2];
                time3.FlatStyle = FlatStyle.Popup;
                time3.Style.BackColor = Color.Green;
                DataGridViewButtonCell time4 = (DataGridViewButtonCell)r.Cells[3];
                time4.FlatStyle = FlatStyle.Popup;
                time4.Style.BackColor = Color.Green;
                DataGridViewButtonCell time5 = (DataGridViewButtonCell)r.Cells[4];
                time5.FlatStyle = FlatStyle.Popup;
                time5.Style.BackColor = Color.Green;

                //b.UseColumnTextForButtonValue = true;
                //b.Text = "aaa";
            }
            var ListDataSource = new List<clien>();
            ListDataSource = cls.GetAll().Select(ele => new clien()
            {
                IDCIENT = ele.idClient,
                nomcomplet = ele.Nom + " " + ele.Prenom
            }).ToList();
            bunifuDropdown_client_rendez.DataSource = ListDataSource;
            bunifuDropdown_client_rendez.DisplayMember = "NOMCOMPLET";
            bunifuDropdown_client_rendez.ValueMember = "IDCIENT";
            bunifuDataGridView_list_times.Rows[0].Cells[0].Selected= false;
            time_reserve();
        }

        private void button_next_year_Click(object sender, EventArgs e)
        {
            yers.Text = (int.Parse(yers.Text) + 1).ToString();
            Selectedyear = int.Parse(yers.Text);
            time_reserve();
        }

        private void button_prev_year_Click(object sender, EventArgs e)
        {
            yers.Text = (int.Parse(yers.Text) - 1).ToString();
            Selectedyear =int.Parse(yers.Text);
            time_reserve();

        }
        public class clien
        {
            [DisplayName("IDCIENT")]
            public int IDCIENT { get; set; }
            [DisplayName("NOMCOMPLET")]
            public string nomcomplet { get; set; }
        }

        private void ButtonAdd_rendez_vous_Click(object sender, EventArgs e)
        {
            if (tm.Count == 0)
                return;
            var redvs = new List<Rendez_vous>();
            for (int i = 0; i < tm.Count; i++)
            { 
                var redv = new Rendez_vous();
                redv.idClient = (int)bunifuDropdown_client_rendez.SelectedValue;
                redv.datee = Convert.ToDateTime(CTL_DAY_ITEM.datecomlet);
                redv.description = richTextBox_description.Text;
                if (tm.Count > 1)
                {
                    //redv.Timedebut =dateTime;
                    redv.Timedebut = tm[i].ToString();
                }
                else
                {
                    //redv.Timedebut = dateTime;
                    redv.Timedebut = tm[i].ToString();
                }
                redvs.Add(redv);
            }
            tm.Clear();
            rv.AddRange(redvs);
        }

        private void bunifuDataGridView_list_times_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewButtonCell time1;
            try
            {
                time1 = (DataGridViewButtonCell)bunifuDataGridView_list_times.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
            catch
            {
                return;
            }
            string time = time1.Value.ToString();
            if (time1.Style.BackColor == Color.Red)
            {
                int endIndex = ((string)time1.Tag).Length;
                int title =int.Parse(((string)time1.Tag).Substring(6, endIndex-6));
                bunifuDropdown_client_rendez.SelectedValue = title;            
               // richTextBox_description.Text = rv.FindById(title);                                
                time1.Selected = false;
                return;
            }             
            if(time1.Style.BackColor == Color.Orange)
            {
                tm.Remove(time);
                time1.Style.BackColor = Color.Green;
                time1.Selected = false;
                return;
            }
            tm.Add(time);
            time1.Style.BackColor = Color.Orange;
            time1.Selected = false;
        }
        private void ButtonSerch_client_Click(object sender, EventArgs e)
        {
            ((Button)this.Parent.Controls["add_client"].Controls["bunifuPages1"].Controls["tabPage_CLIENT"].Controls["ButtonEdit"]).Enabled = false;
            ((Button)this.Parent.Controls["add_client"].Controls["bunifuPages1"].Controls["tabPage_CLIENT"].Controls["ButtonAdd"]).Enabled = false;
            THEME.T = this.GetType();
            THEME.navigat(typeof(add_client));
            THEME.client_or_dossier = (ComboBox)this.Controls["bunifuDropdown_client_rendez"];
        }
    }
}
