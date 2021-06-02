using System;
using System.Collections.Generic;
using System.Text;

namespace Scanner1
{
    class FindCommentRepository : IRepositoryFindComment
    {
        int index = 0;
        string Lexem = "/^adsada\ndsdsadsa";
        public int FindMultipleLinesComment()
        {
            char c;
            int length = Lexem.Length;
            for (int i = 0; i < length; i++)
            {
                c = Lexem[i];
                if (c == '/')
                {
                    c = Lexem[++i];
                    if (c == '@')
                    {
                        for (int j = i; j < length; j++)
                        {
                            c = Lexem[j];
                            if (c == '@')
                            {
                                c = Lexem[++j];
                                if (c == '/')
                                {
                                    return index = j + 1;
                                }
                            }

                        }
                    }
                }
            }
            return index;

        }       

        public int FindSingleLineComment()
        {
            char c;
            int length = Lexem.Length;
            for (int i = 0; i < length; i++)
            {
                c = Lexem[i];
                if (c == '/')
                {
                    c = Lexem[++i];
                    if (c == '^')
                    {
                        for (int j = i; j < length; j++)
                        {
                            c = Lexem[j];
                            if (c == '\n')
                            {

                                return index = j + 1;

                            }

                        }
                    }
                }
            }
            return index;

        }
    }
}
