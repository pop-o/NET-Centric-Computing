using System;

//constructor ofsuperclass cannot be called directly by onbejct of subclass
//to call constructor of siperclass, base keyword should be used
//Base keyword uses:
//1. to call superclass constructor
//2. to call overriden method(method overriding)

namespace NewFirst
{
    class Calculation
    {
        private int x;
        private int y;
        //constructor
        public Calculation()
        {
            Console.WriteLine("Default constructor of Calculation");
        }
        public Calculation(int x, int y)
        {
            this.x = x; 
            this.y = y;
        }
        public void sum()
        {
            Console.WriteLine("Sum is "+(x+y));
        }
    }
    class Solution : Calculation
    {
        private int z;
        public Solution():base()//calls default constructor of superclass
        {
            Console.WriteLine("Default Contructor of Solution");
        }
        public Solution(int z,int x,int y):base(x,y)
        {
            this.z = z;
        }
        public void Square()
        {
            Console.WriteLine("Square is " + (z * z));
        }
    }
}
