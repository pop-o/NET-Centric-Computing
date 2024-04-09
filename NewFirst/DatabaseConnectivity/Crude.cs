using System;
using System.Collections.Generic;
using System.Data.SqlClient; //for sql coonnection
using System.Data;
using System.Collections.Specialized;
using System.Globalization;
//to connect with ecternal data source like database, xml file
//System.SQLClient package should be import.
//to connect with database SQLConnection class is used and
//to execute the query SQLCommand class is used
//Step to connect with database and CRUDE operation
//1. import SQLClient class
//2. create connection string that contains all the necessary parameter to connect with database like server, dbname and security
//3. create object of SQLConnection class to connect with server
//4. open the connection using open() method
//5. write necessary query and handle SQLException
//6. execute query using SQLCommand object
//7. close the connection


namespace DatabaseConnectivity
{
    class Crude
    {

        public void createtable()
        {
            string cs = "Data Source=POEM;Initial Catalog=db_prime;Integrated Security=true";
                         //servername     //dbname                 //windows authentication
            //connecting with database
            SqlConnection conn = new SqlConnection(cs);
            try
            {
                conn.Open();//opening connection
                //creating table
                string tableQuery = "create table tbl_emp("+
                    "id int primary key," +
                    "name varchar(50)," +
                    "gender varchar(50)," +
                    "deparment varchar(50)," +
                    "salary varchar(50))";
               
                //excute query
                SqlCommand sc= new SqlCommand(tableQuery, conn);
                //query,connection
                sc.ExecuteNonQuery();//to execute query
                //use it for insert, update and delete
                Console.WriteLine("Table created");
                
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void insertData()
        {

            string cs = "Data Source=POEM;Initial Catalog=db_prime;Integrated Security=true";
            SqlConnection conn = new SqlConnection(cs);
            try
            {
                conn.Open();//opening connection
                
                //string insQuery = "insert into tbl_emp values(2,'Popo','Male','HR','200000')";
                //taking user input
                Console.WriteLine("ENter your id: ");
                string id=Console.ReadLine();
                Console.WriteLine("ENter your name: ");
                string name = Console.ReadLine();
                Console.WriteLine("ENter your gender: ");
                string gender = Console.ReadLine();
                Console.WriteLine("ENter your department: ");
                string department = Console.ReadLine();
                Console.WriteLine("ENter your salary: ");
                string salary = Console.ReadLine();

                string insQuery1 = "insert into tbl_emp values(@id,@name,@gender,@department,@salary)";
                //excute query
                //SqlCommand sc = new SqlCommand(insQuery, conn);
                SqlCommand sc=new SqlCommand(insQuery1, conn);
                sc.Parameters.AddWithValue("@id", id);
                sc.Parameters.AddWithValue("@name", name);
                sc.Parameters.AddWithValue("@gender", gender);
                sc.Parameters.AddWithValue("@department", department);
                sc.Parameters.AddWithValue("@salary", salary);
                //query,connection

                int res = sc.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine(res + " Data inserted");
                }
               

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void fetchData()
        {

            string cs = "Data Source=POEM;Initial Catalog=db_prime;Integrated Security=true";
            //servername     //dbname                 //windows authentication
            //connecting with database
            SqlConnection conn = new SqlConnection(cs);
            try
            {
                conn.Open();
                string disQuery = "select * from tbl_emp";
                SqlCommand sc = new SqlCommand(disQuery, conn);
                SqlDataReader row=sc.ExecuteReader();//return object of SqlData
                while(row.Read())
                {
                    Console.WriteLine("id is " + row["id"]);
                    Console.WriteLine("Name is " + row["name"]);
                    Console.WriteLine("Gender is " + row["gender"]);
                    Console.WriteLine("Department is " + row["deparment"]);
                    Console.WriteLine("Salary is " + row["salary"]);
                    Console.WriteLine("-------------------------------------");
                }
            }catch(SqlException ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void updateData()
        {

            string cs = "Data Source=POEM;Initial Catalog=db_prime;Integrated Security=true";
            //servername     //dbname                 //windows authentication
            //connecting with database
            SqlConnection conn = new SqlConnection(cs);
            try
            {
                conn.Open();
                //update name, gender , departmnet and salary of employee to the value given by
                //user accoirding to id which is also given by user
                string upQuery = "update tbl_emp set name=@name,gender=@gender," +
                    "deparment=@department, salary=@salary where id=@id";
                Console.WriteLine("Enter id of employee for which you want to update: ");
                string upID=Console.ReadLine();
                Console.WriteLine("Enter updated name");
                string upName=Console.ReadLine();
                Console.WriteLine("Enter updated gender");
                string upGender = Console.ReadLine();
                Console.WriteLine("Enter updated deparment");
                string upDepartment = Console.ReadLine();
                Console.WriteLine("Enter updated salary");
                string upSalary = Console.ReadLine();

                SqlCommand sc=new SqlCommand(upQuery, conn);
                sc.Parameters.AddWithValue("@id", upID);
                sc.Parameters.AddWithValue("@name", upName);
                sc.Parameters.AddWithValue("@gender", upGender);
                sc.Parameters.AddWithValue("@department", upDepartment);
                sc.Parameters.AddWithValue("@salary", upSalary) ;
                int res=sc.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine(res + " Data Updated");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void deleteData()
        {
            string cs = "Data Source=POEM;Initial Catalog=db_prime;Integrated Security=true";
            SqlConnection conn = new SqlConnection(cs);
            try
            {
                conn.Open();
                //delete record of employee whose id is given by user
                string delQuery = "delete from tbl_emp where id=@id";
                Console.WriteLine("Enter id of employee which you want to delete:");
                string delId = Console.ReadLine();
                SqlCommand sc = new SqlCommand(delQuery, conn);
                sc.Parameters.AddWithValue("@id", delId);
                int res = sc.ExecuteNonQuery();
                if(res > 0)
                {
                    Console.WriteLine(res+" Record Deleted");
                }
            }catch(SqlException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
