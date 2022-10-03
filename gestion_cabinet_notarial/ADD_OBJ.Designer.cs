namespace gestion_cabinet_notarial
{
    partial class ADD_OBJ
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADD_OBJ));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.buttonadd_add_obj = new System.Windows.Forms.Button();
            this.bunifuDataGridView_objs = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDropdown_client = new System.Windows.Forms.ComboBox();
            this.ButtonSerch_client = new System.Windows.Forms.Button();
            this.textBox_obj = new System.Windows.Forms.TextBox();
            this.textBox_titre_foncier = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.controL_CONTROL_BOX1 = new gestion_cabinet_notarial.CONTROL_CONTROL_BOX();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView_objs)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 2;
            this.bunifuPanel1.Controls.Add(this.controL_CONTROL_BOX1);
            this.bunifuPanel1.Controls.Add(this.buttonadd_add_obj);
            this.bunifuPanel1.Controls.Add(this.bunifuDataGridView_objs);
            this.bunifuPanel1.Controls.Add(this.label1);
            this.bunifuPanel1.Controls.Add(this.bunifuDropdown_client);
            this.bunifuPanel1.Controls.Add(this.ButtonSerch_client);
            this.bunifuPanel1.Controls.Add(this.textBox_obj);
            this.bunifuPanel1.Controls.Add(this.textBox_titre_foncier);
            this.bunifuPanel1.Controls.Add(this.label7);
            this.bunifuPanel1.Controls.Add(this.label6);
            this.bunifuPanel1.Location = new System.Drawing.Point(2, 2);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(620, 514);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // buttonadd_add_obj
            // 
            this.buttonadd_add_obj.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonadd_add_obj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(201)))), ((int)(((byte)(175)))));
            this.buttonadd_add_obj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonadd_add_obj.FlatAppearance.BorderSize = 0;
            this.buttonadd_add_obj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonadd_add_obj.Font = new System.Drawing.Font("Ithra-Light", 12F);
            this.buttonadd_add_obj.ForeColor = System.Drawing.Color.White;
            this.buttonadd_add_obj.Image = global::gestion_cabinet_notarial.Properties.Resources.Add;
            this.buttonadd_add_obj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonadd_add_obj.Location = new System.Drawing.Point(270, 252);
            this.buttonadd_add_obj.Margin = new System.Windows.Forms.Padding(2);
            this.buttonadd_add_obj.Name = "buttonadd_add_obj";
            this.buttonadd_add_obj.Size = new System.Drawing.Size(132, 35);
            this.buttonadd_add_obj.TabIndex = 505;
            this.buttonadd_add_obj.Tag = "AcceptButton";
            this.buttonadd_add_obj.Text = "AJOUTER";
            this.buttonadd_add_obj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonadd_add_obj.UseVisualStyleBackColor = false;
            this.buttonadd_add_obj.Click += new System.EventHandler(this.buttonadd_add_obj_Click_1);
            // 
            // bunifuDataGridView_objs
            // 
            this.bunifuDataGridView_objs.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView_objs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuDataGridView_objs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuDataGridView_objs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridView_objs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDataGridView_objs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuDataGridView_objs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView_objs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuDataGridView_objs.ColumnHeadersHeight = 40;
            this.bunifuDataGridView_objs.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView_objs.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView_objs.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView_objs.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView_objs.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView_objs.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView_objs.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView_objs.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView_objs.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView_objs.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView_objs.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.bunifuDataGridView_objs.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView_objs.CurrentTheme.Name = null;
            this.bunifuDataGridView_objs.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView_objs.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView_objs.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView_objs.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView_objs.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView_objs.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuDataGridView_objs.EnableHeadersVisualStyles = false;
            this.bunifuDataGridView_objs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView_objs.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView_objs.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDataGridView_objs.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView_objs.Location = new System.Drawing.Point(10, 292);
            this.bunifuDataGridView_objs.Name = "bunifuDataGridView_objs";
            this.bunifuDataGridView_objs.RowHeadersVisible = false;
            this.bunifuDataGridView_objs.RowTemplate.Height = 40;
            this.bunifuDataGridView_objs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView_objs.Size = new System.Drawing.Size(600, 211);
            this.bunifuDataGridView_objs.TabIndex = 504;
            this.bunifuDataGridView_objs.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubuntu Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(66, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 503;
            this.label1.Text = "Propriétaire : ";
            // 
            // bunifuDropdown_client
            // 
            this.bunifuDropdown_client.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuDropdown_client.Font = new System.Drawing.Font("Ubuntu Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDropdown_client.FormattingEnabled = true;
            this.bunifuDropdown_client.Location = new System.Drawing.Point(184, 182);
            this.bunifuDropdown_client.Name = "bunifuDropdown_client";
            this.bunifuDropdown_client.Size = new System.Drawing.Size(320, 31);
            this.bunifuDropdown_client.TabIndex = 502;
            // 
            // ButtonSerch_client
            // 
            this.ButtonSerch_client.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonSerch_client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(160)))), ((int)(((byte)(198)))));
            this.ButtonSerch_client.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSerch_client.FlatAppearance.BorderSize = 0;
            this.ButtonSerch_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSerch_client.Font = new System.Drawing.Font("Ithra-Light", 12F);
            this.ButtonSerch_client.ForeColor = System.Drawing.Color.White;
            this.ButtonSerch_client.Image = global::gestion_cabinet_notarial.Properties.Resources.Search;
            this.ButtonSerch_client.Location = new System.Drawing.Point(509, 182);
            this.ButtonSerch_client.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonSerch_client.Name = "ButtonSerch_client";
            this.ButtonSerch_client.Size = new System.Drawing.Size(28, 31);
            this.ButtonSerch_client.TabIndex = 501;
            this.ButtonSerch_client.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSerch_client.UseVisualStyleBackColor = false;
            this.ButtonSerch_client.Click += new System.EventHandler(this.ButtonSerch_client_Click);
            // 
            // textBox_obj
            // 
            this.textBox_obj.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_obj.Font = new System.Drawing.Font("Ubuntu Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_obj.Location = new System.Drawing.Point(185, 74);
            this.textBox_obj.Multiline = true;
            this.textBox_obj.Name = "textBox_obj";
            this.textBox_obj.Size = new System.Drawing.Size(319, 31);
            this.textBox_obj.TabIndex = 500;
            // 
            // textBox_titre_foncier
            // 
            this.textBox_titre_foncier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_titre_foncier.Font = new System.Drawing.Font("Ubuntu Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_titre_foncier.Location = new System.Drawing.Point(185, 129);
            this.textBox_titre_foncier.Multiline = true;
            this.textBox_titre_foncier.Name = "textBox_titre_foncier";
            this.textBox_titre_foncier.Size = new System.Drawing.Size(319, 31);
            this.textBox_titre_foncier.TabIndex = 499;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ubuntu Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(102, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 498;
            this.label7.Text = "OBJET :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ubuntu Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(51, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 19);
            this.label6.TabIndex = 497;
            this.label6.Text = "TITRE FONCIER : ";
            // 
            // controL_CONTROL_BOX1
            // 
            this.controL_CONTROL_BOX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controL_CONTROL_BOX1.BackColor = System.Drawing.Color.Transparent;
            this.controL_CONTROL_BOX1.Location = new System.Drawing.Point(549, 3);
            this.controL_CONTROL_BOX1.Name = "controL_CONTROL_BOX1";
            this.controL_CONTROL_BOX1.Size = new System.Drawing.Size(68, 32);
            this.controL_CONTROL_BOX1.TabIndex = 506;
            // 
            // ADD_OBJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 517);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ADD_OBJ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADD_OBJ";
            this.Load += new System.EventHandler(this.ADD_OBJ_Load);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView_objs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private CONTROL_CONTROL_BOX controL_CONTROL_BOX1;
        public System.Windows.Forms.Button buttonadd_add_obj;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView_objs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox bunifuDropdown_client;
        public System.Windows.Forms.Button ButtonSerch_client;
        private System.Windows.Forms.TextBox textBox_obj;
        private System.Windows.Forms.TextBox textBox_titre_foncier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}