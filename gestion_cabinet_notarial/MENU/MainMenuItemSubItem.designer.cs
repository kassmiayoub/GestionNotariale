using gestion_cabinet_notarial.Properties;
namespace gestion_cabinet_notarial

{
    partial class MainMenuItemSubItem
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
            this.LabelSubItemName = new System.Windows.Forms.Label();
            this.ContextMenuStripFav = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemFav = new System.Windows.Forms.ToolStripMenuItem();
            this.PictureBoxArrow = new System.Windows.Forms.PictureBox();
            this.ContextMenuStripFav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelSubItemName
            // 
            this.LabelSubItemName.Font = new System.Drawing.Font("Ithra-Light", 10F);
            this.LabelSubItemName.Location = new System.Drawing.Point(14, 1);
            this.LabelSubItemName.Name = "LabelSubItemName";
            this.LabelSubItemName.Size = new System.Drawing.Size(159, 20);
            this.LabelSubItemName.TabIndex = 4;
            this.LabelSubItemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelSubItemName.MouseLeave += new System.EventHandler(this.MainMenuItemSubItem_MouseLeave);
            this.LabelSubItemName.MouseHover += new System.EventHandler(this.MainMenuItemSubItem_MouseHover);
            // 
            // ContextMenuStripFav
            // 
            this.ContextMenuStripFav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFav});
            this.ContextMenuStripFav.Name = "ContextMenuStripFav";
            this.ContextMenuStripFav.Size = new System.Drawing.Size(68, 26);
            // 
            // ToolStripMenuItemFav
            // 
            this.ToolStripMenuItemFav.Name = "ToolStripMenuItemFav";
            this.ToolStripMenuItemFav.Size = new System.Drawing.Size(67, 22);
            // 
            // PictureBoxArrow
            // 
            this.PictureBoxArrow.Image = global::gestion_cabinet_notarial.Properties.Resources.RightArrow;
            this.PictureBoxArrow.Location = new System.Drawing.Point(1, 3);
            this.PictureBoxArrow.Name = "PictureBoxArrow";
            this.PictureBoxArrow.Size = new System.Drawing.Size(15, 15);
            this.PictureBoxArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxArrow.TabIndex = 3;
            this.PictureBoxArrow.TabStop = false;
            this.PictureBoxArrow.MouseLeave += new System.EventHandler(this.MainMenuItemSubItem_MouseLeave);
            this.PictureBoxArrow.MouseHover += new System.EventHandler(this.MainMenuItemSubItem_MouseHover);
            // 
            // MainMenuItemSubItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ContextMenuStrip = this.ContextMenuStripFav;
            this.Controls.Add(this.LabelSubItemName);
            this.Controls.Add(this.PictureBoxArrow);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MainMenuItemSubItem";
            this.Size = new System.Drawing.Size(175, 21);
            this.MouseLeave += new System.EventHandler(this.MainMenuItemSubItem_MouseLeave);
            this.MouseHover += new System.EventHandler(this.MainMenuItemSubItem_MouseHover);
            this.ContextMenuStripFav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxArrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxArrow;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripFav;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFav;
        public System.Windows.Forms.Label LabelSubItemName;
    }
}
