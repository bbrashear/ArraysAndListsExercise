using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:
            //Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well 
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            // Create an integer Array of size 50

            int[] numbers = new int[50];


            //Create a method to populate the number array with 50 random numbers that are between 0 and 50

            Populater(numbers);
            Console.WriteLine(string.Join(" ", numbers));
            Console.ReadLine();

            //Print the first number of the array

            Console.WriteLine(numbers[0]);
            Console.ReadLine();

            ////Print the last number of the array

            Console.WriteLine(numbers[49]);
            Console.ReadLine();

            ////Use this method to print out your numbers from arrays or lists

            NumberPrinter(numbers);
            Console.ReadLine();

            ////Reverse the contents of the array and then print the array out to the console.
            ////Try for 2 different ways
            ///*     Hint: Array._____(); Create a custom method     */

            ReverseArray(numbers);
            Console.ReadLine();

            ////Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers

            ThreeKiller(numbers);
            Console.WriteLine(string.Join(" ", numbers));
            Console.ReadLine();

            ////Sort the array in order now            

            Array.Sort(numbers);
            Console.WriteLine(string.Join(" ", numbers));
            Console.ReadLine();

            //Console.WriteLine("\n************End Arrays*************** \n");
            //#endregion

            //#region Lists
            //Console.WriteLine("************Start Lists**************");

            ///*   Set Up   */
            ////Create an integer List

            var numberList = new List<int>();

            ////Print the capacity of the list to the console

            Console.WriteLine(numberList.Capacity);
            Console.ReadLine();

            ////Populate the List with 50 random numbers between 0 and 50 you will need a method for this   

            Populater(numberList);

            ////Print the new capacity

            Console.WriteLine(numberList.Capacity);
            Console.ReadLine();

            ////Create a method that prints if a user number is present in the list

            Console.WriteLine("What number would you like to check to see if its in the list?");
            int searchNumber = int.Parse(Console.ReadLine());
            string response = NumberChecker(numberList, searchNumber);
            Console.WriteLine(response);
            Console.ReadLine();

            ////Print all numbers in the list

            NumberPrinter(numberList);
            Console.ReadLine();

            ////Create a method that will remove all odd numbers from the list then print results

            OddKiller(numberList);
            Console.WriteLine(string.Join(" ", numberList));
            Console.ReadLine();

            ////Sort the list then print results

            numberList.Sort();
            Console.WriteLine(string.Join(" ", numberList));
            Console.ReadLine();

            ////Convert the list to an array and store that into a variable

            int[] numberListArray = numberList.ToArray();
            Console.ReadLine();

            ////Clear the list

            numberList.Clear();

            #endregion
        }

        private static int[] ThreeKiller(int[] numbers)
        {

            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }

            return numbers;
        }

        private static List<int> OddKiller(List<int> numberList)
        {

                for (int i = 0; i < numberList.Count; i++)
                {
                    if (numberList[i] % 2 != 0)
                    {
                        numberList.Remove(numberList[i]);
                    }
                }

            return numberList;
        }

        private static string NumberChecker(List<int> numberList, int searchNumber)
        {
            if(numberList.Contains(searchNumber))
            {
                return $"{searchNumber}";
            }
            else
            {
                return "The number is not in the list.";
            }

        }

        private static List<int> Populater(List<int> numberList)
        {
            Random rng = new Random();
            for(int i = 0; i < 50; i++)
            {
                int a = rng.Next(51);
                numberList.Add(a);
            }

            return numberList;
        }

        private static int[] Populater(int[] numbers)
        {
            Random rng = new Random();
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(51);
            }

            return numbers;
        }       

        private static int[] ReverseArray(int[] array)
        {
            Array.Reverse(array);

            foreach(int value in array)
            {
                Console.WriteLine(value);
            }

            return array;
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
