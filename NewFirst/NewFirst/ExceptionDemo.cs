using System;
using System.Security.Permissions;
//Exception is any kind of error that disturb the normal flow of program. if exception occur then whole program is stopped.
//to deal with such error exception handling mechanism is required
//it contains 4 keyword
//1. try: use to surroind a code that can cause error
//2. catch: use to handle a exception thrown from try
//3. throw: use to throw own exception
//4. finally: this block is always executed whether exception occur or not

namespace NewFirst
{
    class ExceptionDemo
    {
        public void setData()
        {
            Console.WriteLine("Enter first number:");
            int x=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int y=Int32.Parse(Console.ReadLine());
            try { 
                int div = x / y;
                Console.WriteLine("div is " + div);

            }catch(DivideByZeroException d)
            {
                Console.WriteLine("cannot divide " + d);
            }catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Always executed");
            }
            Console.WriteLine("out of try catch");
        }
    }
}
