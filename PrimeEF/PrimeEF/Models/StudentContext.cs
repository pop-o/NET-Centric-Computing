using Microsoft.EntityFrameworkCore;
namespace PrimeEF.Models
{
    //this context class is responsible for creating object of server(sql server) and
    //creating table (setting column of table of database)
    //this class should inherit DbContext class
    public class StudentContext:DbContext
    {
        //creating constructor that will set the object of server
        public StudentContext(DbContextOptions<StudentContext> options):base (options) {}
        //settin column of table. for this we have to use contructor of DbSet() class
        public DbSet<Student> Students { get; set; }
                  //modelclass //table name
                    //here student is model class that will set column
                    //Students is a table name

    }
}
