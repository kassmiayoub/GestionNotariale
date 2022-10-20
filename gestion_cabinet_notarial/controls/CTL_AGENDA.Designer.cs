using gestion_cabinet_notarial.Properties;
namespace gestion_cabinet_notarial
{
    partial class CTL_AGENDA
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LabelMonth = new System.Windows.Forms.Label();
            this.PanelDays = new System.Windows.Forms.FlowLayoutPanel();
            this.yers = new System.Windows.Forms.Label();
            this.bunifuDataGridView_list_times = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.contextMenuStrip_passer_supprimer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pASSERCETTERENDEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sUPPRIMERCETTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aNNULERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aNNULERToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aNNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox_description = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bunifuDropdown_client_rendez = new System.Windows.Forms.ComboBox();
            this.ButtonAdd_rendez_vous = new System.Windows.Forms.Button();
            this.ButtonSerch_client = new System.Windows.Forms.Button();
            this.button_next_year = new System.Windows.Forms.Button();
            this.button_prev_year = new System.Windows.Forms.Button();
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.ButtonNextMonth = new System.Windows.Forms.Button();
            this.ButtonPrevMonth = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView_list_times)).BeginInit();
            this.contextMenuStrip_passer_supprimer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelMonth
            // 
            this.LabelMonth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelMonth.Font = new System.Drawing.Font("Ithra-Light", 17F);
            this.LabelMonth.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.LabelMonth.Location = new System.Drawing.Point(97, 256);
            this.LabelMonth.Name = "LabelMonth";
            this.LabelMonth.Size = new System.Drawing.Size(305, 31);
            this.LabelMonth.TabIndex = 407;
            this.LabelMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelDays
            // 
            this.PanelDays.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PanelDays.Location = new System.Drawing.Point(24, 290);
            this.PanelDays.Name = "PanelDays";
            this.PanelDays.Size = new System.Drawing.Size(503, 238);
            this.PanelDays.TabIndex = 410;
            // 
            // yers
            // 
            this.yers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.yers.Font = new System.Drawing.Font("Ithra-Light", 17F);
            this.yers.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.yers.Location = new System.Drawing.Point(97, 218);
            this.yers.Name = "yers";
            this.yers.Size = new System.Drawing.Size(305, 31);
            this.yers.TabIndex = 415;
            this.yers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuDataGridView_list_times
            // 
            this.bunifuDataGridView_list_times.AllowUserToAddRows = false;
            this.bunifuDataGridView_list_times.AllowUserToDeleteRows = false;
            this.bunifuDataGridView_list_times.AllowUserToResizeColumns = false;
            this.bunifuDataGridView_list_times.AllowUserToResizeRows = false;
            this.bunifuDataGridView_list_times.Anchor = System.Windows.Forms.AnchorStyles.Top;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView_list_times.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuDataGridView_list_times.ColumnHeadersHeight = 35;
            this.bunifuDataGridView_list_times.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.bunifuDataGridView_list_times.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.bunifuDataGridView_list_times.Location = new System.Drawing.Point(586, 132);
            this.bunifuDataGridView_list_times.MinimumSize = new System.Drawing.Size(0, 20);
            this.bunifuDataGridView_list_times.MultiSelect = false;
            this.bunifuDataGridView_list_times.Name = "bunifuDataGridView_list_times";
            this.bunifuDataGridView_list_times.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView_list_times.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuDataGridView_list_times.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            this.bunifuDataGridView_list_times.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuDataGridView_list_times.RowTemplate.Height = 45;
            this.bunifuDataGridView_list_times.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bunifuDataGridView_list_times.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.bunifuDataGridView_list_times.Size = new System.Drawing.Size(503, 399);
            this.bunifuDataGridView_list_times.TabIndex = 468;
            this.bunifuDataGridView_list_times.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuDataGridView_list_times_CellClick);
            this.bunifuDataGridView_list_times.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bunifuDataGridView_list_times_MouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "08-10";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "10-12";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "12-14";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "14-16";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "16-18";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // contextMenuStrip_passer_supprimer
            // 
            this.contextMenuStrip_passer_supprimer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pASSERCETTERENDEToolStripMenuItem,
            this.sUPPRIMERCETTEToolStripMenuItem,
            this.aNNULERToolStripMenuItem,
            this.aNNULERToolStripMenuItem1,
            this.aNNToolStripMenuItem});
            this.contextMenuStrip_passer_supprimer.Name = "contextMenuStrip_passer_supprimer";
            this.contextMenuStrip_passer_supprimer.Size = new System.Drawing.Size(263, 114);
            // 
            // pASSERCETTERENDEToolStripMenuItem
            // 
            this.pASSERCETTERENDEToolStripMenuItem.Name = "pASSERCETTERENDEToolStripMenuItem";
            this.pASSERCETTERENDEToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.pASSERCETTERENDEToolStripMenuItem.Text = "PASSER CETTE RENDIVEZ-VOUS";
            this.pASSERCETTERENDEToolStripMenuItem.Click += new System.EventHandler(this.pASSERCETTERENDEToolStripMenuItem_Click);
            // 
            // sUPPRIMERCETTEToolStripMenuItem
            // 
            this.sUPPRIMERCETTEToolStripMenuItem.Name = "sUPPRIMERCETTEToolStripMenuItem";
            this.sUPPRIMERCETTEToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.sUPPRIMERCETTEToolStripMenuItem.Text = "SUPPRIMER CETTE RENDIVEZ-VOUS";
            this.sUPPRIMERCETTEToolStripMenuItem.Click += new System.EventHandler(this.sUPPRIMERCETTEToolStripMenuItem_Click);
            // 
            // aNNULERToolStripMenuItem
            // 
            this.aNNULERToolStripMenuItem.Name = "aNNULERToolStripMenuItem";
            this.aNNULERToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.aNNULERToolStripMenuItem.Text = "DETAIL CETTE CLIENT";
            this.aNNULERToolStripMenuItem.Click += new System.EventHandler(this.aNNULERToolStripMenuItem_Click);
            // 
            // aNNULERToolStripMenuItem1
            // 
            this.aNNULERToolStripMenuItem1.Name = "aNNULERToolStripMenuItem1";
            this.aNNULERToolStripMenuItem1.Size = new System.Drawing.Size(262, 22);
            this.aNNULERToolStripMenuItem1.Text = "ABSENCE";
            this.aNNULERToolStripMenuItem1.Click += new System.EventHandler(this.aNNULERToolStripMenuItem1_Click);
            // 
            // aNNToolStripMenuItem
            // 
            this.aNNToolStripMenuItem.Name = "aNNToolStripMenuItem";
            this.aNNToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.aNNToolStripMenuItem.Text = "ANNULER";
            // 
            // richTextBox_description
            // 
            this.richTextBox_description.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.richTextBox_description.Font = new System.Drawing.Font("Ubuntu Light", 14.25F, System.Drawing.FontStyle.Bold);
            this.richTextBox_description.Location = new System.Drawing.Point(198, 81);
            this.richTextBox_description.Name = "richTextBox_description";
            this.richTextBox_description.Size = new System.Drawing.Size(307, 96);
            this.richTextBox_description.TabIndex = 469;
            this.richTextBox_description.Text = "";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Ubuntu Light", 13F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label11.Location = new System.Drawing.Point(20, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 23);
            this.label11.TabIndex = 479;
            this.label11.Text = "DESCREPTION : ";
            // 
            // bunifuDropdown_client_rendez
            // 
            this.bunifuDropdown_client_rendez.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuDropdown_client_rendez.Font = new System.Drawing.Font("Ubuntu Light", 14.25F, System.Drawing.FontStyle.Bold);
            this.bunifuDropdown_client_rendez.FormattingEnabled = true;
            this.bunifuDropdown_client_rendez.Location = new System.Drawing.Point(758, 81);
            this.bunifuDropdown_client_rendez.Name = "bunifuDropdown_client_rendez";
            this.bunifuDropdown_client_rendez.Size = new System.Drawing.Size(279, 33);
            this.bunifuDropdown_client_rendez.TabIndex = 480;
            // 
            // ButtonAdd_rendez_vous
            // 
            this.ButtonAdd_rendez_vous.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonAdd_rendez_vous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(201)))), ((int)(((byte)(175)))));
            this.ButtonAdd_rendez_vous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAdd_rendez_vous.FlatAppearance.BorderSize = 0;
            this.ButtonAdd_rendez_vous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd_rendez_vous.Font = new System.Drawing.Font("Ubuntu Light", 14.25F, System.Drawing.FontStyle.Bold);
            this.ButtonAdd_rendez_vous.ForeColor = System.Drawing.Color.White;
            this.ButtonAdd_rendez_vous.Image = global::gestion_cabinet_notarial.Properties.Resources.Add;
            this.ButtonAdd_rendez_vous.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAdd_rendez_vous.Location = new System.Drawing.Point(421, 554);
            this.ButtonAdd_rendez_vous.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonAdd_rendez_vous.Name = "ButtonAdd_rendez_vous";
            this.ButtonAdd_rendez_vous.Size = new System.Drawing.Size(145, 35);
            this.ButtonAdd_rendez_vous.TabIndex = 467;
            this.ButtonAdd_rendez_vous.Tag = "AcceptButton";
            this.ButtonAdd_rendez_vous.Text = "AJOUTER";
            this.ButtonAdd_rendez_vous.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonAdd_rendez_vous.UseVisualStyleBackColor = false;
            this.ButtonAdd_rendez_vous.Click += new System.EventHandler(this.ButtonAdd_rendez_vous_Click);
            // 
            // ButtonSerch_client
            // 
            this.ButtonSerch_client.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonSerch_client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(160)))), ((int)(((byte)(198)))));
            this.ButtonSerch_client.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSerch_client.FlatAppearance.BorderSize = 0;
            this.ButtonSerch_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSerch_client.Font = new System.Drawing.Font("Ubuntu Light", 14.25F, System.Drawing.FontStyle.Bold);
            this.ButtonSerch_client.ForeColor = System.Drawing.Color.White;
            this.ButtonSerch_client.Image = global::gestion_cabinet_notarial.Properties.Resources.Search;
            this.ButtonSerch_client.Location = new System.Drawing.Point(1046, 81);
            this.ButtonSerch_client.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonSerch_client.Name = "ButtonSerch_client";
            this.ButtonSerch_client.Size = new System.Drawing.Size(28, 31);
            this.ButtonSerch_client.TabIndex = 434;
            this.ButtonSerch_client.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSerch_client.UseVisualStyleBackColor = false;
            this.ButtonSerch_client.Click += new System.EventHandler(this.ButtonSerch_client_Click);
            // 
            // button_next_year
            // 
            this.button_next_year.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_next_year.BackColor = System.Drawing.Color.Transparent;
            this.button_next_year.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_next_year.FlatAppearance.BorderSize = 0;
            this.button_next_year.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_next_year.Font = new System.Drawing.Font("Ithra-Light", 12F);
            this.button_next_year.ForeColor = System.Drawing.Color.White;
            this.button_next_year.Image = global::gestion_cabinet_notarial.Properties.Resources.AgendaNext;
            this.button_next_year.Location = new System.Drawing.Point(393, 219);
            this.button_next_year.Margin = new System.Windows.Forms.Padding(2);
            this.button_next_year.Name = "button_next_year";
            this.button_next_year.Size = new System.Drawing.Size(30, 30);
            this.button_next_year.TabIndex = 416;
            this.button_next_year.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_next_year.UseVisualStyleBackColor = false;
            this.button_next_year.Click += new System.EventHandler(this.button_next_year_Click);
            // 
            // button_prev_year
            // 
            this.button_prev_year.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_prev_year.BackColor = System.Drawing.Color.Transparent;
            this.button_prev_year.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_prev_year.FlatAppearance.BorderSize = 0;
            this.button_prev_year.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_prev_year.Font = new System.Drawing.Font("Ithra-Light", 12F);
            this.button_prev_year.ForeColor = System.Drawing.Color.White;
            this.button_prev_year.Image = global::gestion_cabinet_notarial.Properties.Resources.AgendaPrev;
            this.button_prev_year.Location = new System.Drawing.Point(62, 220);
            this.button_prev_year.Margin = new System.Windows.Forms.Padding(2);
            this.button_prev_year.Name = "button_prev_year";
            this.button_prev_year.Size = new System.Drawing.Size(30, 30);
            this.button_prev_year.TabIndex = 414;
            this.button_prev_year.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_prev_year.UseVisualStyleBackColor = false;
            this.button_prev_year.Click += new System.EventHandler(this.button_prev_year_Click);
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonRefresh.BackColor = System.Drawing.Color.Transparent;
            this.ButtonRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRefresh.FlatAppearance.BorderSize = 0;
            this.ButtonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRefresh.Font = new System.Drawing.Font("Ithra-Light", 12F);
            this.ButtonRefresh.ForeColor = System.Drawing.Color.White;
            this.ButtonRefresh.Image = global::gestion_cabinet_notarial.Properties.Resources.Refresh2;
            this.ButtonRefresh.Location = new System.Drawing.Point(475, 239);
            this.ButtonRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(30, 30);
            this.ButtonRefresh.TabIndex = 412;
            this.ButtonRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonRefresh.UseVisualStyleBackColor = false;
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // ButtonNextMonth
            // 
            this.ButtonNextMonth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonNextMonth.BackColor = System.Drawing.Color.Transparent;
            this.ButtonNextMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNextMonth.FlatAppearance.BorderSize = 0;
            this.ButtonNextMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNextMonth.Font = new System.Drawing.Font("Ithra-Light", 12F);
            this.ButtonNextMonth.ForeColor = System.Drawing.Color.White;
            this.ButtonNextMonth.Image = global::gestion_cabinet_notarial.Properties.Resources.AgendaNext;
            this.ButtonNextMonth.Location = new System.Drawing.Point(393, 257);
            this.ButtonNextMonth.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonNextMonth.Name = "ButtonNextMonth";
            this.ButtonNextMonth.Size = new System.Drawing.Size(30, 30);
            this.ButtonNextMonth.TabIndex = 408;
            this.ButtonNextMonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonNextMonth.UseVisualStyleBackColor = false;
            this.ButtonNextMonth.Click += new System.EventHandler(this.ButtonNextMonth_Click);
            // 
            // ButtonPrevMonth
            // 
            this.ButtonPrevMonth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonPrevMonth.BackColor = System.Drawing.Color.Transparent;
            this.ButtonPrevMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPrevMonth.FlatAppearance.BorderSize = 0;
            this.ButtonPrevMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPrevMonth.Font = new System.Drawing.Font("Ithra-Light", 12F);
            this.ButtonPrevMonth.ForeColor = System.Drawing.Color.White;
            this.ButtonPrevMonth.Image = global::gestion_cabinet_notarial.Properties.Resources.AgendaPrev;
            this.ButtonPrevMonth.Location = new System.Drawing.Point(62, 258);
            this.ButtonPrevMonth.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonPrevMonth.Name = "ButtonPrevMonth";
            this.ButtonPrevMonth.Size = new System.Drawing.Size(30, 30);
            this.ButtonPrevMonth.TabIndex = 406;
            this.ButtonPrevMonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonPrevMonth.UseVisualStyleBackColor = false;
            this.ButtonPrevMonth.Click += new System.EventHandler(this.ButtonPrevMonth_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ubuntu Light", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(644, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 481;
            this.label1.Text = "CLIENT : ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 55);
            this.panel1.TabIndex = 482;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ubuntu", 18F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(430, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "LES RENDEZ-VOUS";
            // 
            // CTL_AGENDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuDropdown_client_rendez);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.richTextBox_description);
            this.Controls.Add(this.bunifuDataGridView_list_times);
            this.Controls.Add(this.ButtonAdd_rendez_vous);
            this.Controls.Add(this.ButtonSerch_client);
            this.Controls.Add(this.button_next_year);
            this.Controls.Add(this.yers);
            this.Controls.Add(this.button_prev_year);
            this.Controls.Add(this.ButtonRefresh);
            this.Controls.Add(this.PanelDays);
            this.Controls.Add(this.ButtonNextMonth);
            this.Controls.Add(this.LabelMonth);
            this.Controls.Add(this.ButtonPrevMonth);
            this.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CTL_AGENDA";
            this.Size = new System.Drawing.Size(1095, 596);
            this.Tag = "الأجنـدة";
            this.Load += new System.EventHandler(this.CTL_AGENDA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView_list_times)).EndInit();
            this.contextMenuStrip_passer_supprimer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button ButtonPrevMonth;
        private System.Windows.Forms.Label LabelMonth;
        public System.Windows.Forms.Button ButtonNextMonth;
        public System.Windows.Forms.FlowLayoutPanel PanelDays;
        public System.Windows.Forms.Button ButtonRefresh;
        public System.Windows.Forms.Button button_next_year;
        private System.Windows.Forms.Label yers;
        public System.Windows.Forms.Button button_prev_year;
        public System.Windows.Forms.Button ButtonSerch_client;
        public System.Windows.Forms.Button ButtonAdd_rendez_vous;
        private System.Windows.Forms.DataGridView bunifuDataGridView_list_times;
        private System.Windows.Forms.RichTextBox richTextBox_description;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox bunifuDropdown_client_rendez;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_passer_supprimer;
        private System.Windows.Forms.ToolStripMenuItem pASSERCETTERENDEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sUPPRIMERCETTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aNNULERToolStripMenuItem;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.ToolStripMenuItem aNNULERToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aNNToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
    }
}
