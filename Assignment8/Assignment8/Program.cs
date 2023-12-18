using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class Program
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataReader reader;

        static string constr = "server=DESKTOP-VDRMSHO;database=Day8AsignDb;trusted_connection=true;";
        static void Main(string[] args)
        {

            try
            {
                con = new SqlConnection(constr);
                cmd = new SqlCommand
                {
                    Connection = con,
                    CommandText = "select * from Products order by Pid desc"
                };
                con.Open();
                reader = cmd.ExecuteReader();
                Console.WriteLine("ID\tPName\tPPrice\tMafDate\tExpDate");
                while (reader.Read())
                {
                    Console.Write(reader[0] + "\t");
                    Console.Write(reader[1] + "\t \t");
                    Console.Write(reader[2] + "\t \t");
                    Console.Write(reader[3] + "\t");
                    Console.WriteLine("\n");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!");
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }
        }
    }
}
