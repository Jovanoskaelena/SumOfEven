using System;

namespace SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make a console application called SumOfEven. Inside it create an array of 6 integers.
            //Get numbers from the input, find and print the sum of the even numbers from the array:
            int[] numbersArray = new int[6];
            int sumNumbers = 0;
            for(int i =0; i<numbersArray.Length; i++)
            {
                Console.WriteLine("Input integers:" + (i + 1));
                numbersArray[i] = int.Parse(Console.ReadLine());
                if (numbersArray[i] % 2 == 0)
                {
                    sumNumbers += numbersArray[i];
                }
            }
            Console.WriteLine("Sum of even numbers is:" + sumNumbers);
            Console.ReadLine();
        }
    }
}
