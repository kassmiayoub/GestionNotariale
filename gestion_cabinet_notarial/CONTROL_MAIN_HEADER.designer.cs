using gestion_cabinet_notarial.Properties;
namespace Avocat_Maroc.PL
{
    partial class CONTROL_MAIN_HEADER
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
            this.LabelDate = new System.Windows.Forms.Label();
            this.LabelLogOut = new System.Windows.Forms.Label();
            this.TimerDate = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelOfficeName = new System.Windows.Forms.Label();
            this.PanelLogOut = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelLogOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelDate
            // 
            this.LabelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDate.ForeColor = System.Drawing.Color.Black;
            this.LabelDate.Location = new System.Drawing.Point(480, 27);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(319, 41);
            this.LabelDate.TabIndex = 359;
            this.LabelDate.Text = "-";
            this.LabelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelLogOut
            // 
            this.LabelLogOut.AutoSize = true;
            this.LabelLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelLogOut.Font = new System.Drawing.Font("Ithra-Light", 12F);
            this.LabelLogOut.ForeColor = System.Drawing.Color.Black;
            this.LabelLogOut.Location = new System.Drawing.Point(38, 39);
            this.LabelLogOut.Name = "LabelLogOut";
            this.LabelLogOut.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelLogOut.Size = new System.Drawing.Size(180, 27);
            this.LabelLogOut.TabIndex = 362;
            this.LabelLogOut.Text = "SE DECONNECTER";
            this.LabelLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelLogOut.Click += new System.EventHandler(this.LabelLogOut_Click);
            // 
            // TimerDate
            // 
            this.TimerDate.Interval = 1;
            this.TimerDate.Tick += new System.EventHandler(this.TimerDate_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::gestion_cabinet_notarial.Properties.Resources.LogOut;
            this.pictureBox3.Location = new System.Drawing.Point(3, 32);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 361;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.LabelLogOut_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::gestion_cabinet_notarial.Properties.Resources.UserImage;
            this.pictureBox2.Location = new System.Drawing.Point(409, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 357;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::gestion_cabinet_notarial.Properties.Resources.Balance;
            this.pictureBox1.Location = new System.Drawing.Point(805, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ithra-Light", 14F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(580, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(130, 33);
            this.label1.TabIndex = 358;
            this.label1.Text = "aujourd’hui :";
            // 
            // LabelOfficeName
            // 
            this.LabelOfficeName.Font = new System.Drawing.Font("Ithra-Light", 14F);
            this.LabelOfficeName.ForeColor = System.Drawing.Color.Black;
            this.LabelOfficeName.Location = new System.Drawing.Point(3, -6);
            this.LabelOfficeName.Name = "LabelOfficeName";
            this.LabelOfficeName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelOfficeName.Size = new System.Drawing.Size(394, 41);
            this.LabelOfficeName.TabIndex = 360;
            this.LabelOfficeName.Text = "UTILISATUER";
            this.LabelOfficeName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PanelLogOut
            // 
            this.PanelLogOut.Controls.Add(this.pictureBox3);
            this.PanelLogOut.Controls.Add(this.LabelOfficeName);
            this.PanelLogOut.Controls.Add(this.LabelLogOut);
            this.PanelLogOut.Location = new System.Drawing.Point(3, 3);
            this.PanelLogOut.Name = "PanelLogOut";
            this.PanelLogOut.Size = new System.Drawing.Size(400, 65);
            this.PanelLogOut.TabIndex = 363;
            // 
            // CONTROL_MAIN_HEADER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PanelLogOut);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CONTROL_MAIN_HEADER";
            this.Size = new System.Drawing.Size(970, 72);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelLogOut.ResumeLayout(false);
            this.PanelLogOut.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label LabelLogOut;
        private System.Windows.Forms.Timer TimerDate;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label LabelOfficeName;
        public System.Windows.Forms.Panel PanelLogOut;
    }
}
