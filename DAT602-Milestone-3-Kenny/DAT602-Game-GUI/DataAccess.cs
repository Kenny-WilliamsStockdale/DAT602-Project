using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DAT602_MS3_Game_GUI
{
    class DataAccess
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
        public string Logout(string pUserName)
        {
            List<MySqlParameter> p = new List<MySqlParameter>();
            var aP = new MySqlParameter("@pUserName", MySqlDbType.VarChar, 50);
            aP.Value = pUserName;
            p.Add(aP);

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "Logout(@pUserName)", p.ToArray());


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
        public string joinGame(string pEmail)
        {
            List<MySqlParameter> p = new List<MySqlParameter>();
            var aP = new MySqlParameter("@pEmail", MySqlDbType.VarChar, 50);
            aP.Value = pEmail;
            p.Add(aP);

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "joinGame(@pEmail)", p.ToArray());


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
        public string adminUpdatePlayerInfo(string pUser, string pUserName, string pPassword)
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

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "adminUpdatePlayerInfo(@pUser,@pUserName,@pPassword)", p.ToArray());


            // expecting one table with one row
            return (aDataSet.Tables[0].Rows[0])["message"].ToString();
        }

        //GET SPEC PLAYER INFORMATION
        public DataRow GetPlayerInfo(string pEmail)
        {
            List<MySqlParameter> p = new List<MySqlParameter>();
            var aP = new MySqlParameter("@pEmail", MySqlDbType.VarChar, 50);
            aP.Value = pEmail;
            p.Add(aP);

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "GetAllPlayers(pEmail)", p.ToArray());


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
                lsUsers.Add(lcUser);
            }

            // expecting one table with one row
            return lsUsers;
        }
    }
   
}
