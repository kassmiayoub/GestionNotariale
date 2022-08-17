using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_cabinet_notarial
{
    internal static class THEME
    {
        public static ADD_DOSSIER ADD_DOSSIER { get; set; }
        public static CTL_CREDIT CTL_CREDIT { get; set; }
        public static DETAIL_CONTRAT DETAIL_CONTRAT { get; set; }
        public static detail_dossier_add_contrat detail_dossier_add_contrat { get; set; }
        public static Panel MainControlPanel { get; set; }
        
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
            ControlsList.Add(detail_dossier_add_contrat);
        }
            private static void create_obj_ctl()
        {
            ADD_DOSSIER = new ADD_DOSSIER() { Visible = false };
            CTL_CREDIT = new CTL_CREDIT() { Visible = false };
            DETAIL_CONTRAT = new DETAIL_CONTRAT() { Visible = false };
            detail_dossier_add_contrat = new detail_dossier_add_contrat() { Visible = false };
        }
        public static void navigat(Type t, Panel p)
        {
            p.Controls.Cast<Control>().ToList().ForEach(ele => ele.Visible = false);
            Control c = p.Controls.Cast<Control>().First(ele => ele.GetType() == t);
            c.Width = p.Width;
            c.Height = p.Height;
            c.Visible = true;
        }
    }
}
