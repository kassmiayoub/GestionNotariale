namespace gestion_cabinet_notarial
{
    partial class MainMenuItem
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
            this.LabelItemName = new System.Windows.Forms.Label();
            this.FlowLayoutPanelSubItems = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelBottomLine = new System.Windows.Forms.Panel();
            this.PictureBoxArrow = new System.Windows.Forms.PictureBox();
            this.PictureBoxIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelItemName
            // 
            this.LabelItemName.Font = new System.Drawing.Font("Ithra-Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelItemName.Location = new System.Drawing.Point(52, 3);
            this.LabelItemName.Name = "LabelItemName";
            this.LabelItemName.Size = new System.Drawing.Size(163, 30);
            this.LabelItemName.TabIndex = 6;
            this.LabelItemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelItemName.Click += new System.EventHandler(this.LabelItemName_Click);
            this.LabelItemName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainMenuItem_MouseDown);
            this.LabelItemName.MouseLeave += new System.EventHandler(this.MainMenuItem_MouseLeave);
            this.LabelItemName.MouseHover += new System.EventHandler(this.MainMenuItem_MouseHover);
            // 
            // FlowLayoutPanelSubItems
            // 
            this.FlowLayoutPanelSubItems.Location = new System.Drawing.Point(19, 39);
            this.FlowLayoutPanelSubItems.Margin = new System.Windows.Forms.Padding(0);
            this.FlowLayoutPanelSubItems.Name = "FlowLayoutPanelSubItems";
            this.FlowLayoutPanelSubItems.Size = new System.Drawing.Size(175, 0);
            this.FlowLayoutPanelSubItems.TabIndex = 7;
            this.FlowLayoutPanelSubItems.Visible = false;
            this.FlowLayoutPanelSubItems.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainMenuItem_MouseDown);
            this.FlowLayoutPanelSubItems.MouseLeave += new System.EventHandler(this.MainMenuItem_MouseLeave);
            this.FlowLayoutPanelSubItems.MouseHover += new System.EventHandler(this.MainMenuItem_MouseHover);
            // 
            // PanelBottomLine
            // 
            this.PanelBottomLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.PanelBottomLine.Location = new System.Drawing.Point(0, 39);
            this.PanelBottomLine.Name = "PanelBottomLine";
            this.PanelBottomLine.Size = new System.Drawing.Size(230, 1);
            this.PanelBottomLine.TabIndex = 8;
            this.PanelBottomLine.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainMenuItem_MouseDown);
            this.PanelBottomLine.MouseLeave += new System.EventHandler(this.MainMenuItem_MouseLeave);
            this.PanelBottomLine.MouseHover += new System.EventHandler(this.MainMenuItem_MouseHover);
            // 
            // PictureBoxArrow
            // 
            this.PictureBoxArrow.Location = new System.Drawing.Point(219, 12);
            this.PictureBoxArrow.Name = "PictureBoxArrow";
            this.PictureBoxArrow.Size = new System.Drawing.Size(15, 15);
            this.PictureBoxArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxArrow.TabIndex = 5;
            this.PictureBoxArrow.TabStop = false;
            this.PictureBoxArrow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainMenuItem_MouseDown);
            this.PictureBoxArrow.MouseLeave += new System.EventHandler(this.MainMenuItem_MouseLeave);
            this.PictureBoxArrow.MouseHover += new System.EventHandler(this.MainMenuItem_MouseHover);
            // 
            // PictureBoxIcon
            // 
            this.PictureBoxIcon.Location = new System.Drawing.Point(3, 3);
            this.PictureBoxIcon.Name = "PictureBoxIcon";
            this.PictureBoxIcon.Size = new System.Drawing.Size(30, 30);
            this.PictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxIcon.TabIndex = 4;
            this.PictureBoxIcon.TabStop = false;
            this.PictureBoxIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainMenuItem_MouseDown);
            this.PictureBoxIcon.MouseLeave += new System.EventHandler(this.MainMenuItem_MouseLeave);
            this.PictureBoxIcon.MouseHover += new System.EventHandler(this.MainMenuItem_MouseHover);
            // 
            // MainMenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PanelBottomLine);
            this.Controls.Add(this.FlowLayoutPanelSubItems);
            this.Controls.Add(this.LabelItemName);
            this.Controls.Add(this.PictureBoxArrow);
            this.Controls.Add(this.PictureBoxIcon);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MainMenuItem";
            this.Size = new System.Drawing.Size(239, 40);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainMenuItem_MouseDown);
            this.MouseLeave += new System.EventHandler(this.MainMenuItem_MouseLeave);
            this.MouseHover += new System.EventHandler(this.MainMenuItem_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelItemName;
        private System.Windows.Forms.PictureBox PictureBoxArrow;
        private System.Windows.Forms.PictureBox PictureBoxIcon;
        public System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelSubItems;
        private System.Windows.Forms.Panel PanelBottomLine;
    }
}
