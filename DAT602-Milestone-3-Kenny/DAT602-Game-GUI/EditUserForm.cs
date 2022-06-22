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
    public partial class EditUserForm : Form
    {
        public User _user;
        private GameLobby _gameLobby;
        public EditUserForm(GameLobby _parentForm)
        {
            InitializeComponent();
            _gameLobby = _parentForm;
        }

        private void btnOkEUF_Click(object sender, EventArgs e)
        {
            _user.Email = boxEmailEUF.Text;
            _user.UserName = boxUserNameEUF.Text;
            _user.Password = boxPasswordEUF.Text;
            _user.HighScore = Convert.ToInt32(boxHighScoreEUF.Text);
            _user.LoginCount = Convert.ToInt32(boxLoginCountEUF.Text);
            _user.LockOut = Convert.ToBoolean(checkBoxLoginCountEUF.Checked);
            _gameLobby.UpdateDisplay();

            var _dbAccess = new DataAccess();
            List<Message> aMessages = _dbAccess.adminUpdatePlayerInfo(_user.Email, _user.UserName, _user.Password, _user.HighScore, _user.LoginCount, _user.LockOut);
            MessageBox.Show(aMessages[0].TheMessage);
            _gameLobby.UpdateDisplay();
            Close();
        }

        private void btnCancelEUF_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
