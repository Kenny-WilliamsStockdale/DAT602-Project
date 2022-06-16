namespace DAT602_MS3_Game_GUI
{
    partial class Login
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
            this.labelUsernameLogin = new System.Windows.Forms.Label();
            this.boxUsernameLogin = new System.Windows.Forms.TextBox();
            this.boxPasswordLogin = new System.Windows.Forms.TextBox();
            this.labelPasswordLogin = new System.Windows.Forms.Label();
            this.btnOKLogin = new System.Windows.Forms.Button();
            this.btnRegisterLogin = new System.Windows.Forms.Button();
            this.btnCancelLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUsernameLogin
            // 
            this.labelUsernameLogin.AutoSize = true;
            this.labelUsernameLogin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUsernameLogin.Location = new System.Drawing.Point(52, 103);
            this.labelUsernameLogin.Name = "labelUsernameLogin";
            this.labelUsernameLogin.Size = new System.Drawing.Size(127, 35);
            this.labelUsernameLogin.TabIndex = 0;
            this.labelUsernameLogin.Text = "Username";
            // 
            // boxUsernameLogin
            // 
            this.boxUsernameLogin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxUsernameLogin.Location = new System.Drawing.Point(185, 100);
            this.boxUsernameLogin.Name = "boxUsernameLogin";
            this.boxUsernameLogin.Size = new System.Drawing.Size(160, 41);
            this.boxUsernameLogin.TabIndex = 1;
            // 
            // boxPasswordLogin
            // 
            this.boxPasswordLogin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxPasswordLogin.Location = new System.Drawing.Point(185, 169);
            this.boxPasswordLogin.Name = "boxPasswordLogin";
            this.boxPasswordLogin.Size = new System.Drawing.Size(160, 41);
            this.boxPasswordLogin.TabIndex = 3;
            // 
            // labelPasswordLogin
            // 
            this.labelPasswordLogin.AutoSize = true;
            this.labelPasswordLogin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPasswordLogin.Location = new System.Drawing.Point(59, 172);
            this.labelPasswordLogin.Name = "labelPasswordLogin";
            this.labelPasswordLogin.Size = new System.Drawing.Size(120, 35);
            this.labelPasswordLogin.TabIndex = 2;
            this.labelPasswordLogin.Text = "Password";
            // 
            // btnOKLogin
            // 
            this.btnOKLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOKLogin.Location = new System.Drawing.Point(296, 337);
            this.btnOKLogin.Name = "btnOKLogin";
            this.btnOKLogin.Size = new System.Drawing.Size(98, 34);
            this.btnOKLogin.TabIndex = 4;
            this.btnOKLogin.Text = "OK";
            this.btnOKLogin.UseVisualStyleBackColor = true;
            this.btnOKLogin.Click += new System.EventHandler(this.btnOKLogin_Click);
            // 
            // btnRegisterLogin
            // 
            this.btnRegisterLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegisterLogin.Location = new System.Drawing.Point(156, 252);
            this.btnRegisterLogin.Name = "btnRegisterLogin";
            this.btnRegisterLogin.Size = new System.Drawing.Size(98, 34);
            this.btnRegisterLogin.TabIndex = 5;
            this.btnRegisterLogin.Text = "Register";
            this.btnRegisterLogin.UseVisualStyleBackColor = true;
            this.btnRegisterLogin.Click += new System.EventHandler(this.btnRegisterLogin_Click);
            // 
            // btnCancelLogin
            // 
            this.btnCancelLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelLogin.Location = new System.Drawing.Point(12, 337);
            this.btnCancelLogin.Name = "btnCancelLogin";
            this.btnCancelLogin.Size = new System.Drawing.Size(98, 34);
            this.btnCancelLogin.TabIndex = 6;
            this.btnCancelLogin.Text = "Cancel";
            this.btnCancelLogin.UseVisualStyleBackColor = true;
            this.btnCancelLogin.Click += new System.EventHandler(this.btnCancelLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 383);
            this.Controls.Add(this.btnCancelLogin);
            this.Controls.Add(this.btnRegisterLogin);
            this.Controls.Add(this.btnOKLogin);
            this.Controls.Add(this.boxPasswordLogin);
            this.Controls.Add(this.labelPasswordLogin);
            this.Controls.Add(this.boxUsernameLogin);
            this.Controls.Add(this.labelUsernameLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelUsernameLogin;
        private TextBox boxUsernameLogin;
        private TextBox boxPasswordLogin;
        private Label labelPasswordLogin;
        private Button btnOKLogin;
        private Button btnRegisterLogin;
        private Button btnCancelLogin;
    }
}