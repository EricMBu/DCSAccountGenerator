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
            lstAccounts = new ListBox();
            btnNew = new Button();
            txtInfo = new RichTextBox();
            imgCaptcha = new PictureBox();
            txtUName = new TextBox();
            btnActivate = new Button();
            lblStatus = new Label();
            txtCaptcha = new TextBox();
            btnCreate = new Button();
            btnCancel = new Button();
            lblCaptchaStatus = new Label();
            btnDelete = new Button();
            btnCopyUname = new Button();
            btnCopyPass = new Button();
            ((System.ComponentModel.ISupportInitialize)imgCaptcha).BeginInit();
            SuspendLayout();
            // 
            // lstAccounts
            // 
            lstAccounts.FormattingEnabled = true;
            lstAccounts.ItemHeight = 15;
            lstAccounts.Location = new Point(26, 16);
            lstAccounts.Margin = new Padding(3, 2, 3, 2);
            lstAccounts.Name = "lstAccounts";
            lstAccounts.Size = new Size(132, 199);
            lstAccounts.TabIndex = 0;
            lstAccounts.SelectedIndexChanged += lstAccounts_SelectedIndexChanged;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(175, 16);
            btnNew.Margin = new Padding(3, 2, 3, 2);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(108, 22);
            btnNew.TabIndex = 1;
            btnNew.Text = "New Account";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(26, 238);
            txtInfo.Margin = new Padding(3, 2, 3, 2);
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.Size = new Size(208, 91);
            txtInfo.TabIndex = 2;
            txtInfo.Text = "";
            // 
            // imgCaptcha
            // 
            imgCaptcha.BackColor = SystemColors.ControlLight;
            imgCaptcha.Location = new Point(311, 68);
            imgCaptcha.Margin = new Padding(3, 2, 3, 2);
            imgCaptcha.Name = "imgCaptcha";
            imgCaptcha.Size = new Size(171, 44);
            imgCaptcha.TabIndex = 3;
            imgCaptcha.TabStop = false;
            // 
            // txtUName
            // 
            txtUName.Location = new Point(175, 68);
            txtUName.Margin = new Padding(3, 2, 3, 2);
            txtUName.Name = "txtUName";
            txtUName.PlaceholderText = "Username";
            txtUName.Size = new Size(110, 23);
            txtUName.TabIndex = 4;
            txtUName.TextChanged += txtUName_TextChanged;
            // 
            // btnActivate
            // 
            btnActivate.Enabled = false;
            btnActivate.Location = new Point(354, 16);
            btnActivate.Margin = new Padding(3, 2, 3, 2);
            btnActivate.Name = "btnActivate";
            btnActivate.Size = new Size(103, 22);
            btnActivate.TabIndex = 5;
            btnActivate.Text = "Activate Trials";
            btnActivate.UseVisualStyleBackColor = true;
            btnActivate.Click += btnActivate_Click;
            // 
            // lblStatus
            // 
            lblStatus.ImageAlign = ContentAlignment.MiddleLeft;
            lblStatus.Location = new Point(240, 314);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(242, 15);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "status";
            lblStatus.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCaptcha
            // 
            txtCaptcha.Location = new Point(354, 125);
            txtCaptcha.Margin = new Padding(3, 2, 3, 2);
            txtCaptcha.Name = "txtCaptcha";
            txtCaptcha.PlaceholderText = "Captcha";
            txtCaptcha.Size = new Size(110, 23);
            txtCaptcha.TabIndex = 8;
            // 
            // btnCreate
            // 
            btnCreate.Enabled = false;
            btnCreate.Location = new Point(175, 105);
            btnCreate.Margin = new Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(82, 22);
            btnCreate.TabIndex = 9;
            btnCreate.Text = "Confirm";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Enabled = false;
            btnCancel.Location = new Point(175, 132);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 23);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblCaptchaStatus
            // 
            lblCaptchaStatus.AutoSize = true;
            lblCaptchaStatus.ForeColor = Color.Red;
            lblCaptchaStatus.Location = new Point(358, 150);
            lblCaptchaStatus.Name = "lblCaptchaStatus";
            lblCaptchaStatus.RightToLeft = RightToLeft.No;
            lblCaptchaStatus.Size = new Size(38, 15);
            lblCaptchaStatus.TabIndex = 11;
            lblCaptchaStatus.Text = "status";
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(175, 192);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 23);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCopyUname
            // 
            btnCopyUname.Enabled = false;
            btnCopyUname.Location = new Point(257, 238);
            btnCopyUname.Name = "btnCopyUname";
            btnCopyUname.Size = new Size(116, 23);
            btnCopyUname.TabIndex = 13;
            btnCopyUname.Text = "Copy Username";
            btnCopyUname.UseVisualStyleBackColor = true;
            btnCopyUname.Click += btnCopyUname_Click;
            // 
            // btnCopyPass
            // 
            btnCopyPass.Enabled = false;
            btnCopyPass.Location = new Point(257, 267);
            btnCopyPass.Name = "btnCopyPass";
            btnCopyPass.Size = new Size(116, 23);
            btnCopyPass.TabIndex = 14;
            btnCopyPass.Text = "Copy Password";
            btnCopyPass.UseVisualStyleBackColor = true;
            btnCopyPass.Click += btnCopyPass_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 338);
            Controls.Add(btnCopyPass);
            Controls.Add(btnCopyUname);
            Controls.Add(btnDelete);
            Controls.Add(lblCaptchaStatus);
            Controls.Add(btnCancel);
            Controls.Add(btnCreate);
            Controls.Add(txtCaptcha);
            Controls.Add(lblStatus);
            Controls.Add(btnActivate);
            Controls.Add(txtUName);
            Controls.Add(imgCaptcha);
            Controls.Add(txtInfo);
            Controls.Add(btnNew);
            Controls.Add(lstAccounts);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Account Manager";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)imgCaptcha).EndInit();
            ResumeLayout(false);
            PerformLayout();
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