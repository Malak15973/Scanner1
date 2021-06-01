﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Scanner1
{
    public class FirstSeven : IRepositorySecondSevenDFA
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

        //Omw
        public void matchOmw(string Lexeme)
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
            if (state == 6) Console.WriteLine("Matched\tOmw");
        }

        //SIMww
        public void matchSignedIntegerType(string Lexeme)
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
        }

        //Chji
        public void matchCharacterType(string Lexeme)
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
        }

        //Seriestl
        public void matchStringType(string Lexeme)
        {
            int state = 1, i = 0;
            char c;
            while (state != 16 && state != 0)
            {
                c = Lexeme[i];
                switch (state)
                {
                    case 1:
                        if (c == 'S') state = 2;
                        else state = 0;
                        i++;
                        break;
                    case 2:
                        if (c == 'e') state = 4;
                        else state = 0;
                        i++;
                        break;
                    case 4:
                        if (c == 'r') state = 6;
                        else state = 0;
                        i++;
                        break;
                    case 6:
                        if (c == 'i') state = 8;
                        else state = 0;
                        i++;
                        break;
                    case 8:
                        if (c == 'e') state = 10;
                        else state = 0;
                        i++;
                        break;
                    case 10:
                        if (c == 's') state = 12;
                        else state = 0;
                        i++;
                        break;
                    case 12:
                        if (c == 't') state = 14;
                        else state = 0;
                        i++;
                        break;
                    case 14:
                        if (c == 'l') state = 16;
                        else state = 0;
                        i++;
                        break;
                }
            }
            if (state == 16) Console.WriteLine("Matched\tSeriestl");
        }

        //IMwf
        public void matchFloatType(string Lexeme)
        {
            int state = 1, i = 0;
            char character;
            while (state != 8 && state != 0)
            {
                character = Lexeme[i];
                switch (state)
                {
                    case 1:
                        if (character == 'I') state = 2;
                        else state = 0;
                        i++;
                        break;
                    case 2:
                        if (character == 'M') state = 4;
                        else state = 0;
                        i++;
                        break;
                    case 4:
                        if (character == 'w') state = 6;
                        else state = 0;
                        i++;
                        break;
                    case 6:
                        if (character == 'f') state = 8;
                        else state = 0;
                        i++;
                        break;
                }
            }
            if (state == 8) Console.WriteLine("Matched\tIMwf");
        }

        //SIMwf
        public void matchSignedFloatType(string Lexeme)
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
                        if (character == 'f') state = 10;
                        else state = 0;
                        i++;
                        break;
                }
            }
            if (state == 10) Console.WriteLine("Matched\tSIMwf");
        }
    }
}
