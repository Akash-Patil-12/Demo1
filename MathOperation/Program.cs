using System;

namespace MathOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("welcome");
            Add obj= new Add();
            obj.add(2,5);

            Sub subobj = new Sub();
            subobj.subtraction(10, 5);

            Mul mulobj = new Mul();
            mulobj.multiplication(10, 5);
            Console.ReadLine();

        }
    }
}
