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
    public partial class Login : Form
    {
        private Login _login;
        private Register _register;
        private User _user;
        private GameLobby _gameLobby;
        private DataAccess _dbAccess = new();

        public Login()
        {
            InitializeComponent();
        }

        private void btnCancelLogin_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void btnRegisterLogin_Click(object sender, EventArgs e)
        {
            _register = new Register();
            _user = new User();
            this.Hide();
            if (_user != null && _register.ShowDialog(this, _user))
            {
                _gameLobby = new GameLobby();
                _gameLobby.ShowDialog(_user.Email, this);
            } 
        }

        private void btnOKLogin_Click(object sender, EventArgs e)
        {
            // check email and password credintials
            _user = new();
            string email = this.boxEmailLogin.Text;
            string password = this.boxPasswordLogin.Text;

            if (
                email.Length == 0 ||
                password.Length == 0
                )
            {
                MessageBox.Show("Please fill in a fields", "Login", MessageBoxButtons.OK);
                return;
            }

            string message = _dbAccess.Login(email, password);

            
            if (message == "Logged In")
            {
                this.Hide();
                _gameLobby = new GameLobby();
                if (
                _gameLobby.ShowDialog(email, this))
                {
                    this.Show();
                }
            }
            else if (message == "Locked Out")
            {
                MessageBox.Show(message, "Login Error", MessageBoxButtons.OK);
                return;
            }
            else
            {
                MessageBox.Show(message, "Login Error.", MessageBoxButtons.OK);
                return;
            }
            

        }
    }
}
