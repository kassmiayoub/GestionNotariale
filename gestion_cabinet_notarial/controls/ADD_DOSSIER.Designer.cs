
namespace gestion_cabinet_notarial
{
    partial class ADD_DOSSIER
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADD_DOSSIER));
            this.ButtonInit = new System.Windows.Forms.Button();
            this.ButtonAdd_dossier = new System.Windows.Forms.Button();
            this.textBox_N_dossier = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ButtonSearch_dossier = new System.Windows.Forms.Button();
            this.ButtonEdit_dossier = new System.Windows.Forms.Button();
            this.textBox_prix = new System.Windows.Forms.TextBox();
            this.textBox_titre_foncier = new System.Windows.Forms.TextBox();
            this.textBox_obj = new System.Windows.Forms.TextBox();
            this.button_detail_dossier = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.bunifuDataGridView_list_dossier = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuDatePicker_dubet = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bunifuDatePicker_fin = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bunifuCheckBox_status = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.label_vent_location = new System.Windows.Forms.Label();
            this.textBox_anne_achat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_anne_vente = new System.Windows.Forms.TextBox();
            this.textBoxPRIX_ACHAT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonadd_add_objs = new System.Windows.Forms.Button();
            this.contextMenuStrip_vente_location = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pourVenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pourLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView_list_dossier)).BeginInit();
            this.contextMenuStrip_vente_location.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonInit
            // 
            this.ButtonInit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonInit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(168)))), ((int)(((byte)(204)))));
            this.ButtonInit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonInit.FlatAppearance.BorderSize = 0;
            this.ButtonInit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInit.Font = new System.Drawing.Font("Ubuntu Light", 14F, System.Drawing.FontStyle.Bold);
            this.ButtonInit.ForeColor = System.Drawing.Color.White;
            this.ButtonInit.Image = global::gestion_cabinet_notarial.Properties.Resources.Refresh;
            this.ButtonInit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonInit.Location = new System.Drawing.Point(127, 253);
            this.ButtonInit.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonInit.Name = "ButtonInit";
            this.ButtonInit.Size = new System.Drawing.Size(132, 35);
            this.ButtonInit.TabIndex = 404;
            this.ButtonInit.Text = "VIDER";
            this.ButtonInit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonInit.UseVisualStyleBackColor = false;
            this.ButtonInit.Click += new System.EventHandler(this.ButtonInit_Click);
            // 
            // ButtonAdd_dossier
            // 
            this.ButtonAdd_dossier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonAdd_dossier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(201)))), ((int)(((byte)(175)))));
            this.ButtonAdd_dossier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAdd_dossier.FlatAppearance.BorderSize = 0;
            this.ButtonAdd_dossier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd_dossier.Font = new System.Drawing.Font("Ubuntu Light", 14F, System.Drawing.FontStyle.Bold);
            this.ButtonAdd_dossier.ForeColor = System.Drawing.Color.White;
            this.ButtonAdd_dossier.Image = global::gestion_cabinet_notarial.Properties.Resources.Add;
            this.ButtonAdd_dossier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAdd_dossier.Location = new System.Drawing.Point(261, 253);
            this.ButtonAdd_dossier.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonAdd_dossier.Name = "ButtonAdd_dossier";
            this.ButtonAdd_dossier.Size = new System.Drawing.Size(132, 35);
            this.ButtonAdd_dossier.TabIndex = 403;
            this.ButtonAdd_dossier.Tag = "AcceptButton";
            this.ButtonAdd_dossier.Text = "AJOUTER";
            this.ButtonAdd_dossier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonAdd_dossier.UseVisualStyleBackColor = false;
            this.ButtonAdd_dossier.Click += new System.EventHandler(this.ButtonAdd_dossier_Click);
            // 
            // textBox_N_dossier
            // 
            this.textBox_N_dossier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_N_dossier.Font = new System.Drawing.Font("Ubuntu Light", 13F, System.Drawing.FontStyle.Bold);
            this.textBox_N_dossier.Location = new System.Drawing.Point(159, 43);
            this.textBox_N_dossier.Multiline = true;
            this.textBox_N_dossier.Name = "textBox_N_dossier";
            this.textBox_N_dossier.Size = new System.Drawing.Size(278, 31);
            this.textBox_N_dossier.TabIndex = 405;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ubuntu Light", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(46, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 412;
            this.label1.Text = "N DOSSIER : ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ubuntu Light", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(2, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 413;
            this.label2.Text = "DATE OUVERTURE : ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ubuntu Light", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(2, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 414;
            this.label3.Text = "DATE FERMETURE :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ubuntu Light", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(538, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 415;
            this.label4.Text = "PRIX D\'ACQUISITION :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ubuntu Light", 11F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(568, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 417;
            this.label6.Text = "TITRE FONCIER : ";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ubuntu Light", 11F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(622, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 418;
            this.label7.Text = "OBJET :";
            // 
            // ButtonSearch_dossier
            // 
            this.ButtonSearch_dossier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonSearch_dossier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.ButtonSearch_dossier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSearch_dossier.FlatAppearance.BorderSize = 0;
            this.ButtonSearch_dossier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSearch_dossier.Font = new System.Drawing.Font("Ubuntu Light", 14F, System.Drawing.FontStyle.Bold);
            this.ButtonSearch_dossier.ForeColor = System.Drawing.Color.White;
            this.ButtonSearch_dossier.Image = global::gestion_cabinet_notarial.Properties.Resources.Search;
            this.ButtonSearch_dossier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSearch_dossier.Location = new System.Drawing.Point(529, 253);
            this.ButtonSearch_dossier.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonSearch_dossier.Name = "ButtonSearch_dossier";
            this.ButtonSearch_dossier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonSearch_dossier.Size = new System.Drawing.Size(169, 35);
            this.ButtonSearch_dossier.TabIndex = 419;
            this.ButtonSearch_dossier.Tag = "AcceptButton";
            this.ButtonSearch_dossier.Text = "RECHARCHER";
            this.ButtonSearch_dossier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSearch_dossier.UseVisualStyleBackColor = false;
            this.ButtonSearch_dossier.Click += new System.EventHandler(this.ButtonSearch_dossier_Click);
            // 
            // ButtonEdit_dossier
            // 
            this.ButtonEdit_dossier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonEdit_dossier.BackColor = System.Drawing.Color.Silver;
            this.ButtonEdit_dossier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonEdit_dossier.FlatAppearance.BorderSize = 0;
            this.ButtonEdit_dossier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEdit_dossier.Font = new System.Drawing.Font("Ubuntu Light", 14F, System.Drawing.FontStyle.Bold);
            this.ButtonEdit_dossier.ForeColor = System.Drawing.Color.White;
            this.ButtonEdit_dossier.Image = global::gestion_cabinet_notarial.Properties.Resources.Edit;
            this.ButtonEdit_dossier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonEdit_dossier.Location = new System.Drawing.Point(395, 253);
            this.ButtonEdit_dossier.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonEdit_dossier.Name = "ButtonEdit_dossier";
            this.ButtonEdit_dossier.Size = new System.Drawing.Size(132, 35);
            this.ButtonEdit_dossier.TabIndex = 420;
            this.ButtonEdit_dossier.Tag = "EditColleague";
            this.ButtonEdit_dossier.Text = "MODIFIER";
            this.ButtonEdit_dossier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonEdit_dossier.UseVisualStyleBackColor = false;
            this.ButtonEdit_dossier.Click += new System.EventHandler(this.ButtonEdit_dossier_Click);
            // 
            // textBox_prix
            // 
            this.textBox_prix.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_prix.Font = new System.Drawing.Font("Ubuntu Light", 13F, System.Drawing.FontStyle.Bold);
            this.textBox_prix.Location = new System.Drawing.Point(700, 39);
            this.textBox_prix.Multiline = true;
            this.textBox_prix.Name = "textBox_prix";
            this.textBox_prix.Size = new System.Drawing.Size(278, 31);
            this.textBox_prix.TabIndex = 422;
            this.textBox_prix.Click += new System.EventHandler(this.textBox_prix_Click);
            this.textBox_prix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_prix_KeyPress);
            // 
            // textBox_titre_foncier
            // 
            this.textBox_titre_foncier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_titre_foncier.Font = new System.Drawing.Font("Ubuntu Light", 13F, System.Drawing.FontStyle.Bold);
            this.textBox_titre_foncier.Location = new System.Drawing.Point(700, 85);
            this.textBox_titre_foncier.Multiline = true;
            this.textBox_titre_foncier.Name = "textBox_titre_foncier";
            this.textBox_titre_foncier.Size = new System.Drawing.Size(278, 31);
            this.textBox_titre_foncier.TabIndex = 426;
            this.textBox_titre_foncier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_titre_foncier_KeyPress);
            // 
            // textBox_obj
            // 
            this.textBox_obj.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_obj.Font = new System.Drawing.Font("Ubuntu Light", 13F, System.Drawing.FontStyle.Bold);
            this.textBox_obj.Location = new System.Drawing.Point(700, 133);
            this.textBox_obj.Multiline = true;
            this.textBox_obj.Name = "textBox_obj";
            this.textBox_obj.Size = new System.Drawing.Size(278, 31);
            this.textBox_obj.TabIndex = 427;
            // 
            // button_detail_dossier
            // 
            this.button_detail_dossier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_detail_dossier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(168)))), ((int)(((byte)(204)))));
            this.button_detail_dossier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_detail_dossier.FlatAppearance.BorderSize = 0;
            this.button_detail_dossier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_detail_dossier.Font = new System.Drawing.Font("Ubuntu Light", 14F, System.Drawing.FontStyle.Bold);
            this.button_detail_dossier.ForeColor = System.Drawing.Color.White;
            this.button_detail_dossier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_detail_dossier.Location = new System.Drawing.Point(785, 246);
            this.button_detail_dossier.Margin = new System.Windows.Forms.Padding(2);
            this.button_detail_dossier.Name = "button_detail_dossier";
            this.button_detail_dossier.Size = new System.Drawing.Size(216, 53);
            this.button_detail_dossier.TabIndex = 431;
            this.button_detail_dossier.Text = "DETALS DE DOSSIER";
            this.button_detail_dossier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_detail_dossier.UseVisualStyleBackColor = false;
            this.button_detail_dossier.Click += new System.EventHandler(this.button_detail_dossier_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Ubuntu Light", 14F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(397, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 25);
            this.label10.TabIndex = 432;
            this.label10.Text = "AJOUTER  DOSSIER ";
            // 
            // bunifuDataGridView_list_dossier
            // 
            this.bunifuDataGridView_list_dossier.AllowCustomTheming = false;
            this.bunifuDataGridView_list_dossier.AllowUserToAddRows = false;
            this.bunifuDataGridView_list_dossier.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView_list_dossier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuDataGridView_list_dossier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuDataGridView_list_dossier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridView_list_dossier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDataGridView_list_dossier.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuDataGridView_list_dossier.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView_list_dossier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuDataGridView_list_dossier.ColumnHeadersHeight = 40;
            this.bunifuDataGridView_list_dossier.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView_list_dossier.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView_list_dossier.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView_list_dossier.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView_list_dossier.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView_list_dossier.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView_list_dossier.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView_list_dossier.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView_list_dossier.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView_list_dossier.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView_list_dossier.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.bunifuDataGridView_list_dossier.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView_list_dossier.CurrentTheme.Name = null;
            this.bunifuDataGridView_list_dossier.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView_list_dossier.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView_list_dossier.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView_list_dossier.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView_list_dossier.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Ubuntu Light", 13F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView_list_dossier.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuDataGridView_list_dossier.EnableHeadersVisualStyles = false;
            this.bunifuDataGridView_list_dossier.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView_list_dossier.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView_list_dossier.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDataGridView_list_dossier.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView_list_dossier.Location = new System.Drawing.Point(3, 301);
            this.bunifuDataGridView_list_dossier.Name = "bunifuDataGridView_list_dossier";
            this.bunifuDataGridView_list_dossier.ReadOnly = true;
            this.bunifuDataGridView_list_dossier.RowHeadersVisible = false;
            this.bunifuDataGridView_list_dossier.RowTemplate.Height = 40;
            this.bunifuDataGridView_list_dossier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView_list_dossier.Size = new System.Drawing.Size(1004, 313);
            this.bunifuDataGridView_list_dossier.TabIndex = 433;
            this.bunifuDataGridView_list_dossier.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.bunifuDataGridView_list_dossier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuDataGridView_list_dossier_CellClick);
            // 
            // bunifuDatePicker_dubet
            // 
            this.bunifuDatePicker_dubet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuDatePicker_dubet.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDatePicker_dubet.BorderColor = System.Drawing.Color.Silver;
            this.bunifuDatePicker_dubet.BorderRadius = 1;
            this.bunifuDatePicker_dubet.Color = System.Drawing.Color.Silver;
            this.bunifuDatePicker_dubet.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.bunifuDatePicker_dubet.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.bunifuDatePicker_dubet.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDatePicker_dubet.DisplayWeekNumbers = false;
            this.bunifuDatePicker_dubet.DPHeight = 0;
            this.bunifuDatePicker_dubet.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.bunifuDatePicker_dubet.FillDatePicker = false;
            this.bunifuDatePicker_dubet.Font = new System.Drawing.Font("Ubuntu Light", 13F, System.Drawing.FontStyle.Bold);
            this.bunifuDatePicker_dubet.ForeColor = System.Drawing.Color.Black;
            this.bunifuDatePicker_dubet.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bunifuDatePicker_dubet.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuDatePicker_dubet.Icon")));
            this.bunifuDatePicker_dubet.IconColor = System.Drawing.Color.Gray;
            this.bunifuDatePicker_dubet.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.bunifuDatePicker_dubet.LeftTextMargin = 5;
            this.bunifuDatePicker_dubet.Location = new System.Drawing.Point(159, 88);
            this.bunifuDatePicker_dubet.MinimumSize = new System.Drawing.Size(4, 32);
            this.bunifuDatePicker_dubet.Name = "bunifuDatePicker_dubet";
            this.bunifuDatePicker_dubet.Size = new System.Drawing.Size(277, 32);
            this.bunifuDatePicker_dubet.TabIndex = 434;
            // 
            // bunifuDatePicker_fin
            // 
            this.bunifuDatePicker_fin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuDatePicker_fin.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDatePicker_fin.BorderColor = System.Drawing.Color.Silver;
            this.bunifuDatePicker_fin.BorderRadius = 1;
            this.bunifuDatePicker_fin.Color = System.Drawing.Color.Silver;
            this.bunifuDatePicker_fin.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.bunifuDatePicker_fin.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.bunifuDatePicker_fin.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDatePicker_fin.DisplayWeekNumbers = false;
            this.bunifuDatePicker_fin.DPHeight = 0;
            this.bunifuDatePicker_fin.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.bunifuDatePicker_fin.FillDatePicker = false;
            this.bunifuDatePicker_fin.Font = new System.Drawing.Font("Ubuntu Light", 13F, System.Drawing.FontStyle.Bold);
            this.bunifuDatePicker_fin.ForeColor = System.Drawing.Color.Black;
            this.bunifuDatePicker_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bunifuDatePicker_fin.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuDatePicker_fin.Icon")));
            this.bunifuDatePicker_fin.IconColor = System.Drawing.Color.Gray;
            this.bunifuDatePicker_fin.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.bunifuDatePicker_fin.LeftTextMargin = 5;
            this.bunifuDatePicker_fin.Location = new System.Drawing.Point(158, 137);
            this.bunifuDatePicker_fin.MinimumSize = new System.Drawing.Size(4, 32);
            this.bunifuDatePicker_fin.Name = "bunifuDatePicker_fin";
            this.bunifuDatePicker_fin.Size = new System.Drawing.Size(278, 32);
            this.bunifuDatePicker_fin.TabIndex = 435;
            // 
            // bunifuCheckBox_status
            // 
            this.bunifuCheckBox_status.AllowBindingControlAnimation = true;
            this.bunifuCheckBox_status.AllowBindingControlColorChanges = false;
            this.bunifuCheckBox_status.AllowBindingControlLocation = true;
            this.bunifuCheckBox_status.AllowCheckBoxAnimation = false;
            this.bunifuCheckBox_status.AllowCheckmarkAnimation = true;
            this.bunifuCheckBox_status.AllowOnHoverStates = true;
            this.bunifuCheckBox_status.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCheckBox_status.AutoCheck = true;
            this.bunifuCheckBox_status.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox_status.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCheckBox_status.BackgroundImage")));
            this.bunifuCheckBox_status.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuCheckBox_status.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.bunifuCheckBox_status.BorderRadius = 12;
            this.bunifuCheckBox_status.Checked = true;
            this.bunifuCheckBox_status.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.bunifuCheckBox_status.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuCheckBox_status.CustomCheckmarkImage = null;
            this.bunifuCheckBox_status.Location = new System.Drawing.Point(442, 141);
            this.bunifuCheckBox_status.MinimumSize = new System.Drawing.Size(17, 17);
            this.bunifuCheckBox_status.Name = "bunifuCheckBox_status";
            this.bunifuCheckBox_status.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCheckBox_status.OnCheck.BorderRadius = 12;
            this.bunifuCheckBox_status.OnCheck.BorderThickness = 2;
            this.bunifuCheckBox_status.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCheckBox_status.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox_status.OnCheck.CheckmarkThickness = 2;
            this.bunifuCheckBox_status.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox_status.OnDisable.BorderRadius = 12;
            this.bunifuCheckBox_status.OnDisable.BorderThickness = 2;
            this.bunifuCheckBox_status.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox_status.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox_status.OnDisable.CheckmarkThickness = 2;
            this.bunifuCheckBox_status.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox_status.OnHoverChecked.BorderRadius = 12;
            this.bunifuCheckBox_status.OnHoverChecked.BorderThickness = 2;
            this.bunifuCheckBox_status.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox_status.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox_status.OnHoverChecked.CheckmarkThickness = 2;
            this.bunifuCheckBox_status.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox_status.OnHoverUnchecked.BorderRadius = 12;
            this.bunifuCheckBox_status.OnHoverUnchecked.BorderThickness = 1;
            this.bunifuCheckBox_status.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox_status.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.bunifuCheckBox_status.OnUncheck.BorderRadius = 12;
            this.bunifuCheckBox_status.OnUncheck.BorderThickness = 1;
            this.bunifuCheckBox_status.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox_status.Size = new System.Drawing.Size(28, 28);
            this.bunifuCheckBox_status.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.bunifuCheckBox_status.TabIndex = 436;
            this.bunifuCheckBox_status.ThreeState = false;
            this.bunifuCheckBox_status.ToolTipText = null;
            this.bunifuCheckBox_status.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.bunifuCheckBox_status_CheckedChanged);
            // 
            // label_vent_location
            // 
            this.label_vent_location.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_vent_location.AutoSize = true;
            this.label_vent_location.BackColor = System.Drawing.Color.Transparent;
            this.label_vent_location.Font = new System.Drawing.Font("Ubuntu Light", 11F, System.Drawing.FontStyle.Bold);
            this.label_vent_location.Location = new System.Drawing.Point(14, 190);
            this.label_vent_location.Name = "label_vent_location";
            this.label_vent_location.Size = new System.Drawing.Size(133, 20);
            this.label_vent_location.TabIndex = 438;
            this.label_vent_location.Text = "ANNE D\'ACHAT  : ";
            // 
            // textBox_anne_achat
            // 
            this.textBox_anne_achat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_anne_achat.Font = new System.Drawing.Font("Ubuntu Light", 13F, System.Drawing.FontStyle.Bold);
            this.textBox_anne_achat.Location = new System.Drawing.Point(168, 176);
            this.textBox_anne_achat.Multiline = true;
            this.textBox_anne_achat.Name = "textBox_anne_achat";
            this.textBox_anne_achat.Size = new System.Drawing.Size(118, 31);
            this.textBox_anne_achat.TabIndex = 437;
            this.textBox_anne_achat.TextChanged += new System.EventHandler(this.textBox_anne_achat_TextChanged);
            this.textBox_anne_achat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_anne_achat_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Ubuntu Light", 11F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(299, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 20);
            this.label8.TabIndex = 440;
            this.label8.Text = "ANNE DE VENTE : ";
            // 
            // textBox_anne_vente
            // 
            this.textBox_anne_vente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_anne_vente.Font = new System.Drawing.Font("Ubuntu Light", 13F, System.Drawing.FontStyle.Bold);
            this.textBox_anne_vente.Location = new System.Drawing.Point(442, 179);
            this.textBox_anne_vente.Multiline = true;
            this.textBox_anne_vente.Name = "textBox_anne_vente";
            this.textBox_anne_vente.Size = new System.Drawing.Size(134, 31);
            this.textBox_anne_vente.TabIndex = 439;
            this.textBox_anne_vente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_anne_vente_KeyPress);
            // 
            // textBoxPRIX_ACHAT
            // 
            this.textBoxPRIX_ACHAT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxPRIX_ACHAT.Font = new System.Drawing.Font("Ubuntu Light", 13F, System.Drawing.FontStyle.Bold);
            this.textBoxPRIX_ACHAT.Location = new System.Drawing.Point(700, 179);
            this.textBoxPRIX_ACHAT.Multiline = true;
            this.textBoxPRIX_ACHAT.Name = "textBoxPRIX_ACHAT";
            this.textBoxPRIX_ACHAT.Size = new System.Drawing.Size(278, 31);
            this.textBoxPRIX_ACHAT.TabIndex = 442;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ubuntu Light", 11F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(578, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 20);
            this.label9.TabIndex = 441;
            this.label9.Text = "PRIX D\'ACHAT :";
            // 
            // buttonadd_add_objs
            // 
            this.buttonadd_add_objs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonadd_add_objs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(201)))), ((int)(((byte)(175)))));
            this.buttonadd_add_objs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonadd_add_objs.FlatAppearance.BorderSize = 0;
            this.buttonadd_add_objs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonadd_add_objs.Font = new System.Drawing.Font("Ubuntu Light", 10F, System.Drawing.FontStyle.Bold);
            this.buttonadd_add_objs.ForeColor = System.Drawing.Color.White;
            this.buttonadd_add_objs.Image = global::gestion_cabinet_notarial.Properties.Resources.Add;
            this.buttonadd_add_objs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonadd_add_objs.Location = new System.Drawing.Point(981, 133);
            this.buttonadd_add_objs.Margin = new System.Windows.Forms.Padding(2);
            this.buttonadd_add_objs.Name = "buttonadd_add_objs";
            this.buttonadd_add_objs.Size = new System.Drawing.Size(29, 31);
            this.buttonadd_add_objs.TabIndex = 468;
            this.buttonadd_add_objs.Tag = "AcceptButton";
            this.buttonadd_add_objs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonadd_add_objs.UseVisualStyleBackColor = false;
            this.buttonadd_add_objs.Click += new System.EventHandler(this.buttonadd_add_objs_Click_1);
            // 
            // contextMenuStrip_vente_location
            // 
            this.contextMenuStrip_vente_location.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pourVenteToolStripMenuItem,
            this.pourLocationToolStripMenuItem,
            this.annulerToolStripMenuItem});
            this.contextMenuStrip_vente_location.Name = "contextMenuStrip1";
            this.contextMenuStrip_vente_location.Size = new System.Drawing.Size(146, 70);
            // 
            // pourVenteToolStripMenuItem
            // 
            this.pourVenteToolStripMenuItem.Name = "pourVenteToolStripMenuItem";
            this.pourVenteToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.pourVenteToolStripMenuItem.Text = "pour vente";
            this.pourVenteToolStripMenuItem.Click += new System.EventHandler(this.pourVenteToolStripMenuItem_Click);
            // 
            // pourLocationToolStripMenuItem
            // 
            this.pourLocationToolStripMenuItem.Name = "pourLocationToolStripMenuItem";
            this.pourLocationToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.pourLocationToolStripMenuItem.Text = "pour location";
            this.pourLocationToolStripMenuItem.Click += new System.EventHandler(this.pourLocationToolStripMenuItem_Click);
            // 
            // annulerToolStripMenuItem
            // 
            this.annulerToolStripMenuItem.Name = "annulerToolStripMenuItem";
            this.annulerToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.annulerToolStripMenuItem.Text = "annuler";
            this.annulerToolStripMenuItem.Click += new System.EventHandler(this.annulerToolStripMenuItem_Click);
            // 
            // ADD_DOSSIER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonadd_add_objs);
            this.Controls.Add(this.textBoxPRIX_ACHAT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_anne_vente);
            this.Controls.Add(this.label_vent_location);
            this.Controls.Add(this.textBox_anne_achat);
            this.Controls.Add(this.bunifuCheckBox_status);
            this.Controls.Add(this.bunifuDatePicker_fin);
            this.Controls.Add(this.bunifuDatePicker_dubet);
            this.Controls.Add(this.bunifuDataGridView_list_dossier);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button_detail_dossier);
            this.Controls.Add(this.textBox_obj);
            this.Controls.Add(this.textBox_titre_foncier);
            this.Controls.Add(this.textBox_prix);
            this.Controls.Add(this.ButtonEdit_dossier);
            this.Controls.Add(this.ButtonSearch_dossier);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_N_dossier);
            this.Controls.Add(this.ButtonInit);
            this.Controls.Add(this.ButtonAdd_dossier);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Name = "ADD_DOSSIER";
            this.Size = new System.Drawing.Size(1010, 617);
            this.Load += new System.EventHandler(this.ADD_DOSSIER_Load);
            this.VisibleChanged += new System.EventHandler(this.ADD_DOSSIER_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView_list_dossier)).EndInit();
            this.contextMenuStrip_vente_location.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button ButtonInit;
        public System.Windows.Forms.Button ButtonAdd_dossier;
        private System.Windows.Forms.TextBox textBox_N_dossier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button ButtonSearch_dossier;
        public System.Windows.Forms.Button ButtonEdit_dossier;
        private System.Windows.Forms.TextBox textBox_prix;
        private System.Windows.Forms.TextBox textBox_titre_foncier;
        private System.Windows.Forms.TextBox textBox_obj;
        public System.Windows.Forms.Button button_detail_dossier;
        private System.Windows.Forms.Label label10;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView_list_dossier;
        private Bunifu.UI.WinForms.BunifuDatePicker bunifuDatePicker_dubet;
        private Bunifu.UI.WinForms.BunifuDatePicker bunifuDatePicker_fin;
        private Bunifu.UI.WinForms.BunifuCheckBox bunifuCheckBox_status;
        private System.Windows.Forms.Label label_vent_location;
        private System.Windows.Forms.TextBox textBox_anne_achat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_anne_vente;
        private System.Windows.Forms.TextBox textBoxPRIX_ACHAT;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button buttonadd_add_objs;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_vente_location;
        private System.Windows.Forms.ToolStripMenuItem pourVenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pourLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annulerToolStripMenuItem;
    }
}
