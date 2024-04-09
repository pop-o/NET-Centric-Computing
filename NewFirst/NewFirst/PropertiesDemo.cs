using System;


namespace NewFirst
{
    class Rectangle
    {
        //properties is used to initialize instance variable
        //and return value of instance vairable
        //it is same like getter and setter method
        //set is used to initialize instance vairable and 
        //get is used to return value of instance vairable
        private int length;
        private int breadth;
        //using properties
        public int Length
        {
            get { return length; }
            set { this.length = value; }
        }
        public int Breadth
        {
            get { return breadth; }
            set { breadth = value; }
        }
    }
}