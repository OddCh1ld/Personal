using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * An array is a type of data structure that stores elements of the same type in a contiguous block of memory. In an array, , of size , each memory location has some unique index,  (where ), that can be referenced as  (you may also see it written as ).

Given an array, , of  integers, print each element in reverse order as a single line of space-separated integers.

Note: If you've already solved our C++ domain's Arrays Introduction challenge, you may want to skip this.

Input Format

The first line contains an integer,  (the number of integers in ). 
The second line contains  space-separated integers describing .

Constraints

Output Format

Print all  integers in  in reverse order as a single line of space-separated integers.

Sample Input

4
1 4 3 2
Sample Output

2 3 4 1
 * 
 * 
 * 
 */
namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            string totalStrings = Console.ReadLine(); // first input is number of elements stored
            string inputStrings = Console.ReadLine(); // second is are numbers stored as elements

            // Act
            int totalInt = int.Parse(totalStrings);
            int[] inputArray = new int[totalInt];

            #region commented out code
            /*
             * Example of arrays
             * string[] stringArray = new string[100];
             * double[] doubleArray = new double[40];
             * decimal[] decimalArray = new decimal[19];
             * public class foo { public bool AreYouAFool { get; set;} } 
             * foo[] foos = new foo[1];
             */

            // Fill inn our array
            // 1 4 3 2

            // FIRST ATTEMPT OF PARSING A STRING
            //int count = 0;
            //foreach (char letter in inputStrings)
            //{
            //    //Console.WriteLine(letter);
            //    if (letter != ' ')
            //    {
            //        int i = int.Parse(letter.ToString());
            //        inputArray[count] = i;

            //        // [BUCKET IN MEMORY] = [BUCKET VALUE] + 1
            //        count = count + 1;
            //    }
            //}
            #endregion

            // Attempt number two to parse the string :-D 
            string localStrinng = inputStrings; // We are dumping the inputString  (line 2) into a seprate string because we are going to cut it the fuck up
            // FOR LOOP
            // Declationn: i = 1
            // Exit Conditioin: The number of input strings
            // Increment / decrement: addinng 1 to i

            // inside of the loop
            // FIND THE INDEX OF The first space
            // SUbString (take the big string and reduce it down to a smaller strinng) from the 0th postionn to index
            // Parse the substring into an int
            // Add the int to the ith position of the array (we don't need a count because we already have an increment of plus 1)
            // set local string equal to the substring of the rest of the strinng (strip out the part we have already parsed into an int)

            for (int i = 0; i < totalInt; i++)
            {
                int space = localStrinng.IndexOf(' ');
                if (space != -1)
                {
                    string firstString = localStrinng.Substring(0, space);
                    inputArray[i] = int.Parse(firstString);
                    localStrinng = localStrinng.Substring(space + 1, localStrinng.Count() - (space + 1));
                }
                else
                    inputArray[i] = int.Parse(localStrinng);
                
            }

            // Taylor's example 
            string[] array = inputStrings.Split(' ');

            for (int i = inputArray.Count() - 1; i >= 0; i--)
            {
                Console.Write(inputArray[i] + " ");
            }


            // Output
            //Console.WriteLine(totalStrings);
            //Console.WriteLine(inputStrings);
            Console.ReadLine();
        }
    }
}
