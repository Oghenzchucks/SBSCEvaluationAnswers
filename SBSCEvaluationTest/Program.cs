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
            string string1 = "1-2-2-4-5";

            // Split string on hyphens (this will separate all the numbers).
            string[] words = string1.Split('-');

            // Loop over result array and print it
            foreach (string word in words)
            {
                Console.WriteLine("WORD: " + word);
            }


            // Calculates the difference between first and the next
            int k;

            for (int i = 0; i < words.Length; i++)
            {
                int.Parse(words[i]);

                if (i > 0 - 1 && i < words.Length - 1)
                {
                    k = int.Parse(words[i + 1]) - int.Parse(words[i]);
                    Console.WriteLine("Difference: " + k);
                }

            }

            #endregion

            #region Question 2


            #endregion


            #region Question 3
            // Input string.
            string string3 = "occurrence";
            char ch1 = 'o';
            char ch2 = 'c';
            char ch3 = 'u';
            char ch4 = 'r';
            char ch5 = 'e';
            char ch6 = 'n';

            int freq1 = string3.Count(f => (f == ch1));
            int freq2 = string3.Count(f => (f == ch2));
            int freq3 = string3.Count(f => (f == ch3));
            int freq4 = string3.Count(f => (f == ch4));
            int freq5 = string3.Count(f => (f == ch5));
            int freq6 = string3.Count(f => (f == ch6));

            Console.WriteLine(ch1.ToString() + freq1 + ch2.ToString() + freq2 + ch3.ToString() + freq3 + ch4.ToString() + freq4 + ch5.ToString() + freq5 + ch6.ToString() + freq6);


            #endregion


        }
    }
}
