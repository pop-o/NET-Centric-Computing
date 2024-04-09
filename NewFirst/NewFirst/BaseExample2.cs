using System;
//method overriding : if suoerclass and subclass have same method(same name,same return type and same parameter)
//to call overriden method of superclasss from subclass keyword is used
//for method overiding two keyword are used
//virtual: represent overriden method in superclass
//override: represent overriden method in sub class
//important from Exam point of view
//also called dynamic polymorphism
namespace NewFirst
{
    class Calc
    {
        public virtual void calc1()
        {
            Console.WriteLine("default method of calc");
        }
        public virtual void calc2(int x,int y)
        {
            Console.WriteLine("sum is "+(x+y));
        }
    }

    class Soln:Calc
    {
        public override void calc1()
        {
            base.calc1();
            Console.WriteLine("default method of subclass Soln");
        }
        public override void calc2(int x, int y)
        {
            base.calc2(x, y);
            Console.WriteLine("diff is "+(x-y));
        }
    }
}
