using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace _15oop
{
    internal class Data
    {
        private SqlConnection sqlconnection = new SqlConnection(@"Data Source=DESKTOP-F67DKTK\ROSTIK;Initial Catalog=15lab;Integrated Security=true");
        
        public Data()
        {
            OpenConnection();
        }
        public void OpenConnection()
        {
            if (sqlconnection.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    sqlconnection.Open();
                }
                catch (Exception)
                {
                    Console.WriteLine("4toto ne to");
                }
            }
        }

        public void CloseConnection()
        {
            if (sqlconnection.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    sqlconnection.Close();
                }
                catch (Exception)
                {
                    Console.WriteLine("4toto ne to");
                }
            }
        }

        public void GetCon()
        {
            if (sqlconnection.State == System.Data.ConnectionState.Open)
            {
                Console.WriteLine("siiiiiii");
            }
            else
            {
                Console.WriteLine("ne siiiii");
            }
        }

        public SqlConnection GetSQL()
        {
            return sqlconnection;
        }
    }
}
