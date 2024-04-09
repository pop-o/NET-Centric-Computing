using System;
using System.Collections.Generic;
using System.Linq;


namespace ClassWork
{
    class Program
    {
        static void Main(string[] args) { 
        List<Employee> employees = new List<Employee>()
        {
            new Employee(){Id = 1,Name="Poem"},
            new Employee(){Id=2,Name="Popo"},
            new Employee(){Id = 3,Name="Yato"},
            new Employee(){Id=4,Name="Yuji"},
            new Employee(){Id = 5,Name="Gojo"},
            new Employee(){Id=6,Name="Shiro"},
            new Employee(){Id = 7,Name="Yuta"},
            new Employee(){Id=8,Name="Jogo"},
            new Employee(){Id = 9,Name="Ran"},
            new Employee(){Id=10,Name="Yuki"},
        };

        var res = employees.OrderBy(x => x.Name);
        foreach(var v in res)
            {
                Console.WriteLine("Id is: "+v.Id);
                Console.WriteLine("Name is: "+v.Name);
            }

            var res1 = employees.Select(x => (x.Id%2==0));
            foreach(var v in res1)
            {
                Console.WriteLine(v);
            }
            var res2 = employees.Where(x => (x.Name.Length %2==0));
            foreach (var v in res2)
            {
                Console.WriteLine("Id is: " + v.Id);
                Console.WriteLine("Name is: " + v.Name);
            }

        }
    }
}
