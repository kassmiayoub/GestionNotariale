namespace gestion_cabinet_notarial
{
    partial class Form1
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
            this.MAINPANEL = new System.Windows.Forms.Panel();
            this.controL_MAIN_HEADER1 = new Avocat_Maroc.PL.CONTROL_MAIN_HEADER();
            this.controL_CONTROL_BOX1 = new Avocat_Maroc.PL.CONTROL_CONTROL_BOX();
            this.mainMenu1 = new gestion_cabinet_notarial.MainMenu();
            this.SuspendLayout();
            // 
            // MAINPANEL
            // 
            this.MAINPANEL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MAINPANEL.Location = new System.Drawing.Point(278, 107);
            this.MAINPANEL.Name = "MAINPANEL";
            this.MAINPANEL.Size = new System.Drawing.Size(853, 579);
            this.MAINPANEL.TabIndex = 5;
            // 
            // controL_MAIN_HEADER1
            // 
            this.controL_MAIN_HEADER1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controL_MAIN_HEADER1.BackColor = System.Drawing.Color.White;
            this.controL_MAIN_HEADER1.Location = new System.Drawing.Point(18, 12);
            this.controL_MAIN_HEADER1.Name = "controL_MAIN_HEADER1";
            this.controL_MAIN_HEADER1.Size = new System.Drawing.Size(1021, 72);
            this.controL_MAIN_HEADER1.TabIndex = 4;
            // 
            // controL_CONTROL_BOX1
            // 
            this.controL_CONTROL_BOX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controL_CONTROL_BOX1.BackColor = System.Drawing.Color.Transparent;
            this.controL_CONTROL_BOX1.Location = new System.Drawing.Point(1070, 12);
            this.controL_CONTROL_BOX1.Name = "controL_CONTROL_BOX1";
            this.controL_CONTROL_BOX1.Size = new System.Drawing.Size(72, 32);
            this.controL_CONTROL_BOX1.TabIndex = 1;
            // 
            // mainMenu1
            // 
            this.mainMenu1.BackColor = System.Drawing.Color.White;
            this.mainMenu1.Location = new System.Drawing.Point(9, 107);
            this.mainMenu1.Margin = new System.Windows.Forms.Padding(0);
            this.mainMenu1.Name = "mainMenu1";
            this.mainMenu1.Size = new System.Drawing.Size(250, 579);
            this.mainMenu1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 711);
            this.Controls.Add(this.mainMenu1);
            this.Controls.Add(this.MAINPANEL);
            this.Controls.Add(this.controL_MAIN_HEADER1);
            this.Controls.Add(this.controL_CONTROL_BOX1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

       // private Avocat_Maroc.PL.THEME.MENU.MainMenu mainMenu1;
        private Avocat_Maroc.PL.CONTROL_CONTROL_BOX controL_CONTROL_BOX1;
        private Avocat_Maroc.PL.CONTROL_MAIN_HEADER controL_MAIN_HEADER1;
        private System.Windows.Forms.Panel MAINPANEL;
        private MainMenu mainMenu1;
    }
}

