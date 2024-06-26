using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Prac
{
    class demo
    {
        public void createTable()
        {
            string cs = "Data Source=POEM;Initial Catalog=db_prime;Integrated Security=true";
            SqlConnection conn = new SqlConnection(cs);
            try
            {
                conn.Open();
                string tQ = "Create table hello(id int primary key,name varchar(50)";
                SqlCommand sc = new SqlCommand(tQ, conn);
                sc.ExecuteNonQuery();
                Console.WriteLine("Created");

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void insertData()
        {
            string cs = "Data Source=POEM;Initial Catalog=db_prime;Intergrated Security=true";
            SqlConnection conn = new SqlConnection(cs);

            try
            {
                conn.Open();
                Console.WriteLine("Enter id");
                string id = Console.ReadLine();
                Console.WriteLine("Enter name");
                string name = Console.ReadLine();
                string insQ = "insert into tab_emp values(@id,@name)";
                SqlCommand sc = new SqlCommand(insQ, conn);
                sc.Parameters.AddWithValue("@id", id);
                sc.Parameters.AddWithValue("@name", name);
                int res = sc.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("data inseteed Succes");
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        public void Display()
        {
            string cs = "Data Source=POEM;INitail Catalog=db;Integraterd Secuiryt=ture";
            SqlConnection conn = new SqlConnection(cs);
            try
            {
                conn.Open();
                string dquery = "select* from tablename";
                SqlCommand sc = new SqlCommand(dquery, conn);
                SqlDataReader row=sc.ExecuteReader();
                while (row.Read())
                {
                    Console.Write(row["id"]);
                }
            }catch(Exception ex){
                Console.WriteLine(ex);
            }
        }
    }
}
