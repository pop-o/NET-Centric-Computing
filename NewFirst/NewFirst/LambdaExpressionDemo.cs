using System;
using System.Collections.Generic;
using System.Linq;
//lamda expression is like a anonymous function except that it doesnt have data type.
//it uses = symbol which has two part
//left side of sysmbol is inpout and right side of symbol is expression or statement
//symbol => expression or statement
namespace NewFirst
{
    class LambdaExpressionDemo
    {
        public void setExpression()
        {
            List<int> num1 = new List<int>() { 30, 40, 50, 60, 13 };
            //using lambda expression find out
            //whether the number is even or not
            var result=num1.Select(x => (x%2)==0);
            foreach(var res in result)
            {
                Console.WriteLine(res);
            }
            List<int> l2 = num1.FindAll(x=>x%2==0);
            foreach (var res1 in result)
            {
                Console.WriteLine(res1);
            }


        }
    }
    class Employees
    {
        private int id;
        private string name;
        private string department;

        public int Id { 
            get { return id; }
            set { id = value; }
        }
        public string Name { 
            get { return name; }
            set { name = value; }
        }

        public string Department { 
            get { return department; } 
            set { department = value; }
        }
    }
}
