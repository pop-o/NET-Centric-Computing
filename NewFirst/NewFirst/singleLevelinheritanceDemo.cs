using System;



namespace NewFirst
{
    class Employee
    {
        private int id;
        private string name;
        private string address;
        private string department;
        //method to initialize instance variable
        public void setEmployee(int id,string name,string address,string department)
        {
            this.id = id;   
            this.name = name;
            this.address = address;
            this.department = department;
        }
        public void displayEmployee()
        {
            Console.WriteLine("Id is: " + this.id);
            Console.WriteLine("Name is: "+this.name);
            Console.WriteLine("Address is: " + this.address);
            Console.WriteLine("Department is: " + this.department);
        }
    }
    //inheriting employee by teacher
    class Teacher : Employee //teacher is subclass and employee is superclass
    {
        private string specialization;
        private string salary;
        public void setTeacher(string specialization,string salary)
        {
            this.specialization = specialization;
            this.salary = salary; 
        }
        public void displayTeacher()
        {
            Console.WriteLine("Specialization is: " + this.specialization);
            Console.WriteLine("Salary is: " + this.salary);
        }
    }
}
