using full_stack;

namespace Compilers_LastEight
{
    using System;

    /// <summary>
    /// Defines the <see cref="DFAtoFunctions" />.
    /// </summary>
    internal class DFAtoFunctions
    {
        /// <summary>
        /// The AssignmentOperator.
        /// </summary>
        /// <param name="lexeme">The lexeme<see cref="string"/>.</param>
        public void AssignmentOperator(string lexeme)
        {
            int state = 1, i = 0;
            char c;
            while (state != 2 && state != 0)//0 For Error
            {
                c = lexeme[i];
                switch (state)
                {
                    case 1:
                        if (c == '=') state = 2;
                        else state = 0;
                        i++;
                        break;
                }

            }
            if (state == 2) Console.WriteLine("Matched");
            else Console.WriteLine("Not Matched");
        }

        /// <summary>
        /// The AccessOperator.
        /// </summary>
        /// <param name="lexeme">The lexeme<see cref="string"/>.</param>
        public void AccessingOperator(string lexeme)
        {
            int state = 1, i = 0;
            char c, c1;
            while (state != 2 && state != 0)
            {
                c = lexeme[i];
                c1 = lexeme[i + 1];
                switch (state)
                {
                    case 1:
                        if (c == '=' && c1 == '>') state = 2;
                        else state = 0;
                        i++;
                        break;
                }

            }
            if (state == 2) Console.WriteLine("Matched");
            else Console.WriteLine("Not Matched");
        }

        /// <summary>
        /// The Braces.
        /// </summary>
        /// <param name="lexeme">The lexeme<see cref="string"/>.</param>
        public void Braces(string lexeme)
        {
            int state = 1, i = 0;
            char c;
            while (state != 2 && state != 0)
            {
                c = lexeme[i];
                switch (state)
                {
                    case 1:
                        if (c == '{' || c == '(' || c == '[' || c == '}' || c == ')' || c == ']') state = 2;
                        else state = 0;
                        i++;
                        break;
                }

            }
            if (state == 2) Console.WriteLine("Matched");
            else Console.WriteLine("Not Matched");
        }

        /// <summary>
        /// The Strings.
        /// </summary>
        /// <param name="lexeme">The lexeme<see cref="string"/>.</param>
        public void Include(string lexeme)
        {
            int state = 1, i = 0;
            char c;
            while (state != 14 && state != 0)
            {
                c = lexeme[i];
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
                        if (c == 'd') state = 14;
                        else state = 0;
                        i++;
                        break;

                }

            }
            if (state == 14) Console.WriteLine("Matched");
            else Console.WriteLine("Not Matched");
        }

        /// <summary>
        /// The NumbersAndConstants.
        /// </summary>
        /// <param name="lexeme">The lexeme<see cref="string"/>.</param>
        public void NumbersAndConstants(string lexeme = "")
        {
            int state = 1, i = 0;
            char c;
            while (state != 8 && state != 0)
            {
                c = lexeme[i];
                switch (state)
                {
                    case 1:
                        if (c == '-')
                        {
                            state = 2;
                            i++;
                            Console.WriteLine(Convert.ToChar(c) + " matched");
                        }
                        else
                        {
                            state = 2;
                            i++;
                        }

                        break;
                    case 2:
                        if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' ||
                            c == '7' || c == '8' || c == '9')
                        {
                            state = 2;
                            i++;
                            Console.WriteLine(Convert.ToChar(c) + " matched");
                        }
                        else if (c != '0' || c != '1' || c != '2' || c != '3' || c != '4' || c != '5' || c != '6' ||
                                 c != '7' || c != '8' || c != '9')
                        {
                            state = 0;
                        }
                        else
                        {
                            state = 4;
                            i++;
                        }
                        break;
                    case 4:
                        if (c == '.')
                        {
                            state = 6;
                            i++;
                            Console.WriteLine(Convert.ToChar(c) + " matched");
                        }
                        else
                        {
                            state = 0;
                            i++;
                        }
                        break;
                    case 6:
                        if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
                        {
                            state = 6;
                            i++;
                            Console.WriteLine(Convert.ToChar(c) + " matched");
                        }
                        else
                        {
                            state = 8;
                            i++;
                        }
                        break;
                }

            }
            if (state == 8) Console.WriteLine("Numbers - Matched");
            else Console.WriteLine("Not Matched");
        }

        /// <summary>
        /// The Conditions.
        /// </summary>
        /// <param name="lexeme">The lexeme<see cref="string"/>.</param>
        public void Conditions(string lexeme)
        {
            int i = 0;
            bool matchedFlag = false;
            char c1 = lexeme[1];

            foreach (char c in lexeme)
            {
                if (c == '=' && c1 == '=')
                {
                    matchedFlag = true;
                    i += 2;
                    Console.WriteLine(Convert.ToChar(c) + Convert.ToChar(c1) + " matched");
                    continue;
                }

                if (c == '!' && c1 == '=')
                {
                    matchedFlag = true;
                    i += 2;
                    Console.WriteLine(Convert.ToChar(c) + Convert.ToChar(c1) + " matched");
                    continue;
                }

                if (c == '>' && c1 == '=')
                {
                    matchedFlag = true;
                    i += 2;
                    Console.WriteLine(Convert.ToChar(c) + Convert.ToChar(c1) + " matched");
                    continue;
                }

                if (c == '>' && c1 != '=')
                {
                    matchedFlag = true;
                    i += 1;
                    Console.WriteLine(Convert.ToChar(c) + " matched");
                    continue;
                }

                if (c == '<' && c1 == '=')
                {
                    matchedFlag = true;
                    i += 2;
                    Console.WriteLine(Convert.ToChar(c) + Convert.ToChar(c1) + " matched");
                    continue;
                }

                if (c == '<' && c1 != '=')
                {
                    matchedFlag = true;
                    i += 1;
                    Console.WriteLine(Convert.ToChar(c) + " matched");
                    continue;
                }

                c1 = lexeme[i + 1];

                matchedFlag = false;
            }

            if (matchedFlag) Console.WriteLine("Matched");
            else Console.WriteLine("Not Matched");
        }


        public void Strings(string lexeme)
        {
            int i = 0, numberOfSingleQuote = 0, numberOfDoubleQuote = 0;
            CustomStack<char> cStack = new CustomStack<char>();

            foreach (char c in lexeme)
            {
                if (c == '\'' && (i % 2) == 0)
                {
                    cStack.Push(c);
                    i++;
                }
                else
                {
                    cStack.Pop(c);
                }
            }

            i = 0;

            foreach (char c in lexeme)
            {
                if (c == '"' && (i % 2) == 0)
                {
                    cStack.Push(c);
                    i++;
                }
                else
                {
                    cStack.Pop(c);
                }
            }

            numberOfSingleQuote = cStack.NoOfRepetitions('\'');
            numberOfDoubleQuote = cStack.NoOfRepetitions('"');


            if (numberOfSingleQuote == 0 && numberOfDoubleQuote == 0) Console.WriteLine("Matched");
            else Console.WriteLine("Not Matched");
        }

    }
}
