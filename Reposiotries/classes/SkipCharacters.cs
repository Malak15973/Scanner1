using System;
using Scanner1.Reposiotries.interfaces;

namespace Scanner1.Reposiotries.classes
{
    class SkipCharacters : ISkipCharactersRepository
    {
        //(+, -, *, /,)
        public bool MatchArithmeticOperation(string Lexeme)
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
            if (state == 2)
            {
                GetTokens.result += $"{GetTokens.lineNumber}\t\t\t+\t\t\tArithmetic Operation\t\t\t{++GetTokens.lexemeNumber}\t\t\tMatched\n";
                return true;
            }
            else if(state == 4)
            {
                GetTokens.result += $"{GetTokens.lineNumber}\t\t\t-\t\t\tArithmetic Operation\t\t\t{++GetTokens.lexemeNumber}\t\t\tMatched\n";
                return true;
            }
            else if(state == 6)
            {
                GetTokens.result += $"{GetTokens.lineNumber}\t\t\t*\t\t\tArithmetic Operation\t\t\t{++GetTokens.lexemeNumber}\t\t\tMatched\n";
                return true;
            }
            else if (state == 8)
            {
                GetTokens.result += $"{GetTokens.lineNumber}\t\t\t/\t\t\tArithmetic Operation\t\t\t{++GetTokens.lexemeNumber}\t\t\tMatched\n";
                return true;
            }
            return false;
        } 
        //(&&, ||, ~)
        public bool MatchLogicoperators(string Lexeme)
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
            if (state == 4)
            {
                GetTokens.result += $"{GetTokens.lineNumber}\t\t\t&&\t\t\tLogic operators\t\t\t\t{++GetTokens.lexemeNumber}\t\t\tMatched\n";
                return true;
            }
            else if (state == 8)
            {
                GetTokens.result += $"{GetTokens.lineNumber}\t\t\t||\t\t\tLogic operators\t\t\t\t{++GetTokens.lexemeNumber}\t\t\tMatched\n";
                return true;
            }
            else if (state == 10)
            {
                GetTokens.result += $"{GetTokens.lineNumber}\t\t\t~\t\t\tLogic operators\t\t\t\t{++GetTokens.lexemeNumber}\t\t\tMatched\n";
                return true;
            }
            return false;
        }
        //(/@)
        public bool MatchStartComment(string Lexeme)
        { 
            int state = 1, i = 0;
            char c;
            while (state != 4 && state != 0)//0 For Error
            {
                c = Lexeme[i];
                switch (state)
                {
                    case 1:
                        if (c == '/') state = 2;
                        else state = 0;
                        i++;
                        break;
                    case 2:
                        if (c == '@') state = 4;
                        else state = 0;
                        i++;
                        break;
                }

            }
            if (state == 4) {
                GetTokens.result += $"{GetTokens.lineNumber}\t\t\t\t/@\t\t\tComment\t\t{++GetTokens.lexemeNumber}\t\t\t\tMatched\n";
                return true;
            }
            return false;
        }
        //(@/)
        public bool MatchEndComment(string Lexeme)
        {
            int state = 1, i = 0;
            char c;
            while (state != 4 && state != 0)//0 For Error
            {
                c = Lexeme[i];
                switch (state)
                {
                    case 1:
                        if (c == '@') state = 2;
                        else state = 0;
                        i++;
                        break;
                    case 2:
                        if (c == '/') state = 4;
                        else state = 0;
                        i++;
                        break;
                }

            }
            if (state == 4) {
                GetTokens.result += $"{GetTokens.lineNumber}\t\t\t\t@/\t\t\tComment\t\t{++GetTokens.lexemeNumber}\t\t\t\tMatched\n";
                return true;
            }
            return false;
        }
        //(/^)
        public bool MatchSingleCodeComment(string Lexeme)
        {
            int state = 1, i = 0;
            char c;
            while (state != 4 && state != 0)//0 For Error
            {
                c = Lexeme[i];
                switch (state)
                {
                    case 1:
                        if (c == '/') state = 2;
                        else state = 0;
                        i++;
                        break;
                    case 2:
                        if (c == '^') state = 4;
                        else state = 0;
                        i++;
                        break;
                }

            }
            if (state == 4)
            {
                GetTokens.result += $"{GetTokens.lineNumber}\t\t\t/^\t\t\tComment\t\t\t\t{++GetTokens.lexemeNumber}\t\t\tMatched\n";
                return true;  
            }
            return false;
        }
        //($)
        public bool MatchTokenDelimiter(string Lexeme)
        { 
            int state = 1, i = 0;
            char c;
            while (state != 2 && state != 0) //0 For Error
            {
                c = Lexeme[i];
                switch (state)
                {
                    case 1:
                        if (c == '$') state = 2;
                        else state = 0;
                        i++;
                        break;
                }

            }
            if (state == 2)
            {
                GetTokens.result += $"{GetTokens.lineNumber}\t\t\t$\t\t\tToken Delimiter\t\t\t\t{++GetTokens.lexemeNumber}\t\t\tMatched\n";
                return true;
            }
            return false; 
        }
        //(.)
        public bool MatchLineDelimiter(string Lexeme)
        { 
            int state = 1, i = 0;
            char c;
            while (state != 2 && state != 0) //0 For Error
            {
                c = Lexeme[i];
                switch (state)
                {
                    case 1:
                        if (c == '.') state = 2;
                        else state = 0;
                        i++;
                        break;
                }

            }
            if (state == 2) { 
                GetTokens.result += $"{GetTokens.lineNumber}\t\t\t.\t\t\tLine Delimiter\t\t\t\t{++GetTokens.lexemeNumber}\t\t\tMatched\n";
                return true;
            }
            return false;
        }
        //(=)
        public bool AssignmentOperator(string Lexeme)
        {
            int state = 1, i = 0;
            char c;
            while (state != 2 && state != 0)//0 For Error
            {
                c = Lexeme[i];
                switch (state)
                {
                    case 1:
                        if (c == '=') state = 2;
                        else state = 0;
                        i++;
                        break;
                }

            }
            if (state == 2) { 
                GetTokens.result += $"{GetTokens.lineNumber}\t\t\t=\t\t\tAssignment operator\t\t\t{++GetTokens.lexemeNumber}\t\t\tMatched\n";
                return true;
            }
            return false;
        }
        //(->)
        public bool AccessingOperator(string Lexeme)
        {
            int state = 1, i = 0;
            char c, c1;
            while (state != 2 && state != 0)
            {
                c = Lexeme[i];
                c1 = Lexeme[i + 1];
                switch (state)
                {
                    case 1:
                        if (c == '-' && c1 == '>') state = 2;
                        else state = 0;
                        i++;
                        break;
                }

            }
            if (state == 2) {
                GetTokens.result += $"{GetTokens.lineNumber}\t\t\t->\t\t\tAccess Operator\t\t\t\t{++GetTokens.lexemeNumber}\t\t\tMatched\n";
                return true;
            }
            return false;
        }
        //{,},[,],(,)
        public bool Braces(string Lexeme)
        {
            int state = 1, i = 0;
            char c;
            while ((state != 2 && state != 4 && state != 6 && state != 8 && state != 10 && state != 12) && state != 0)
            {
                c = Lexeme[i];
                switch (state)
                {
                    case 1:
                        if (c == '{') state = 2;
                        else if (c == '}') state = 4;
                        else if (c == '(') state = 6;
                        else if (c == ')') state = 8;
                        else if (c == '[') state = 10;
                        else if (c == ']') state = 12;
                        else state = 0;
                        i++;
                        break;
                }

            }
            if (state == 2)
            {
                GetTokens.result += $"{GetTokens.lineNumber}\t\t\t{Convert.ToChar('{')}\t\t\tBraces\t\t\t\t\t{++GetTokens.lexemeNumber}\t\t\tMatched\n";
                return true;
            }
            else if (state == 4)
            {
                GetTokens.result += $"{GetTokens.lineNumber}\t\t\t{Convert.ToChar('}')}\t\t\tBraces\t\t\t\t\t{++GetTokens.lexemeNumber}\t\t\tMatched\n";
                return true;
            }
            else if (state == 6)
            {
                GetTokens.result += $"{GetTokens.lineNumber}\t\t\t(\t\t\tBraces\t\t\t\t\t{++GetTokens.lexemeNumber}\t\t\tMatched\n";
                return true;
            }
            else if (state == 8)
            {
                GetTokens.result += $"{GetTokens.lineNumber}\t\t\t)\t\t\tBraces\t\t\t\t\t{++GetTokens.lexemeNumber}\t\t\tMatched\n";
                return true;
            }
            else if (state == 10)
            {
                GetTokens.result += $"{GetTokens.lineNumber}\t\t\t[\t\t\tBraces\t\t\t\t\t{++GetTokens.lexemeNumber}\t\t\tMatched\n";
                return true;
            }
            else if (state == 12)
            {
                GetTokens.result += $"{GetTokens.lineNumber}\t\t\t]\t\t\tBraces\t\t\t\t\t{++GetTokens.lexemeNumber}\t\t\tMatched\n";
                return true;
            }
            return false;
        }

        public bool QuotationMark(string Lexeme)
        {
            int state = 1, i = 0;
            char c;
            while ((state != 2 && state != 4  ) && state != 0)
            {
                c = Lexeme[i];
                switch (state)
                {
                    case 1:
                        if (c == '"') state = 2;
                        else if (c == '\'') state = 4; 
                        else state = 0;
                        i++;
                        break;
                }

            }
            if (state == 2)
            {
                GetTokens.result += $"{GetTokens.lineNumber}\t\t\t\"\t\t\tQuotation Mark\t\t\t{++GetTokens.lexemeNumber}\t\t\tMatched\n";
                return true;
            }
            else if (state == 4)
            {
                GetTokens.result += $"{GetTokens.lineNumber}\t\t\t'\t\t\tQuotation Mark\t\t\t{++GetTokens.lexemeNumber}\t\t\tMatched\n";
                return true;
            }
            
            return false;
        }
        public void FindIdent(string Lexem)
        {
            char c;
            int length = Lexem.Length;
            string myIdent = "";
 

                    for (int j = 0; j < length; j++)
                    {
                        c = Lexem[j];

                        if (c == ',' || c == ' ' || c == '\n'|| j == length-1)
                        {
                            if (j == length-1)
                            {
                                myIdent += c;
                            }
                            GetTokens.result += $"{GetTokens.lineNumber}\t\t\t{myIdent}\t\t\tIdentifier\t\t\t{++GetTokens.lexemeNumber}\t\t\tMatched\n";
                            if (c == ',')
                            {                        
                                FindIdent(Lexem[(j+1)..length]);
                            }
                            return;
                        }

                        myIdent += c;
                    }               
                    

        }
     

        public void FindDigit(string Lexem)
        {
            char c;
            int length = Lexem.Length;
            string myIdent = "";
        }


    }
}
 
