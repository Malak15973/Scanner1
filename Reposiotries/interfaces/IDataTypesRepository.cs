namespace Scanner1.Reposiotries.interfaces
{
    interface IDataTypesRepository
    {
        public bool MatchIntegerType(string Lexeme);
        public bool MatchSignedIntegerType(string Lexeme);
        public bool MatchCharacterType(string Lexeme);
        public bool MatchStringType(string Lexeme);
        public bool MatchFloatType(string Lexeme);
        public bool MatchSignedFloatType(string Lexeme);
    }
}
