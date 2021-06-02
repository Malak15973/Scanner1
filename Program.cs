using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scanner1
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        //public static void StartComment()
        //{
        //    string lexeme = code[index..index + 2];
        //    int state = 1, i = 0;
        //    char c;
        //    while (state != 4 && state != 0)//0 For Error
        //    {
        //        c = lexeme[i];
        //        switch (state)
        //        {
        //            case 1:
        //                if (c == '@') state = 2;
        //                else state = 0;
        //                i++;
        //                break;
        //            case 2:
        //                if (c == '/') state = 4;
        //                else state = 0;
        //                i++;
        //                break;
        //        }

        //    }
        //    if (state == 4) Console.WriteLine("Matched");
        //    else Console.WriteLine("Not Matched");
        //}
        //public static void SingleCodeComment()
        //{
        //    string lexeme =  code[index..index + 2];

        //    int state = 1, i = 0;
        //    char c;
        //    while (state != 4 && state != 0)//0 For Error
        //    {
        //        c = lexeme[i];
        //        switch (state)
        //        {
        //            case 1:
        //                if (c == '/') state = 2;
        //                else state = 0;
        //                i++;
        //                break;
        //            case 2:
        //                if (c == '^') state = 4;
        //                else state = 0;
        //                i++;
        //                break;
        //        }

        //    }
        //    if (state == 4) Console.WriteLine("Matched");
        //    else Console.WriteLine("Not Matched");
        //}
        //public static void TokenDelimiter()
        //{
        //    string lexeme = code[index] ; 
        //    int state = 1, i = 0;
        //    char c;
        //    while (state != 2 && state != 0) //0 For Error
        //    {
        //        c = lexeme[i];
        //        switch (state)
        //        {
        //            case 1:
        //                if (c == '$') state = 2;
        //                else state = 0;
        //                i++;
        //                break;
        //        }

        //    }
        //    if (state == 2) Console.WriteLine("Matched");
        //    else Console.WriteLine("Not Matched");
        //}
        //public static void LineDelimiter()
        //{
        //    string lexeme = code[index] ;

        //    int state = 1, i = 0;
        //    char c;
        //    while (state != 2 && state != 0) //0 For Error
        //    {
        //        c = lexeme[i];
        //        switch (state)
        //        {
        //            case 1:
        //                if (c == '.') state = 2;
        //                else state = 0;
        //                i++;
        //                break;
        //        }

        //    }
        //    if (state == 2) Console.WriteLine("Matched");
        //    else Console.WriteLine("Not Matched");
        //}
        //public static void StartProgram()
        //{
        //    string lexeme = code[index..index + 5];

        //    int state = 1, i = 0;
        //    char c;
        //    while (state != 10 && state != 0)//0 For Error
        //    {
        //        c = lexeme[i];
        //        switch (state)
        //        {
        //            case 1:
        //                if (c == 'S') state = 2;
        //                else state = 0;
        //                i++;
        //                break;
        //            case 2:
        //                if (c == 't') state = 4;
        //                else state = 0;
        //                i++;
        //                break;
        //            case 4:
        //                if (c == 'a') state = 6;
        //                else state = 0;
        //                i++;
        //                break;
        //            case 6:
        //                if (c == 'r') state = 8;
        //                else state = 0;
        //                i++;
        //                break;
        //            case 8:
        //                if (c == 't') state = 10;
        //                else state = 0;
        //                i++;
        //                break;
        //        }

        //    }
        //    if (state == 10) Console.WriteLine("Matched");
        //    else Console.WriteLine("Not Matched");
        //}
        //public static void EndProgram()
        //{
        //    string lexeme = code[index..index + 4]; ;
        //    int state = 1, i = 0;
        //    char c;
        //    while (state != 8 && state != 0)//0 For Error
        //    {
        //        c = lexeme[i];
        //        switch (state)
        //        {
        //            case 1:
        //                if (c == 'L') state = 2;
        //                else state = 0;
        //                i++;
        //                break;
        //            case 2:
        //                if (c == 'a') state = 4;
        //                else state = 0;
        //                i++;
        //                break;
        //            case 4:
        //                if (c == 's') state = 6;
        //                else state = 0;
        //                i++;
        //                break;
        //            case 6:
        //                if (c == 't') state = 8;
        //                else state = 0;
        //                i++;
        //                break;
        //        }

        //    }
        //    if (state == 8) Console.WriteLine("Matched");
        //    else Console.WriteLine("Not Matched");
        //} 

    }
}
