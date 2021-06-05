namespace Scanner1.Reposiotries.interfaces
{
    interface ISkipCharactersRepository
    {
        public bool MatchArithmeticOperation(string Lexeme);
        public bool MatchLogicoperators(string Lexeme);
        public bool MatchStartComment(string Lexeme);
        public bool MatchSingleCodeComment(string Lexeme);
        public bool MatchTokenDelimiter(string Lexeme);
        public bool MatchLineDelimiter(string Lexeme);
        public bool MatchEndComment(string Lexeme);

        public bool AssignmentOperator(string Lexeme);
        public bool AccessingOperator(string Lexeme);
        public bool Braces(string Lexeme);

        public bool QuotationMark(string Lexeme);
       
    }
}
