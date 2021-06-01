using System;
using System.Collections.Generic;
using System.Text;

namespace Scanner1
{
    public class FirstSeven : IRepositorySecondSevenDFA
    {
        //Omw
        public void integerType(string Lexeme)
        {
            int state = 1, i = 0;
            char character;
            while (state != 6 && state != 0)
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
                        if (character == 'm') state = 4;
                        else state = 0;
                        i++;
                        break;
                    case 4:
                        if (character == 'w') state = 6;
                        else state = 0;
                        i++;
                        break;
                }
            }
            if (state == 8) Console.WriteLine("Matched\tOmw");
            else Console.WriteLine("Not Matched");
        }

        //SIMww
        public void signedIntegerType(string Lexeme)
        {
            int state = 1, i = 0;
            char character;
            while (state != 10 && state != 0)
            {
                character = Lexeme[i];
                switch (state)
                {
                    case 1:
                        if (character == 'S') state = 2;
                        else state = 0;
                        i++;
                        break;
                    case 2:
                        if (character == 'I') state = 4;
                        else state = 0;
                        i++;
                        break;
                    case 4:
                        if (character == 'M') state = 6;
                        else state = 0;
                        i++;
                        break;
                    case 6:
                        if (character == 'w') state = 8;
                        else state = 0;
                        i++;
                        break;
                    case 8:
                        if (character == 'w') state = 10;
                        else state = 0;
                        i++;
                        break;
                }
            }
            if (state == 10) Console.WriteLine("Matched\tSIMww");
            else Console.WriteLine("Not Matched");
        }
        
        //Chji
        public void characterType(string Lexeme)
        {
            int state = 1, i = 0;
            char character;
            while (state != 8 && state != 0)
            {
                character = Lexeme[i];
                switch (state)
                {
                    case 1:
                        if (character == 'C') state = 2;
                        else state = 0;
                        i++;
                        break;
                    case 2:
                        if (character == 'h') state = 4;
                        else state = 0;
                        i++;
                        break;
                    case 4:
                        if (character == 'j') state = 6;
                        else state = 0;
                        i++;
                        break;
                    case 6:
                        if (character == 'i') state = 8;
                        else state = 0;
                        i++;
                        break;
                }
            }
            if (state == 8) Console.WriteLine("Matched\tChji");
            else Console.WriteLine("Not Matched");
        }
    }
}
