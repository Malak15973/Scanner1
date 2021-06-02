namespace full_stack
{
    using System;

    /// <summary>
    /// Defines the <see cref="Program" />.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The Main.
        /// </summary>
        /// <param name="args">The args<see cref="string[]"/>.</param>
        internal static void Main(string[] args)
        {
        }

        /// <summary>
        /// The AssignmentOperator.
        /// </summary>
        public static void AssignmentOperator()
        {

            string lexeme = "=";
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
        public static void AccessOperator()
        {

            string lexeme = "=>";
            int state = 1, i = 0;
            char c, c1;
            while (state != 2 && state != 0)//0 For Error
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
        /// The AccessOperator.
        /// </summary>
        public static void AccessingOperator()
        {

            string lexeme = "=>";
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
        public static void Braces()
        {

            string lexeme = "{([])}";
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
        public static void Strings()
        {

            string lexeme = "Include \".h\"";
            int state = 1, i = 0;
            char c;
            while (state != 24 && state != 0)
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
                        if (c == 'e') state = 14;
                        else state = 0;
                        i++;
                        break;
                    case 16:
                        if (c == '"') state = 18;
                        else state = 0;
                        i++;
                        break;
                    case 20:
                        if (c == '.') state = 22;
                        else state = 0;
                        i++;
                    case 22:
                        if (c == 'h') state = 24;
                        else state = 0;
                        i++;

                }

            }
            if (state == 2) Console.WriteLine("Matched");
            else Console.WriteLine("Not Matched");
        }

        /// <summary>
        /// The NumbersAndConstants.
        /// </summary>
        public static void NumbersAndConstants()
        {

            string lexeme = "-123456789.2";
            int state = 1, i = 0;
            char c;
            while (state != 6 && state != 0)
            {
                c = lexeme[i];
                switch (state)
                {
                    case 1:
                        if (c == '-')
                            state = 2;
                        else state = 0;
                        i++;
                        break;
                    case 2:
                        if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
                            state = 4;
                        else state = 0;
                        i++;
                        break;
                    case 4:
                        if (c == '.')
                            state = 6;
                        else state = 2;
                        i++;
                        break;
                    case 6:
                        if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
                            state = 2;
                        else state = 0;
                        i++;
                        break;
                }

            }
            if (state == 2) Console.WriteLine("Matched");
            else Console.WriteLine("Not Matched");
        }

        /// <summary>
        /// The Conditions.
        /// </summary>
        public static void Conditions()
        {

            string lexeme = "==>=<=!=";
            int state = 1, i = 0;
            char c, c1;
            while (state != 8 && state != 0)
            {
                c = lexeme[i];
                c1 = lexeme[i + 1];

                switch (state)
                {
                    case 1:
                        if (c == '<')
                        {
                            if (c1 == '=')
                            {
                                state = 2;
                                i += 2;
                            }
                        }
                        else
                        {
                            state = 0;
                            i++;
                        }
                        break;

                    case 2:
                        if (c == '>')
                        {
                            if (c1 == '=')
                            {
                                state = 4;
                                i += 2;
                            }
                        }
                        else
                        {
                            state = 0;
                            i++;
                        }
                        break;

                    case 4:
                        if (c == '=')
                        {
                            if (c1 == '=')
                            {
                                state = 6;
                                i += 2;
                            }
                        }
                        else
                        {
                            state = 0;
                            i++;
                        }
                        break;
                    case 6:
                        if (c == '!')
                        {
                            if (c1 == '=')
                            {
                                state = 8;
                                i += 2;
                            }
                        }
                        else
                        {
                            state = 0;
                            i++;
                        }
                        break;
                }
                if (state == 0) Console.WriteLine("Matched");
                else Console.WriteLine("Not Matched");
            }
        }
    }
}
