﻿
using gestion_cabinet_notarial.controls;
using gestion_cabinet_notarial.Properties;
using System.Windows.Forms;

namespace gestion_cabinet_notarial
{
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        public void AddTheMenu()
        {
           // MessageBox.Show(this.Parent.Controls["MAINPANEL"].Name);
            PanelItems.Controls.Clear();

            PanelItems.Controls.Add(new MainMenuItem(Resources.home, "ACCUEIL", false, (se, ev) => THEME.navigat(typeof(Accueil))

            ));
            //PanelItems.Controls.Add(new MainMenuItem(Resources.Client, "client", true, null,
            //    new MainMenuItemSubItem("ajouter client"/*, (se, ev) => Theme.Navigate(typeof(CTL_ADD_CLIENT)), "AddClient"*/) { Tag = "AddClient" },
            //    new MainMenuItemSubItem("list client"/*, (se, ev) => Theme.Navigate(typeof(CTL_CLIENTS_LIST)), "ClientsList"*/) { Tag = "ClientsList" }

            //));
            PanelItems.Controls.Add(new MainMenuItem(Resources.Client, "CLIENT", false, (se, ev) => THEME.navigat(typeof(add_client))
            //new MainMenuItemSubItem("AJOUTER CLIENT", (se, ev) => THEME.navigat(typeof(add_client))/*), "AddColleague"*/) { Tag = "Addclient" },
            // new MainMenuItemSubItem("List Client", (se, ev) => THEME.navigat(typeof(LIST_CLIENT))/*), "AddColleague"*/) { Tag = "Adddossier" }
            ));
            PanelItems.Controls.Add(new MainMenuItem(Resources.Archive, "DOSSIER", false, (se, ev) => THEME.navigat(typeof(ADD_DOSSIER))
                //new MainMenuItemSubItem("Ajouter Dossier", (se, ev) => THEME.navigat(typeof(ADD_DOSSIER))/*), "AddColleague"*/) { Tag = "Adddossier" }
                //new MainMenuItemSubItem("list dossier"/*, (se, ev) => Theme.Navigate(typeof(CTL_COLLEAGUES_LIST)), "ColleaguesList"*/) { Tag = "ColleaguesList" }
            ));
            //PanelItems.Controls.Add(new MainMenuItem(Resources.Calendar, "Rendez-vous", true, null,
            //    new MainMenuItemSubItem("ajouter Rendez-vous"/*, (se, ev) => Theme.Navigate(typeof(CTL_ADD_CLIENT)), "AddClient"*/) { Tag = "AddClient" },
            //    new MainMenuItemSubItem("list Rendez-vous"/*, (se, ev) => Theme.Navigate(typeof(CTL_CLIENTS_LIST)), "ClientsList"*/) { Tag = "ClientsList" }

            //));
            ////PanelItems.Controls.Add(new MainMenuItem(Resources.Case, "قضيـة / جلسـة", true, null,
            //    new MainMenuItemSubItem("إضافـة قضيـة", (se, ev) => Theme.Navigate(typeof(CTL_ADD_CASE)), "AddCase") { Tag = "AddCase" },
            //    new MainMenuItemSubItem("قائمـة القضايـا", (se, ev) => Theme.Navigate(typeof(CTL_CASES_LIST)), "CasesList") { Tag = "CasesList" },
            //    new MainMenuItemSubItem("إضافـة جلسـة", (se, ev) => Theme.Navigate(typeof(CTL_ADD_SESSION)), "AddSession") { Tag = "AddSession" },
            //    new MainMenuItemSubItem("قائمـة الجلسـات", (se, ev) => Theme.Navigate(typeof(CTL_SESSIONS_LIST)), "SessionsList") { Tag = "SessionsList" },
            //    new MainMenuItemSubItem("إضافـة حكـم قضائـي", (se, ev) => Theme.Navigate(typeof(CTL_ADD_JUDGMENT)), "AddJudgment") { Tag = "AddJudgment" },
            //    new MainMenuItemSubItem("قائمـة الأحكـام القضائيـة", (se, ev) => Theme.Navigate(typeof(CTL_JUDGMENTS_LIST)), "JudgmentsList") { Tag = "JudgmentsList" }
            //));
            //PanelItems.Controls.Add(new MainMenuItem(Properties.Resources.Assignment, "التبليـع / التنفيـذ", true, null,
            //    new MainMenuItemSubItem("إضافـة ملـف تبليـغ", (se, ev) => Theme.Navigate(typeof(CTL_ADD_ASSIGNMENT_CASE)), "AddAssignmentCase") { Tag = "AddAssignmentCase" },
            //    new MainMenuItemSubItem("قائمـة ملفـات التبليـغ", (se, ev) => Theme.Navigate(typeof(CTL_ASSIGNMENT_CASE_LIST)), "AssignmentCasesList") { Tag = "AssignmentCasesList" },
            //    new MainMenuItemSubItem("إضافـة ملـف تنفيـذي", (se, ev) => Theme.Navigate(typeof(CTL_ADD_EXECUTION_CASE)), "AddExecutionCase") { Tag = "AddExecutionCase" },
            //    new MainMenuItemSubItem("قائمـة ملفـات التنفيـذ", (se, ev) => Theme.Navigate(typeof(CTL_EXECUTION_CASE_LIST)), "ExecutionCasesList") { Tag = "ExecutionCasesList" }
            //));
            //PanelItems.Controls.Add(new MainMenuItem(Properties.Resources.Archive, "الأرشيـف", true, null,
            //    new MainMenuItemSubItem("إضافـة أرشيـف", (se, ev) => Theme.Navigate(typeof(CTL_ADD_ARCHIVE)), "AddArchive") { Tag = "AddArchive" },
            //    new MainMenuItemSubItem("قائمـة الأرشيفـات", (se, ev) => Theme.Navigate(typeof(CTL_ARCHIVES_LIST)), "ArchivesList") { Tag = "ArchivesList" }
            PanelItems.Controls.Add(new MainMenuItem(Resources.Dollar, "CREDIT", true, null,
                new MainMenuItemSubItem("NOUVAEU CREDIT", (se, ev) => THEME.navigat(typeof(nouveau_credit)), "AFFICHIER LES CRRDITS"),
                new MainMenuItemSubItem("PAYEMENT CREDIT", (se, ev) => THEME.navigat(typeof(CTL_CREDIT)), "PAYEMENT CREDIT")             

            ));
            PanelItems.Controls.Add(new MainMenuItem(Resources.rendez_vous, "RENDEZ-VOUS", false, (se, ev) => THEME.navigat(typeof(CTL_AGENDA))));
            PanelItems.Controls.Add(new MainMenuItem(Resources.box, "CDG", false, (se, ev) => THEME.navigat(typeof(CTL_CDG))));
            PanelItems.Controls.Add(new MainMenuItem(Resources.Juridiction, "BANQUE", false, (se, ev) => THEME.navigat(typeof(CTL_BANQUE))));
            PanelItems.Controls.Add(new MainMenuItem(Resources.Note, "NOTE", false, (se, ev) => THEME.navigat(typeof(CTL_NOTE))));



            //PanelItems.Controls.Add(new MainMenuItem(Properties.Resources.Attachment, "مرفـق", true, null,
            //    new MainMenuItemSubItem("إضافـة مرفـق", (se, ev) => Theme.Navigate(typeof(CTL_ADD_ATTACHMENT)), "AddAttachment") { Tag = "AddAttachment" },
            //    new MainMenuItemSubItem("قائمـة المرفقـات", (se, ev) => Theme.Navigate(typeof(CTL_ATTACHMENTS_LIST)), "AttachmentLists") { Tag = "AttachmentLists" }
            //));
            //PanelItems.Controls.Add(new MainMenuItem(Properties.Resources.Call, "مكالمـة", true, null,
            //    new MainMenuItemSubItem("إضافـة مكاملـة", (se, ev) => Theme.Navigate(typeof(CTL_ADD_CALL)), "AddCall") { Tag = "AddCall" },
            //    new MainMenuItemSubItem("قائمـة المكالمـات", (se, ev) => Theme.Navigate(typeof(CTL_CALLS_LIST)), "CallsList") { Tag = "CallsList" }
            //));
            //PanelItems.Controls.Add(new MainMenuItem(Properties.Resources.Event, "حـدث", true, null,
            //    new MainMenuItemSubItem("إضافـة حـدث", (se, ev) => Theme.Navigate(typeof(CTL_ADD_EVENT)), "AddEvent") { Tag = "AddEvent" },
            //    new MainMenuItemSubItem("قائمـة الأحـداث", (se, ev) => Theme.Navigate(typeof(CTL_EVENTS_LIST)), "EventsList") { Tag = "EventsList" }
            //));

            //PanelItems.Controls.Add(new MainMenuItem(Resources.Note, "note", true, null,
            //    new MainMenuItemSubItem("ajouter note"/*, (se, ev) => Theme.Navigate(typeof(CTL_ADD_NOTE)), "AddNote"*/) { Tag = "AddNote" },
            //    new MainMenuItemSubItem("list note"/*, (se, ev) => Theme.Navigate(typeof(CTL_NOTES_LIST)), "NotesList"*/) { Tag = "NotesList" }
            //));
            PanelItems.Controls.Add(new MainMenuItem(Resources.STATISTIQUE, "STATISTIQUE", false, (se, ev) => THEME.navigat(typeof(CTL_STATISTIC))
            ));
            PanelItems.Controls.Add(new MainMenuItem(Resources.Settings, "PARAMETRE", true, null,
                new MainMenuItemSubItem("LIST UTILISATUER", (se, ev) => THEME.navigat(typeof(CTL_LIST_UTILATUER)), "LIST UTILISATUER") { Tag = "Database" },
                new MainMenuItemSubItem("AJOUTER UTILISATUER", (se, ev) => THEME.navigat(typeof(CTL_PARAMETER_AJOUTER_UTILISATUER)),"AJOUTER UTILISATUER") { Tag = "Categories" },
                new MainMenuItemSubItem("MODIFIER COMPTE", (se, ev) => THEME.navigat(typeof(CTL_modifier_compte)), "MODIFIER COMPTE"),
                new MainMenuItemSubItem("BASE DE DONNEE", (se, ev) => THEME.navigat(typeof(CTL_DATABASE)), "BASE DE DONNEE") { Tag = "OfficeInfo" },
                new MainMenuItemSubItem("LIST OPERATIONS", (se, ev) => THEME.navigat(typeof(CTL_LIST__operation)), "LIST OPERATION") { Tag = "AddUser" },
                new MainMenuItemSubItem("CABINET", (se, ev) => THEME.navigat(typeof(CTL_information_cabinet)), "INFORMMATION DE CABINET") { Tag = "AddUser" }

            ));
            //PanelItems.Controls.Add(new MainMenuItem(Properties.Resources.Info, "عـن البرنامـج", false, (se, ev) => Theme.Navigate(typeof(CTL_ABOUT))));
        }
        private void PanelItems_Paint(object sender, PaintEventArgs e)
        {

        }
    }    
}
