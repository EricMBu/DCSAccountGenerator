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
            this.lblCaptchaStatus = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCopyUname = new System.Windows.Forms.Button();
            this.btnCopyPass = new System.Windows.Forms.Button();
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
            this.btnNew.Location = new System.Drawing.Point(200, 21);
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
            this.imgCaptcha.BackColor = System.Drawing.SystemColors.ControlLight;
            this.imgCaptcha.Location = new System.Drawing.Point(355, 91);
            this.imgCaptcha.Name = "imgCaptcha";
            this.imgCaptcha.Size = new System.Drawing.Size(195, 59);
            this.imgCaptcha.TabIndex = 3;
            this.imgCaptcha.TabStop = false;
            // 
            // txtUName
            // 
            this.txtUName.Location = new System.Drawing.Point(200, 91);
            this.txtUName.Name = "txtUName";
            this.txtUName.PlaceholderText = "Username";
            this.txtUName.Size = new System.Drawing.Size(125, 27);
            this.txtUName.TabIndex = 4;
            this.txtUName.TextChanged += new System.EventHandler(this.txtUName_TextChanged);
            // 
            // btnActivate
            // 
            this.btnActivate.Enabled = false;
            this.btnActivate.Location = new System.Drawing.Point(405, 21);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(118, 29);
            this.btnActivate.TabIndex = 5;
            this.btnActivate.Text = "Activate Trials";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStatus.Location = new System.Drawing.Point(274, 419);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(277, 20);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCaptcha
            // 
            this.txtCaptcha.Location = new System.Drawing.Point(405, 167);
            this.txtCaptcha.Name = "txtCaptcha";
            this.txtCaptcha.PlaceholderText = "Captcha";
            this.txtCaptcha.Size = new System.Drawing.Size(125, 27);
            this.txtCaptcha.TabIndex = 8;
            // 
            // btnCreate
            // 
            this.btnCreate.Enabled = false;
            this.btnCreate.Location = new System.Drawing.Point(200, 140);
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
            this.btnCancel.Location = new System.Drawing.Point(200, 176);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 31);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCaptchaStatus
            // 
            this.lblCaptchaStatus.AutoSize = true;
            this.lblCaptchaStatus.ForeColor = System.Drawing.Color.Red;
            this.lblCaptchaStatus.Location = new System.Drawing.Point(409, 200);
            this.lblCaptchaStatus.Name = "lblCaptchaStatus";
            this.lblCaptchaStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCaptchaStatus.Size = new System.Drawing.Size(47, 20);
            this.lblCaptchaStatus.TabIndex = 11;
            this.lblCaptchaStatus.Text = "status";
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(200, 256);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 31);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCopyUname
            // 
            this.btnCopyUname.Enabled = false;
            this.btnCopyUname.Location = new System.Drawing.Point(294, 317);
            this.btnCopyUname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCopyUname.Name = "btnCopyUname";
            this.btnCopyUname.Size = new System.Drawing.Size(133, 31);
            this.btnCopyUname.TabIndex = 13;
            this.btnCopyUname.Text = "Copy Username";
            this.btnCopyUname.UseVisualStyleBackColor = true;
            this.btnCopyUname.Click += new System.EventHandler(this.btnCopyUname_Click);
            // 
            // btnCopyPass
            // 
            this.btnCopyPass.Enabled = false;
            this.btnCopyPass.Location = new System.Drawing.Point(294, 356);
            this.btnCopyPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCopyPass.Name = "btnCopyPass";
            this.btnCopyPass.Size = new System.Drawing.Size(133, 31);
            this.btnCopyPass.TabIndex = 14;
            this.btnCopyPass.Text = "Copy Password";
            this.btnCopyPass.UseVisualStyleBackColor = true;
            this.btnCopyPass.Click += new System.EventHandler(this.btnCopyPass_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(565, 451);
            this.Controls.Add(this.btnCopyPass);
            this.Controls.Add(this.btnCopyUname);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblCaptchaStatus);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
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
        private Label lblCaptchaStatus;
        private Button btnDelete;
        private Button btnCopyUname;
        private Button btnCopyPass;
    }
}