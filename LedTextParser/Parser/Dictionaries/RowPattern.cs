using System.Collections.Generic;

namespace LedTextParser.Parser.Dictionaries
{
    public class RowPattern
    {
        // Primarily created to show how the lists were generated for the dictionary of
        // Letters/List of chars. This dictionary doesn't get used in the code, but if I had to
        // generate a working version of the LED display, this could be useful.

        public Dictionary<char, List<int>> Dict = new Dictionary<char, List<int>>
        {
            {'a', new List<int> {0,0,0,0,0}},
            {'A', new List<int> {1,1,1,1,1}},
            {'b', new List<int> {0,0,0,0,1}},
            {'B', new List<int> {1,1,1,1,0}},
            {'c', new List<int> {0,0,0,1,0}},
            {'C', new List<int> {1,1,1,0,1}},
            {'d', new List<int> {0,0,1,0,0}},
            {'D', new List<int> {1,1,0,1,1}},
            {'e', new List<int> {0,1,0,0,0}},
            {'E', new List<int> {1,0,1,1,1}},
            {'f', new List<int> {1,0,0,0,0}},
            {'F', new List<int> {0,1,1,1,1}},
            {'g', new List<int> {0,0,1,1,1}},
            {'G', new List<int> {1,1,0,0,0}},
            {'h', new List<int> {0,1,1,1,0}},
            {'H', new List<int> {1,0,0,0,1}},
            {'i', new List<int> {0,1,0,0,1}},
            {'I', new List<int> {1,0,1,1,0}},
            {'j', new List<int> {0,1,0,1,1}},
            {'J', new List<int> {1,0,1,0,0}},
            {'k', new List<int> {0,1,1,0,1}},
            {'K', new List<int> {1,0,0,1,0}},
            {'l', new List<int> {0,1,0,1,0}},
            {'L', new List<int> {1,0,1,0,1}},
            {'m', new List<int> {0,0,1,0,1}},
            {'M', new List<int> {1,1,0,1,0}},
            {'n', new List<int> {0,0,0,1,1}},
            {'N', new List<int> {1,1,1,0,0}},
            {'o', new List<int> {0,1,1,0,0}},
            {'O', new List<int> {1,0,0,1,1}},
            {'p', new List<int> {0,0,1,1,0}},
            {'P', new List<int> {1,1,0,0,1}}
        };
    }
}