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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LabelMonth = new System.Windows.Forms.Label();
            this.PanelDays = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.ButtonNextMonth = new System.Windows.Forms.Button();
            this.ButtonPrevMonth = new System.Windows.Forms.Button();
            this.bunifuDataGridView_list_times = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button_next_year = new System.Windows.Forms.Button();
            this.yers = new System.Windows.Forms.Label();
            this.button_prev_year = new System.Windows.Forms.Button();
            this.bunifuDropdown_client_rendez = new Bunifu.UI.WinForms.BunifuDropdown();
            this.ButtonSerch_client = new System.Windows.Forms.Button();
            this.ButtonAdd_rendez_vous = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView_list_times)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelMonth
            // 
            this.LabelMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelMonth.Font = new System.Drawing.Font("Ithra-Light", 17F);
            this.LabelMonth.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.LabelMonth.Location = new System.Drawing.Point(77, 170);
            this.LabelMonth.Name = "LabelMonth";
            this.LabelMonth.Size = new System.Drawing.Size(305, 31);
            this.LabelMonth.TabIndex = 407;
            this.LabelMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelDays
            // 
            this.PanelDays.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelDays.Location = new System.Drawing.Point(4, 208);
            this.PanelDays.Name = "PanelDays";
            this.PanelDays.Size = new System.Drawing.Size(503, 262);
            this.PanelDays.TabIndex = 410;
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
            this.ButtonRefresh.Location = new System.Drawing.Point(438, 153);
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
            this.ButtonNextMonth.Location = new System.Drawing.Point(356, 171);
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
            this.ButtonPrevMonth.Location = new System.Drawing.Point(46, 171);
            this.ButtonPrevMonth.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonPrevMonth.Name = "ButtonPrevMonth";
            this.ButtonPrevMonth.Size = new System.Drawing.Size(30, 30);
            this.ButtonPrevMonth.TabIndex = 406;
            this.ButtonPrevMonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonPrevMonth.UseVisualStyleBackColor = false;
            this.ButtonPrevMonth.Click += new System.EventHandler(this.ButtonPrevMonth_Click);
            // 
            // bunifuDataGridView_list_times
            // 
            this.bunifuDataGridView_list_times.AllowCustomTheming = false;
            this.bunifuDataGridView_list_times.AllowUserToAddRows = false;
            this.bunifuDataGridView_list_times.AllowUserToDeleteRows = false;
            this.bunifuDataGridView_list_times.AllowUserToResizeColumns = false;
            this.bunifuDataGridView_list_times.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green;
            this.bunifuDataGridView_list_times.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuDataGridView_list_times.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuDataGridView_list_times.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridView_list_times.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDataGridView_list_times.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuDataGridView_list_times.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView_list_times.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuDataGridView_list_times.ColumnHeadersHeight = 40;
            this.bunifuDataGridView_list_times.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.bunifuDataGridView_list_times.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.Green;
            this.bunifuDataGridView_list_times.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView_list_times.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView_list_times.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Green;
            this.bunifuDataGridView_list_times.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView_list_times.CurrentTheme.BackColor = System.Drawing.Color.Green;
            this.bunifuDataGridView_list_times.CurrentTheme.GridColor = System.Drawing.Color.Green;
            this.bunifuDataGridView_list_times.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView_list_times.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView_list_times.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView_list_times.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.bunifuDataGridView_list_times.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView_list_times.CurrentTheme.Name = null;
            this.bunifuDataGridView_list_times.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.Green;
            this.bunifuDataGridView_list_times.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView_list_times.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView_list_times.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.Green;
            this.bunifuDataGridView_list_times.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView_list_times.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuDataGridView_list_times.EnableHeadersVisualStyles = false;
            this.bunifuDataGridView_list_times.GridColor = System.Drawing.Color.Green;
            this.bunifuDataGridView_list_times.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView_list_times.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDataGridView_list_times.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView_list_times.Location = new System.Drawing.Point(513, 88);
            this.bunifuDataGridView_list_times.Name = "bunifuDataGridView_list_times";
            this.bunifuDataGridView_list_times.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Green;
            this.bunifuDataGridView_list_times.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuDataGridView_list_times.RowTemplate.Height = 40;
            this.bunifuDataGridView_list_times.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView_list_times.Size = new System.Drawing.Size(453, 360);
            this.bunifuDataGridView_list_times.TabIndex = 413;
            this.bunifuDataGridView_list_times.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.bunifuDataGridView_list_times.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuDataGridView_list_times_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "8-10";
            this.Column1.Name = "Column1";
            this.Column1.Text = "";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "10-12";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "12-2";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "2-4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "4-6";
            this.Column5.Name = "Column5";
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
            this.button_next_year.Location = new System.Drawing.Point(356, 133);
            this.button_next_year.Margin = new System.Windows.Forms.Padding(2);
            this.button_next_year.Name = "button_next_year";
            this.button_next_year.Size = new System.Drawing.Size(30, 30);
            this.button_next_year.TabIndex = 416;
            this.button_next_year.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_next_year.UseVisualStyleBackColor = false;
            this.button_next_year.Click += new System.EventHandler(this.button_next_year_Click);
            // 
            // yers
            // 
            this.yers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yers.Font = new System.Drawing.Font("Ithra-Light", 17F);
            this.yers.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.yers.Location = new System.Drawing.Point(77, 132);
            this.yers.Name = "yers";
            this.yers.Size = new System.Drawing.Size(305, 31);
            this.yers.TabIndex = 415;
            this.yers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.button_prev_year.Location = new System.Drawing.Point(46, 133);
            this.button_prev_year.Margin = new System.Windows.Forms.Padding(2);
            this.button_prev_year.Name = "button_prev_year";
            this.button_prev_year.Size = new System.Drawing.Size(30, 30);
            this.button_prev_year.TabIndex = 414;
            this.button_prev_year.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_prev_year.UseVisualStyleBackColor = false;
            this.button_prev_year.Click += new System.EventHandler(this.button_prev_year_Click);
            // 
            // bunifuDropdown_client_rendez
            // 
            this.bunifuDropdown_client_rendez.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuDropdown_client_rendez.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown_client_rendez.BackgroundColor = System.Drawing.Color.White;
            this.bunifuDropdown_client_rendez.BorderColor = System.Drawing.Color.Silver;
            this.bunifuDropdown_client_rendez.BorderRadius = 1;
            this.bunifuDropdown_client_rendez.Color = System.Drawing.Color.Silver;
            this.bunifuDropdown_client_rendez.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.bunifuDropdown_client_rendez.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bunifuDropdown_client_rendez.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuDropdown_client_rendez.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bunifuDropdown_client_rendez.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bunifuDropdown_client_rendez.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.bunifuDropdown_client_rendez.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bunifuDropdown_client_rendez.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.bunifuDropdown_client_rendez.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bunifuDropdown_client_rendez.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bunifuDropdown_client_rendez.FillDropDown = true;
            this.bunifuDropdown_client_rendez.FillIndicator = false;
            this.bunifuDropdown_client_rendez.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuDropdown_client_rendez.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuDropdown_client_rendez.ForeColor = System.Drawing.Color.Black;
            this.bunifuDropdown_client_rendez.FormattingEnabled = true;
            this.bunifuDropdown_client_rendez.Icon = null;
            this.bunifuDropdown_client_rendez.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifuDropdown_client_rendez.IndicatorColor = System.Drawing.Color.DarkGray;
            this.bunifuDropdown_client_rendez.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifuDropdown_client_rendez.IndicatorThickness = 2;
            this.bunifuDropdown_client_rendez.IsDropdownOpened = false;
            this.bunifuDropdown_client_rendez.ItemBackColor = System.Drawing.Color.White;
            this.bunifuDropdown_client_rendez.ItemBorderColor = System.Drawing.Color.White;
            this.bunifuDropdown_client_rendez.ItemForeColor = System.Drawing.Color.Black;
            this.bunifuDropdown_client_rendez.ItemHeight = 26;
            this.bunifuDropdown_client_rendez.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDropdown_client_rendez.ItemHighLightForeColor = System.Drawing.Color.White;
            this.bunifuDropdown_client_rendez.ItemTopMargin = 3;
            this.bunifuDropdown_client_rendez.Location = new System.Drawing.Point(287, 29);
            this.bunifuDropdown_client_rendez.Name = "bunifuDropdown_client_rendez";
            this.bunifuDropdown_client_rendez.Size = new System.Drawing.Size(260, 32);
            this.bunifuDropdown_client_rendez.TabIndex = 417;
            this.bunifuDropdown_client_rendez.Text = null;
            this.bunifuDropdown_client_rendez.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bunifuDropdown_client_rendez.TextLeftMargin = 5;
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
            this.ButtonSerch_client.Location = new System.Drawing.Point(552, 28);
            this.ButtonSerch_client.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonSerch_client.Name = "ButtonSerch_client";
            this.ButtonSerch_client.Size = new System.Drawing.Size(28, 32);
            this.ButtonSerch_client.TabIndex = 434;
            this.ButtonSerch_client.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSerch_client.UseVisualStyleBackColor = false;
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
            this.ButtonAdd_rendez_vous.Location = new System.Drawing.Point(415, 475);
            this.ButtonAdd_rendez_vous.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonAdd_rendez_vous.Name = "ButtonAdd_rendez_vous";
            this.ButtonAdd_rendez_vous.Size = new System.Drawing.Size(132, 35);
            this.ButtonAdd_rendez_vous.TabIndex = 467;
            this.ButtonAdd_rendez_vous.Tag = "AcceptButton";
            this.ButtonAdd_rendez_vous.Text = "AJOUTER";
            this.ButtonAdd_rendez_vous.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonAdd_rendez_vous.UseVisualStyleBackColor = false;
            this.ButtonAdd_rendez_vous.Click += new System.EventHandler(this.ButtonAdd_rendez_vous_Click);
            // 
            // CTL_AGENDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ButtonAdd_rendez_vous);
            this.Controls.Add(this.ButtonSerch_client);
            this.Controls.Add(this.bunifuDropdown_client_rendez);
            this.Controls.Add(this.button_next_year);
            this.Controls.Add(this.yers);
            this.Controls.Add(this.button_prev_year);
            this.Controls.Add(this.bunifuDataGridView_list_times);
            this.Controls.Add(this.ButtonRefresh);
            this.Controls.Add(this.PanelDays);
            this.Controls.Add(this.ButtonNextMonth);
            this.Controls.Add(this.LabelMonth);
            this.Controls.Add(this.ButtonPrevMonth);
            this.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CTL_AGENDA";
            this.Size = new System.Drawing.Size(969, 526);
            this.Tag = "الأجنـدة";
            this.Load += new System.EventHandler(this.CTL_AGENDA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView_list_times)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button ButtonPrevMonth;
        private System.Windows.Forms.Label LabelMonth;
        public System.Windows.Forms.Button ButtonNextMonth;
        public System.Windows.Forms.FlowLayoutPanel PanelDays;
        public System.Windows.Forms.Button ButtonRefresh;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView_list_times;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        public System.Windows.Forms.Button button_next_year;
        private System.Windows.Forms.Label yers;
        public System.Windows.Forms.Button button_prev_year;
        private Bunifu.UI.WinForms.BunifuDropdown bunifuDropdown_client_rendez;
        public System.Windows.Forms.Button ButtonSerch_client;
        public System.Windows.Forms.Button ButtonAdd_rendez_vous;
    }
}
