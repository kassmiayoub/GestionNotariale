﻿namespace gestion_cabinet_notarial
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
            this.controL_MAIN_HEADER1 = new Avocat_Maroc.PL.CONTROL_MAIN_HEADER();
            this.controL_CONTROL_BOX1 = new Avocat_Maroc.PL.CONTROL_CONTROL_BOX();
            this.mainMenu1 = new gestion_cabinet_notarial.MainMenu();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MAINPANEL
            // 
            this.MAINPANEL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MAINPANEL.BackColor = System.Drawing.Color.White;
            this.MAINPANEL.Location = new System.Drawing.Point(242, 137);
            this.MAINPANEL.Name = "MAINPANEL";
            this.MAINPANEL.Size = new System.Drawing.Size(1006, 654);
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
            this.bunifuPanel1.Controls.Add(this.controL_CONTROL_BOX1);
            this.bunifuPanel1.Location = new System.Drawing.Point(9, 7);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = false;
            this.bunifuPanel1.Size = new System.Drawing.Size(1239, 50);
            this.bunifuPanel1.TabIndex = 7;
            // 
            // controL_MAIN_HEADER1
            // 
            this.controL_MAIN_HEADER1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controL_MAIN_HEADER1.BackColor = System.Drawing.Color.White;
            this.controL_MAIN_HEADER1.Location = new System.Drawing.Point(9, 49);
            this.controL_MAIN_HEADER1.Name = "controL_MAIN_HEADER1";
            this.controL_MAIN_HEADER1.Size = new System.Drawing.Size(1239, 125);
            this.controL_MAIN_HEADER1.TabIndex = 4;
            // 
            // controL_CONTROL_BOX1
            // 
            this.controL_CONTROL_BOX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controL_CONTROL_BOX1.BackColor = System.Drawing.Color.Transparent;
            this.controL_CONTROL_BOX1.Location = new System.Drawing.Point(1157, 5);
            this.controL_CONTROL_BOX1.Name = "controL_CONTROL_BOX1";
            this.controL_CONTROL_BOX1.Size = new System.Drawing.Size(75, 32);
            this.controL_CONTROL_BOX1.TabIndex = 1;
            // 
            // mainMenu1
            // 
            this.mainMenu1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mainMenu1.BackColor = System.Drawing.Color.White;
            this.mainMenu1.Location = new System.Drawing.Point(9, 136);
            this.mainMenu1.Margin = new System.Windows.Forms.Padding(0);
            this.mainMenu1.Name = "mainMenu1";
            this.mainMenu1.Size = new System.Drawing.Size(237, 654);
            this.mainMenu1.TabIndex = 6;
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1257, 799);
            this.Controls.Add(this.mainMenu1);
            this.Controls.Add(this.MAINPANEL);
            this.Controls.Add(this.controL_MAIN_HEADER1);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bunifuPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

       // private Avocat_Maroc.PL.THEME.MENU.MainMenu mainMenu1;
        private Avocat_Maroc.PL.CONTROL_CONTROL_BOX controL_CONTROL_BOX1;
        private Avocat_Maroc.PL.CONTROL_MAIN_HEADER controL_MAIN_HEADER1;
        private System.Windows.Forms.Panel MAINPANEL;
        private MainMenu mainMenu1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
    }
}
