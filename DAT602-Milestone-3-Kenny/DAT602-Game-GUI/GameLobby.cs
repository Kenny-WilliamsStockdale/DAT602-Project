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
    public partial class GameLobby : Form
    {
        private DataRow? _user;
        private string _email;
        private DataRow? _player;
        private DataRow? _session;
        private Login _login;
        private Account _account;
        private Admin _admin;
        private GameBoard _board;
        private DataAccess _dbAccess = new();
        public GameLobby()
        {
            InitializeComponent();
        }
        public bool ShowDialog(string email, Login login)
        {
            _login = login;
            _email = email;
            UpdateDisplay();
            return ShowDialog() == DialogResult.Cancel;
        }

        public void UpdateDisplay()
        {
            //Player section
            _player = _dbAccess.GetPlayerInfo(_email);
            dataGridViewPlayers.DataSource = _dbAccess.GetAllPlayers();
            dataGridViewPlayers.Columns[0].Visible = false;
            dataGridViewPlayers.Columns[1].HeaderText = "User Name";
            dataGridViewPlayers.Columns[2].Visible = false;
            dataGridViewPlayers.Columns[3].HeaderText = "High Score";
            dataGridViewPlayers.Columns[4].Visible = false;
            dataGridViewPlayers.Columns[5].Visible = false;
            dataGridViewPlayers.Columns[6].Visible = false;
            dataGridViewPlayers.Columns[7].Visible = false;
            dataGridViewPlayers.Columns[8].Visible = false;

            //Session section
            BindingSource session = new();
            session.DataSource = _dbAccess.getAllSession().Tables[0];
            dataGridViewGames.DataSource = session;
            //dataGridViewGames.DataSource = _dbAccess.getAllSession();
            //dataGridViewGames.Columns[0].HeaderText = "Game ID";

            //Chat section
            dataGridViewChat.DataSource = _dbAccess.GetAllchat();
            dataGridViewChat.Columns[0].Visible = false;
            dataGridViewChat.Columns[2].HeaderText = "From";
        }

        private void btnLogoutLobby_Click(object sender, EventArgs e)
        {
            if (_email != null)
            {
                _dbAccess.Logout(_email);

            }
            _login.Show();
            DialogResult = DialogResult.Cancel;

        }

        private void btnAccountLobby_Click(object sender, EventArgs e)
        {
            _account = new Account();
            _account.Show();
        }

        private void btnAdminLobby_Click(object sender, EventArgs e)
        {

        }

        private void GameLobby_Load(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void dataGridViewPlayers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string adminCheck = _player["isAdmin"].ToString();

            if (adminCheck == "True")
            {
                User aDataTransferObject = (User)dataGridViewPlayers.SelectedRows[0].DataBoundItem;
                aDataTransferObject.Edit(this);
            }
            else
            {
                MessageBox.Show("Access Denied", "Admin", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnJoinLobby_Click(object sender, EventArgs e)
        {
            if (dataGridViewGames.RowCount == 0)
            {
                MessageBox.Show("There are no game sessions", "Game Session", MessageBoxButtons.OK);
                return;
            }
            if (dataGridViewGames.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select a game session", "Game Session", MessageBoxButtons.OK);
                return;
            }
            _session = (DataRow)((DataRowView)dataGridViewGames.SelectedRows[0].DataBoundItem).Row;
            if (_session == null)
            {
                MessageBox.Show("Please select a Session", "Edit Session", MessageBoxButtons.OK);
                return;
            }

            int sessionId = Convert.ToInt32(_session["sessionID"]);
            string playerEmail = Convert.ToString(_player["email"]);
            string message = _dbAccess.joinGame(playerEmail, sessionId);
            if (message == "Welcome to the game")
            {
                _board = new();
                this.Hide();
            }
            else if (message == "You have already joined the session")
            {
                MessageBox.Show("You have already joined the session", "Game", MessageBoxButtons.OK);
                return;
            }

            this.Show();
        }
    }
}
