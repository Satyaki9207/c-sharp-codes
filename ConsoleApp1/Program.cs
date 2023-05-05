using System;
namespace ConsoleApp1
{
    public class Program1
    {
        static void Main(string[] args)
        {
            /*This is how
             you put a multiline
            comment*/

            // single line commnet
            /*bool canIvote = true;
            Console.WriteLine($"Biggest Interger possible {int.MaxValue}");
            Console.WriteLine($"Smallest Integer possible {int.MinValue}");
            Console.WriteLine("Biggest long value {0}", long.MaxValue);
            Console.WriteLine("Smallest long value {0}", long.MinValue);

            //Adding two decimal numbers
            double a1 = 3.14159;
            double a2 = 5.33578944;
            Console.WriteLine($"Sum of a1 and a2 is {a1 + a2}");

            //type conversion
            bool boolfrmstr = bool.Parse("true");
            int intfrmstring = int.Parse("30");
            double dblfrmstr=double.Parse("1.3365");
            // string from double
            string strfrmdbl=dblfrmstr.ToString();

            //getting datatype of a variable
            Console.WriteLine($"datatype of strfrmsbl is {strfrmdbl.GetType()}");

            //casting double into an integer (explicit conversion)
            double db1num = 12.42423;
            Console.WriteLine($"value after explicit conversion is {(int)db1num}");

            //output formatting
            Console.WriteLine("Currency : {0:c}",12.345);*/
            string randstring = "This is a string";
            Console.WriteLine("Length of the string : {0}",randstring.Length);

            // check if the string contains a substring
            Console.WriteLine("randstring contains is {0}", randstring.Contains("is"));

            //index of a certain string
            Console.WriteLine("Index of is {0}", randstring.IndexOf("is"));

            // Removing a certain string
            int idx1 = 10;int idx2=6;
            Console.WriteLine("String after removing indices 10 through 6 : {0}",randstring.Remove(idx1, idx2));

            //adding string at a certain location
            Console.WriteLine("adding string at index 10 : {0}", randstring.Insert(idx1, "short "));

            //Replace string within a string
            Console.WriteLine("String after replacement: {0}", randstring.Replace("string","sentence"));

            //Comparing 2 strings
            Console.WriteLine("Compare 2 strings : {0}",
                String.Compare("Plant","Tree",StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("------------------------------------");

            // string comparison 2
            Console.WriteLine("A=a :{0}",String.Equals("A","a", StringComparison.OrdinalIgnoreCase));

            //padding strings
            Console.WriteLine("pad left :{0}", randstring.PadLeft(10, '.'));

            //Trimming whitespace
            Console.WriteLine("String after trimming: {0}", randstring.Trim());

            //Changecase
            Console.WriteLine("Change to uppercase : {0}", randstring.ToUpper());

            //creating strings with the format statement
            string newstr = "{0} saw a {1} {2} eating in the {3}";
            Console.WriteLine(newstr, "Paul", "rabbit", "eating", "field"+"\n");

            // printing special characters
            Console.WriteLine("Exactly what I \"Type\"");

        }
    }
}