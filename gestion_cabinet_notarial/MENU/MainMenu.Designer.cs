namespace gestion_cabinet_notarial
{
    partial class MainMenu
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
            this.PanelItems = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // PanelItems
            // 
            this.PanelItems.AutoScroll = true;
            this.PanelItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelItems.Location = new System.Drawing.Point(0, 0);
            this.PanelItems.Margin = new System.Windows.Forms.Padding(0);
            this.PanelItems.Name = "PanelItems";
            this.PanelItems.Size = new System.Drawing.Size(250, 400);
            this.PanelItems.TabIndex = 0;
            this.PanelItems.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelItems_Paint);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PanelItems);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(250, 400);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel PanelItems;
    }
}
