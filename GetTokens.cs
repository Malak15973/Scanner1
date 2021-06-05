using System;
using System.Collections.Generic;
using System.Text;
using Scanner1.Reposiotries.classes; 

namespace Scanner1
{
    class GetTokens
    {
        private string code;
        public static string result ;
        public static int lineNumber;
        public static int lexemeNumber;
        public static int i;
        public static int errors;
        public static bool findStart;

        public GetTokens(string code)
        {
            this.code = code;
        }

         

        public string Compile()
        {
            result = "lineNumber\t\t\tlexeme\t\t\tToken\t\t\tlexemeNoInLine\t\t\tmatchability\n";
            lineNumber = 1;
            lexemeNumber = 0;
            errors = 0;
            findStart = false;
            DataTypes dataTypes = new DataTypes();
            SkipCharacters skipCharacters = new SkipCharacters();
            ReservedKeywords reservedKeywords = new ReservedKeywords();
            Utilites utilites = new Utilites();

            for (i = 0; i < utilites.GetLength(code); i++)
            {
                if (code[i] == '\n')
                {
                    lineNumber++;
                    lexemeNumber = 0;
                }
                else
                {
                    //Start handling comment

                    try
                    {
                        if (skipCharacters.MatchSingleCodeComment(utilites.GetSlice(code, i, i + 2)))
                        {
                            i += 2;
                            while (true)
                            {
                                if(code[i]!= '\n')
                                {
                                    i++;
                                }
                                else
                                {
                                    lineNumber++;
                                    lexemeNumber = 0;
                                    break;
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }
                    
                    try
                    {
                        if (skipCharacters.MatchStartComment(utilites.GetSlice(code, i, i + 2)))
                        {
                            i += 2;
                            while (!skipCharacters.MatchEndComment(utilites.GetSlice(code, i, i + 2)))
                            {
                                if (code[i] == '\n')
                                {
                                    lineNumber++;
                                    lexemeNumber = 0;
                                }
                                i++;
                            }
                            i += 2;
                        }

                    }
                    catch (Exception)
                    {
                    }       

                    //End handling comment

                    // Start handling datatypes

                    try
                    {
                        
                        if (dataTypes.MatchIntegerType(utilites.GetSlice(code, i, i + 3)))
                        { 
                            i += 3;
                            if (!findStart)
                            {
                                findStart = true;
                                errors++;
                            }
                        }
                         
                    }catch(Exception)
                    {
                    }
                    try {
                       
                        if (dataTypes.MatchSignedIntegerType(utilites.GetSlice(code, i, i + 5)))
                        {
                            i += 5;
                            if (!findStart)
                            {
                                findStart = true;
                                errors++;
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }   
                    try {
                        
                        if (dataTypes.MatchCharacterType(utilites.GetSlice(code, i, i + 4)))
                        {
                            i += 4;
                            if (!findStart)
                            {
                                findStart = true;
                                errors++;
                            }
                        }
                     }catch (Exception)
                     {
                     }
                    try {
                       
                        if (dataTypes.MatchStringType(utilites.GetSlice(code, i, i + 8)))
                        {
                            i += 8;
                            if (!findStart)
                            {
                                findStart = true;
                                errors++;
                            }
                        }
                    }catch (Exception)
                    {
                    }
                    try {
                        
                        if (dataTypes.MatchFloatType(utilites.GetSlice(code, i, i + 4)))
                        {
                            i += 4;
                            if (!findStart)
                            {
                                findStart = true;
                                errors++;
                            }
                        }
                    }catch (Exception)
                    {
                    }
                    try {
                       
                        if (dataTypes.MatchSignedFloatType(utilites.GetSlice(code, i, i + 5)))
                        {
                            i += 5;
                            if (!findStart)
                            {
                                findStart = true;
                                errors++;
                            }
                        }
                    }catch (Exception)
                    {
                    }

                    // End handling datatypes


                    // Start handling reserved Keywords
                    
                    try
                    {
                        if (reservedKeywords.Void(utilites.GetSlice(code, i, i + 8)))
                        {
                            i += 8;

                            if (!findStart)
                            {
                                findStart = true;
                                errors++;
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }
                    try
                    {
                       
                        if (reservedKeywords.Loop(utilites.GetSlice(code, i, i + 10)))
                        {
                            i += 10;
                            if (!findStart)
                            {
                                findStart = true;
                                errors++;
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }
                    try
                    {
                       
                        if (reservedKeywords.Return(utilites.GetSlice(code, i, i + 7))) 
                        {
                            i += 7;
                            if (!findStart)
                            {
                                findStart = true;
                                errors++;
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }
                    try
                    {
                        
                        if (reservedKeywords.Break(utilites.GetSlice(code, i, i + 7))) {
                            i += 7;
                            if (!findStart)
                            {
                                findStart = true;
                                errors++;
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }
                    try
                    {
                       
                        if (reservedKeywords.Struct(utilites.GetSlice(code, i, i + 4))) 
                        {
                            i += 4;
                            if (!findStart)
                            {
                                findStart = true;
                                errors++;
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }
                    try
                    {
                        
                        if (reservedKeywords.StartProgram(utilites.GetSlice(code, i, i + 5))) 
                        {
                            i += 5;
                            findStart = true;
                        }
                    }
                    catch (Exception)
                    {
                    }
                    try
                    {

                       
                        if (reservedKeywords.EndProgram(utilites.GetSlice(code, i, i + 4))) 
                        {
                            i += 4;
                            if (!findStart)
                            {
                                findStart = true;
                                errors++;
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }
                    try
                    {
                       
                        if (reservedKeywords.MatchIf(utilites.GetSlice(code, i, i + 5))) {
                            i += 5;
                            if (!findStart)
                            {
                                findStart = true;
                                errors++;
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }
                    try
                    {
                       
                        if (reservedKeywords.MatchOtherwise(utilites.GetSlice(code, i, i + 9))) 
                        {
                            i += 9;
                            if (!findStart)
                            {
                                findStart = true;
                                errors++;
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }
                    try
                    {
                        if (reservedKeywords.Include(utilites.GetSlice(code, i, i + 7))) 
                        {
                            i += 7;

                            if (!findStart)
                            {
                                findStart = true;
                                errors++;
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }

                    // End handling reserved Keywords

                    // Start handling skip charcters

                    try
                    {
                       
                        if (skipCharacters.MatchLogicoperators(utilites.GetSlice(code, i, i + 2))) 
                        {
                            i += 2;
                            if (!findStart)
                            {
                                findStart = true;
                                errors++;
                            }
                        }
                    }
                    catch (Exception)
                    {
                    } 
                    try
                    {
                        
                        bool IsArith = skipCharacters.MatchArithmeticOperation(utilites.GetSlice(code, i, i + 1));
                        if (IsArith)
                        {
                            if (!findStart)
                            {
                                findStart = true;
                                errors++;
                            }
                        }
                    }
                    catch (Exception)
                    {
                    } 
                    try
                    {
                       
                        bool IsDoler = skipCharacters.MatchTokenDelimiter(utilites.GetSlice(code, i, i + 1));
                        if (IsDoler)
                        {
                            skipCharacters.FindIdent(code[(i+1)..utilites.GetLength(code)]);
                            if (!findStart)
                            {
                                findStart = true;
                                errors++;
                            }
                        }
                    }
                    catch (Exception)
                    {
                    } 
                    try
                    {
                        
                        bool IsMatch = skipCharacters.MatchLineDelimiter(utilites.GetSlice(code, i, i + 1));
                        if (IsMatch)
                        {
                            if (!findStart)
                            {
                                findStart = true;
                                errors++;
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }   
                    try
                    {

                        
                        if (skipCharacters.AccessingOperator(utilites.GetSlice(code, i, i + 2)))
                        {
                            i += 2;
                            if (!findStart)
                            {
                                findStart = true;
                                errors++;
                            }
                        }
                    }
                    catch (Exception)
                    {
                    } 
                    try
                    {
                       
                        bool IsBarce = skipCharacters.Braces(utilites.GetSlice(code, i, i + 1));
                        if (IsBarce)
                        {
                            if (!findStart)
                            {
                                findStart = true;
                                errors++;
                            }
                        }
                    }
                    catch (Exception)
                    {
                    } 
                    try
                    {
                       
                        bool IsAss = skipCharacters.AssignmentOperator(utilites.GetSlice(code, i, i + 1));
                        if (IsAss)
                        {
                            if (!findStart)
                            {
                                findStart = true;
                                errors++;
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }
                    try
                    {
                       
                        bool ISQout = skipCharacters.QuotationMark(utilites.GetSlice(code, i, i + 1));
                        if (ISQout)
                        {
                            if (!findStart)
                            {
                                findStart = true;
                                errors++;
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }

                    // End handling skip charcters
                  
                 
                }
            }
            
            return result;

        }
         
    }
    }
 
