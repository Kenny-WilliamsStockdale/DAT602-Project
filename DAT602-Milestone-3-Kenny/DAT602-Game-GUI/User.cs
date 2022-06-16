using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT602_MS3_Game_GUI
{
    public class User
    {
        private string _email;
        private string _userName;
        private string _password;
        private int _highScore;
        private int _currentScore;
        private bool _isAdmin;
        private int _loginCount;
        private bool _lockOut;
        private int _activeStatus;

        public string Email { get => _email; set => _email = value; }
        public string UserName { get => _userName; set => _userName = value; }
        public string Password { get => _password; set => _password = value; }
        public int HighScore { get => _highScore; set => _highScore = value; }
        public int CurrentScore { get => _currentScore; set => _currentScore = value; }
        public bool IsAdmin { get => _isAdmin; set => _isAdmin = value; }
        public int LoginCount { get => _loginCount; set => _loginCount = value; }
        public bool LockOut { get => _lockOut; set => _lockOut = value; }
        public int ActiveStatus { get => _activeStatus; set => _activeStatus = value; }
    }
}
