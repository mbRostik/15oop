using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_2_
{
    internal class tovaru
    {
        private SqlConnection sqlconnection = new SqlConnection(@"Data Source=DESKTOP-F67DKTK\ROSTIK;Initial Catalog=15lab;Integrated Security=true");

        public tovaru()
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

        public void GetAll()
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Kanctovaru", sqlconnection);
            SqlDataReader sdr = sqlCommand.ExecuteReader();
            while (sdr.Read())
            {
                for (int i = 0; i != sdr.FieldCount; i++)
                {
                    Console.Write(sdr[i] + " ");
                }
                Console.WriteLine();
            }
            sdr.Close();
        }

        public void GetTypes()
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT Type FROM Kanctovaru GROUP BY Type", sqlconnection);
            SqlDataReader sdr = sqlCommand.ExecuteReader();
            while (sdr.Read())
            {
                for (int i = 0; i != sdr.FieldCount; i++)
                {
                    Console.Write(sdr[i] + " ");
                }
                Console.WriteLine();
            }
            sdr.Close();
        }

        public void GetManagers()
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT Manager FROM Kanctovaru GROUP BY Manager", sqlconnection);
            SqlDataReader sdr = sqlCommand.ExecuteReader();
            while (sdr.Read())
            {
                for (int i = 0; i != sdr.FieldCount; i++)
                {
                    Console.Write(sdr[i] + " ");
                }
                Console.WriteLine();
            }
            sdr.Close();
        }

        public void GetMaxKol()
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT Name, Kol FROM Kanctovaru WHERE Kol = (SELECT MAX(Kol) FROM Kanctovaru);", sqlconnection);
            SqlDataReader sdr = sqlCommand.ExecuteReader();
            while (sdr.Read())
            {
                for (int i = 0; i != sdr.FieldCount; i++)
                {
                    Console.Write(sdr[i] + " ");
                }
                Console.WriteLine();
            }
            sdr.Close();
        }

        public void GetMinKol()
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT Name, Kol FROM Kanctovaru WHERE Kol = (SELECT MIN(Kol) FROM Kanctovaru);", sqlconnection);
            SqlDataReader sdr = sqlCommand.ExecuteReader();
            while (sdr.Read())
            {
                for (int i = 0; i != sdr.FieldCount; i++)
                {
                    Console.Write(sdr[i] + " ");
                }
                Console.WriteLine();
            }
            sdr.Close();
        }

        public void GetMaxPrice()
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT Name, Price FROM Kanctovaru WHERE Price = (SELECT MAX(Price) FROM Kanctovaru);", sqlconnection);
            SqlDataReader sdr = sqlCommand.ExecuteReader();
            while (sdr.Read())
            {
                for (int i = 0; i != sdr.FieldCount; i++)
                {
                    Console.Write(sdr[i] + " ");
                }
                Console.WriteLine();
            }
            sdr.Close();
        }

        public void GetMinPrice()
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT Name, Price FROM Kanctovaru WHERE Price = (SELECT MIN(Price) FROM Kanctovaru);", sqlconnection);
            SqlDataReader sdr = sqlCommand.ExecuteReader();
            while (sdr.Read())
            {
                for (int i = 0; i != sdr.FieldCount; i++)
                {
                    Console.Write(sdr[i] + " ");
                }
                Console.WriteLine();
            }
            sdr.Close();
        }
    }
}

