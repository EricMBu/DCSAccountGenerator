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
            lstAccounts = new ListBox();
            btnNew = new Button();
            txtInfo = new RichTextBox();
            imgCaptcha = new PictureBox();
            txtUName = new TextBox();
            btnActivate = new Button();
            txtPassword = new TextBox();
            lblStatus = new Label();
            txtCaptcha = new TextBox();
            btnCreate = new Button();
            btnCancel = new Button();
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
            lstAccounts.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(195, 16);
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
            txtInfo.TextChanged += richTextBox1_TextChanged;
            // 
            // imgCaptcha
            // 
            imgCaptcha.Location = new Point(354, 68);
            imgCaptcha.Margin = new Padding(3, 2, 3, 2);
            imgCaptcha.Name = "imgCaptcha";
            imgCaptcha.Size = new Size(109, 46);
            imgCaptcha.TabIndex = 3;
            imgCaptcha.TabStop = false;
            // 
            // txtUName
            // 
            txtUName.Location = new Point(195, 68);
            txtUName.Margin = new Padding(3, 2, 3, 2);
            txtUName.Name = "txtUName";
            txtUName.PlaceholderText = "Username";
            txtUName.ReadOnly = true;
            txtUName.Size = new Size(110, 23);
            txtUName.TabIndex = 4;
            // 
            // btnActivate
            // 
            btnActivate.Location = new Point(354, 16);
            btnActivate.Margin = new Padding(3, 2, 3, 2);
            btnActivate.Name = "btnActivate";
            btnActivate.Size = new Size(103, 22);
            btnActivate.TabIndex = 5;
            btnActivate.Text = "Activate Trial";
            btnActivate.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(195, 101);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(110, 23);
            txtPassword.TabIndex = 6;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(439, 314);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(38, 15);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "label1";
            // 
            // txtCaptcha
            // 
            txtCaptcha.Location = new Point(354, 118);
            txtCaptcha.Margin = new Padding(3, 2, 3, 2);
            txtCaptcha.Name = "txtCaptcha";
            txtCaptcha.PlaceholderText = "Captcha";
            txtCaptcha.ReadOnly = true;
            txtCaptcha.Size = new Size(110, 23);
            txtCaptcha.TabIndex = 8;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(195, 193);
            btnCreate.Margin = new Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(82, 22);
            btnCreate.TabIndex = 9;
            btnCreate.Text = "Confirm";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(283, 192);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 338);
            Controls.Add(btnCancel);
            Controls.Add(btnCreate);
            Controls.Add(txtCaptcha);
            Controls.Add(lblStatus);
            Controls.Add(txtPassword);
            Controls.Add(btnActivate);
            Controls.Add(txtUName);
            Controls.Add(imgCaptcha);
            Controls.Add(txtInfo);
            Controls.Add(btnNew);
            Controls.Add(lstAccounts);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Account Manager";
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
        private TextBox txtPassword;
        private Label lblStatus;
        private TextBox txtCaptcha;
        private Button btnCreate;
        private Button btnCancel;
    }
}