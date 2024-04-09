using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;


namespace Exam
{
    class Database
    {
        public void createTable()
        {
            string cs = "Data Source=POEM;Initial Catalog=db_prime;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(cs);
            try
            {
                conn.Open();
                string query = "create table student(id int primary key,name varchar(50),phone varchar(50));";
                SqlCommand sc = new SqlCommand(query, conn);
                sc.ExecuteNonQuery();
                Console.WriteLine("table created");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void insertData()
        {
            string cs = "Data Source=POEM;Initial Catalog=db_prime;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(cs);
            try
            {
                conn.Open();
                string insQuery = "insert into student values(1,'Poem','123445678');";
                SqlCommand ab = new SqlCommand(insQuery, conn);
                int res = ab.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("successful");
                }

            }
            catch (Exception ex) { Console.WriteLine(ex); }

        }
        

        public void selectData()
        {
            string cs = "Data Source=POEM;Initial Catalog=db_prime;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(cs);

            try
            {
                conn.Open();
                string selQuery = "select * from student";
                SqlCommand sc = new SqlCommand(selQuery, conn);
                SqlDataReader row = sc.ExecuteReader();
                while (row.Read())
                {
                    Console.WriteLine("id is: " + row["id"]);
                    Console.WriteLine("name is: " + row["name"]);
                    Console.WriteLine("Phone is: " + row["phone"]);
                    
                }

            }
            catch (Exception ex) { Console.WriteLine(ex); };

        }

        public void insMultipleData()
        {
            string cs = "Data Source=POEM;Initial Catalog=db_prime;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(cs);

            try
            {
                conn.Open();
                string insQuery = "insert into student values(@id,@name,@phone)";
                Console.WriteLine("Enter your id:");
                string id = Console.ReadLine();
                Console.WriteLine("Enter your Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter your phone:");
                string phone = Console.ReadLine();
                SqlCommand sc = new SqlCommand(insQuery, conn);
                sc.Parameters.AddWithValue("@id", id);
                sc.Parameters.AddWithValue("@name", name);
                sc.Parameters.AddWithValue("@phone", phone);
                int res = sc.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine(res + "Data inserted");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); };
        }

        public void updateData()
        {
            string cs = "Data Source=POEM;Initial Catalog=db_prime;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(cs);
            try
            {
                conn.Open();
                string upQuery = "update student set name=@name,phone=@phone where id=@id ";
                SqlCommand sc = new SqlCommand(upQuery, conn);
                Console.WriteLine("Enter id your wnat to update data:");
                string id = Console.ReadLine();
                Console.WriteLine("Enter update name:");
                string upname = Console.ReadLine();
                Console.WriteLine("Enter Update phone:");
                string upphone = Console.ReadLine();
                sc.Parameters.AddWithValue("@id", id);
                sc.Parameters.AddWithValue("@name", upname);
                sc.Parameters.AddWithValue("@phone", upphone);
                int res = sc.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine(res + " Data updated");
                }

            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public void delData()
        {
            string cs = "Data Source=POEM;Initial Catalog=db_prime;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(cs);

            try
            {
                conn.Open();
                string delQuery = "delete from student where id=@id";
                SqlCommand sc = new SqlCommand(delQuery, conn);
                Console.WriteLine("Enter id you want to delete:");
                string delId = Console.ReadLine();
                sc.Parameters.AddWithValue("@id", delId);
                int res = sc.ExecuteNonQuery();
                if (res > 0) { Console.WriteLine(res + " Data Deleted"); }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

    }


}