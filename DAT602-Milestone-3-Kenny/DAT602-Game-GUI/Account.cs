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
    public partial class Account : Form
    {
        private GameLobby _gameLobby;
        private Login _login;
        private User _user;
        private PasswordChange _passwordChange;
        public Account()
        {
            InitializeComponent();
        }

        public bool ShowDialog(GameLobby gameLobby)
        {
            _gameLobby = gameLobby;
            return ShowDialog() == DialogResult.OK;
        }


        private void btnCancelAccount_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPasswordAccount_Click(object sender, EventArgs e)
        {
            _passwordChange = new PasswordChange();
            _passwordChange.Show();
        }
    }
}
