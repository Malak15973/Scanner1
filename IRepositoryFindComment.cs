using System;
using System.Collections.Generic;
using System.Text;

namespace Scanner1
{
    public interface IRepositoryFindComment
    {
        public int FindMultipleLinesComment();
        public int FindSingleLineComment();

    }
}
