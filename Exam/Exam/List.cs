using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam
{
    class list
    {
        public void print()
        {
            List<int> l1 = new List<int>();
            List<int> l2 = new List<int> { 1, 2, 3, 4 };
            l1.Add(12);
            l1.Add(34);
            l2.Add(213);
            foreach (var v in l1)
            {
                Console.WriteLine(v);
            }
            for (var v = 0; v < l1.Count(); v++)
            {
                Console.WriteLine(l1[v]);

            }
            foreach (var x in l2) { Console.WriteLine(x); }
        }
    }
        class Teacher
        {
            private int id;
            private string name;
            public int Id
            {
                get { return id; }
                set { this.id = value; }
            }
            public string Name
            {
                get { return name; }
                set { this.name = value; }
            }


        }


    }



