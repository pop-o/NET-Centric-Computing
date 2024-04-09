using System;
using System.Collections.Generic;//for list
using System.Linq;


namespace NewFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating object of box
            //when object is created constuctor is called
            box b1 = new box();//deafult constructor
            b1.calcArea();
            box b2= new box(34,29,23); 
            b2.calcArea();
            Console.WriteLine("\n---example on properties---");
            Rectangle r1 = new Rectangle();
            //calling set of length and breadth
            r1.Length = 10;//calls set of length
            r1.Breadth = 20;//calls set of breadth
            //calling get of length and breadth;
            Console.WriteLine("length is " + r1.Length);
            Console.WriteLine("breadth is " + r1.Breadth);
            int area = r1.Length * r1.Breadth;
            Console.WriteLine("area is " + area);

            Console.WriteLine("\n-----Example on method overloading-------");
            Calculations c1=new Calculations();
            //calling first method
            c1.calc();
            //calling second method
            c1.calc(12, 42);
            //calling third method
            c1.calc(123.231, 24.21);
            //calling fourth method
            int mul = c1.calc(12, 41, 11);
            Console.WriteLine("Multiplication is:" + mul);
            Console.WriteLine("-------Example on Single Level Inheirtance------");
            //creating object of sub class
            Teacher t1 = new Teacher();
            //using parent properties
            t1.setEmployee(1, "Poem", "ktm", "CSIT");
            t1.displayEmployee();
            //using own properties
            t1.setTeacher("Networking", "99999");
            t1.displayTeacher();
            
            //creating object of parent class(super class)
            Employee e1= new Employee();
            e1.setEmployee(2, "popo", "JPN", "IT");
            e1.displayEmployee();
            //e1.setTeacher("admin","232322"); cannot access methods of child class


            Console.WriteLine("");
            Console.WriteLine("-----example on multilevel inheritance-------");
            //creating object of grandchild (ElectricBike)
            ElectricBike eb= new ElectricBike();
            //using grandparent  (twowheeler)
            eb.Reg = 101;
            eb.Name = "niu";
            eb.Model = "new";
            //using parent property (bike)
            eb.Speed = "40";
            //using own property
            eb.Range = "50";
            Console.WriteLine("reg is "+eb.Reg);
            Console.WriteLine("name is " + eb.Name);
            Console.WriteLine("model is " + eb.Model);
            Console.WriteLine("speed is "+eb.Speed);
            Console.WriteLine("range is " + eb.Range);

            //creating object of Bike
            Bike bi = new Bike();
            //using two wheelet property
            bi.Reg = 102;
            bi.Name = "pulsar";
            bi.Model = "old";
            bi.Speed = "200";//using own property
            //bi.range = "40";//cannot accesss child property
            Console.WriteLine("\nReg of bike is "+bi.Reg);
            Console.WriteLine("name of bike is" + bi.Name);
            Console.WriteLine("Model of bike is" + bi.Model);
            Console.WriteLine("Speed of bike is" + bi.Speed);
            Console.WriteLine("");
            Console.WriteLine("------example of base keyword---------");
            Solution s1= new Solution();
            Solution s2= new Solution(5,6,7);
            s2.sum();
            s2.Square();

            Console.WriteLine("------example on method overriding------");
            Soln sol1=new Soln();
            sol1.calc1();
            sol1.calc2(234, 42);

            Console.WriteLine("------Example on exception demo------------");
            ExceptionDemo ed=new ExceptionDemo();
            ed.setData();


            Console.WriteLine("---------Example on custom exception demo-----------");
            CustomExceptionDemo ce=new CustomExceptionDemo();
            try { 
                ce.setAge(77);
            }catch(AgeException a)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("----------Example on file demo--------------");
            FileReadWriteDemo fd= new FileReadWriteDemo();
            fd.writeFile();
            Console.WriteLine("\nRead content");
            fd.readFile();



            Console.WriteLine("-------------Example on Array demo------------");
            ArrayDemo ad=new ArrayDemo();
            ad.setArray();

            Console.WriteLine("-------------Lambda Expression demo----------------");
            LambdaExpressionDemo l1=new LambdaExpressionDemo();
            l1.setExpression();

            //creating list of object and arranging in ascending
            //order by name
            List<Employees> em = new List<Employees>()
            {
                new Employees() {Id=1,Name="Popo",Department="IT"},
                new Employees() {Id=2,Name="Poem",Department="mgmt"},
                new Employees() {Id=3,Name="opop",Department="IT"},
            };
            var so1=em.OrderBy(x=> x.Name);
            foreach(var e in so1)
            {
                Console.WriteLine("Id is " + e.Id + " Name is " + e.Name);
            }

            Console.WriteLine("");
            Console.WriteLine("---------example on list demo------------");
            ListDemo ld1=new ListDemo();
            ld1.seList();
            //for second part
            //creating 5 objects of teachers class using list
            List<Teachers> lt1 = new List<Teachers>()
            {
                new Teachers(){Tid=1,Tname="Poem",Department="IT"},
                new Teachers(){Tid=2,Tname="Popo",Department="Finance"},
                new Teachers(){Tid=3,Tname="Yato",Department="IT"},
                new Teachers(){Tid=4,Tname="Bishamon",Department="HR"},
                new Teachers(){Tid=5,Tname = "Yuji",Department="Marketing"},
            };

            foreach(var v in lt1)
            {
                Console.WriteLine("Id is: "+v.Tid);
                Console.WriteLine("Name is: " + v.Tname);
                Console.WriteLine("Department is: " + v.Department);
            }

            Console.WriteLine("");
            Console.WriteLine("----------Exam question-----------");
            //using lambda to sort object and display
            var sort1= lt1.OrderBy(x => x.Tname);
            foreach(var v1 in sort1)
            {
                Console.WriteLine("Id is: " + v1.Tid);
                Console.WriteLine("Name is: " + v1.Tname);
                Console.WriteLine("Department is: " + v1.Department);
            }
            Console.ReadKey();//to hold screen
        }
    }
}
