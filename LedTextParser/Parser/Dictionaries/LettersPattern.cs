using System.Collections.Generic;

namespace LedTextParser.Parser.Dictionaries
{
    public class LettersPattern
    {
        public Dictionary<string, string> ProvideDictionary()
        {
            return LetterDictionary;
        }

        public Dictionary<string, string> LetterDictionary = new Dictionary<string, string>
        {
            {"A", "dlhll"},
            {"B", "NKNKN"},
            {"C", "BfffB"},
            {"D", "NKKKN"},
            {"E", "BfNfB"},
            {"F", "BfNff"},
            {"G", "BfIKB"},
            {"H", "KKBKK"},
            {"I", "hdddh"},
            {"J", "BddJo"},
            {"K", "KJGJK"},
            {"L", "ffffB"},
            {"M", "DLHHH"},
            {"N", "HPLOH"},
            {"O", "BKKKB"},
            {"P", "NJNff"},
            {"Q", "BKKIA"},
            {"R", "BHBKH"},
            {"S", "BfBcB"},
            {"T", "Adddd"},
            {"U", "HHHHA"},
            {"V", "HHDld"},
            {"W", "HHLDH"},
            {"X", "HldlH"},
            {"Y", "HHAdd"},
            {"Z", "AcdeA"},
            {"0", "hOLPh"},
            {"1", "odddh"},
            {"2", "hcheh"},
            {"3", "BbFbB"},
            {"4", "llhdd"},
            {"5", "hehch"},
            {"6", "hehlh"},
            {"7", "hcccc"},
            {"8", "hlhlh"},
            {"9", "hlhcc"}
        };
    }
}
