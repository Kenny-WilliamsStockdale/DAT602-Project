namespace DAT602_MS3_Game_GUI
{
    partial class Register
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
            this.boxPasswordRegister = new System.Windows.Forms.TextBox();
            this.labelPasswordRegister = new System.Windows.Forms.Label();
            this.boxUsernameRegister = new System.Windows.Forms.TextBox();
            this.labelUsernameRegister = new System.Windows.Forms.Label();
            this.boxEmailRegister = new System.Windows.Forms.TextBox();
            this.labelEmailRegister = new System.Windows.Forms.Label();
            this.btnOkRegister = new System.Windows.Forms.Button();
            this.btnCancelRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boxPasswordRegister
            // 
            this.boxPasswordRegister.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxPasswordRegister.Location = new System.Drawing.Point(179, 198);
            this.boxPasswordRegister.Name = "boxPasswordRegister";
            this.boxPasswordRegister.PasswordChar = '*';
            this.boxPasswordRegister.Size = new System.Drawing.Size(265, 41);
            this.boxPasswordRegister.TabIndex = 7;
            // 
            // labelPasswordRegister
            // 
            this.labelPasswordRegister.AutoSize = true;
            this.labelPasswordRegister.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPasswordRegister.Location = new System.Drawing.Point(53, 201);
            this.labelPasswordRegister.Name = "labelPasswordRegister";
            this.labelPasswordRegister.Size = new System.Drawing.Size(120, 35);
            this.labelPasswordRegister.TabIndex = 6;
            this.labelPasswordRegister.Text = "Password";
            // 
            // boxUsernameRegister
            // 
            this.boxUsernameRegister.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxUsernameRegister.Location = new System.Drawing.Point(179, 129);
            this.boxUsernameRegister.Name = "boxUsernameRegister";
            this.boxUsernameRegister.Size = new System.Drawing.Size(265, 41);
            this.boxUsernameRegister.TabIndex = 5;
            // 
            // labelUsernameRegister
            // 
            this.labelUsernameRegister.AutoSize = true;
            this.labelUsernameRegister.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUsernameRegister.Location = new System.Drawing.Point(46, 132);
            this.labelUsernameRegister.Name = "labelUsernameRegister";
            this.labelUsernameRegister.Size = new System.Drawing.Size(127, 35);
            this.labelUsernameRegister.TabIndex = 4;
            this.labelUsernameRegister.Text = "Username";
            // 
            // boxEmailRegister
            // 
            this.boxEmailRegister.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxEmailRegister.Location = new System.Drawing.Point(179, 57);
            this.boxEmailRegister.Name = "boxEmailRegister";
            this.boxEmailRegister.Size = new System.Drawing.Size(265, 41);
            this.boxEmailRegister.TabIndex = 9;
            // 
            // labelEmailRegister
            // 
            this.labelEmailRegister.AutoSize = true;
            this.labelEmailRegister.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEmailRegister.Location = new System.Drawing.Point(98, 63);
            this.labelEmailRegister.Name = "labelEmailRegister";
            this.labelEmailRegister.Size = new System.Drawing.Size(75, 35);
            this.labelEmailRegister.TabIndex = 8;
            this.labelEmailRegister.Text = "Email";
            // 
            // btnOkRegister
            // 
            this.btnOkRegister.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOkRegister.Location = new System.Drawing.Point(517, 337);
            this.btnOkRegister.Name = "btnOkRegister";
            this.btnOkRegister.Size = new System.Drawing.Size(98, 34);
            this.btnOkRegister.TabIndex = 11;
            this.btnOkRegister.Text = "OK";
            this.btnOkRegister.UseVisualStyleBackColor = true;
            this.btnOkRegister.Click += new System.EventHandler(this.btnRegisterRegister_Click);
            // 
            // btnCancelRegister
            // 
            this.btnCancelRegister.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelRegister.Location = new System.Drawing.Point(12, 337);
            this.btnCancelRegister.Name = "btnCancelRegister";
            this.btnCancelRegister.Size = new System.Drawing.Size(98, 34);
            this.btnCancelRegister.TabIndex = 10;
            this.btnCancelRegister.Text = "Cancel";
            this.btnCancelRegister.UseVisualStyleBackColor = true;
            this.btnCancelRegister.Click += new System.EventHandler(this.btnCancelRegister_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 383);
            this.Controls.Add(this.btnOkRegister);
            this.Controls.Add(this.btnCancelRegister);
            this.Controls.Add(this.boxEmailRegister);
            this.Controls.Add(this.labelEmailRegister);
            this.Controls.Add(this.boxPasswordRegister);
            this.Controls.Add(this.labelPasswordRegister);
            this.Controls.Add(this.boxUsernameRegister);
            this.Controls.Add(this.labelUsernameRegister);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox boxPasswordRegister;
        private Label labelPasswordRegister;
        private TextBox boxUsernameRegister;
        private Label labelUsernameRegister;
        private TextBox boxEmailRegister;
        private Label labelEmailRegister;
        private Button btnOkRegister;
        private Button btnCancelRegister;
    }
}