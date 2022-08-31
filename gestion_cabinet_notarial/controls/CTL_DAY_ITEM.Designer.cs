namespace gestion_cabinet_notarial
{
    partial class CTL_DAY_ITEM
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
            this.LabelDayNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelDayNumber
            // 
            this.LabelDayNumber.Font = new System.Drawing.Font("Ubuntu", 13F);
            this.LabelDayNumber.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.LabelDayNumber.Location = new System.Drawing.Point(0, -2);
            this.LabelDayNumber.Name = "LabelDayNumber";
            this.LabelDayNumber.Size = new System.Drawing.Size(40, 40);
            this.LabelDayNumber.TabIndex = 0;
            this.LabelDayNumber.Text = "0";
            this.LabelDayNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelDayNumber.Click += new System.EventHandler(this.CTL_DAY_ITEM_Click);
            this.LabelDayNumber.MouseLeave += new System.EventHandler(this.CTL_DAY_ITEM_MouseLeave);
            this.LabelDayNumber.MouseHover += new System.EventHandler(this.CTL_DAY_ITEM_MouseHover);
            // 
            // CTL_DAY_ITEM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LabelDayNumber);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "CTL_DAY_ITEM";
            this.Size = new System.Drawing.Size(40, 40);
            this.Click += new System.EventHandler(this.CTL_DAY_ITEM_Click);
            this.MouseLeave += new System.EventHandler(this.CTL_DAY_ITEM_MouseLeave);
            this.MouseHover += new System.EventHandler(this.CTL_DAY_ITEM_MouseHover);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelDayNumber;
    }
}
