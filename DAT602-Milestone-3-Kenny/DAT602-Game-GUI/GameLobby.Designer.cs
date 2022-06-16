namespace DAT602_MS3_Game_GUI
{
    partial class GameLobby
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
            this.labelTitleLobby = new System.Windows.Forms.Label();
            this.dataGridViewPlayers = new System.Windows.Forms.DataGridView();
            this.dataGridViewGames = new System.Windows.Forms.DataGridView();
            this.labelPlayersLobby = new System.Windows.Forms.Label();
            this.labelGamesLobby = new System.Windows.Forms.Label();
            this.btnPlayLobby = new System.Windows.Forms.Button();
            this.btnLogoutLobby = new System.Windows.Forms.Button();
            this.btnAccountLobby = new System.Windows.Forms.Button();
            this.btnAdminLobby = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnChatLobby = new System.Windows.Forms.Button();
            this.boxChatLobby = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitleLobby
            // 
            this.labelTitleLobby.AutoSize = true;
            this.labelTitleLobby.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitleLobby.Location = new System.Drawing.Point(331, 29);
            this.labelTitleLobby.Name = "labelTitleLobby";
            this.labelTitleLobby.Size = new System.Drawing.Size(128, 25);
            this.labelTitleLobby.TabIndex = 0;
            this.labelTitleLobby.Text = "Player Lobby";
            // 
            // dataGridViewPlayers
            // 
            this.dataGridViewPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayers.Location = new System.Drawing.Point(55, 112);
            this.dataGridViewPlayers.Name = "dataGridViewPlayers";
            this.dataGridViewPlayers.RowHeadersWidth = 51;
            this.dataGridViewPlayers.RowTemplate.Height = 29;
            this.dataGridViewPlayers.Size = new System.Drawing.Size(300, 314);
            this.dataGridViewPlayers.TabIndex = 1;
            // 
            // dataGridViewGames
            // 
            this.dataGridViewGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGames.Location = new System.Drawing.Point(443, 112);
            this.dataGridViewGames.Name = "dataGridViewGames";
            this.dataGridViewGames.RowHeadersWidth = 51;
            this.dataGridViewGames.RowTemplate.Height = 29;
            this.dataGridViewGames.Size = new System.Drawing.Size(300, 314);
            this.dataGridViewGames.TabIndex = 2;
            // 
            // labelPlayersLobby
            // 
            this.labelPlayersLobby.AutoSize = true;
            this.labelPlayersLobby.Location = new System.Drawing.Point(165, 69);
            this.labelPlayersLobby.Name = "labelPlayersLobby";
            this.labelPlayersLobby.Size = new System.Drawing.Size(55, 20);
            this.labelPlayersLobby.TabIndex = 3;
            this.labelPlayersLobby.Text = "Players";
            // 
            // labelGamesLobby
            // 
            this.labelGamesLobby.AutoSize = true;
            this.labelGamesLobby.Location = new System.Drawing.Point(559, 69);
            this.labelGamesLobby.Name = "labelGamesLobby";
            this.labelGamesLobby.Size = new System.Drawing.Size(54, 20);
            this.labelGamesLobby.TabIndex = 4;
            this.labelGamesLobby.Text = "Games";
            // 
            // btnPlayLobby
            // 
            this.btnPlayLobby.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlayLobby.Location = new System.Drawing.Point(688, 694);
            this.btnPlayLobby.Name = "btnPlayLobby";
            this.btnPlayLobby.Size = new System.Drawing.Size(100, 34);
            this.btnPlayLobby.TabIndex = 5;
            this.btnPlayLobby.Text = "Play";
            this.btnPlayLobby.UseVisualStyleBackColor = true;
            // 
            // btnLogoutLobby
            // 
            this.btnLogoutLobby.Location = new System.Drawing.Point(212, 699);
            this.btnLogoutLobby.Name = "btnLogoutLobby";
            this.btnLogoutLobby.Size = new System.Drawing.Size(94, 29);
            this.btnLogoutLobby.TabIndex = 6;
            this.btnLogoutLobby.Text = "Logout";
            this.btnLogoutLobby.UseVisualStyleBackColor = true;
            this.btnLogoutLobby.Click += new System.EventHandler(this.btnLogoutLobby_Click);
            // 
            // btnAccountLobby
            // 
            this.btnAccountLobby.Location = new System.Drawing.Point(12, 699);
            this.btnAccountLobby.Name = "btnAccountLobby";
            this.btnAccountLobby.Size = new System.Drawing.Size(94, 29);
            this.btnAccountLobby.TabIndex = 7;
            this.btnAccountLobby.Text = "Account";
            this.btnAccountLobby.UseVisualStyleBackColor = true;
            this.btnAccountLobby.Click += new System.EventHandler(this.btnAccountLobby_Click);
            // 
            // btnAdminLobby
            // 
            this.btnAdminLobby.Location = new System.Drawing.Point(112, 699);
            this.btnAdminLobby.Name = "btnAdminLobby";
            this.btnAdminLobby.Size = new System.Drawing.Size(94, 29);
            this.btnAdminLobby.TabIndex = 8;
            this.btnAdminLobby.Text = "Admin";
            this.btnAdminLobby.UseVisualStyleBackColor = true;
            this.btnAdminLobby.Click += new System.EventHandler(this.btnAdminLobby_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 444);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(688, 120);
            this.dataGridView1.TabIndex = 9;
            // 
            // btnChatLobby
            // 
            this.btnChatLobby.Location = new System.Drawing.Point(649, 614);
            this.btnChatLobby.Name = "btnChatLobby";
            this.btnChatLobby.Size = new System.Drawing.Size(94, 29);
            this.btnChatLobby.TabIndex = 10;
            this.btnChatLobby.Text = "Chat";
            this.btnChatLobby.UseVisualStyleBackColor = true;
            // 
            // boxChatLobby
            // 
            this.boxChatLobby.Location = new System.Drawing.Point(55, 570);
            this.boxChatLobby.Multiline = true;
            this.boxChatLobby.Name = "boxChatLobby";
            this.boxChatLobby.Size = new System.Drawing.Size(588, 73);
            this.boxChatLobby.TabIndex = 11;
            // 
            // GameLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 740);
            this.Controls.Add(this.boxChatLobby);
            this.Controls.Add(this.btnChatLobby);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdminLobby);
            this.Controls.Add(this.btnAccountLobby);
            this.Controls.Add(this.btnLogoutLobby);
            this.Controls.Add(this.btnPlayLobby);
            this.Controls.Add(this.labelGamesLobby);
            this.Controls.Add(this.labelPlayersLobby);
            this.Controls.Add(this.dataGridViewGames);
            this.Controls.Add(this.dataGridViewPlayers);
            this.Controls.Add(this.labelTitleLobby);
            this.Name = "GameLobby";
            this.Text = "Game Lobby";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTitleLobby;
        private DataGridView dataGridViewPlayers;
        private DataGridView dataGridViewGames;
        private Label labelPlayersLobby;
        private Label labelGamesLobby;
        private Button btnPlayLobby;
        private Button btnLogoutLobby;
        private Button btnAccountLobby;
        private Button btnAdminLobby;
        private DataGridView dataGridView1;
        private Button btnChatLobby;
        private TextBox boxChatLobby;
    }
}