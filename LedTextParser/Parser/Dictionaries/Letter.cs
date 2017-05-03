using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LedTextParser.Parser.Dictionaries
{
    public class Letter
    {
        public Dictionary<string, List<char>> Dict = new Dictionary<string, List<char>>
        {
            {"A", new List<char>{'d','l','h','l','l'}},
            {"B", new List<char>{'N','K','N','K','N'}},
            {"C", new List<char>{'B','f','f','f','B'}},
            {"D", new List<char>{'N','K','K','K','N'}},
            {"E", new List<char>{'B','f','N','f','B'}},
            {"F", new List<char>{'B','f','N','f','f'}},
            {"G", new List<char>{'B','f','I','K','B'}},
            {"H", new List<char>{'K','K','B','K','K'}},
            {"I", new List<char>{'h','d','d','d','h'}},
            {"J", new List<char>{'B','d','d','J','o'}},
            {"K", new List<char>{'K','J','G','J','K'}},
            {"L", new List<char>{'f','f','f','f','B'}},
            {"M", new List<char>{'D','L','H','H','H'}},
            {"N", new List<char>{'H','P','L','O','H'}},
            {"O", new List<char>{'B','K','K','K','B'}},
            {"P", new List<char>{'N','J','N','f','f'}},
            {"Q", new List<char>{'B','K','K','I','A'}},
            {"R", new List<char>{'B','H','B','K','H'}},
            {"S", new List<char>{'B','f','B','c','B'}},
            {"T", new List<char>{'A','d','d','d','d'}},
            {"U", new List<char>{'H','H','H','H','A'}},
            {"V", new List<char>{'H','H','D','l','d'}},
            {"W", new List<char>{'H','H','L','D','H'}},
            {"X", new List<char>{'H','l','d','l','H'}},
            {"Y", new List<char>{'H','H','A','d','d'}},
            {"Z", new List<char>{'A','c','d','e','A'}},
            {"0", new List<char>{'h','O','L','P','h'}},
            {"1", new List<char>{'o','d','d','d','h'}},
            {"2", new List<char>{'h','c','h','e','h'}},
            {"3", new List<char>{'B','b','F','b','B'}},
            {"4", new List<char>{'l','l','h','d','d'}},
            {"5", new List<char>{'h','e','h','c','h'}},
            {"6", new List<char>{'h','e','h','l','h'}},
            {"7", new List<char>{'h','c','c','c','c'}},
            {"8", new List<char>{'h','l','h','l','h'}},
            {"9", new List<char>{'h','l','h','c','c'}}
        };
    }
}
