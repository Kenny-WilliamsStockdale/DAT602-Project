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

        private void btnRegisterRegister_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
