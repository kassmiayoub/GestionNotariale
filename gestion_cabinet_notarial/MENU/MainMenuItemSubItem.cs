using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using gestion_cabinet_notarial.Properties;
//using MAZ_Lawyer.PL.PL_THEMES.CUSROM_MESSAGE_BOX;

namespace gestion_cabinet_notarial
{
    public partial class MainMenuItemSubItem : UserControl
    {
        public string SubItemName { get; set; }
        public EventHandler EH { get; set; }
        public string Function { get; set; }
        public MainMenuItemSubItem()
        {
            InitializeComponent();
        }
        public MainMenuItemSubItem(string SubItemName, EventHandler EH/*, string Function = ""*/) : this()
        {
           
         
            this.SubItemName = SubItemName;
            LabelSubItemName.Text = this.SubItemName;
            this.EH = EH;
            this.Function = Function;
            SetOnClickEvent(EH);
        }
        private void MainMenuItemSubItem_MouseHover(object sender, EventArgs e)
        {
            PictureBoxArrow.Image = Resources.RightArrowMouseHover;
            LabelSubItemName.ForeColor = Color.FromArgb(35, 160, 198);
        }

        private void MainMenuItemSubItem_MouseLeave(object sender, EventArgs e)
        {
            PictureBoxArrow.Image =Resources.RightArrow;
            LabelSubItemName.ForeColor = default(Color);
        }
        public void SetOnClickEvent(EventHandler EH)
        {
            //if (Theme.LOGNED_USER != null && (Function == "" || Theme.LOGNED_USER.DevlopperUser != null && Theme.LOGNED_USER.DevlopperUser.Value == 1))
            //{
                Click += EH;
                LabelSubItemName.Click += EH;
                PictureBoxArrow.Click += EH;
           // }
            //else
            //{
            //    if (Theme.LOGNED_USER.USERS_FUNCTIONS.Any(ele => ele.Function == Function))
            //    {
                    //Click += EH;
                    //LabelSubItemName.Click += EH;
                    //PictureBoxArrow.Click += EH;
                //}
                //else
                //{
                //    Click += (se, ev) => ShowNotAutMessage();
                //    LabelSubItemName.Click += (se, ev) => ShowNotAutMessage();
                //    PictureBoxArrow.Click += (se, ev) => ShowNotAutMessage();
                //}
            }
        }

      // private void ShowNotAutMessage() => MessageBox.Show("غيـر مصـرح", "غيـر مصـرح لك الدخـول إلـى هده الخاصيـة"/*, MessageBoxIcon.Information, MessageBoxButtons.OK*/);
    }

