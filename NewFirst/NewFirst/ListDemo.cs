using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;//for list need to import
//list stores collection of similar data. it uses generics so it can aaccpet any type including object
//to use list <> symbol have to be used which indicates which type does list support

namespace NewFirst
{
    class ListDemo
    {
        public void seList()
        {
            List<int> l1 = new List<int> { 2, 4, 3, 1, 5, 6, 7, 8, 9 };
            //using predetermined method
            List<string> l2 = new List<string>();
            l2.Add("apple");
            l2.Add("banana");
            l2.Add("casper");
            //foreach loop to display element
            foreach(var v in l1)
            {
                Console.WriteLine(v);
            }

            //checking whether given character are present or not
            var res=l2.Contains("apple");
            Console.WriteLine(res);

            //lambda expression: arrow function which doesnt have any type
            var res1 =l1.FindAll(x => (x % 2) == 0);
            foreach(var v in res1)
            {
                Console.WriteLine(v);
            }
            //finding out cube of each element using lambda expression
            var res2 = l1.Select(x => (x * x * x));
            foreach(var v in res2)
            {
                Console.WriteLine(v);
            }

            
        }
    }

    //list and lambda expression in user defined class
    class Teachers
    {
        private int tid;
        private string tname;
        private string department;

        public int Tid
        {
            get { return tid; }
            set { tid = value; }
        }
        public string Tname
        {
            get { return tname; }
            set { tname = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }
    }
}
