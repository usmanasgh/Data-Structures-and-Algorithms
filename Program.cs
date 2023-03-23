using System;

namespace Data_Structures_and_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to arrays");

            //StaticFixedArray();

            DynamicArray();
        }

        private static void DynamicArray()
        {
            // Dynamic array of int type  
            int[] numArray = new int[] { 1, 3, 5, 7, 9, 11 };
            Console.WriteLine(numArray[0]);
            Console.WriteLine(numArray[1]);
            Console.WriteLine(numArray[2]);
            Console.WriteLine(numArray[3]);
            Console.WriteLine(numArray[4]);
            Console.WriteLine(numArray[5]);
            numArray[6] = 10; // not possible, check why
            numArray[8] = 10;
            //Console.WriteLine(numArray[5]);
            //Console.WriteLine(numArray[7]); // doesn't exist
            //Console.WriteLine(numArray[8]);
        }

        private static void StaticFixedArray()
        {
            int[] numbers = new int[5];
            numbers[0] = 1;
            numbers[1] = 3;
            numbers[2] = 5;
            numbers[3] = 7;
            numbers[4] = 9;

            //In a fixed array, if you try to add more items than its range, you will get the following error: 
            numbers[5] = 11;
        }
    }
}
