using System;
using System.Collections.Generic;
using System.Text;

namespace Scanner1
{
    public interface IRepositorySecondSevenDFA
    {
        public void Void(string Lexeme);
        public void Loop(string Lexeme);
        public void Return(string Lexeme);
        public void Break(string Lexeme);
        public void Struct(string Lexeme);
        public void ArithmeticOperation(string Lexeme);
        public void Logicoperators(string Lexeme);
    }
}
