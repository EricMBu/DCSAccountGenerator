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
            this.lstAccounts = new System.Windows.Forms.ListBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.RichTextBox();
            this.imgCaptcha = new System.Windows.Forms.PictureBox();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.btnActivate = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtCaptcha = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgCaptcha)).BeginInit();
            this.SuspendLayout();
            // 
            // lstAccounts
            // 
            this.lstAccounts.FormattingEnabled = true;
            this.lstAccounts.ItemHeight = 20;
            this.lstAccounts.Items.AddRange(new object[] {
            "Thing",
            "Other thing",
            "I\'m tired",
            "DCS",
            "h"});
            this.lstAccounts.Location = new System.Drawing.Point(30, 22);
            this.lstAccounts.Name = "lstAccounts";
            this.lstAccounts.Size = new System.Drawing.Size(150, 264);
            this.lstAccounts.TabIndex = 0;
            this.lstAccounts.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(223, 22);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(124, 29);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New Account";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(30, 318);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(237, 120);
            this.txtInfo.TabIndex = 2;
            this.txtInfo.Text = "";
            this.txtInfo.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // imgCaptcha
            // 
            this.imgCaptcha.Location = new System.Drawing.Point(405, 90);
            this.imgCaptcha.Name = "imgCaptcha";
            this.imgCaptcha.Size = new System.Drawing.Size(125, 62);
            this.imgCaptcha.TabIndex = 3;
            this.imgCaptcha.TabStop = false;
            // 
            // txtUName
            // 
            this.txtUName.Location = new System.Drawing.Point(223, 90);
            this.txtUName.Name = "txtUName";
            this.txtUName.PlaceholderText = "Username";
            this.txtUName.ReadOnly = true;
            this.txtUName.Size = new System.Drawing.Size(125, 27);
            this.txtUName.TabIndex = 4;
            // 
            // btnActivate
            // 
            this.btnActivate.Location = new System.Drawing.Point(405, 22);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(118, 29);
            this.btnActivate.TabIndex = 5;
            this.btnActivate.Text = "Activate Trial";
            this.btnActivate.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(223, 135);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(125, 27);
            this.txtPassword.TabIndex = 6;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(502, 418);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 20);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "label1";
            // 
            // txtCaptcha
            // 
            this.txtCaptcha.Location = new System.Drawing.Point(405, 158);
            this.txtCaptcha.Name = "txtCaptcha";
            this.txtCaptcha.PlaceholderText = "Captcha";
            this.txtCaptcha.ReadOnly = true;
            this.txtCaptcha.Size = new System.Drawing.Size(125, 27);
            this.txtCaptcha.TabIndex = 8;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(223, 257);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(94, 29);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Confirm";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtCaptcha);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.txtUName);
            this.Controls.Add(this.imgCaptcha);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lstAccounts);
            this.Name = "Form1";
            this.Text = "Account Manager";
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
        private TextBox txtPassword;
        private Label lblStatus;
        private TextBox txtCaptcha;
        private Button btnCreate;
    }
}