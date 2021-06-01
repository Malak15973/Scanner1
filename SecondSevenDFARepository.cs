using System;
using System.Collections.Generic;
using System.Text;

namespace Scanner1
{
    public class SecondSevenDFARepository : IRepositorySecondSevenDFA
    {
        //(+, -, *, /,)
        public void ArithmeticOperation(string Lexeme)
        {
            int state = 1, i = 0;
            char c;
            while ((state != 2 && state != 4 && state != 6 && state != 8) && state != 0)
            {
                c = Lexeme[i];
                switch (state)
                {
                    case 1:
                        if (c == '+') state = 2;
                        else if (c == '-') state = 4;
                        else if (c == '*') state = 6;
                        else if (c == '/') state = 8;
                        else state = 0;
                        i++;
                        break;
                }

            }
            if (state == 2 || state == 4 || state == 6 || state == 8) Console.WriteLine("Matched");
            else Console.WriteLine("Not Matched");
        }

        //OutLoop
        public void Break(string Lexeme)
        {
            int state = 1, i = 0;
            char c;
            while (state != 14 && state != 0)
            {
                c = Lexeme[i];
                switch (state)
                {
                    case 1:
                        if (c == 'O') state = 2;
                        else state = 0;
                        i++;
                        break;
                    case 2:
                        if (c == 'u') state = 4;
                        else state = 0;
                        i++;
                        break;
                    case 4:
                        if (c == 't') state = 6;
                        else state = 0;
                        i++;
                        break;
                    case 6:
                        if (c == 'L') state = 8;
                        else state = 0;
                        i++;
                        break;
                    case 8:
                        if (c == 'o') state = 10;
                        else state = 0;
                        i++;
                        break;
                    case 10:
                        if (c == 'o') state = 12;
                        else state = 0;
                        i++;
                        break;
                    case 12:
                        if (c == 'p') state = 14;
                        else state = 0;
                        i++;
                        break;
                }
            }
            if (state == 14) Console.WriteLine("Matched");
            else Console.WriteLine("Not Matched");
        }

        //(&&, ||, ~)
        public void Logicoperators(string Lexeme)
        {
            int state = 1, i = 0;
            char c;
            while ((state != 4 && state != 8 && state != 10) && state != 0)
            {
                c = Lexeme[i];
                switch (state)
                {
                    case 1:
                        if (c == '&') state = 2;
                        else if (c == '|') state = 6;
                        else if (c == '~') state = 10;
                        else state = 0;
                        i++;
                        break;
                    case 2:
                        if (state == 2 && c == '&') state = 4;
                        else state = 0;
                        i++;
                        break;
                    case 6:
                        if (state == 6 && c == '|') state = 8;
                        else state = 0;
                        i++;
                        break;
                }

            }
            if (state == 4 || state == 8 || state == 10) Console.WriteLine("Matched");
            else Console.WriteLine("Not Matched");
        }

        //RepeatWhen|Reiterate
        public void Loop(string Lexeme)
        {
            int state = 1, i = 0;
            char c;
            while ((state != 20 && state != 38) && state != 0)
            {
                c = Lexeme[i];
                switch (state)
                {
                    case 1:
                        if (c == 'R') state = 2;
                        else state = 0;
                        i++;
                        break;
                    case 2:
                        if (c == 'e') state = 4;
                        else state = 0;
                        i++;
                        break;
                    case 4:
                        if (c == 'p') state = 6;
                        else if (c == 'i') state = 26;
                        else state = 0;
                        i++;
                        break;
                    case 6:
                        if (c == 'e') state = 8;
                        else state = 0;
                        i++;
                        break;
                    case 8:
                        if (c == 'a') state = 10;
                        else state = 0;
                        i++;
                        break;
                    case 10:
                        if (c == 't') state = 12;
                        else state = 0;
                        i++;
                        break;
                    case 12:
                        if (c == 'W') state = 14;
                        else state = 0;
                        i++;
                        break;
                    case 14:
                        if (c == 'h') state = 16;
                        else state = 0;
                        i++;
                        break;
                    case 16:
                        if (c == 'e') state = 18;
                        else state = 0;
                        i++;
                        break;
                    case 18:
                        if (c == 'n') state = 20;
                        else state = 0;
                        i++;
                        break;
                    case 26:
                        if (c == 't') state = 28;
                        else state = 0;
                        i++;
                        break;
                    case 28:
                        if (c == 'e') state = 30;
                        else state = 0;
                        i++;
                        break;
                    case 30:
                        if (c == 'r') state = 32;
                        else state = 0;
                        i++;
                        break;
                    case 32:
                        if (c == 'a') state = 34;
                        else state = 0;
                        i++;
                        break;
                    case 34:
                        if (c == 't') state = 36;
                        else state = 0;
                        i++;
                        break;
                    case 36:
                        if (c == 'e') state = 38;
                        else state = 0;
                        i++;
                        break;
                }

            }
            if (state == 38 || state == 20) Console.WriteLine("Matched");
            else Console.WriteLine("Not Matched");
        }

