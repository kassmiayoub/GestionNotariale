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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LabelMonth = new System.Windows.Forms.Label();
            this.PanelDays = new System.Windows.Forms.FlowLayoutPanel();
            this.yers = new System.Windows.Forms.Label();
            this.bunifuDataGridView_list_times = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip_passer_supprimer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pASSERCETTERENDEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sUPPRIMERCETTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aNNULERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox_description = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bunifuDropdown_client_rendez = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ButtonAdd_rendez_vous = new System.Windows.Forms.Button();
            this.ButtonSerch_client = new System.Windows.Forms.Button();
            this.button_next_year = new System.Windows.Forms.Button();
            this.button_prev_year = new System.Windows.Forms.Button();
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.ButtonNextMonth = new System.Windows.Forms.Button();
            this.ButtonPrevMonth = new System.Windows.Forms.Button();
            this.aNNULERToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView_list_times)).BeginInit();
            this.contextMenuStrip_passer_supprimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelMonth
            // 
            this.LabelMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelMonth.Font = new System.Drawing.Font("Ithra-Light", 17F);
            this.LabelMonth.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.LabelMonth.Location = new System.Drawing.Point(90, 194);
            this.LabelMonth.Name = "LabelMonth";
            this.LabelMonth.Size = new System.Drawing.Size(305, 31);
            this.LabelMonth.TabIndex = 407;
            this.LabelMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelDays
            // 
            this.PanelDays.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelDays.Location = new System.Drawing.Point(17, 228);
            this.PanelDays.Name = "PanelDays";
            this.PanelDays.Size = new System.Drawing.Size(503, 238);
            this.PanelDays.TabIndex = 410;
            // 
            // yers
            // 
            this.yers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yers.Font = new System.Drawing.Font("Ithra-Light", 17F);
            this.yers.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.yers.Location = new System.Drawing.Point(90, 156);
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
            this.bunifuDataGridView_list_times.Anchor = System.Windows.Forms.AnchorStyles.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView_list_times.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuDataGridView_list_times.ColumnHeadersHeight = 35;
            this.bunifuDataGridView_list_times.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.bunifuDataGridView_list_times.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.bunifuDataGridView_list_times.Location = new System.Drawing.Point(579, 70);
            this.bunifuDataGridView_list_times.MinimumSize = new System.Drawing.Size(0, 20);
            this.bunifuDataGridView_list_times.MultiSelect = false;
            this.bunifuDataGridView_list_times.Name = "bunifuDataGridView_list_times";
            this.bunifuDataGridView_list_times.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView_list_times.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.bunifuDataGridView_list_times.RowHeadersVisible = false;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Transparent;
            this.bunifuDataGridView_list_times.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.bunifuDataGridView_list_times.RowTemplate.Height = 45;
            this.bunifuDataGridView_list_times.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bunifuDataGridView_list_times.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.bunifuDataGridView_list_times.Size = new System.Drawing.Size(503, 399);
            this.bunifuDataGridView_list_times.TabIndex = 468;
            this.bunifuDataGridView_list_times.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuDataGridView_list_times_CellClick);
            this.bunifuDataGridView_list_times.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bunifuDataGridView_list_times_MouseClick);
            // 
            // contextMenuStrip_passer_supprimer
            // 
            this.contextMenuStrip_passer_supprimer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pASSERCETTERENDEToolStripMenuItem,
            this.sUPPRIMERCETTEToolStripMenuItem,
            this.aNNULERToolStripMenuItem,
            this.aNNULERToolStripMenuItem1});
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
            // richTextBox_description
            // 
            this.richTextBox_description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox_description.Location = new System.Drawing.Point(191, 2);
            this.richTextBox_description.Name = "richTextBox_description";
            this.richTextBox_description.Size = new System.Drawing.Size(307, 96);
            this.richTextBox_description.TabIndex = 469;
            this.richTextBox_description.Text = "";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label11.Location = new System.Drawing.Point(13, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 24);
            this.label11.TabIndex = 479;
            this.label11.Text = "DESCREPTION : ";
            // 
            // bunifuDropdown_client_rendez
            // 
            this.bunifuDropdown_client_rendez.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuDropdown_client_rendez.Font = new System.Drawing.Font("Ubuntu Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDropdown_client_rendez.FormattingEnabled = true;
            this.bunifuDropdown_client_rendez.Location = new System.Drawing.Point(593, 19);
            this.bunifuDropdown_client_rendez.Name = "bunifuDropdown_client_rendez";
            this.bunifuDropdown_client_rendez.Size = new System.Drawing.Size(279, 31);
            this.bunifuDropdown_client_rendez.TabIndex = 480;
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
            // ButtonAdd_rendez_vous
            // 
            this.ButtonAdd_rendez_vous.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonAdd_rendez_vous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(201)))), ((int)(((byte)(175)))));
            this.ButtonAdd_rendez_vous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAdd_rendez_vous.FlatAppearance.BorderSize = 0;
            this.ButtonAdd_rendez_vous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd_rendez_vous.Font = new System.Drawing.Font("Ithra-Light", 12F);
            this.ButtonAdd_rendez_vous.ForeColor = System.Drawing.Color.White;
            this.ButtonAdd_rendez_vous.Image = global::gestion_cabinet_notarial.Properties.Resources.Add;
            this.ButtonAdd_rendez_vous.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAdd_rendez_vous.Location = new System.Drawing.Point(362, 481);
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
            this.ButtonSerch_client.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonSerch_client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(160)))), ((int)(((byte)(198)))));
            this.ButtonSerch_client.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSerch_client.FlatAppearance.BorderSize = 0;
            this.ButtonSerch_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSerch_client.Font = new System.Drawing.Font("Ithra-Light", 12F);
            this.ButtonSerch_client.ForeColor = System.Drawing.Color.White;
            this.ButtonSerch_client.Image = global::gestion_cabinet_notarial.Properties.Resources.Search;
            this.ButtonSerch_client.Location = new System.Drawing.Point(881, 19);
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
            this.button_next_year.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_next_year.BackColor = System.Drawing.Color.Transparent;
            this.button_next_year.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_next_year.FlatAppearance.BorderSize = 0;
            this.button_next_year.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_next_year.Font = new System.Drawing.Font("Ithra-Light", 12F);
            this.button_next_year.ForeColor = System.Drawing.Color.White;
            this.button_next_year.Image = global::gestion_cabinet_notarial.Properties.Resources.AgendaNext;
            this.button_next_year.Location = new System.Drawing.Point(386, 157);
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
            this.button_prev_year.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_prev_year.BackColor = System.Drawing.Color.Transparent;
            this.button_prev_year.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_prev_year.FlatAppearance.BorderSize = 0;
            this.button_prev_year.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_prev_year.Font = new System.Drawing.Font("Ithra-Light", 12F);
            this.button_prev_year.ForeColor = System.Drawing.Color.White;
            this.button_prev_year.Image = global::gestion_cabinet_notarial.Properties.Resources.AgendaPrev;
            this.button_prev_year.Location = new System.Drawing.Point(59, 157);
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
            this.ButtonRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonRefresh.BackColor = System.Drawing.Color.Transparent;
            this.ButtonRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRefresh.FlatAppearance.BorderSize = 0;
            this.ButtonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRefresh.Font = new System.Drawing.Font("Ithra-Light", 12F);
            this.ButtonRefresh.ForeColor = System.Drawing.Color.White;
            this.ButtonRefresh.Image = global::gestion_cabinet_notarial.Properties.Resources.Refresh2;
            this.ButtonRefresh.Location = new System.Drawing.Point(468, 177);
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
            this.ButtonNextMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonNextMonth.BackColor = System.Drawing.Color.Transparent;
            this.ButtonNextMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNextMonth.FlatAppearance.BorderSize = 0;
            this.ButtonNextMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNextMonth.Font = new System.Drawing.Font("Ithra-Light", 12F);
            this.ButtonNextMonth.ForeColor = System.Drawing.Color.White;
            this.ButtonNextMonth.Image = global::gestion_cabinet_notarial.Properties.Resources.AgendaNext;
            this.ButtonNextMonth.Location = new System.Drawing.Point(386, 195);
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
            this.ButtonPrevMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonPrevMonth.BackColor = System.Drawing.Color.Transparent;
            this.ButtonPrevMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPrevMonth.FlatAppearance.BorderSize = 0;
            this.ButtonPrevMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPrevMonth.Font = new System.Drawing.Font("Ithra-Light", 12F);
            this.ButtonPrevMonth.ForeColor = System.Drawing.Color.White;
            this.ButtonPrevMonth.Image = global::gestion_cabinet_notarial.Properties.Resources.AgendaPrev;
            this.ButtonPrevMonth.Location = new System.Drawing.Point(59, 195);
            this.ButtonPrevMonth.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonPrevMonth.Name = "ButtonPrevMonth";
            this.ButtonPrevMonth.Size = new System.Drawing.Size(30, 30);
            this.ButtonPrevMonth.TabIndex = 406;
            this.ButtonPrevMonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonPrevMonth.UseVisualStyleBackColor = false;
            this.ButtonPrevMonth.Click += new System.EventHandler(this.ButtonPrevMonth_Click);
            // 
            // aNNULERToolStripMenuItem1
            // 
            this.aNNULERToolStripMenuItem1.Name = "aNNULERToolStripMenuItem1";
            this.aNNULERToolStripMenuItem1.Size = new System.Drawing.Size(262, 22);
            this.aNNULERToolStripMenuItem1.Text = "ANNULER";
            // 
            // CTL_AGENDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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
            this.Size = new System.Drawing.Size(1095, 526);
            this.Tag = "الأجنـدة";
            this.Load += new System.EventHandler(this.CTL_AGENDA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView_list_times)).EndInit();
            this.contextMenuStrip_passer_supprimer.ResumeLayout(false);
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
    }
}
