using System;
using System.Runtime.Serialization;
// Introduction to Arrays
namespace Intro2Arrays
{
    public class program
    {
        static void Main()
        {
            int[] favNums = new int[3]; //arrays in C# have fixed sizes
            favNums[0] = 23;
            Console.WriteLine($"array value at index 0 is {favNums[0]}");
            string[] cnames = { "Bob", "Sally", "Sue" };
            var employees = new[] { "Paul", "Rick", "Sally" }; //entries must be of same datatype
            // array containing objects of different datatypes
            object[] rndarray = { "Paul", 45, 3.14159 };
            //getting datatypes of array objects
            Console.WriteLine("random array 0 datatype :{0}", rndarray[0].GetType());
            //array size
            Console.WriteLine("array size {0}",rndarray.Length);

            // For-loops
            for(int j=0; j<rndarray.Length; j++)
            {
                Console.WriteLine("Array element at position {0} is {1}", j, rndarray[j]);
            }
            Console.WriteLine("--------------------------");
            //Multi dimensional arrays
            string[,] custnames = new string[2, 2] { {"Bob","Sally"}, 
                {"Smith","Hector"} };
            // accessing elements inside multi dimensional array
            Console.WriteLine("Array element at pos (0,0) is {0}", custnames.GetValue(0, 0));

        }
    }
}