        //GetBack
        public void Return(string Lexeme)
        {
            int state = 1, i = 0;
            char c;
            while (state != 14 && state != 0)
            {
                c = Lexeme[i];
                switch (state)
                {
                    case 1:
                        if (c == 'G') state = 2;
                        else state = 0;
                        i++;
                        break;
                    case 2:
                        if (c == 'e') state = 4;
                        else state = 0;
                        i++;
                        break;
                    case 4:
                        if (c == 't') state = 6;
                        else state = 0;
                        i++;
                        break;
                    case 6:
                        if (c == 'B') state = 8;
                        else state = 0;
                        i++;
                        break;
                    case 8:
                        if (c == 'a') state = 10;
                        else state = 0;
                        i++;
                        break;
                    case 10:
                        if (c == 'c') state = 12;
                        else state = 0;
                        i++;
                        break;
                    case 12:
                        if (c == 'k') state = 14;
                        else state = 0;
                        i++;
                        break;
                }
            }
            if (state == 14) Console.WriteLine("Matched");
            else Console.WriteLine("Not Matched");
        }

        //Loli
        public void Struct(string Lexeme)
        {
            int state = 1, i = 0;
            char c;
            while (state != 8 && state != 0)
            {
                c = Lexeme[i];
                switch (state)
                {
                    case 1:
                        if (c == 'L') state = 2;
                        else state = 0;
                        i++;
                        break;
                    case 2:
                        if (c == 'o') state = 4;
                        else state = 0;
                        i++;
                        break;
                    case 4:
                        if (c == 'l') state = 6;
                        else state = 0;
                        i++;
                        break;
                    case 6:
                        if (c == 'i') state = 8;
                        else state = 0;
                        i++;
                        break;
                }
            }
            if (state == 8) Console.WriteLine("Matched");
            else Console.WriteLine("Not Matched");
        }

        //NOReturn
        public void Void(string Lexeme)
        {
            int state = 1, i = 0;
            char c;
            while (state != 16 && state != 0)
            {
                c = Lexeme[i];
                switch (state)
                {
                    case 1:
                        if (c == 'N') state = 2;
                        else state = 0;
                        i++;
                        break;
                    case 2:
                        if (c == 'o') state = 4;
                        else state = 0;
                        i++;
                        break;
                    case 4:
                        if (c == 'R') state = 6;
                        else state = 0;
                        i++;
                        break;
                    case 6:
                        if (c == 'e') state = 8;
                        else state = 0;
                        i++;
                        break;
                    case 8:
                        if (c == 't') state = 10;
                        else state = 0;
                        i++;
                        break;
                    case 10:
                        if (c == 'u') state = 12;
                        else state = 0;
                        i++;
                        break;
                    case 12:
                        if (c == 'r') state = 14;
                        else state = 0;
                        i++;
                        break;
                    case 14:
                        if (c == 'n') state = 16;
                        else state = 0;
                        i++;
                        break;
                }
            }
            if (state == 16) Console.WriteLine("Matched");
            else Console.WriteLine("Not Matched");
        }
    }
}
