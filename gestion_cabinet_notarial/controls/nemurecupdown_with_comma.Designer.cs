namespace gestion_cabinet_notarial
{
    partial class nemurecupdown_with_comma
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_porsontage = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PictureBoxArrow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "%";
            // 
            // textBox_porsontage
            // 
            this.textBox_porsontage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_porsontage.Location = new System.Drawing.Point(3, 3);
            this.textBox_porsontage.Name = "textBox_porsontage";
            this.textBox_porsontage.Size = new System.Drawing.Size(53, 26);
            this.textBox_porsontage.TabIndex = 9;
            this.textBox_porsontage.Text = "0.00";
            this.textBox_porsontage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_porsontage_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::gestion_cabinet_notarial.Properties.Resources.up;
            this.pictureBox1.Location = new System.Drawing.Point(82, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PictureBoxArrow
            // 
            this.PictureBoxArrow.Image = global::gestion_cabinet_notarial.Properties.Resources.down;
            this.PictureBoxArrow.Location = new System.Drawing.Point(82, 0);
            this.PictureBoxArrow.Name = "PictureBoxArrow";
            this.PictureBoxArrow.Size = new System.Drawing.Size(15, 15);
            this.PictureBoxArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxArrow.TabIndex = 6;
            this.PictureBoxArrow.TabStop = false;
            this.PictureBoxArrow.Click += new System.EventHandler(this.PictureBoxArrow_Click);
            // 
            // nemurecupdown_with_comma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox_porsontage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PictureBoxArrow);
            this.Name = "nemurecupdown_with_comma";
            this.Size = new System.Drawing.Size(100, 33);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxArrow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_porsontage;
    }
}
