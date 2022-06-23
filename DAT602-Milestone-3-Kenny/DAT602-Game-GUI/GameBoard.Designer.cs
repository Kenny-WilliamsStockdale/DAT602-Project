namespace DAT602_MS3_Game_GUI
{
    partial class GameBoard
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
            this.Up = new System.Windows.Forms.Button();
            this.Right = new System.Windows.Forms.Button();
            this.Left = new System.Windows.Forms.Button();
            this.Down = new System.Windows.Forms.Button();
            this.btnCancelGameBoard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Up
            // 
            this.Up.Location = new System.Drawing.Point(651, 161);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(94, 29);
            this.Up.TabIndex = 1;
            this.Up.Text = "Up";
            this.Up.UseVisualStyleBackColor = true;
            // 
            // Right
            // 
            this.Right.Location = new System.Drawing.Point(731, 220);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(94, 29);
            this.Right.TabIndex = 2;
            this.Right.Text = "Right";
            this.Right.UseVisualStyleBackColor = true;
            // 
            // Left
            // 
            this.Left.Location = new System.Drawing.Point(570, 220);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(94, 29);
            this.Left.TabIndex = 3;
            this.Left.Text = "Left";
            this.Left.UseVisualStyleBackColor = true;
            // 
            // Down
            // 
            this.Down.Location = new System.Drawing.Point(651, 281);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(94, 29);
            this.Down.TabIndex = 4;
            this.Down.Text = "Down";
            this.Down.UseVisualStyleBackColor = true;
            // 
            // btnCancelGameBoard
            // 
            this.btnCancelGameBoard.Location = new System.Drawing.Point(808, 559);
            this.btnCancelGameBoard.Name = "btnCancelGameBoard";
            this.btnCancelGameBoard.Size = new System.Drawing.Size(94, 29);
            this.btnCancelGameBoard.TabIndex = 5;
            this.btnCancelGameBoard.Text = "Quit";
            this.btnCancelGameBoard.UseVisualStyleBackColor = true;
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.btnCancelGameBoard);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Up);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GameBoard";
            this.Text = "Game Board";
            this.Load += new System.EventHandler(this.GameBoard_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Button Up;
        private Button Right;
        private Button Left;
        private Button Down;
        private Button btnCancelGameBoard;
    }
}