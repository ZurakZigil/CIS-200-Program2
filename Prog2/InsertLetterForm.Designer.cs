namespace UPVApp
{
    partial class InsertLetterForm
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
            this.components = new System.ComponentModel.Container();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDestAdd = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblOgAdd = new System.Windows.Forms.Label();
            this.comboBoxOriginAddress = new System.Windows.Forms.ComboBox();
            this.comboBoxDestAddress = new System.Windows.Forms.ComboBox();
            this.ErrorLetter = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorLetter)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(532, 135);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 31);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(451, 135);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 31);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCancel_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(613, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(613, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "*";
            // 
            // lblDestAdd
            // 
            this.lblDestAdd.AutoSize = true;
            this.lblDestAdd.Location = new System.Drawing.Point(2, 63);
            this.lblDestAdd.Name = "lblDestAdd";
            this.lblDestAdd.Size = new System.Drawing.Size(157, 20);
            this.lblDestAdd.TabIndex = 28;
            this.lblDestAdd.Text = "Destination Address:";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(113, 107);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(46, 20);
            this.lblCost.TabIndex = 29;
            this.lblCost.Text = "Cost:";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(165, 104);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(140, 26);
            this.txtCost.TabIndex = 2;
            this.txtCost.Validating += new System.ComponentModel.CancelEventHandler(this.txtCost_Validating);
            this.txtCost.Validated += new System.EventHandler(this.txtCost_Validated);
            // 
            // lblOgAdd
            // 
            this.lblOgAdd.AutoSize = true;
            this.lblOgAdd.Location = new System.Drawing.Point(42, 28);
            this.lblOgAdd.Name = "lblOgAdd";
            this.lblOgAdd.Size = new System.Drawing.Size(117, 20);
            this.lblOgAdd.TabIndex = 27;
            this.lblOgAdd.Text = "Origin Address:";
            // 
            // comboBoxOriginAddress
            // 
            this.comboBoxOriginAddress.FormattingEnabled = true;
            this.comboBoxOriginAddress.Location = new System.Drawing.Point(165, 25);
            this.comboBoxOriginAddress.Name = "comboBoxOriginAddress";
            this.comboBoxOriginAddress.Size = new System.Drawing.Size(442, 28);
            this.comboBoxOriginAddress.TabIndex = 0;
            this.comboBoxOriginAddress.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxOriginAddress_Validating);
            this.comboBoxOriginAddress.Validated += new System.EventHandler(this.comboBoxOriginAddress_Validated);
            // 
            // comboBoxDestAddress
            // 
            this.comboBoxDestAddress.FormattingEnabled = true;
            this.comboBoxDestAddress.Location = new System.Drawing.Point(165, 60);
            this.comboBoxDestAddress.Name = "comboBoxDestAddress";
            this.comboBoxDestAddress.Size = new System.Drawing.Size(442, 28);
            this.comboBoxDestAddress.TabIndex = 1;
            this.comboBoxDestAddress.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxDestAddress_Validating);
            this.comboBoxDestAddress.Validated += new System.EventHandler(this.comboBoxDestAddress_Validated);
            // 
            // ErrorLetter
            // 
            this.ErrorLetter.ContainerControl = this;
            // 
            // InsertLetterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 180);
            this.Controls.Add(this.comboBoxDestAddress);
            this.Controls.Add(this.comboBoxOriginAddress);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDestAdd);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblOgAdd);
            this.Name = "InsertLetterForm";
            this.Text = "Create a New Letter Form";
            this.Load += new System.EventHandler(this.InsertLetterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorLetter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDestAdd;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblOgAdd;
        private System.Windows.Forms.ComboBox comboBoxOriginAddress;
        private System.Windows.Forms.ComboBox comboBoxDestAddress;
        private System.Windows.Forms.ErrorProvider ErrorLetter;
    }
}