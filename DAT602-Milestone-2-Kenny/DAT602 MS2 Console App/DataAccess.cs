using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace DAT602_MS2_ConsoleApp
{
    class DataAccess
    {
        private static string connectionString
        {
            get { return "Server=localhost;Port=3306;Database=DAT602_Kenny_Project;Uid=root;password=@Marine33486"; }

        }

        private static MySqlConnection _mySqlConnection = null;
        public static MySqlConnection mySqlConnection
        {
            get
            {
                if (_mySqlConnection == null)
                {
                    _mySqlConnection = new MySqlConnection(connectionString);
                }

                return _mySqlConnection;

            }
        }
        //REGISTER
        public string Register(string pUserName, string pPassword, string pEmail, string pIsAdmin)
        {
            List<MySqlParameter> p = new List<MySqlParameter>();
            var aP = new MySqlParameter("@pUserName", MySqlDbType.VarChar, 50);
            aP.Value = pUserName;
            p.Add(aP);
            var aP1 = new MySqlParameter("@pPassword", MySqlDbType.VarChar, 50);
            aP1.Value = pPassword;
            p.Add(aP1);
            var aP2 = new MySqlParameter("@pEmail", MySqlDbType.VarChar, 50);
            aP2.Value = pEmail;
            p.Add(aP2);
            var aP3 = new MySqlParameter("@pIsAdmin", MySqlDbType.Bit);
            aP3.Value = pIsAdmin;
            p.Add(aP3);

            var aDataSet = MySqlHelper.ExecuteDataset(DataAccess.mySqlConnection, "Register(@pUserName,@pPassword,@pEmail,@pIsAdmin)", p.ToArray());


            // expecting one table with one row
            return (aDataSet.Tables[0].Rows[0])["message"].ToString();
        }

        //LOGIN
        public string Login(string pUserName, string pPassword)
        {
            List<MySqlParameter> p = new List<MySqlParameter>();
            var aP = new MySqlParameter("@pUserName", MySqlDbType.VarChar, 50);
            aP.Value = pUserName;
            p.Add(aP);
            var aP2 = new MySqlParameter("@pPassword", MySqlDbType.VarChar, 50);
            aP2.Value = pPassword;
            p.Add(aP2);

            var aDataSet = MySqlHelper.ExecuteDataset(DataAccess.mySqlConnection, "Login(@pUserName,@pPassword)", p.ToArray());


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

            var aDataSet = MySqlHelper.ExecuteDataset(DataAccess.mySqlConnection, "Logout(@pUserName)", p.ToArray());


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

            var aDataSet = MySqlHelper.ExecuteDataset(DataAccess.mySqlConnection, "deleteAccount(@pUserName)", p.ToArray());


            // expecting one table with one row
            return (aDataSet.Tables[0].Rows[0])["message"].ToString();
        }

        //GENERATE MAP
        public string genMap()
        {
            List<MySqlParameter> p = new List<MySqlParameter>();

            var aDataSet = MySqlHelper.ExecuteDataset(DataAccess.mySqlConnection, "genMap()", p.ToArray());


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

            var aDataSet = MySqlHelper.ExecuteDataset(DataAccess.mySqlConnection, "joinGame(@pEmail)", p.ToArray());


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

            var aDataSet = MySqlHelper.ExecuteDataset(DataAccess.mySqlConnection, "playerMovement(@pEmail,@pTileID)", p.ToArray());


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

            var aDataSet = MySqlHelper.ExecuteDataset(DataAccess.mySqlConnection, "chat(@pContent,@pEmail)", p.ToArray());


            // expecting one table with one row
            return (aDataSet.Tables[0].Rows[0])["message"].ToString();
        }

        //FINISH GAME | must have a current score on a player record
        public string finishGame()
        {
            List<MySqlParameter> p = new List<MySqlParameter>();

            var aDataSet = MySqlHelper.ExecuteDataset(DataAccess.mySqlConnection, "finishGame()", p.ToArray());


            // expecting one table with one row
            return (aDataSet.Tables[0].Rows[0])["message"].ToString();
        }

        //ADMIN UPDATE PLAYER INFORMATION 
        public string adminUpdatePlayerInfo( string pUser, string pUserName, string pPassword )
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

            var aDataSet = MySqlHelper.ExecuteDataset(DataAccess.mySqlConnection, "adminUpdatePlayerInfo(@pUser,@pUserName,@pPassword)", p.ToArray());


            // expecting one table with one row
            return (aDataSet.Tables[0].Rows[0])["message"].ToString();
        }
    }
}
