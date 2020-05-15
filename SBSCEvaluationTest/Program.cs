using System;
using System.Linq;

namespace SBSCEval
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Question 1

            // Input string.

            // Uncomment the strings below to check them both

            //string string1 = "1-2-2-4-5";
            string string1 = "3-4-5-6-7";

            // Split string on hyphens (this will separate all the numbers).
            string[] words = string1.Split('-');

            // Loop over result array and print it
            foreach (string word in words)
            {
                Console.WriteLine("WORD: " + word);
            }

            // Calculates the difference between first and the next

            int[] diff = new int[8];

            for (int i = 0; i < words.Length; i++)
            {
                int.Parse(words[i]);

                if (i > 0 - 1 && i < words.Length - 1)
                {
                    diff[i] = int.Parse(words[i + 1]) - int.Parse(words[i]);

                    Console.WriteLine("Difference: " + diff[i]);
                }
            }

            // Checks to see if all values in the array are the same.
            int a;
            for (a = 1; a < diff.Length; a++)
            {
                if (diff[0] == diff[a])
                    continue;
                else
                    break;
            }

            // Output the final result
            if (a == 4)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
                


            

            #endregion



            #region Question 2
            int[] arr1 = new int[] { 1, 4, 6, 9 };
            for(int i = 0; i < arr1.Length; i++)
            {
                if(i < arr1.Length - 1)
                {
                    int d = arr1[i + 1] - arr1[i];

                    int[] arr2 = new int[d];

                    Console.WriteLine(d);
                }
                
            }

            #endregion


            #region Question 3
            // Input string.
            string string3 = "occurrence";

            // separate all characters in string with each one occuring once
            char ch1 = 'o';
            char ch2 = 'c';
            char ch3 = 'u';
            char ch4 = 'r';
            char ch5 = 'e';
            char ch6 = 'n';

            // Counts how many times the character occurs
            int freq1 = string3.Count(f => (f == ch1));
            int freq2 = string3.Count(f => (f == ch2));
            int freq3 = string3.Count(f => (f == ch3));
            int freq4 = string3.Count(f => (f == ch4));
            int freq5 = string3.Count(f => (f == ch5));
            int freq6 = string3.Count(f => (f == ch6));

            // Prints the final results
            Console.WriteLine(ch1.ToString() + freq1 + ch2.ToString() + freq2 + ch3.ToString() + freq3 + ch4.ToString() + freq4 + ch5.ToString() + freq5 + ch6.ToString() + freq6);


            #endregion


        }
    }
}
