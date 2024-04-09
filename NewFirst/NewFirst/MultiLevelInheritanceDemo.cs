using System;
//here one class is inherited ny second class and such second intruns get inherited by third class

namespace NewFirst
{
    class TwoWheeler
    {
        private int reg;
        private string name;
        private string model;
        //properties
        public int Reg
        {
            get { return reg; }
            set { reg = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Model
        {
            get { return model; }       
            set { model = value; }  
        }
    }
    //second class that will inherit twowheeler
    class Bike : TwoWheeler
    {
        private string speed;
        public string Speed
        {
            get { return speed; }
            set { speed = value; }
        }
    }
    //third class that will inherit bike. this class can access both properties of twowheeler and bike
    class ElectricBike : Bike
    {
        private string range;
        public string Range
        {
            get { return range; }   
            set { range = value; }
        }
    }
}
