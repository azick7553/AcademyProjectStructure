using System;
using AnotherNamespace;
namespace Program
{
    class Program1
    {
        static void Main()
        {
            int[] inputArr = { 2, 3, 4, 5 };
            // ShowElementsOfArray(inputArr);
            // ShowElementsOfArray(new int[] { 3, 5, 6, 7, });

            ShowElementsOfArray("2", 3, 4, 5, 6, 7, 8);
            Person p1 = new Person();
        }

        static void ShowElementsOfArray(string x, params int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.WriteLine(arr[i]);
            }
        }
    }
}