
using System;
namespace oops
{
    public abstract class Employee
    {
        public virtual void LeaderName()
        {
        }
    }

    public class hrDepart : Employee
    {
        public override void LeaderName()
        {
            Console.WriteLine("Mr. jone");
        }
    }
    public class itDepart : Employee
    {
        public override void LeaderName()
        {
            Console.WriteLine("Mr. Tom");
        }
    }

    public class financeDepart : Employee
    {
        public override void LeaderName()
        {
            Console.WriteLine("Mr. Linus");
        }
    }

    class PolymorphismDemo
    {
        static void Main(string[] args)
        {
            hrDepart obj1 = new hrDepart();
            itDepart obj2 = new itDepart();
            financeDepart obj3 = new financeDepart();

            obj1.LeaderName();
            obj2.LeaderName();
            obj3.LeaderName();

            Console.ReadKey();
        }
    }
}
