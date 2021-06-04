namespace Scanner1.Reposiotries.interfaces
{
    interface IReservedKeywordsRepository
    {
        public bool Void(string Lexeme);
        public bool Loop(string Lexeme);
        public bool Return(string Lexeme);
        public bool Break(string Lexeme);
        public bool Struct(string Lexeme);
        public bool StartProgram(string Lexeme);
        public bool EndProgram(string Lexeme);
        public bool MatchIf(string Lexeme);
        public bool MatchOtherwise(string Lexeme);
        public bool Include(string Lexeme);
    }
}
