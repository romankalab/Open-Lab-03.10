using System;
using System.Linq;

namespace Open_Lab_03._10
{
    public class Checker
    {
        public int GetNumberOfCharsInString(char letter, string str)
        {
           int result = str.Count(x => x == letter);
            return result;
        }
    }
}
