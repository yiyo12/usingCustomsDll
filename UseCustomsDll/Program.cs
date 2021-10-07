using System;
using MyCustomArithmeticLibrary;
namespace UseCustomsDll
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCustomArithmeticLibrary.calculate obj= new MyCustomArithmeticLibrary.calculate();
            var resultSuma = obj.sum(3, 5);
            Console.WriteLine(resultSuma);
        }
    }
}
