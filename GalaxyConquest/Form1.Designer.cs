namespace GalaxyConquest
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.mainMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mainMenuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.galaxyImage = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.buttonSpinLeft = new System.Windows.Forms.Button();
            this.buttonSpinRight = new System.Windows.Forms.Button();
            this.buttonSpinUp = new System.Windows.Forms.Button();
            this.buttonSpinDown = new System.Windows.Forms.Button();
            this.mainMenuText = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.galaxyImage)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuFile,
            this.mainMenuText});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(483, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // mainMenuFile
            // 
            this.mainMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuNew,
            this.mainMenuOpen,
            this.mainMenuSave,
            this.toolStripSeparator1,
            this.mainMenuQuit});
            this.mainMenuFile.Name = "mainMenuFile";
            this.mainMenuFile.Size = new System.Drawing.Size(35, 20);
            this.mainMenuFile.Text = "File";
            // 
            // mainMenuNew
            // 
            this.mainMenuNew.Name = "mainMenuNew";
            this.mainMenuNew.Size = new System.Drawing.Size(152, 22);
            this.mainMenuNew.Text = "New";
            this.mainMenuNew.Click += new System.EventHandler(this.mainMenuNew_Click);
            // 
            // mainMenuOpen
            // 
            this.mainMenuOpen.Name = "mainMenuOpen";
            this.mainMenuOpen.Size = new System.Drawing.Size(152, 22);
            this.mainMenuOpen.Text = "Open...";
            this.mainMenuOpen.Click += new System.EventHandler(this.mainMenuOpen_Click);
            // 
            // mainMenuSave
            // 
            this.mainMenuSave.Name = "mainMenuSave";
            this.mainMenuSave.Size = new System.Drawing.Size(152, 22);
            this.mainMenuSave.Text = "Save...";
            this.mainMenuSave.Click += new System.EventHandler(this.mainMenuSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // mainMenuQuit
            // 
            this.mainMenuQuit.Name = "mainMenuQuit";
            this.mainMenuQuit.Size = new System.Drawing.Size(152, 22);
            this.mainMenuQuit.Text = "Quit";
            this.mainMenuQuit.Click += new System.EventHandler(this.mainMenuQuit_Click);
            // 
            // galaxyImage
            // 
            this.galaxyImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.galaxyImage.BackColor = System.Drawing.Color.Black;
            this.galaxyImage.Location = new System.Drawing.Point(140, 27);
            this.galaxyImage.Name = "galaxyImage";
            this.galaxyImage.Size = new System.Drawing.Size(311, 263);
            this.galaxyImage.TabIndex = 1;
            this.galaxyImage.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 316);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(483, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(29, 45);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(75, 23);
            this.buttonDraw.TabIndex = 3;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // buttonSpinLeft
            // 
            this.buttonSpinLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSpinLeft.Location = new System.Drawing.Point(234, 290);
            this.buttonSpinLeft.Name = "buttonSpinLeft";
            this.buttonSpinLeft.Size = new System.Drawing.Size(75, 23);
            this.buttonSpinLeft.TabIndex = 4;
            this.buttonSpinLeft.Text = "<---";
            this.buttonSpinLeft.UseVisualStyleBackColor = true;
            this.buttonSpinLeft.Click += new System.EventHandler(this.buttonSpinLeft_Click);
            // 
            // buttonSpinRight
            // 
            this.buttonSpinRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSpinRight.Location = new System.Drawing.Point(315, 290);
            this.buttonSpinRight.Name = "buttonSpinRight";
            this.buttonSpinRight.Size = new System.Drawing.Size(75, 23);
            this.buttonSpinRight.TabIndex = 5;
            this.buttonSpinRight.Text = "--->";
            this.buttonSpinRight.UseVisualStyleBackColor = true;
            this.buttonSpinRight.Click += new System.EventHandler(this.buttonSpinRight_Click);
            // 
            // buttonSpinUp
            // 
            this.buttonSpinUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSpinUp.Location = new System.Drawing.Point(457, 72);
            this.buttonSpinUp.Name = "buttonSpinUp";
            this.buttonSpinUp.Size = new System.Drawing.Size(25, 66);
            this.buttonSpinUp.TabIndex = 6;
            this.buttonSpinUp.Text = "/\\";
            this.buttonSpinUp.UseVisualStyleBackColor = true;
            this.buttonSpinUp.Click += new System.EventHandler(this.buttonSpinUp_Click);
            // 
            // buttonSpinDown
            // 
            this.buttonSpinDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSpinDown.Location = new System.Drawing.Point(458, 144);
            this.buttonSpinDown.Name = "buttonSpinDown";
            this.buttonSpinDown.Size = new System.Drawing.Size(25, 66);
            this.buttonSpinDown.TabIndex = 7;
            this.buttonSpinDown.Text = "\\/";
            this.buttonSpinDown.UseVisualStyleBackColor = true;
            this.buttonSpinDown.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainMenuText
            // 
            this.mainMenuText.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mainMenuText.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuAbout});
            this.mainMenuText.Name = "mainMenuText";
            this.mainMenuText.Size = new System.Drawing.Size(40, 20);
            this.mainMenuText.Text = "Help";
            // 
            // mainMenuAbout
            // 
            this.mainMenuAbout.Name = "mainMenuAbout";
            this.mainMenuAbout.Size = new System.Drawing.Size(152, 22);
            this.mainMenuAbout.Text = "About...";
            this.mainMenuAbout.Click += new System.EventHandler(this.mainMenuAbout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 338);
            this.Controls.Add(this.buttonSpinDown);
            this.Controls.Add(this.buttonSpinUp);
            this.Controls.Add(this.buttonSpinRight);
            this.Controls.Add(this.buttonSpinLeft);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.galaxyImage);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "Form1";
            this.Text = "GalaxyConquest";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.galaxyImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem mainMenuFile;
        private System.Windows.Forms.ToolStripMenuItem mainMenuQuit;
        private System.Windows.Forms.PictureBox galaxyImage;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuNew;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Button buttonSpinLeft;
        private System.Windows.Forms.Button buttonSpinRight;
        private System.Windows.Forms.Button buttonSpinUp;
        private System.Windows.Forms.Button buttonSpinDown;
        private System.Windows.Forms.ToolStripMenuItem mainMenuOpen;
        private System.Windows.Forms.ToolStripMenuItem mainMenuSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuText;
        private System.Windows.Forms.ToolStripMenuItem mainMenuAbout;
    }
}

