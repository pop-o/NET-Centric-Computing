namespace PrimeEF.Models
{
    //Entity framework act as bridge to cinnect with external data source
    //like sql server when using asp.net core or MVC application. it uses object relational mapper
    //which means all the operation of database are done by create class and object like table, db
    //, tables,column, CRUDE operation
    //to use entity framework two packages needs to be downloaded
    //EntityFrameworkCore.SqlServer and EntityFramewrkCore.Tools
    public class Student
    {
        //using this class, column of table and table's name will be created
        public Guid Id {  get; set; }//auto id generation with primary key

        public string Name { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }

        public string Faculty { get; set; }

       
    }
}
