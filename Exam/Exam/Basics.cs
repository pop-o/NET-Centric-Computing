using System;
using System.Collections.Generic;

namespace Exam
{
    class Basics
    {
        private int length;
        private int breadth;
        public int Length
        {
            get { return length; }
            set { this.length = value; }

        }

        public int Breadth
        {
            get { return breadth; }
            set { this.breadth = value; }
        }
        public void calcArea()
        {
            Console.WriteLine(this.length*this.breadth);
        }

        public void calcArea(int length)
        {
            Console.WriteLine(length *length);
        }
    }
    class twoWheeler
    {
        private int model;
        private int speed;
        public int Model
        {
            get { return model; }
            set { this.model = value; }
        }
        public int Speed
        {
            get { return speed; }
            set { this.speed = value; }
        }
    }
    class bike : twoWheeler
    {
        private int coverage;
        public int Coverage
        {
            get { return coverage; }
            set { this.coverage = value; }
        }
    }
}
