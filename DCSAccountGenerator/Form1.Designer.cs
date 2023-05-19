namespace DCSAccountGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstAccounts = new System.Windows.Forms.ListBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.RichTextBox();
            this.imgCaptcha = new System.Windows.Forms.PictureBox();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.btnActivate = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtCaptcha = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgCaptcha)).BeginInit();
            this.SuspendLayout();
            // 
            // lstAccounts
            // 
            this.lstAccounts.FormattingEnabled = true;
            this.lstAccounts.ItemHeight = 20;
            this.lstAccounts.Location = new System.Drawing.Point(30, 21);
            this.lstAccounts.Name = "lstAccounts";
            this.lstAccounts.Size = new System.Drawing.Size(150, 264);
            this.lstAccounts.TabIndex = 0;
            this.lstAccounts.SelectedIndexChanged += new System.EventHandler(this.lstAccounts_SelectedIndexChanged);
            // 
            // btnNew
            // 
            this.btnNew.Enabled = false;
            this.btnNew.Location = new System.Drawing.Point(223, 21);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(123, 29);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New Account";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(30, 317);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(237, 120);
            this.txtInfo.TabIndex = 2;
            this.txtInfo.Text = "";
            // 
            // imgCaptcha
            // 
            this.imgCaptcha.Location = new System.Drawing.Point(405, 91);
            this.imgCaptcha.Name = "imgCaptcha";
            this.imgCaptcha.Size = new System.Drawing.Size(125, 61);
            this.imgCaptcha.TabIndex = 3;
            this.imgCaptcha.TabStop = false;
            // 
            // txtUName
            // 
            this.txtUName.Location = new System.Drawing.Point(223, 91);
            this.txtUName.Name = "txtUName";
            this.txtUName.PlaceholderText = "Username";
            this.txtUName.Size = new System.Drawing.Size(125, 27);
            this.txtUName.TabIndex = 4;
            // 
            // btnActivate
            // 
            this.btnActivate.Enabled = false;
            this.btnActivate.Location = new System.Drawing.Point(405, 21);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(118, 29);
            this.btnActivate.TabIndex = 5;
            this.btnActivate.Text = "Activate Trial";
            this.btnActivate.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(343, 422);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStatus.Size = new System.Drawing.Size(47, 20);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "status";
            // 
            // txtCaptcha
            // 
            this.txtCaptcha.Location = new System.Drawing.Point(405, 157);
            this.txtCaptcha.Name = "txtCaptcha";
            this.txtCaptcha.PlaceholderText = "Captcha";
            this.txtCaptcha.ReadOnly = true;
            this.txtCaptcha.Size = new System.Drawing.Size(125, 27);
            this.txtCaptcha.TabIndex = 8;
            // 
            // btnCreate
            // 
            this.btnCreate.Enabled = false;
            this.btnCreate.Location = new System.Drawing.Point(223, 197);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(94, 29);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Confirm";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(223, 233);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 31);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 451);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtCaptcha);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.txtUName);
            this.Controls.Add(this.imgCaptcha);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lstAccounts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Account Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgCaptcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstAccounts;
        private Button btnNew;
        private RichTextBox txtInfo;
        private PictureBox imgCaptcha;
        private TextBox txtUName;
        private Button btnActivate;
        private Label lblStatus;
        private TextBox txtCaptcha;
        private Button btnCreate;
        private Button btnCancel;
    }
}