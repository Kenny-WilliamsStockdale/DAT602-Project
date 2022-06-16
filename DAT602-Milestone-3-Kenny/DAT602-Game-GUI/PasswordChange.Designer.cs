namespace DAT602_MS3_Game_GUI
{
    partial class PasswordChange
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
            this.btnOKPasswordChange = new System.Windows.Forms.Button();
            this.btnCancelRegister = new System.Windows.Forms.Button();
            this.labelPasswordChange = new System.Windows.Forms.Label();
            this.boxPasswordChange = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOKPasswordChange
            // 
            this.btnOKPasswordChange.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOKPasswordChange.Location = new System.Drawing.Point(296, 337);
            this.btnOKPasswordChange.Name = "btnOKPasswordChange";
            this.btnOKPasswordChange.Size = new System.Drawing.Size(98, 34);
            this.btnOKPasswordChange.TabIndex = 13;
            this.btnOKPasswordChange.Text = "OK";
            this.btnOKPasswordChange.UseVisualStyleBackColor = true;
            // 
            // btnCancelRegister
            // 
            this.btnCancelRegister.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelRegister.Location = new System.Drawing.Point(12, 337);
            this.btnCancelRegister.Name = "btnCancelRegister";
            this.btnCancelRegister.Size = new System.Drawing.Size(98, 34);
            this.btnCancelRegister.TabIndex = 12;
            this.btnCancelRegister.Text = "Cancel";
            this.btnCancelRegister.UseVisualStyleBackColor = true;
            this.btnCancelRegister.Click += new System.EventHandler(this.btnCancelRegister_Click);
            // 
            // labelPasswordChange
            // 
            this.labelPasswordChange.AutoSize = true;
            this.labelPasswordChange.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPasswordChange.Location = new System.Drawing.Point(102, 57);
            this.labelPasswordChange.Name = "labelPasswordChange";
            this.labelPasswordChange.Size = new System.Drawing.Size(202, 25);
            this.labelPasswordChange.TabIndex = 14;
            this.labelPasswordChange.Text = "Enter in new password";
            // 
            // boxPasswordChange
            // 
            this.boxPasswordChange.Location = new System.Drawing.Point(102, 126);
            this.boxPasswordChange.Name = "boxPasswordChange";
            this.boxPasswordChange.Size = new System.Drawing.Size(202, 27);
            this.boxPasswordChange.TabIndex = 15;
            // 
            // PasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 383);
            this.Controls.Add(this.boxPasswordChange);
            this.Controls.Add(this.labelPasswordChange);
            this.Controls.Add(this.btnOKPasswordChange);
            this.Controls.Add(this.btnCancelRegister);
            this.Name = "PasswordChange";
            this.Text = "PasswordChange";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnOKPasswordChange;
        private Button btnCancelRegister;
        private Label labelPasswordChange;
        private TextBox boxPasswordChange;
    }
}