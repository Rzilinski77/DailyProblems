using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DailyProblems
{
    class Methods
    {
        public int addChar(string stringInput, char charInput)
        {
            char[] charArray = stringInput.ToCharArray();
            int match = 0;

            foreach (Char character in charArray)
            {
                if (character == charInput)
                {
                    match += 1;
                }
            }

            return match;
        }
    }
}
