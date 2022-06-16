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
            if (_register.ShowDialog(this, _user))
            {
                this.Show();
            }
           
            
        }

        private void btnOKLogin_Click(object sender, EventArgs e)
        {
            _gameLobby = new GameLobby();
            this.Hide();
            if (_gameLobby.ShowDialog(this, _user))
            {
                this.Show();
            }
            

        }
    }
}
