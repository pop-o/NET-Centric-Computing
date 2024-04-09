using System;
using System.Collections.Generic;

namespace DatabaseConnectivity
{
    class Program
    {
        static void Main(string[] args)
        {
            Crude i1 = new Crude();
            //i1.createtable();
            //i1.insertData();
            i1.fetchData();
            //i1.updateData();
            i1.deleteData();

            i1.fetchData();
            Console.ReadKey();
        }
    }
}
