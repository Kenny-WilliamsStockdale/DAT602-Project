using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT602_MS3_Game_GUI
{
    public class Chat
    {
        private int _chatID;
        private string _message;
        private string _fromEmail;

        public int ChatID { get => _chatID; set => _chatID = value; }
        public string Message { get => _message; set => _message = value; }
        public string FromEmail { get => _fromEmail; set => _fromEmail = value; }
    }
}
