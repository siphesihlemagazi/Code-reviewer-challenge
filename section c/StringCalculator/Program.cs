using System;
using System.Collections.Generic;

namespace StringCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Factorial
            Console.WriteLine("\nFActorial");
            Calculator fac = new Calculator();
            Console.WriteLine(fac.factor());

            // Prime numbers
            Console.WriteLine("\nPrime numbers");
            Calculator p = new Calculator();
            Console.WriteLine(p.CheckHighestPrime());

            // Fibonacci
            Console.WriteLine("\nFibonacci");
            Calculator f = new Calculator();
            Console.WriteLine(f.CheckHighestFibo());

            // Addition
            Console.WriteLine("\nAddition");
            Calculator a = new Calculator();
            Console.WriteLine(a.Add());

            // Multiplication
            Console.WriteLine("\nMultiplication");
            Calculator m = new Calculator();
            Console.WriteLine(m.Mult());

            // Division
            Console.WriteLine("\nDivision");
            Calculator d = new Calculator();
            Console.WriteLine(d.Div());

            // Long expression
            Console.WriteLine("\nLong Expressions");
            Calculator l = new Calculator();
            Console.WriteLine(l.LongExp());


        }
    }
}


