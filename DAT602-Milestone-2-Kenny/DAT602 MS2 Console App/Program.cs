using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace DAT602_MS2_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DataAccess aDataAccess = new DataAccess();

            Console.WriteLine("Message is " + aDataAccess.Register("Player3", "P@ssword2", "player3@mail.com", "0"));
            Console.WriteLine("Message is " + aDataAccess.Login("Player", "P@ssword2"));
            Console.WriteLine("Message is " + aDataAccess.Logout("Player"));
            Console.WriteLine("Message is " + aDataAccess.deleteAccount("Player3"));

        }
    }
}
