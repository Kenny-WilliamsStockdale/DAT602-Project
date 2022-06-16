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
        private Login _login;
        private Account _account;
        private Admin _admin;
        public GameLobby()
        {
            InitializeComponent();
        }
        public bool ShowDialog(Login login, User user)
        {
            _login = login;
            _user = user;
            return ShowDialog() == DialogResult.OK;
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
            _admin = new Admin();
            _admin.Show();
        }
    }
}
