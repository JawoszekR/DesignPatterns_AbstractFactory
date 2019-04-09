using DesignPatterns_AbstractFactory.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory fac = new Factory1();
            ClassA A;
            ClassB B;

            A = fac.GetClassA();
            B = fac.GetClassB();
            Console.WriteLine(A.Name);
            Console.WriteLine(B.Name);
            fac = new Factory2();
            A = fac.GetClassA();
            B = fac.GetClassB();
            Console.WriteLine(A.Name);
            Console.WriteLine(B.Name);
            Console.ReadKey();
        }
    }
}
