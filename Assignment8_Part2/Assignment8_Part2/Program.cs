using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8_Part2
{
    internal class Program
    {
        static DataTable create()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Pid", typeof(int));
            dt.Columns.Add("Pname", typeof(string));
            dt.Columns.Add("Pprice", typeof(int));
            dt.Columns.Add("MnfDate", typeof(DateTime));
            dt.Columns.Add("ExpDate", typeof(DateTime));
            dt.PrimaryKey = new DataColumn[] { dt.Columns["Pid"] };
            return dt;
        }
        static void Insert(DataTable dt, int id, string pn,  int price, DateTime mdate,DateTime edate)
        {
            DataRow dr = dt.NewRow();
            dr["Pid"] = id;
            dr["Pname"] = pn;
            dr["Pprice"] = price;
            dr["MnfDate"] = mdate;
            dr["ExpDate"] = edate;
            dt.Rows.Add(dr);
            Console.WriteLine($"record inserted for id:{id}");
        }
        static void Search(DataTable dt, int id)
        {
            DataRow foundRow = dt.Rows.Find(id);
            if (foundRow == null)
            {
                Console.WriteLine("no such id exists");
            }
            else
            {
                Console.WriteLine("Record found details as follows");
                Console.WriteLine($"ID:\t {foundRow["Pid"]}");
                Console.WriteLine($"First Name:\t {foundRow["Pname"]}");
                Console.WriteLine($"Last Name:\t {foundRow["Pprice"]}");
                Console.WriteLine($"Salary:\t {foundRow["MnfDate"]}");
                Console.WriteLine($"DOJ:\t {foundRow["ExpDate"]}");
            }
        }
        static void Delete(DataTable dt, int id)
        {
            DataRow delRow = dt.Rows.Find(id);
            if (delRow == null)
            {
                Console.WriteLine("no such id exists");
            }
            else
            {
                dt.Rows.Remove(delRow);
                Console.WriteLine($"Record Deleted from table");
            }
        }
        static void Update(DataTable dt, int id, string pn, int price, DateTime mdate, DateTime edate)
        {
            DataRow updaterow = dt.Rows.Find(id);
            if (updaterow != null)
            {
                updaterow["Pname"] = pn;
                updaterow["Pprice"] = price;
                updaterow["MnfDate"] = mdate;
                updaterow["ExpDate"] = edate;
            }
            else
            {
                Console.WriteLine("no such id exists");
            }

        }

        static void Display(DataTable dt)
        {
            Console.WriteLine("stored current data");
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine("ID:\t" + row["Pid"]);
                Console.WriteLine("Pnmae:\t" + row["Pname"]);
                Console.WriteLine("Pprice:\t" + row["Pprice"]);
                Console.WriteLine("MnfDate:\t" + row["MnfDate"]);
                Console.WriteLine("ExpDate:\t" + row["ExpDate"]);
            }
        }
        static void Main(string[] args)
        {
            DataTable dt = create();
            Insert(dt, 1, "Laptop", 50000, new DateTime(day: 26, month: 02, year: 2019), new DateTime(day: 02, month: 02, year: 2059));
            Insert(dt, 2, "Mobile", 60000, new DateTime(day: 05, month: 01, year: 2020), new DateTime(day: 10, month: 05, year: 2040));
            Insert(dt, 3, "Laptop", 30000, new DateTime(day: 28, month: 05, year: 2000), new DateTime(day: 05, month: 02, year: 2060));
            Insert(dt, 4, "Earphones", 1000, new DateTime(day: 20, month: 09, year: 2021), new DateTime(day: 30, month: 11, year: 2030));
            Insert(dt, 5, "Laptop", 5000, new DateTime(day: 30, month: 10, year: 2022), new DateTime(day: 15, month: 09, year: 2035));

            Display(dt);

            Console.WriteLine("enter id to be deleted");
            int del = int.Parse(Console.ReadLine());
            Delete(dt, del);


            Console.WriteLine("\n");
            Console.WriteLine("********after deletion***************");
            Display(dt);

            Console.WriteLine("\n");
            Console.WriteLine("enter id to be Search");
            int ser = int.Parse(Console.ReadLine());
            Search(dt, ser);


            Console.WriteLine("\n");
            Console.WriteLine("enter id to be updated");
            int id=int.Parse(Console.ReadLine());
            Console.WriteLine("enter pname");
            string pn=Console.ReadLine();
            Console.WriteLine("enter price");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("enter manf date");
            DateTime mfd=DateTime.Parse(Console.ReadLine());
            Console.WriteLine("enter exp date");
            DateTime exp = DateTime.Parse(Console.ReadLine());

            Update(dt, id, pn, price, mfd, exp);

            Console.WriteLine("\n");
            Console.WriteLine("************After update****************");
            Display(dt);





        }
    }
}
