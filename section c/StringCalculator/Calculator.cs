using System;
using System.Collections.Generic;
using System.Text;

namespace StringCalculator
{
    class Calculator
    {
        public double factor( )
        {
            Console.WriteLine("Enter number to factorize: ");
            int num = int.Parse(Console.ReadLine());

            int results = 1;
            while (num != 1)
            {
                results = results * num;
                num = num - 1;
            }
            return results;
        }

        public string CheckHighestPrime()
        {
            List<int> prime_list = new List<int>();
            bool is_prime = true;
            Console.WriteLine("Enter numbers to check (highest prime no.) : ");
            string r = "There is none";
            int num_to_check = int.Parse(Console.ReadLine());

            for (int i = 2; i <= num_to_check; i++)
            {
                for (int j = 2; j <= num_to_check; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        is_prime = false;
                        break;
                    }
                }

                if (is_prime)
                {
                    prime_list.Add(i);
                }
                is_prime = true;

                if (prime_list.Count != 1)
                {
                    if(prime_list[prime_list.Count - 1] == num_to_check)
                    {
                        r = $"The highest prime number under {num_to_check} is: {prime_list[prime_list.Count - 2]}";
                    }
                    else
                    {
                        r = $"The highest prime number under {num_to_check} is: {prime_list[prime_list.Count - 1]}";
                    }
                }
            }
            return r;
        }

        public string CheckHighestFibo()
        {
            int val1 = 0, val2 = 1, val3, i, n;

            Console.WriteLine("Enter numbers to check (highest fibo no.) : ");
            n = int.Parse(Console.ReadLine());

            List<int> fibo_list = new List<int>();
            List<int> fibo_list2 = new List<int>();

            string r = "There is none";

            for (i = 2; i <= n; ++i)
            {
                val3 = val1 + val2;
                fibo_list.Add(val3);
                val1 = val2;
                val2 = val3;
            }
            foreach (int k in fibo_list)
            {
                if (k < n)
                {
                    fibo_list2.Add(k);
                    r = $"The highest fibonacci number under {n} is: {fibo_list2[fibo_list2.Count - 1]}";
                }
            }
            return r;
        }


        public double Add()
        {
            Console.WriteLine("Enter first number: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            double y = double.Parse(Console.ReadLine());

            double r = x + y;
            int res = (int)r;

            return res;
        }


        public double Mult()
        {
            Console.WriteLine("Enter first number: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            double y = double.Parse(Console.ReadLine());

            double r = x * y;
            int res = (int)r;

            return res;
        }


        public double Div()
        {
            Console.WriteLine("Enter first number: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            double y = double.Parse(Console.ReadLine());

            double r = x / y;
            int res = (int)r;

            return res;
        }

       public double LongExp()
        {
            int res = 0;
            List<int> nums = new List<int>();
            Console.WriteLine("Enter the volume of numbers you will calculate: ");
            int total_exp = int.Parse(Console.ReadLine());

            for (int i = 0; i < total_exp; i++)
            {
                Console.WriteLine("Enter number: ");
                int exp = int.Parse(Console.ReadLine());
                nums.Add(exp);
            }
            foreach (int j in nums)
            {
                res = res + j;
            }
            
            return res;
        }


    }
}
