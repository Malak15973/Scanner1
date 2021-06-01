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
    }
}
