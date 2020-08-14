using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProblems
{
    class Program
    {




        static void Main(string[] args)
        {
            Console.WriteLine(SumSquareDifference());
            Console.ReadLine();

        }

        static void EvenFebonacci()
        {
            int getal1 = 0;
            int getal2 = 1;
            int totaal = 0;

            while (getal2 < 4000000)
            {
                int temp = getal2;

                getal2 += getal1;
                getal1 = temp;

                Console.WriteLine(getal2);
                if (getal2 % 2 == 0)
                {
                    totaal += getal2;
                }


            }

            Console.WriteLine("totaal: {0}", totaal);
        } // Problem 2: sum of the even febonacci-numbers < 4.000.000
        static void LargestPalindrome()
        {
            int product = 0;
            int highest = 0;

            for (int getal = 999; getal > 100 ; getal--)
            {
                for (int i = 999; i > 100; i--)
                {
                    product = getal * i;

                    string strProduct = product.ToString();
                    if (strProduct[0] == strProduct[strProduct.Length - 1] && strProduct[1] == strProduct[strProduct.Length - 2] && strProduct[2] == strProduct[strProduct.Length - 3])
                    {
                        if (product > highest)
                        {
                            highest = product;
                            Console.WriteLine("found: " + product);

                        }
                    }
                }

            }



        } // Problem 4: largest palindrome by 2 3-digit numbers
        static void SmallestMultiple()
        {
            bool isSmallest = false;

            for (int counter = 100; counter < 900000000; counter++)
            {
                for (int divider = 2; divider <= 20; divider++)
                {
                    if (counter % divider != 0)
                    {
                        break;
                    }
                    if (divider == 20)
                    {
                        Console.WriteLine("found one");
                        isSmallest = true;
                    }

                }

                if (isSmallest)
                {
                    Console.WriteLine(counter);

                    break;
                }
            }

        } // Problem 5: smallest multiple of the numbers 1-20
        static int SumSquareDifference()
        {
            double sum = 0;
            double square = 0;
            int total = 0;

            for (int i = 1; i < 101; i++)
            {
                sum += Math.Pow(i,2);
            }

            for (int i = 1; i < 101; i++)
            {
                total += i;
                square = Math.Pow(total,2);
            }

            return (int)square - (int)sum;
        } // Problem 6: difference between sum of squares and squares of sum
    }
}
