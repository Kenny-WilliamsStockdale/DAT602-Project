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
    public partial class Register : Form
    {
        private Login _login;
        private User _user;
        private DataAccess _dbAccess = new();
        public Register()
        {
            InitializeComponent();
        }

        public bool ShowDialog(Login login, User user)
        {
            _login = login;
            _user = user;
            return ShowDialog() == DialogResult.OK;
        }

        private void btnCancelRegister_Click(object sender, EventArgs e)
        {
            _login.Show();
            DialogResult = DialogResult.Cancel;
        }
        private void PushData()
        {
            _user.Email = boxEmailRegister.Text;
            _user.UserName = boxUsernameRegister.Text;
            _user.Password = boxPasswordRegister.Text;
        }

        private void btnRegisterRegister_Click(object sender, EventArgs e)
        {
            string email = boxEmailRegister.Text;
            string username = boxUsernameRegister.Text;
            string password = boxPasswordRegister.Text;
            if (
             email.Length == 0 ||
             username.Length == 0 ||
             password.Length == 0
             )
            {
                MessageBox.Show("Please fill in all fields", "Register", MessageBoxButtons.OK);
                return;
            }
            string message = _dbAccess.Register(email, username, password);
            if (message == "USER ADDED")
            {
                MessageBox.Show("Registration confirmed, Welcome!", "Register", MessageBoxButtons.OK);
                PushData();
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(message, "Register", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
