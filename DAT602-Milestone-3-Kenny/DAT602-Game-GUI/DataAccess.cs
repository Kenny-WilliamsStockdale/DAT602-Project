using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DAT602_MS3_Game_GUI
{
    public class DataAccess
    {
        private static readonly String connectionString = "Server=localhost;Port=3306;Database=DAT602_Kenny_Project;Uid=root;password=@Marine33486";
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection = new(connectionString);

        //REGISTER
        public string Register(string pEmail, string pUserName, string pPassword)
        {
            List<MySqlParameter> p = new List<MySqlParameter>();
            var aP = new MySqlParameter("@pEmail", MySqlDbType.VarChar, 50);
            aP.Value = pEmail;
            p.Add(aP);
            var aP1 = new MySqlParameter("@pUserName", MySqlDbType.VarChar, 50);
            aP1.Value = pUserName;
            p.Add(aP1);
            var aP2 = new MySqlParameter("@pPassword", MySqlDbType.VarChar, 50);
            aP2.Value = pPassword;
            p.Add(aP2);
            

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "Register(@pEmail,@pUserName,@pPassword)", p.ToArray());


            // expecting one table with one row
            return (aDataSet.Tables[0].Rows[0])["message"].ToString();
        }

        //LOGIN
        public string Login(string pEmail, string pPassword)
        {
            List<MySqlParameter> p = new List<MySqlParameter>();
            var aP = new MySqlParameter("@pEmail", MySqlDbType.VarChar, 50);
            aP.Value = pEmail;
            p.Add(aP);
            var aP2 = new MySqlParameter("@pPassword", MySqlDbType.VarChar, 50);
            aP2.Value = pPassword;
            p.Add(aP2);

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "Login(@pEmail,@pPassword)", p.ToArray());


            // expecting one table with one row
            return (aDataSet.Tables[0].Rows[0])["message"].ToString();
        }

        //LOGOUT
        public string Logout(string pEmail)
        {
            List<MySqlParameter> p = new List<MySqlParameter>();
            var aP = new MySqlParameter("@pEmail", MySqlDbType.VarChar, 50);
            aP.Value = pEmail;
            p.Add(aP);

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "Logout(@pEmail)", p.ToArray());


            // expecting one table with one row
            return (aDataSet.Tables[0].Rows[0])["message"].ToString();
        }

        //DELETE ACCOUNT
        public string deleteAccount(string pUserName)
        {
            List<MySqlParameter> p = new List<MySqlParameter>();
            var aP = new MySqlParameter("@pUserName", MySqlDbType.VarChar, 50);
            aP.Value = pUserName;
            p.Add(aP);

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "deleteAccount(@pUserName)", p.ToArray());


            // expecting one table with one row
            return (aDataSet.Tables[0].Rows[0])["message"].ToString();
        }

        //GENERATE MAP
        public string genMap()
        {
            List<MySqlParameter> p = new List<MySqlParameter>();

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "genMap()", p.ToArray());


            // expecting one table with one row
            return (aDataSet.Tables[0].Rows[0])["message"].ToString();
        }

        //JOIN GAME 
        public string joinGame(string pEmail, int pSelectedSession)
        {
            List<MySqlParameter> p = new List<MySqlParameter>();
            var aP = new MySqlParameter("@pEmail", MySqlDbType.VarChar, 50);
            aP.Value = pEmail;
            p.Add(aP);
            var aP2 = new MySqlParameter("@pSelectedSession", MySqlDbType.Int32, 50);
            aP2.Value = pSelectedSession;
            p.Add(aP2);

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "joinGame(@pEmail,@pSelectedSession)", p.ToArray());


            // expecting one table with one row
            return (aDataSet.Tables[0].Rows[0])["message"].ToString();
        }


        //PLAYER MOVEMENT
        public string playerMovement(string pEmail, int pTileID)
        {
            List<MySqlParameter> p = new List<MySqlParameter>();
            var aP = new MySqlParameter("@pEmail", MySqlDbType.VarChar, 50);
            aP.Value = pEmail;
            p.Add(aP);
            var aP2 = new MySqlParameter("@pTileID", MySqlDbType.Int32);
            aP2.Value = pTileID;
            p.Add(aP2);

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "playerMovement(@pEmail,@pTileID)", p.ToArray());


            // expecting one table with one row
            return (aDataSet.Tables[0].Rows[0])["message"].ToString();
        }

        //CHAT
        public string chat(string pContent, string pEmail)
        {
            List<MySqlParameter> p = new List<MySqlParameter>();
            var aP = new MySqlParameter("@pContent", MySqlDbType.VarChar, 500);
            aP.Value = pContent;
            p.Add(aP);
            var aP2 = new MySqlParameter("@pEmail", MySqlDbType.VarChar, 50);
            aP2.Value = pEmail;
            p.Add(aP2);

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "chat(@pContent,@pEmail)", p.ToArray());


            // expecting one table with one row
            return (aDataSet.Tables[0].Rows[0])["message"].ToString();
        }

        //FINISH GAME | must have a current score on a player record
        public string finishGame()
        {
            List<MySqlParameter> p = new List<MySqlParameter>();

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "finishGame()", p.ToArray());


            // expecting one table with one row
            return (aDataSet.Tables[0].Rows[0])["message"].ToString();
        }

        //ADMIN UPDATE PLAYER INFORMATION 
        public List<Message> adminUpdatePlayerInfo(string pUser, string pUserName, string pPassword, int pHighscore, int ploginCount, bool pLockout)
        {
            List<MySqlParameter> p = new List<MySqlParameter>();
            var aP = new MySqlParameter("@pUser", MySqlDbType.VarChar, 50);
            aP.Value = pUser;
            p.Add(aP);
            var aP2 = new MySqlParameter("@pUserName", MySqlDbType.VarChar, 50);
            aP2.Value = pUserName;
            p.Add(aP2);
            var aP3 = new MySqlParameter("@pPassword", MySqlDbType.VarChar, 50);
            aP3.Value = pPassword;
            p.Add(aP3);
            var aP4 = new MySqlParameter("@pHighscore", MySqlDbType.Int32, 10);
            aP4.Value = pHighscore;
            p.Add(aP4);
            var aP5 = new MySqlParameter("@ploginCount", MySqlDbType.Int32, 10);
            aP5.Value = ploginCount;
            p.Add(aP5);
            var aP6 = new MySqlParameter("@pLockout", MySqlDbType.Bit);
            aP6.Value = pLockout;
            p.Add(aP6);

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "adminUpdatePlayerInfo(@pUser,@pUserName,@pPassword,@pHighscore,@ploginCount,@pLockout)", p.ToArray());
            List<Message> dataList = new List<Message>();
            foreach (DataRow row in aDataSet.Tables[0].Rows)
            {
                Message aMessage = new Message();
                aMessage.TheMessage = row.Field<string>("Message");
                dataList.Add(aMessage);
            }
            return dataList;
        }

        //GET SPEC PLAYER INFORMATION
        public DataRow GetPlayerInfo(string pEmail)
        {
            List<MySqlParameter> p = new List<MySqlParameter>();
            var aP = new MySqlParameter("@pEmail", MySqlDbType.VarChar, 50);
            aP.Value = pEmail;
            p.Add(aP);

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "Call GetPlayerInfo(@pEmail)", p.ToArray());


            // expecting one table with one row
            return aDataSet.Tables[0].Rows[0];
        }

        //GET ALL ACTIVE PLAYER INFORMATION
        public List<User> GetAllPlayers()
        {
            List<User> lsUsers = new List<User>();

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "Call GetAllPlayers()");
            foreach (DataRow record in aDataSet.Tables[0].Rows)
            {
                User lcUser = new User();
                lcUser.UserName = record.Field<String>("UserName");
                lcUser.Email = record.Field<String>("Email");
                lcUser.HighScore = record.Field<Int32>("highScore");
                lcUser.IsAdmin = record.Field<Boolean>("isAdmin");
                lcUser.Password = record.Field<String>("password");
                lcUser.LoginCount = record.Field<Int32>("loginCount");
                lcUser.LockOut = record.Field<Boolean>("lockOut");
                lsUsers.Add(lcUser);
            }

            // expecting one table with one row
            return lsUsers;
        }

        //GET ALL ACTIVE GAME SESSIONS INFORMATION
        public DataSet getAllSession()
        {
            return MySqlHelper.ExecuteDataset(mySqlConnection, "Call getAllSession()");
            //foreach (DataRow record in aDataSet.Tables[0].Rows)
            //{
            //    Session lcSessions = new Session();
            //    lcSessions.SessionID = record.Field<Int32>("sessionID");
            //    lsSessions.Add(lcSessions);
            //}

            //// expecting one table with one row
            //return lsSessions;
        }

        //GET ALL CHAT/MESSAGES INFORMATION
        public List<Chat> GetAllchat()
        {
            List<Chat> lsChat = new List<Chat>();

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "Call GetAllchat()");
            foreach (DataRow record in aDataSet.Tables[0].Rows)
            {
                Chat lcChat = new Chat();
                lcChat.ChatID = record.Field<Int32>("chatID");
                lcChat.FromEmail = record.Field<String>("fromEmail");
                lcChat.Message = record.Field<String>("message");
                lsChat.Add(lcChat);
            }

            // expecting one table with one row
            return lsChat;
        }
    }
   
}
