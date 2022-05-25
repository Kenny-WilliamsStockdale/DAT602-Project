﻿using System;
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

        ////JOIN GAME -need to fix with single output from MySQL
        //public string joinGame(string pEmail)
        //{
        //    List<MySqlParameter> p = new List<MySqlParameter>();
        //    var aP = new MySqlParameter("@pEmail", MySqlDbType.VarChar, 50);
        //    aP.Value = pEmail;
        //    p.Add(aP);

        //    var aDataSet = MySqlHelper.ExecuteDataset(DataAccess.mySqlConnection, "joinGame(@pEmail)", p.ToArray());


        //    // expecting one table with one row
        //    return (aDataSet.Tables[0].Rows[0])["message"].ToString();
        //}

        ////UPDATE PLAYER HIGH SCORE - Need a player with current score greater than the player's high score before execution
        //public string updatePlayerHighScore(string pEmail)
        //{
        //    List<MySqlParameter> p = new List<MySqlParameter>();
        //    var aP = new MySqlParameter("@pEmail", MySqlDbType.VarChar, 50);
        //    aP.Value = pEmail;
        //    p.Add(aP);

        //    var aDataSet = MySqlHelper.ExecuteDataset(DataAccess.mySqlConnection, "updatePlayerHighScore(@pEmail)", p.ToArray());


        //    // expecting one table with one row
        //    return (aDataSet.Tables[0].Rows[0])["message"].ToString();
        //}
    }
}
