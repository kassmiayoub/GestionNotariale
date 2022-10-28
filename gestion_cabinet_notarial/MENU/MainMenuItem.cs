using System;
using System.Drawing;
using gestion_cabinet_notarial.Properties;
using System.Windows.Forms;

namespace gestion_cabinet_notarial
{
    public partial class MainMenuItem : UserControl
    {
        public Image Icon { get; set; }
        public string ItemName { get; set; }
        public bool ShowDownArrow { get; set; }
        public int InitialHeight { get; set; } = 40;
        public int MaxHeight { get; set; } = 40;
        public bool Expanded { get; set; }
        public EventHandler EH { get; set; }
        public MainMenuItem()
        {
            InitializeComponent();
        }
        public MainMenuItem(Image Icon, string ItemName, bool ShowDownArrow, EventHandler EH, params MainMenuItemSubItem[] MainMenuItemSubItems) : this()
        {
            this.Icon = Icon;
            this.ItemName = ItemName;
            if (Icon != null)
                PictureBoxIcon.Image = Icon;
            this.ShowDownArrow = ShowDownArrow;
            PictureBoxArrow.Visible = ShowDownArrow;
            LabelItemName.Text = ItemName;
            this.EH = EH;
            if (MainMenuItemSubItems != null)
                foreach (var SI in MainMenuItemSubItems)
                {
                    FlowLayoutPanelSubItems.Controls.Add(SI);
                    FlowLayoutPanelSubItems.Height += 21;
                }
            MaxHeight = 50 + FlowLayoutPanelSubItems.Height;
            PictureBoxArrow.Image = Expanded ? Resources.TopArrow : Resources.DownArrow;
        }
        private void MainMenuItem_MouseHover(object sender, System.EventArgs e)
        {
            BackColor = Color.FromArgb(244, 245, 245);
            PictureBoxArrow.Image = Expanded ? Resources.TopArrow :Resources.DownArrow;
        }
        private void MainMenuItem_MouseLeave(object sender, System.EventArgs e)
        {
            BackColor = Color.White;
            PictureBoxArrow.Image = Expanded ?Resources.TopArrow :Resources.DownArrow;
        }
        private void MainMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                return;
            if (ShowDownArrow)
            {
                if (!Expanded)
                {
                    PanelBottomLine.Visible = false;
                    for (var i = InitialHeight; i <= MaxHeight; i += 3)
                        Height = i;
                    PanelBottomLine.Location = new Point(PanelBottomLine.Location.X, Size.Height - 1);
                    PanelBottomLine.Visible = true;
                    FlowLayoutPanelSubItems.Visible = true;
                    Expanded = true;
                    PictureBoxArrow.Image =Resources.TopArrow;
                }
                else
                {
                    PanelBottomLine.Visible = false;
                    for (var i = MaxHeight; i >= InitialHeight; i -= 3)
                        Height = i;
                    PanelBottomLine.Location = new Point(PanelBottomLine.Location.X, Size.Height - 1);
                    PanelBottomLine.Visible = true;
                    FlowLayoutPanelSubItems.Visible = false;
                    Expanded = false;
                    PictureBoxArrow.Image = Resources.DownArrow;
                }
            }
            if (LabelItemName.Text=="CDG")
            {
                if (!THEME.acceder("AFFICHIER LA LIST CDG"))
                {
                    MessageBox.Show("VOUS N'AVEZ PAS LA PERMISSION");
                    return;
                }
            }
            else if (LabelItemName.Text == "STATISTIQUE")
            {
                if (!THEME.acceder("statistique"))
                {
                    MessageBox.Show("VOUS N'AVEZ PAS LA PERMISSION");
                    return;
                }
            }
            else if(LabelItemName.Text == "FACTURE")
            {
                if (!THEME.acceder("facture"))
                {
                    MessageBox.Show("VOUS N'AVEZ PAS LA PERMISSION");
                    return;
                }
            }
            if (EH != null)
            {
                Click += EH;
                PanelBottomLine.Click += EH;
                FlowLayoutPanelSubItems.Click += EH;
                LabelItemName.Click += EH;
                PictureBoxArrow.Click += EH;
                PictureBoxIcon.Click += EH;
            }
        }
        private void LabelItemName_Click(object sender, EventArgs e)
        {

        }
    }
}
