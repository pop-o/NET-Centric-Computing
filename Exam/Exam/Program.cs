using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Database d1 = new Database();
            //d1.createTable();
         
            d1.selectData();
            d1.delData();
            d1.selectData();
            
            Basics b1=new Basics();
            b1.Length = 8;
            b1.Breadth = 9;
            Console.WriteLine(b1.Length);
            Console.WriteLine(b1.Breadth);
            b1.calcArea();
            b1.calcArea(6);

            twoWheeler tw1=new twoWheeler();
            tw1.Speed = 661;
            tw1.Model = 212;
            bike r1 = new bike();
            r1.Speed = 23;
            r1.Model = 222;
            r1.Coverage = 11;


            Console.Write(r1.Model+"\n"+r1.Speed+"\n"+r1.Coverage);
            Console.WriteLine();
            Console.WriteLine(tw1.Model+"\n"+tw1.Speed);
            
            list a1 = new list();
            a1.print();
            */
            List<Teacher> t = new List<Teacher>{
    new Teacher(){Id=1},
    new Teacher(){Id=2},
    new Teacher(){Id=4 }


        };

            foreach (var v in t) {
                Console.WriteLine(v.Id);
                Console.WriteLine(v.Name);

            }
            var order = t.OrderBy(x => x.Name);
            foreach (var v in order) { Console.WriteLine(v.Id); Console.WriteLine(v.Name); }
            var even = t.Select(x => (x.Id % 2) == 0);
            foreach (var v in even) { Console.WriteLine(v); }
            int[][] arr1 = new int[2][];
            arr1[0] = new int[] { 1, 2 };
            arr1[1] = new int[] { 4444 };
            foreach (int[] v in arr1)
            { 
                foreach(var x in v)
                {
                    Console.Write(x);
                }
                Console.WriteLine();
            }


        }

    }}