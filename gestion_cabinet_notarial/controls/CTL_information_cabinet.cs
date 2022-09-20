﻿using gestion_cabinet_notarial.BL;
using gestion_cabinet_notarial.context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_cabinet_notarial.controls
{
    public partial class CTL_information_cabinet : UserControl
    {

        CLS_inormationcabinet info = new CLS_inormationcabinet();
        information_cabinet inforamation ;
        public CTL_information_cabinet()
        {
            InitializeComponent();
        }

        private void ButtonSaveSettings_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textBox_LOGO.Text = ofd.FileName;
                }
            }
        }
        public void get_info()
        {
            inforamation = info.FindByValues(ele => ele.idcabinet == "111").First();
            textBox_NOMCABINET.Text = inforamation.nomcabinet;
            textBox_EMAIL.Text = inforamation.email;
            textBox_SETEWEB.Text = inforamation.setweb;
            textBox_TELE.Text = inforamation.tele;
            textBox_FAX.Text = inforamation.fax;
            textBox_ADRESS.Text = inforamation.localisation;
            textBox_LOGO.Text = inforamation.logo;
            var Name = Path.GetFileName(textBox_LOGO.Text);
            try
            {
                pictureBox_logo.Image = Image.FromFile(THEME.logoDirectoryPath + "/" + Name);
            }
            catch
            {
                pictureBox_logo.Image = null;
            }
        }
        private void CTL_information_cabinet_VisibleChanged(object sender, EventArgs e)
        {
            get_info();
        }
        private void ButtonAdd_INFORMATIONCABINET_Click(object sender, EventArgs e)
        {
            string name_of_file = THEME.CopyFile(textBox_LOGO.Text, "logo", "1");
            if (name_of_file == "")
            {
                MessageBox.Show("Cette fichier existe deja");               
            }
              inforamation.logo =textBox_LOGO.Text;
              inforamation.nomcabinet= textBox_NOMCABINET.Text;
              inforamation.email= textBox_EMAIL.Text;
              inforamation.setweb= textBox_SETEWEB.Text;
              inforamation.tele= textBox_TELE.Text;
              inforamation.fax=textBox_FAX.Text;
              inforamation.localisation= textBox_ADRESS.Text;              
              info.SaveChanges();
            get_info();
        }
    }
}