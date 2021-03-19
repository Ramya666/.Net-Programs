
using System;
namespace oops
{
        
    public class Father
    {
        public void FatherMethod()
        {
            Console.WriteLine("this property belong to Father");
        }
    }

        
    public class Child : Father
    {
        public void ChildMethod()
        {
            Console.WriteLine("this property belong to Child");
        }
    }
    class Inheritance
    {
           
        static void Main(string[] args)
        {

            Father fObj = new Father();
            fObj.FatherMethod();

              
            Child cObj = new Child();
            cObj.FatherMethod();
            cObj.ChildMethod();
        }
    }
}
