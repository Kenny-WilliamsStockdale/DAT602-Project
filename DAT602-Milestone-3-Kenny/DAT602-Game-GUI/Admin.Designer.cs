namespace DAT602_MS3_Game_GUI
{
    partial class Admin
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
            this.labelGamesLobby = new System.Windows.Forms.Label();
            this.labelPlayersLobby = new System.Windows.Forms.Label();
            this.dataGridViewGames = new System.Windows.Forms.DataGridView();
            this.dataGridViewPlayers = new System.Windows.Forms.DataGridView();
            this.labelTitleAdmin = new System.Windows.Forms.Label();
            this.btnStopGameAdmin = new System.Windows.Forms.Button();
            this.btnBackAdmin = new System.Windows.Forms.Button();
            this.btnAddPlayerAdmin = new System.Windows.Forms.Button();
            this.btnUpdatePlayerAdmin = new System.Windows.Forms.Button();
            this.btnDeleteAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGamesLobby
            // 
            this.labelGamesLobby.AutoSize = true;
            this.labelGamesLobby.Location = new System.Drawing.Point(559, 93);
            this.labelGamesLobby.Name = "labelGamesLobby";
            this.labelGamesLobby.Size = new System.Drawing.Size(54, 20);
            this.labelGamesLobby.TabIndex = 9;
            this.labelGamesLobby.Text = "Games";
            // 
            // labelPlayersLobby
            // 
            this.labelPlayersLobby.AutoSize = true;
            this.labelPlayersLobby.Location = new System.Drawing.Point(165, 93);
            this.labelPlayersLobby.Name = "labelPlayersLobby";
            this.labelPlayersLobby.Size = new System.Drawing.Size(55, 20);
            this.labelPlayersLobby.TabIndex = 8;
            this.labelPlayersLobby.Text = "Players";
            // 
            // dataGridViewGames
            // 
            this.dataGridViewGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGames.Location = new System.Drawing.Point(443, 136);
            this.dataGridViewGames.Name = "dataGridViewGames";
            this.dataGridViewGames.RowHeadersWidth = 51;
            this.dataGridViewGames.RowTemplate.Height = 29;
            this.dataGridViewGames.Size = new System.Drawing.Size(300, 314);
            this.dataGridViewGames.TabIndex = 7;
            // 
            // dataGridViewPlayers
            // 
            this.dataGridViewPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayers.Location = new System.Drawing.Point(55, 136);
            this.dataGridViewPlayers.Name = "dataGridViewPlayers";
            this.dataGridViewPlayers.RowHeadersWidth = 51;
            this.dataGridViewPlayers.RowTemplate.Height = 29;
            this.dataGridViewPlayers.Size = new System.Drawing.Size(300, 314);
            this.dataGridViewPlayers.TabIndex = 6;
            // 
            // labelTitleAdmin
            // 
            this.labelTitleAdmin.AutoSize = true;
            this.labelTitleAdmin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitleAdmin.Location = new System.Drawing.Point(363, 52);
            this.labelTitleAdmin.Name = "labelTitleAdmin";
            this.labelTitleAdmin.Size = new System.Drawing.Size(71, 25);
            this.labelTitleAdmin.TabIndex = 5;
            this.labelTitleAdmin.Text = "Admin";
            // 
            // btnStopGameAdmin
            // 
            this.btnStopGameAdmin.Location = new System.Drawing.Point(542, 489);
            this.btnStopGameAdmin.Name = "btnStopGameAdmin";
            this.btnStopGameAdmin.Size = new System.Drawing.Size(94, 29);
            this.btnStopGameAdmin.TabIndex = 10;
            this.btnStopGameAdmin.Text = "Stop Game";
            this.btnStopGameAdmin.UseVisualStyleBackColor = true;
            // 
            // btnBackAdmin
            // 
            this.btnBackAdmin.Location = new System.Drawing.Point(694, 577);
            this.btnBackAdmin.Name = "btnBackAdmin";
            this.btnBackAdmin.Size = new System.Drawing.Size(94, 29);
            this.btnBackAdmin.TabIndex = 12;
            this.btnBackAdmin.Text = "Back";
            this.btnBackAdmin.UseVisualStyleBackColor = true;
            this.btnBackAdmin.Click += new System.EventHandler(this.btnBackAdmin_Click);
            // 
            // btnAddPlayerAdmin
            // 
            this.btnAddPlayerAdmin.Location = new System.Drawing.Point(148, 478);
            this.btnAddPlayerAdmin.Name = "btnAddPlayerAdmin";
            this.btnAddPlayerAdmin.Size = new System.Drawing.Size(94, 29);
            this.btnAddPlayerAdmin.TabIndex = 13;
            this.btnAddPlayerAdmin.Text = "Add Player";
            this.btnAddPlayerAdmin.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePlayerAdmin
            // 
            this.btnUpdatePlayerAdmin.Location = new System.Drawing.Point(139, 513);
            this.btnUpdatePlayerAdmin.Name = "btnUpdatePlayerAdmin";
            this.btnUpdatePlayerAdmin.Size = new System.Drawing.Size(111, 29);
            this.btnUpdatePlayerAdmin.TabIndex = 14;
            this.btnUpdatePlayerAdmin.Text = "Update Player";
            this.btnUpdatePlayerAdmin.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAdmin
            // 
            this.btnDeleteAdmin.Location = new System.Drawing.Point(139, 548);
            this.btnDeleteAdmin.Name = "btnDeleteAdmin";
            this.btnDeleteAdmin.Size = new System.Drawing.Size(111, 29);
            this.btnDeleteAdmin.TabIndex = 15;
            this.btnDeleteAdmin.Text = "Delete Player";
            this.btnDeleteAdmin.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 618);
            this.Controls.Add(this.btnDeleteAdmin);
            this.Controls.Add(this.btnUpdatePlayerAdmin);
            this.Controls.Add(this.btnAddPlayerAdmin);
            this.Controls.Add(this.btnBackAdmin);
            this.Controls.Add(this.btnStopGameAdmin);
            this.Controls.Add(this.labelGamesLobby);
            this.Controls.Add(this.labelPlayersLobby);
            this.Controls.Add(this.dataGridViewGames);
            this.Controls.Add(this.dataGridViewPlayers);
            this.Controls.Add(this.labelTitleAdmin);
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelGamesLobby;
        private Label labelPlayersLobby;
        private DataGridView dataGridViewGames;
        private DataGridView dataGridViewPlayers;
        private Label labelTitleAdmin;
        private Button btnStopGameAdmin;
        private Button btnBackAdmin;
        private Button btnAddPlayerAdmin;
        private Button btnUpdatePlayerAdmin;
        private Button btnDeleteAdmin;
    }
}