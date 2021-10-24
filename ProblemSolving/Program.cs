using System;

namespace ProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringNumbersCompare = new StringNumbersComparison();
            var res = stringNumbersCompare.GreaterStringNumber("k","0");

            Console.WriteLine(res);
        }
    }
}
