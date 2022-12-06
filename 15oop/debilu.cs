using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace _15oop
{
    internal class debilu
    {
        private SqlConnection sqlconnection=new SqlConnection();
       
        public debilu(SqlConnection conection)
        {
            sqlconnection=conection;
            
        }

        public void GetAll()
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Grades", sqlconnection);
            SqlDataReader sdr = sqlCommand.ExecuteReader();
            while (sdr.Read())
            {
                for(int i=0;i!=sdr.FieldCount;i++)
                {
                    Console.Write(sdr[i]+" ");
                }
                Console.WriteLine();
            }
            sdr.Close();
        }

        public void GetMin()
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT MIN(AvgGrade) FROM Grades", sqlconnection);
            SqlDataReader sdr = sqlCommand.ExecuteReader();
            while (sdr.Read())
            {
                Console.WriteLine("MinGrade = " + sdr[0]);
            }
            sdr.Close();
        }

        public void GetMax()
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT MAX(AvgGrade) FROM Grades", sqlconnection);
            SqlDataReader sdr = sqlCommand.ExecuteReader();
            while (sdr.Read())
            {
                Console.WriteLine("MaxGrade = " + sdr[0]);
            }
            sdr.Close();
        }

        public void GetMinMatem()
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT* FROM Grades WHERE MinPredmet='Matem'", sqlconnection);
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

            sqlCommand = new SqlCommand("SELECT COUNT(MinPredmet) FROM Grades WHERE MinPredmet='Matem'", sqlconnection);
            sdr = sqlCommand.ExecuteReader();
            while (sdr.Read())
            {
                Console.WriteLine("Count = " + sdr[0]);
            }

            sdr.Close();
        }

        public void GetMaxMatem()
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT* FROM Grades WHERE MaxPredtem='Matem'", sqlconnection);
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

            sqlCommand = new SqlCommand("SELECT COUNT(MaxPredtem) FROM Grades WHERE MaxPredtem='Matem'", sqlconnection);
            sdr = sqlCommand.ExecuteReader();
            while (sdr.Read())
            {
                Console.WriteLine("Count = " + sdr[0]);
            }

            sdr.Close();
        }

        public void GetGroups()
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(ID), [Name of group] FROM Grades GROUP BY [Name of group]", sqlconnection);
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

        public void GetMarks()
        {
            int temp = int.Parse(Console.ReadLine());

            SqlCommand sqlCommand = new SqlCommand(String.Format("SELECT Name FROM Grades WHERE AvgGrade > ('{0}')", temp), sqlconnection);

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

        public void GetMinPredmet()
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT MinPredmet FROM Grades GROUP BY MinPredmet", sqlconnection);
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
