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
        private User _user;
        string _email;
        private Login _login;
        private Account _account;
        private Admin _admin;
        private DataAccess _dbAccess = new();
        public GameLobby()
        {
            InitializeComponent();
        }
        public bool ShowDialog(Login login, User user)
        {
            _login = login;
            _user = user;
            UpdateDisplay();
            return ShowDialog() == DialogResult.OK;
        }

        private void UpdateDisplay()
        {
            //Player section
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
        }

            private void btnLogoutLobby_Click(object sender, EventArgs e)
        {
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

            if (_user.IsAdmin == true )
            {
                MessageBox.Show("Welcome", "Admin", MessageBoxButtons.OK);
                return;
                _admin = new Admin();
                _admin.Show();
            }
            else
            {
                MessageBox.Show("Acess Denied", "Admin", MessageBoxButtons.OK);
                return;
            }
            
        }

        private void GameLobby_Load(object sender, EventArgs e)
        {
            UpdateDisplay();
        }
    }
}
