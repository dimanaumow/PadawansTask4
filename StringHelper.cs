using System;

namespace PadawansTask4
{
    public class StringHelper
    {
        public static int GetVowelCount(string str)
        {
            if(str == null)
            {
                throw new ArgumentNullException(nameof(str)); 
            }

            if(str.Length == 0)
            {
                throw new ArgumentException("Input string Cannot Be Empty"); 
            }

            string vowels = "aeiou";

            int counter = 0; 
            foreach(char ch in str)
            {
                foreach(char temp in vowels)
                {
                    if(ch == temp)
                    {
                        counter++; 
                    }
                }
            }

            return counter; 
        }
    }
}
