using System;
using System.Runtime.Serialization;
// Introduction to Arrays
namespace Intro2Arrays
{
    public class program

    {   //-----------------FUNCTIONS---------------------
        static void printArray(int[] arr,string msg)
            //Function to cycle through the array and print elements
        {
            foreach(int k in arr)
            {
                Console.WriteLine("{0}:{1}", msg, k);
            }
        }
        //-------------END OF FUNCTIONS------------------


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

            //creating 3-d array
            Console.WriteLine();
            int[] randNums = { 1, 4, 2, 9, 6 };
            printArray(randNums, "forEach");

            //Sorting Arrays
            Array.Sort(randNums);
            Array.Reverse(randNums);
            Console.WriteLine("1 at index: {0}",Array.IndexOf(randNums,1));

            //changing value of elements in an array
            randNums.SetValue(0, 1);
            int[] srcArray = { 1, 2, 3 };
            int[] destArray = new int[2];
            Console.WriteLine();
            int start_idx=0, length=2;
            Array.Copy(srcArray, start_idx,destArray,0,length);
            printArray(destArray, "Copy");

            


        }
    }
}
