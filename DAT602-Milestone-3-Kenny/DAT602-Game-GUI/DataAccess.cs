using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT602_MS3_Game_GUI
{
    internal class DataAccess
    {
        private static readonly String connectionString = "Server=localhost;Port=3306;Database=DAT602_Kenny_Project;Uid=root;password=@Marine33486";
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection = new(connectionString);
    }
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
}
