namespace DAT602_MS3_Game_GUI
{
    partial class Account
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
            this.btnCancelAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnPasswordAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancelAccount
            // 
            this.btnCancelAccount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelAccount.Location = new System.Drawing.Point(12, 337);
            this.btnCancelAccount.Name = "btnCancelAccount";
            this.btnCancelAccount.Size = new System.Drawing.Size(98, 34);
            this.btnCancelAccount.TabIndex = 11;
            this.btnCancelAccount.Text = "Cancel";
            this.btnCancelAccount.UseVisualStyleBackColor = true;
            this.btnCancelAccount.Click += new System.EventHandler(this.btnCancelAccount_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteAccount.Location = new System.Drawing.Point(125, 170);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(157, 34);
            this.btnDeleteAccount.TabIndex = 12;
            this.btnDeleteAccount.Text = "Delete Account";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            // 
            // btnPasswordAccount
            // 
            this.btnPasswordAccount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPasswordAccount.Location = new System.Drawing.Point(117, 115);
            this.btnPasswordAccount.Name = "btnPasswordAccount";
            this.btnPasswordAccount.Size = new System.Drawing.Size(170, 34);
            this.btnPasswordAccount.TabIndex = 13;
            this.btnPasswordAccount.Text = "Change Password";
            this.btnPasswordAccount.UseVisualStyleBackColor = true;
            this.btnPasswordAccount.Click += new System.EventHandler(this.btnPasswordAccount_Click);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 383);
            this.Controls.Add(this.btnPasswordAccount);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.btnCancelAccount);
            this.Name = "Account";
            this.Text = "Account";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCancelAccount;
        private Button btnDeleteAccount;
        private Button btnPasswordAccount;
    }
}