using System;

//to create own kind of exception:
//1. create a error class by inheriting superclass Exception and call the constructor with error messsage
//2. use throw keyword to throw particular exception
namespace NewFirst
{
    class AgeException : Exception
    {
        public AgeException(string msg):base(msg)
        {
            
        }

    }
    class CustomExceptionDemo
    {
        public void setAge(int age)
        {
            if (age < 16)
            {
                throw new AgeException("age should be greater than 16");
            }
            else
            {
                Console.WriteLine("Welcome");
            }
        }
    }
}
