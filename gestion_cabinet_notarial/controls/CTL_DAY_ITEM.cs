using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace gestion_cabinet_notarial
{
    public partial class CTL_DAY_ITEM : UserControl
    {
        public int ItemName { get; set; }
        public DAY_ITEM_STATE State { get; set; }
        public EventHandler EH { get; set; }
        public CTL_AGENDA Agenda { get; set; }
        static public string datecomlet = null;        
        public CTL_DAY_ITEM()
        {
            InitializeComponent();
        }
        public CTL_DAY_ITEM(int ItemName, DAY_ITEM_STATE State, EventHandler EH = null) : this()
        {
            this.EH = EH;
            this.ItemName = ItemName;
            LabelDayNumber.Text = ItemName.ToString();
            this.State = State;
            BackgroundImage = null;
            BackColor = Color.Transparent;
            LabelDayNumber.ForeColor = SystemColors.AppWorkspace;
            //Timer T = new Timer { Interval = 100 };
            //T.Start();
            //T.Tick += (se,ev) =>
            //{
            //    if(Parent.Parent != null)
            //    {
            //        Agenda = (CTL_AGENDA)Parent.Parent;
            //        T.Stop();
            //    }
            //};
            if (State == DAY_ITEM_STATE.EMPTY)
                BackColor = Color.White;            
            BackgroundImageLayout = ImageLayout.Center;
            if (EH != null)
            {
                Click += EH;
                LabelDayNumber.Click += EH;
            }
        }

        private void CTL_DAY_ITEM_MouseHover(object sender, System.EventArgs e)
        {
            if (State == DAY_ITEM_STATE.CURRENT_NOTIFICATIONS || State == DAY_ITEM_STATE.CURRENT_NO_NOTIFICATIONS)
                return;
            BackgroundImage = null;
            BackColor = Color.Transparent;
            if (State == DAY_ITEM_STATE.EMPTY)
                BackgroundImage = Properties.Resources.DayItemEmptyMouseHover;
            else if (State == DAY_ITEM_STATE.NOTIFICATIONS)
                BackgroundImage = Properties.Resources.DayItemHasNotificationMouseHover;
            BackgroundImageLayout = ImageLayout.Center;
        }

        private void CTL_DAY_ITEM_MouseLeave(object sender, System.EventArgs e)
        {
            if (State == DAY_ITEM_STATE.CURRENT_NOTIFICATIONS || State == DAY_ITEM_STATE.CURRENT_NO_NOTIFICATIONS)
                return;
            BackgroundImage = null;
            BackColor = Color.Transparent;
            LabelDayNumber.ForeColor = SystemColors.AppWorkspace;
            if (State == DAY_ITEM_STATE.EMPTY)
                BackColor = Color.White;           
            BackgroundImageLayout = ImageLayout.Center;
        }

        public void CTL_DAY_ITEM_Click(object sender, EventArgs e)
        {
            Agenda.SelectedDay = ItemName;
            Agenda.PanelDays.Controls.Cast<CTL_DAY_ITEM>().ToList().ForEach(ele =>
            {
                if (ele.State == DAY_ITEM_STATE.CURRENT_NOTIFICATIONS)
                {
                    ele.BackgroundImage = null;
                    ele.BackColor = Color.Transparent;
                    ele.BackgroundImage = Properties.Resources.DayItemHasNotification;
                    ele.LabelDayNumber.ForeColor = SystemColors.AppWorkspace;
                    ele.State = DAY_ITEM_STATE.NOTIFICATIONS;
                    ele.BackgroundImageLayout = ImageLayout.Center;
                }
                else if (ele.State == DAY_ITEM_STATE.CURRENT_NO_NOTIFICATIONS)
                {
                    ele.BackgroundImage = null;
                    ele.BackColor = Color.Transparent;
                    ele.BackColor = Color.White;
                    ele.LabelDayNumber.ForeColor = SystemColors.AppWorkspace;
                    ele.State = DAY_ITEM_STATE.EMPTY;
                    ele.BackgroundImageLayout = ImageLayout.Center;
                }
            });
            BackgroundImage = null;
            BackColor = Color.Transparent;
            if (State == DAY_ITEM_STATE.EMPTY)
            {
                BackgroundImage = Properties.Resources.DayItemCurrentNoNotification;
                LabelDayNumber.ForeColor = Color.White;
                State = DAY_ITEM_STATE.CURRENT_NO_NOTIFICATIONS;
            }
            else if (State == DAY_ITEM_STATE.NOTIFICATIONS)
            {
                BackgroundImage = Properties.Resources.DayItemCurrentHasNotification;
                LabelDayNumber.ForeColor = Color.White;
                State = DAY_ITEM_STATE.CURRENT_NOTIFICATIONS;
            }
            BackgroundImageLayout = ImageLayout.Center;
            var date = new DateTime(Agenda.Selectedyear, Agenda.Selectedmonth, ItemName);
            datecomlet = date.ToString();
            Agenda.time_reserve();
        }
    }
    public enum DAY_ITEM_STATE
    {
        EMPTY = 1,
        NOTIFICATIONS = 2,
        CURRENT_NOTIFICATIONS = 3,
        CURRENT_NO_NOTIFICATIONS = 4,
    }
}
