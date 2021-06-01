using System;
using System.Collections.Generic;
using System.Text;

namespace Scanner1
{
    public class ReservedKeywords : IRepositorySecondSevenDFA
    {
        //Yesif
        public void matchIf(string Lexeme)
        {
            int state = 1, i = 0;
            char c;
            while ((state != 10) && state != 0)
            {
                c = Lexeme[i];
                switch (state)
                {
                    case 1:
                        if (c == 'Y') state = 2;
                        else state = 0;
                        i++;
                        break;
                    case 2:
                        if (c == 'e') state = 4;
                        else state = 0;
                        i++;
                        break;
                    case 4:
                        if (c == 's') state = 6;
                        else state = 0;
                        i++;
                        break;
                    case 6:
                        if (c == 'i') state = 8;
                        else state = 0;
                        i++;
                        break;
                    case 8:
                        if (c == 'f') state = 10;
                        else state = 0;
                        i++;
                        break;
                }
            }
            if (state == 10) Console.WriteLine("Matched\tYesif");
        }

        //Otherwise
        public void matchOtherwise(string Lexeme)
        {
            int state = 1, i = 0;
            char character;
            while (state != 18 && state != 0)
            {
                character = Lexeme[i];
                switch (state)
                {
                    case 1:
                        if (character == 'O') state = 2;
                        else state = 0;
                        i++;
                        break;
                    case 2:
                        if (character == 't') state = 4;
                        else state = 0;
                        i++;
                        break;
                    case 4:
                        if (character == 'h') state = 6;
                        else state = 0;
                        i++;
                        break;
                    case 6:
                        if (character == 'e') state = 8;
                        else state = 0;
                        i++;
                        break;
                    case 8:
                        if (character == 'r') state = 10;
                        else state = 0;
                        i++;
                        break;
                    case 10:
                        if (character == 'w') state = 12;
                        else state = 0;
                        i++;
                        break;
                    case 12:
                        if (character == 'i') state = 14;
                        else state = 0;
                        i++;
                        break;
                    case 14:
                        if (character == 's') state = 16;
                        else state = 0;
                        i++;
                        break;
                    case 16:
                        if (character == 'e') state = 18;
                        else state = 0;
                        i++;
                        break;
                }
            }
            if (state == 18) Console.WriteLine("Matched\tOtherwise");
        }
    }
}
