﻿using gestion_cabinet_notarial.BL;
using gestion_cabinet_notarial.context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_cabinet_notarial
{
    public partial class ADD_OBJ : Form
    {
        CSL_BL_Client cls = new CSL_BL_Client();
        CLS_OBJET CLS_OBJET_BL = new CLS_OBJET();

        public ADD_OBJ()
        {
            InitializeComponent();
        }


        private void ADD_OBJ_Load(object sender, EventArgs e)
        {
            var ListDataSource = new List<clien>();
            ListDataSource = cls.GetAll().Select(ele => new clien()
            {
                IDCIENT = ele.idClient,
                nomcomplet = ele.Nom + " " + ele.Prenom
            }).ToList();
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            ListDataSource.ForEach(x => autoCompleteCollection.Add(x.nomcomplet));
            bunifuDropdown_client.AutoCompleteSource = AutoCompleteSource.CustomSource;
            bunifuDropdown_client.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            bunifuDropdown_client.AutoCompleteCustomSource = autoCompleteCollection;
            bunifuDropdown_client.DisplayMember = "NOMCOMPLET";
            bunifuDropdown_client.ValueMember = "IDCIENT";
            bunifuDropdown_client.DataSource = ListDataSource;
            if(THEME.id_Client != 0)
                bunifuDropdown_client.SelectedValue = THEME.id_Client;
            textBox_titre_foncier.Text = THEME.titre;
            textBox_obj.Text = THEME.obj;
            THEME.obj = "";
            bunifuDataGridView_objs.Rows.Clear();

            if(THEME.numdossier != "")
            {                
                    var objs = CLS_OBJET_BL.FindByValues(ele => ele.numdossier == THEME.numdossier).Select(el => new
                    {
                        el.libbele,
                        el.titrefoncier,
                        nomcomplet = el.client.Nom+" "+el.client.Prenom
                    }).ToList();
                bunifuDataGridView_objs.DataSource = objs;
            }
            else if (THEME.objs.Count > 0)
            {
                bunifuDataGridView_objs.ColumnCount = 3;
                bunifuDataGridView_objs.Columns[0].Name = "object";
                bunifuDataGridView_objs.Columns[1].Name = "titre foncier";
                bunifuDataGridView_objs.Columns[2].Name = "client";
                THEME.objs.ForEach(ele =>
                {
                    bunifuDropdown_client.SelectedValue = ele.idclient;
                    string[] row = new string[] { ele.libbele, ele.titrefoncier, bunifuDropdown_client.Text };
                    bunifuDataGridView_objs.Rows.Add(row);
                });
            }
        }
        private void buttonadd_add_obj_Click_1(object sender, EventArgs e)
        {
            var obj = new objet();
            obj.libbele = textBox_obj.Text;
            obj.titrefoncier = textBox_titre_foncier.Text;
            obj.idclient = int.Parse(bunifuDropdown_client.SelectedValue.ToString());
            THEME.objs.Add(obj);
            if(THEME.numdossier != null)
            {
                obj.numdossier = THEME.numdossier;
                CLS_OBJET_BL.Add(obj);
                var objs = CLS_OBJET_BL.FindByValues(ele => ele.numdossier == THEME.numdossier).Select(el => new
                {
                    el.libbele,
                    el.titrefoncier,
                    nomcomplet = el.client.Nom + " " + el.client.Prenom
                }).ToList();
                bunifuDataGridView_objs.DataSource = objs;
            }
            else if(THEME.objs.Count > 0)
            {
                bunifuDataGridView_objs.ColumnCount = 3;
                bunifuDataGridView_objs.Columns[0].Name = "object";
                bunifuDataGridView_objs.Columns[1].Name = "titre foncier";
                bunifuDataGridView_objs.Columns[2].Name = "client";
                    string[] row = new string[] { textBox_obj.Text, textBox_titre_foncier.Text, bunifuDropdown_client.Text };
                    bunifuDataGridView_objs.Rows.Add(row);
            }
        }
        private void ButtonSerch_client_Click(object sender, EventArgs e)
        {
            if (textBox_obj.Text == "")
                THEME.obj = "vide";
            else
                THEME.obj = textBox_obj.Text;
            THEME.titre = textBox_titre_foncier.Text;
            this.Close();
            THEME.navigat(typeof(add_client));
        }
    }
}
