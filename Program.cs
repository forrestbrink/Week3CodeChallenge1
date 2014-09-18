using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //call the findNPrimes function using 10001
            FindNPrimes(10001);
            //call the fibonnaci function 
            EvenFibonnaciSequencer(440);
            //call our longest collatz function
            LongestCollatzSequence();
            //keep the window open
            Console.ReadKey();
        }
        static void FindNPrimes(int maxPrime)
        {
            //createe a new list primeNumbers
            List<int> primeNumbers = new List<int>() { 2 };
            int j = 3;
            //loop running from 2 to the maxPrime
            while (primeNumbers.Count < maxPrime)
            {
                bool isPrime = true;
                //take out numbers that are not prime
                for (int i = 2 - 1; i < j; i++)
                {
                    //if the number is divisible by two
                    if (j % i == 0)
                    {
                        //it is not prime
                        isPrime = false;
                        break;
                    }
                    //if number is prime
                    if (isPrime == true)
                    {
                        //add it to our list
                        primeNumbers.Add(j);
                    }
                    j++;
                }
                //print to the console
                Console.WriteLine("Prime number is " + primeNumbers.Last());
            }
        }
        static void EvenFibonnaciSequencer(int maxValue)
        {
            List<int> fibonnacis = new List<int>()
            {
                1,
                2
            };
            //create variables u, v and evenNumbers
            int evenNumbers = 0;
            int u = 0;
            int v = 0;
            //loop through the fibonnaci list until it reaches the max value
            while (fibonnacis.Last() < maxValue)
            {
                v = fibonnacis[u] + fibonnacis[u + 1];
                fibonnacis.Add(v);
                //add
                u++;
                if (fibonnacis[u] % 2 == 0)
                {
                    evenNumbers += fibonnacis[u];
                }
            }
            //print the even numbers to the console
            Console.WriteLine(evenNumbers);
        }
        static void LongestCollatzSequence()
        {
            //declare our variables
            List<int> longestCollatz = new List<int>();
           List<int> theCollatz = new List<int>();
            int number;
            //loop through until we reach a million
            for (int i = 0; i < 1000000; i++)
            {
                number = i;
                while (number > 1)
                {
                    //if the number is divisible by 2
                    if (number % 2 == 0)
                    {
                        number = number / 2;
                    }
                        //if not
                    else
                    {
                        number = (number * 3) + 1;
                    }
                    theCollatz.Add(number);
                }
                if (theCollatz.Count() > longestCollatz.Count())
                {
                    longestCollatz = theCollatz;
                }

            }
        }
    }
}
