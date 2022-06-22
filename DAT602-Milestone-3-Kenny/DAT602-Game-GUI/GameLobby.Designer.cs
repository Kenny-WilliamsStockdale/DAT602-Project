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
            this.btnJoinLobby = new System.Windows.Forms.Button();
            this.btnLogoutLobby = new System.Windows.Forms.Button();
            this.dataGridViewChat = new System.Windows.Forms.DataGridView();
            this.btnChatLobby = new System.Windows.Forms.Button();
            this.boxChatLobby = new System.Windows.Forms.TextBox();
            this.btnCreateLobby = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChat)).BeginInit();
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
            this.dataGridViewPlayers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewPlayers.Location = new System.Drawing.Point(55, 112);
            this.dataGridViewPlayers.MultiSelect = false;
            this.dataGridViewPlayers.Name = "dataGridViewPlayers";
            this.dataGridViewPlayers.ReadOnly = true;
            this.dataGridViewPlayers.RowHeadersWidth = 51;
            this.dataGridViewPlayers.RowTemplate.Height = 29;
            this.dataGridViewPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPlayers.Size = new System.Drawing.Size(300, 314);
            this.dataGridViewPlayers.TabIndex = 1;
            this.dataGridViewPlayers.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewPlayers_CellMouseDoubleClick);
            // 
            // dataGridViewGames
            // 
            this.dataGridViewGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGames.Location = new System.Drawing.Point(443, 112);
            this.dataGridViewGames.MultiSelect = false;
            this.dataGridViewGames.Name = "dataGridViewGames";
            this.dataGridViewGames.RowHeadersWidth = 51;
            this.dataGridViewGames.RowTemplate.Height = 29;
            this.dataGridViewGames.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            // btnJoinLobby
            // 
            this.btnJoinLobby.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnJoinLobby.Location = new System.Drawing.Point(688, 694);
            this.btnJoinLobby.Name = "btnJoinLobby";
            this.btnJoinLobby.Size = new System.Drawing.Size(100, 34);
            this.btnJoinLobby.TabIndex = 5;
            this.btnJoinLobby.Text = "Join";
            this.btnJoinLobby.UseVisualStyleBackColor = true;
            this.btnJoinLobby.Click += new System.EventHandler(this.btnJoinLobby_Click);
            // 
            // btnLogoutLobby
            // 
            this.btnLogoutLobby.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogoutLobby.Location = new System.Drawing.Point(12, 699);
            this.btnLogoutLobby.Name = "btnLogoutLobby";
            this.btnLogoutLobby.Size = new System.Drawing.Size(100, 34);
            this.btnLogoutLobby.TabIndex = 6;
            this.btnLogoutLobby.Text = "Logout";
            this.btnLogoutLobby.UseVisualStyleBackColor = true;
            this.btnLogoutLobby.Click += new System.EventHandler(this.btnLogoutLobby_Click);
            // 
            // dataGridViewChat
            // 
            this.dataGridViewChat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChat.Location = new System.Drawing.Point(55, 444);
            this.dataGridViewChat.Name = "dataGridViewChat";
            this.dataGridViewChat.RowHeadersWidth = 51;
            this.dataGridViewChat.RowTemplate.Height = 29;
            this.dataGridViewChat.Size = new System.Drawing.Size(688, 120);
            this.dataGridViewChat.TabIndex = 9;
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
            // btnCreateLobby
            // 
            this.btnCreateLobby.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateLobby.Location = new System.Drawing.Point(582, 694);
            this.btnCreateLobby.Name = "btnCreateLobby";
            this.btnCreateLobby.Size = new System.Drawing.Size(100, 34);
            this.btnCreateLobby.TabIndex = 12;
            this.btnCreateLobby.Text = "Create";
            this.btnCreateLobby.UseVisualStyleBackColor = true;
            // 
            // GameLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 740);
            this.Controls.Add(this.btnCreateLobby);
            this.Controls.Add(this.boxChatLobby);
            this.Controls.Add(this.btnChatLobby);
            this.Controls.Add(this.dataGridViewChat);
            this.Controls.Add(this.btnLogoutLobby);
            this.Controls.Add(this.btnJoinLobby);
            this.Controls.Add(this.labelGamesLobby);
            this.Controls.Add(this.labelPlayersLobby);
            this.Controls.Add(this.dataGridViewGames);
            this.Controls.Add(this.dataGridViewPlayers);
            this.Controls.Add(this.labelTitleLobby);
            this.Name = "GameLobby";
            this.Text = "Game Lobby";
            this.Load += new System.EventHandler(this.GameLobby_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTitleLobby;
        private DataGridView dataGridViewPlayers;
        private DataGridView dataGridViewGames;
        private Label labelPlayersLobby;
        private Label labelGamesLobby;
        private Button btnJoinLobby;
        private Button btnLogoutLobby;
        private DataGridView dataGridViewChat;
        private Button btnChatLobby;
        private TextBox boxChatLobby;
        private Button btnCreateLobby;
    }
}