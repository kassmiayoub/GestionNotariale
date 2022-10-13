namespace gestion_cabinet_notarial
{
    partial class form_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_main));
            this.MAINPANEL = new System.Windows.Forms.Panel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.controL_CONTROL_BOX2 = new gestion_cabinet_notarial.CONTROL_CONTROL_BOX();
            this.mainMenu1 = new gestion_cabinet_notarial.MainMenu();
            this.controL_MAIN_HEADER1 = new gestion_cabinet_notarial.CONTROL_MAIN_HEADER();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MAINPANEL
            // 
            this.MAINPANEL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MAINPANEL.BackColor = System.Drawing.Color.White;
            this.MAINPANEL.Location = new System.Drawing.Point(250, 136);
            this.MAINPANEL.Name = "MAINPANEL";
            this.MAINPANEL.Size = new System.Drawing.Size(998, 655);
            this.MAINPANEL.TabIndex = 5;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 0;
            this.bunifuPanel1.Controls.Add(this.controL_CONTROL_BOX2);
            this.bunifuPanel1.Location = new System.Drawing.Point(9, 7);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = false;
            this.bunifuPanel1.Size = new System.Drawing.Size(1239, 50);
            this.bunifuPanel1.TabIndex = 7;
            // 
            // controL_CONTROL_BOX2
            // 
            this.controL_CONTROL_BOX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controL_CONTROL_BOX2.BackColor = System.Drawing.Color.Transparent;
            this.controL_CONTROL_BOX2.Location = new System.Drawing.Point(1168, 0);
            this.controL_CONTROL_BOX2.Name = "controL_CONTROL_BOX2";
            this.controL_CONTROL_BOX2.Size = new System.Drawing.Size(68, 32);
            this.controL_CONTROL_BOX2.TabIndex = 0;
            // 
            // mainMenu1
            // 
            this.mainMenu1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mainMenu1.BackColor = System.Drawing.Color.White;
            this.mainMenu1.Location = new System.Drawing.Point(9, 136);
            this.mainMenu1.Margin = new System.Windows.Forms.Padding(0);
            this.mainMenu1.Name = "mainMenu1";
            this.mainMenu1.Size = new System.Drawing.Size(246, 654);
            this.mainMenu1.TabIndex = 6;
            // 
            // controL_MAIN_HEADER1
            // 
            this.controL_MAIN_HEADER1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controL_MAIN_HEADER1.BackColor = System.Drawing.Color.White;
            this.controL_MAIN_HEADER1.Location = new System.Drawing.Point(9, 43);
            this.controL_MAIN_HEADER1.Name = "controL_MAIN_HEADER1";
            this.controL_MAIN_HEADER1.Size = new System.Drawing.Size(1239, 101);
            this.controL_MAIN_HEADER1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::gestion_cabinet_notarial.Properties.Resources.toback;
            this.pictureBox1.Location = new System.Drawing.Point(1129, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 67);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1257, 799);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MAINPANEL);
            this.Controls.Add(this.mainMenu1);
            this.Controls.Add(this.controL_MAIN_HEADER1);
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

       // private Avocat_Maroc.PL.THEME.MENU.MainMenu mainMenu1;
        private gestion_cabinet_notarial.CONTROL_CONTROL_BOX controL_CONTROL_BOX1;
        private gestion_cabinet_notarial.CONTROL_MAIN_HEADER controL_MAIN_HEADER1;
        private System.Windows.Forms.Panel MAINPANEL;
        private MainMenu mainMenu1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private CONTROL_CONTROL_BOX controL_CONTROL_BOX2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

