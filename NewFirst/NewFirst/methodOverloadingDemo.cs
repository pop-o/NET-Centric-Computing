using System;


namespace NewFirst
{   
    //method overlaoding refers to two or more method having same name but different number of parameter
      class Calculations
    {
        public void calc()
        {
            Console.WriteLine("This is default");
        }
        public void calc(int x,int y) 
        {
            Console.WriteLine("Sum is " + (x + y));
        }
        //if no of parameter are also same then their data type should be different
        public void calc(double x,double y)
        {
            Console.WriteLine("Difference is: " + (x - y));
        }
        public int calc(int x,int y,int z)
        {
            return (x * y * z);
        }
        //method overrriding is used to achieve static polymorphism
        //looks like same but different work
    }
}
