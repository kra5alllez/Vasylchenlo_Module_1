using System;

namespace Vasylchenko_Module_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number of elements of the array : ");
            int lenght = Convert.ToInt32(Console.ReadLine());
            int min = 1;
            int max = 27;
            var array = new int[lenght];
            var counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(min, max);
                if ((array[i] % 2) == 0)
                {
                    counter += 1;
                }
            }

            var arrayOfEvenNumbers = new int[counter];
            var arrayOfOddNumbers = new int[lenght - counter];
            int counterEven = 0;
            int counterOdd = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] % 2) == 0)
                {
                    arrayOfEvenNumbers[counterEven] = array[i];
                    counterEven += 1;
                }
                else
                {
                    arrayOfOddNumbers[counterOdd] = array[i];
                    counterOdd += 1;
                }
            }

            string[] firstArrayOfLetters = DigitToString(arrayOfEvenNumbers);
            string[] secondArrayOfLetters = DigitToString(arrayOfOddNumbers);

            string[] DigitToString(int[] sinplArrey)
            {
                string[] intermediateArray = new string[sinplArrey.Length];
                string[] arreyTree = { "A", "b", "c", "D", "E", "f", "g", "H", "I", "J", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
                for (int i = 0; i < sinplArrey.Length; i++)
                {
                    var k = sinplArrey[i];
                    intermediateArray[i] = arreyTree[k - 1];
                }

                return intermediateArray;
            }

            Console.WriteLine();

            if (LargeLetters(firstArrayOfLetters) > LargeLetters(secondArrayOfLetters))
            {
                Console.WriteLine("More uppercase letters in this array : " + string.Join(" ", firstArrayOfLetters));
            }
            else if (LargeLetters(firstArrayOfLetters) < LargeLetters(secondArrayOfLetters))
            {
                Console.WriteLine("More uppercase letters in this array : " + string.Join(" ", secondArrayOfLetters));
            }
            else
            {
                Console.WriteLine("The number of uppercase characters is the same in both arrays");
            }

            int LargeLetters(string[] args)
            {
                string[] idealArray = { "A", "E", "I", "D", "H", "J" };
                int numberOfUppercase = 0;
                for (int i = 0; i < args.Length; i++)
                {
                    for (int j = 0; j < idealArray.Length; j++)
                    {
                        if (args[i] == idealArray[j])
                        {
                            numberOfUppercase += 1;
                        }
                    }
                }

                return numberOfUppercase;
            }

            Console.WriteLine("First letter array (converted from even numbers): " + string.Join(" ", firstArrayOfLetters));
            Console.WriteLine("Second letter array (converted from odd numbers): " + string.Join(" ", secondArrayOfLetters));
        }
    }
}
