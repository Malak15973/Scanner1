using System;
using Scanner1.Reposiotries.interfaces;  
namespace Scanner1.Reposiotries.classes
{
    class ReservedKeywords : IReservedKeywordsRepository
    {
        //(Start)
        public bool StartProgram(string Lexeme)
        {
             
            int state = 1, i = 0;
            char c;
            while (state != 10 && state != 0)//0 For Error
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
                        if (c == 't') state = 4;
                        else state = 0;
                        i++;
                        break;
                    case 4:
                        if (c == 'a') state = 6;
                        else state = 0;
                        i++;
                        break;
                    case 6:
                        if (c == 'r') state = 8;
                        else state = 0;
                        i++;
                        break;
                    case 8:
                        if (c == 't') state = 10;
                        else state = 0;
                        i++;
                        break;
                }

            }
            if (state == 10) {
                GetTokens.result += $"{GetTokens.lineNumber}\t\t\t\tStart\t\t\tStart\t\t\t{++GetTokens.lexemeNumber}\t\t\t\tMatched\n";
                return true; 
            }
            return false;
        }
        //(Last)
        public bool EndProgram(string Lexeme)
        {
            int state = 1, i = 0;
            char c;
            while (state != 8 && state != 0)//0 For Error
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
                        if (c == 'a') state = 4;
                        else state = 0;
                        i++;
                        break;
                    case 4:
                        if (c == 's') state = 6;
                        else state = 0;
                        i++;
                        break;
                    case 6:
                        if (c == 't') state = 8;
                        else state = 0;
                        i++;
                        break;
                }

            }
            if (state == 8) {
                GetTokens.result += $"{GetTokens.lineNumber}\t\t\t\tLast\t\t\tEnd\t\t\t{++GetTokens.lexemeNumber}\t\t\t\tMatched\n";
                return true;
            }
            return false;
            
        }

        //OutLoop
        public bool Break(string Lexeme)
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
            if (state == 14) {
                GetTokens.result += $"{GetTokens.lineNumber}\t\t\t\tOutLoop\t\t\tBreak\t\t\t{++GetTokens.lexemeNumber}\t\t\t\tMatched\n";  
                return true;
            }
            return false;
            
        }
 
        //RepeatWhen|Reiterate
        public bool Loop(string Lexeme)
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
            if (state == 20)
            {
                GetTokens.result += $"{GetTokens.lineNumber}\t\t\t\tRepeatWhen\t\t\tLoop\t\t\t{++GetTokens.lexemeNumber}\t\t\t\tMatched\n";
                return true;
            }else if (state == 38)
            {
                GetTokens.result += $"{GetTokens.lineNumber}\t\t\t\tReiterate\t\t\tLoop\t\t\t{++GetTokens.lexemeNumber}\t\t\t\tMatched\n";
                return true; 
            }
            return false; 
        }

        //GetBack
        public bool Return(string Lexeme)
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
            if (state == 14) {
                GetTokens.result += $"{GetTokens.lineNumber}\t\t\t\tGetBack\t\t\tReturn\t\t\t{++GetTokens.lexemeNumber}\t\t\t\tMatched\n";
                return true; 
            }
            return false; 

        }

        //Loli
        public bool Struct(string Lexeme)
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
            if (state == 8) { 
                GetTokens.result += $"{GetTokens.lineNumber}\t\t\t\tLoli\t\t\tStruct\t\t\t{++GetTokens.lexemeNumber}\t\t\t\tMatched\n";
                return true; 
            }
            return false;
        }

        //NOReturn
        public bool Void(string Lexeme)
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
                        if (c == 'O') state = 4;
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
            if (state == 16) { 
                GetTokens.result += $"{GetTokens.lineNumber}\t\t\t\tNOReturn\t\tbool\t\t\t{++GetTokens.lexemeNumber}\t\t\t\tMatched\n";
                return true;
            }
            return false;
        }

        //Yesif
        public bool MatchIf(string Lexeme)
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
            if (state == 10) {
                GetTokens.result += $"{GetTokens.lineNumber}\t\t\t\tYesif\t\t\tCondition\t\t{++GetTokens.lexemeNumber}\t\t\t\tMatched\n";
                return true;
            }
            return false; 
            
        }

        //Otherwise
        public bool MatchOtherwise(string Lexeme)
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
            if (state == 18) { 
                GetTokens.result += $"{GetTokens.lineNumber}\t\t\t\tOtherwise\t\tCondition\t\t{++GetTokens.lexemeNumber}\t\t\t\tMatched\n";
                return true; 
            }
            return false;
        }

        //Include
        public bool Include(string Lexeme)
        {
            int state = 1, i = 0;
            char c;
            while (state != 14 && state != 0)
            {
                c = Lexeme[i];
                switch (state)
                {
                    case 1:
                        if (c == 'I') state = 2;
                        else state = 0;
                        i++;
                        break;
                    case 2:
                        if (c == 'n') state = 4;
                        else state = 0;
                        i++;
                        break;
                    case 4:
                        if (c == 'c') state = 6;
                        else state = 0;
                        i++;
                        break;
                    case 6:
                        if (c == 'l') state = 8;
                        else state = 0;
                        i++;
                        break;
                    case 8:
                        if (c == 'u') state = 10;
                        else state = 0;
                        i++;
                        break;
                    case 10:
                        if (c == 'd') state = 12;
                        else state = 0;
                        i++;
                        break;
                    case 12:
                        if (c == 'e') state = 14;
                        else state = 0;
                        i++;
                        break;

                }

            }
            if (state == 14) { 
                GetTokens.result += $"{GetTokens.lineNumber}\t\t\t\tInclude\t\t\tinclusion\t\t{++GetTokens.lexemeNumber}\t\t\t\tMatched\n";
                return true;
            }
            return false; 
        }
         
    }
}
