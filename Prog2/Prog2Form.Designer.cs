namespace UPVApp
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInsertAddress = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInsertLetter = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnListAddress = new System.Windows.Forms.ToolStripMenuItem();
            this.btnListParcels = new System.Windows.Forms.ToolStripMenuItem();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenu,
            this.insertToolStripMenu,
            this.reportToolStripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(847, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenu
            // 
            this.fileToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAbout,
            this.btnExit});
            this.fileToolStripMenu.Name = "fileToolStripMenu";
            this.fileToolStripMenu.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenu.Text = "File";
            // 
            // btnAbout
            // 
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(107, 22);
            this.btnAbout.Text = "About";
            this.btnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 22);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // insertToolStripMenu
            // 
            this.insertToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInsertAddress,
            this.btnInsertLetter});
            this.insertToolStripMenu.Name = "insertToolStripMenu";
            this.insertToolStripMenu.Size = new System.Drawing.Size(48, 20);
            this.insertToolStripMenu.Text = "Insert";
            // 
            // btnInsertAddress
            // 
            this.btnInsertAddress.Name = "btnInsertAddress";
            this.btnInsertAddress.Size = new System.Drawing.Size(116, 22);
            this.btnInsertAddress.Text = "Address";
            this.btnInsertAddress.Click += new System.EventHandler(this.BtnInsertAddress_Click);
            // 
            // btnInsertLetter
            // 
            this.btnInsertLetter.Name = "btnInsertLetter";
            this.btnInsertLetter.Size = new System.Drawing.Size(116, 22);
            this.btnInsertLetter.Text = "Letter";
            this.btnInsertLetter.Click += new System.EventHandler(this.BtnInsertLetter_Click);
            // 
            // reportToolStripMenu
            // 
            this.reportToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnListAddress,
            this.btnListParcels});
            this.reportToolStripMenu.Name = "reportToolStripMenu";
            this.reportToolStripMenu.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenu.Text = "Report";
            // 
            // btnListAddress
            // 
            this.btnListAddress.Name = "btnListAddress";
            this.btnListAddress.Size = new System.Drawing.Size(148, 22);
            this.btnListAddress.Text = "List Addresses";
            this.btnListAddress.Click += new System.EventHandler(this.BtnListAddress_Click);
            // 
            // btnListParcels
            // 
            this.btnListParcels.Name = "btnListParcels";
            this.btnListParcels.Size = new System.Drawing.Size(148, 22);
            this.btnListParcels.Text = "List Parcels";
            this.btnListParcels.Click += new System.EventHandler(this.BtnListParcels_Click);
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(13, 66);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResults.Size = new System.Drawing.Size(822, 708);
            this.txtResults.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 786);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Package Handler";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem btnAbout;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem btnInsertAddress;
        private System.Windows.Forms.ToolStripMenuItem btnInsertLetter;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem btnListAddress;
        private System.Windows.Forms.ToolStripMenuItem btnListParcels;
        private System.Windows.Forms.TextBox txtResults;
    }
}

