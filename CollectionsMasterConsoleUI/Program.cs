using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays

            var intArray = new int[50];

            PopulaterArray(intArray);


            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[intArray.Length - 1]);


            Console.WriteLine("All Numbers Original");
            NumberPrinter(intArray);


            Console.WriteLine("-------------------");
            Console.WriteLine("All Numbers Reversed:");
            ReverseArray(intArray);


            Console.WriteLine("---------REVERSE CUSTOM------------");
            Array.Reverse(intArray);
            NumberPrinter(intArray);
            Console.WriteLine("-------------------");


            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(intArray);
            Console.WriteLine("-------------------");


            Console.WriteLine("Sorted numbers:");
            Array.Sort(intArray);
            NumberPrinter(intArray);


            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");


            var intList = new List<int>();
            NumberPrinter(intList);

            PopulaterList(intList);
            NumberPrinter(intList);
            Console.WriteLine("---------------------");


            Console.Write("What number will you search for in the number list?: ");
            NumberChecker(intList);
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.WriteLine("-------------------");


            Console.WriteLine("All Numbers:");
            NumberPrinter(intList);
            Console.WriteLine("-------------------");


            Console.WriteLine("Evens Only!!");
            OddKiller(intList);
            NumberPrinter(intList);
            Console.WriteLine("------------------");


            Console.WriteLine("Sorted Evens!!");
            intList.Sort();
            NumberPrinter(intList);
            Console.WriteLine("------------------");


            //Convert the list to an array and store that into a variable


            //Clear the list


            #endregion
        }


        //This method will populate an array with randomly generated numbers between the values of 0 and 50.
        private static void PopulaterArray(int[] numbers)
        {
            Random r = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = r.Next(0, 50);
            }
        }

        //This method will reverse the order of the specified array and then print it.
        private static void ReverseArray(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }

        //This method will take integers that are multiples of 3, set their values to 0, then print the array.
        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0) { numbers[i] = 0; }

                Console.WriteLine(numbers[i]);
            }
        }

        //This method will populate a list with randomly generated numbers between the values of 0 and 50.
        private static void PopulaterList(List<int> numberList)
        {
            Random r = new Random();

            for (int i = 0; i < 50; i++)
            {
                numberList.Add(r.Next(0, 50));
            }

        }

        //This method will check for a user's number within the given list, then print that number off if it is within the list.
        private static void NumberChecker(List<int> numberList)
        {
            while (true)
            {
                string numSearch = Console.ReadLine();
                var canParse = Int32.TryParse(numSearch, out int parsedNum);

                if (canParse)
                {
                    for (int i = 0; i < numberList.Count; i++)
                    {
                        if (parsedNum == numberList[i])
                        {
                            Console.WriteLine($"Your number, {parsedNum}, is in the list!");
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
                break;
            }
        }

        //This method will remove all odd numbers from the specified list.
        private static void OddKiller(List<int> numberList)
        {
            for (int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] % 2 == 1)
                {
                    numberList.Remove(i);
                }
            }
        }


        //---------------------------------

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