using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAT602_MS3_Game_GUI
{
    public partial class GameBoard : Form
    {
        PictureBox[,] _tiles = new PictureBox[100, 100];
        public GameBoard()
        {
            InitializeComponent();
        }
        private void UpdateDisplay()
        {
            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    _tiles[row, col] = new PictureBox();
                    _tiles[row, col].Width = 50;
                    _tiles[row, col].Height = 50;
                    _tiles[row, col].BackColor = Color.Red;
                    _tiles[row, col].Left = col * 51;
                    _tiles[row, col].Top = row * 51;
                    _tiles[row, col].Click += pictureBox_Click;
                    this.Controls.Add(_tiles[row, col]);
                    this.Invalidate();
                }
            }
        }
        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;

            int row = (pictureBox.Top / 50);
            int col = (pictureBox.Left / 50);
            MessageBox.Show("The (row,col) is (" + row.ToString() + "," + col.ToString() + ")");
        }

        private void GameBoard_Load(object sender, EventArgs e)
        {
            UpdateDisplay();
        }
    }
}
