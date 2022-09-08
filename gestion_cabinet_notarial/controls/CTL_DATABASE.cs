﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_cabinet_notarial.controls
{
    public partial class CTL_DATABASE : UserControl
    {
        public CTL_DATABASE()
        {
            InitializeComponent();
        }

        private void ButtonSaveSettings_Click(object sender, EventArgs e)
        {
            DATABASE.BackUpDataBase(TextBoxSavePath.Text);
        }

        private void ButtonSerch_client_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.RootFolder = Environment.SpecialFolder.Desktop;
            if (FBD.ShowDialog() == DialogResult.OK)
                TextBoxSavePath.Text = FBD.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.InitialDirectory = TextBoxSavePath.Text != ""
                ? TextBoxSavePath.Text
                : Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (OFD.ShowDialog() == DialogResult.OK)
                TextBoxSavePathRestore.Text = OFD.FileName;
        }

        private void button_Restore_Click(object sender, EventArgs e)
        {
            DATABASE.Restordatabase(TextBoxSavePathRestore.Text);
        }
    }
}