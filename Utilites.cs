using System;
using System.Collections.Generic;
using System.Text;

namespace Scanner1
{
    class Utilites
    {
        public int GetLength(string code)
        {
            int counter = 0;
            foreach (var c in code)
            {
                counter++;
            }
            return counter;
        }
        public string GetSlice(string code , int startIndex,int endIndex)
        {
            string result = "";
            for (int i = startIndex; i < endIndex; i++)
            {
                result += code[i];
            }
            return result; 
        }
        
    }
}
