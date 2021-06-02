using System;
using System.Collections.Generic;
using System.Text;

namespace Scanner1
{
    class Find : IRepositoryFindComment
    {
        int errorsNumber = 0;
        int lineNumber = 3;
        int lexemeNumber = 3;
        int index = 0;
        string code = "$dsfjjkl(";

        public void FindIdentifiers()
        {
            index++; // to skip the $
            String identifier = "";
            while (!isSpecialChar())
            {
                index++;
                identifier += code[index];
            }
            
            if (identifier == "")  // If nothing is valid after the $
            {
                lexemeNumber++;
                Console.WriteLine(lineNumber + "\t" + identifier + "\tIdentifier\t" + lexemeNumber + "\tUnmatched");
                return;
            }

            lexemeNumber++;
            Console.WriteLine(lineNumber + "\t" + identifier + "\tIdentifier\t" + lexemeNumber + "\tmatched");

            if (code[index] == ",")
                FindIdentifiers(); // Recursion
        }

        public void FindDigits(){
            index++;
            String number="";

            // while (!isSpecialChar() && isDigit())         isDigit function needs to be merged
            while (!isSpecialChar())
            {
                number+=code[index];
                index++;
            }

            lexemeNumber++;
            Console.WriteLine(lineNumber + "\t" + number + "\tConst\t" + lexemeNumber + "\tmatched");
        }
    }
}
