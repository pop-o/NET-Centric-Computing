using System;

namespace NewFirst
{
    class box
    {
        //instance variable: class data
        private int length;
        private int breadth;
        private int height;
        //constructor: used to initailize instance variable
        //default constructor: wihtout parameter
        public box()
        {
            length = 0;
            breadth = 0;    
            height = 0; 

        }
        //parameterized constructor: takes data
        public box(int length,int breadth,int height)
        {
            this.length = length;
            this.breadth = breadth;
            this.height = height;   

        }
        //method: used to provide some services
        //method without returing value
        public void calcArea()
        {
            int area=this.length*this.breadth*this.height;
            Console.WriteLine("area is " + area);
        }
    }
}
