using LedTextParser.Parser.Dictionaries;
using System.Collections.Generic;
using System.Linq;

namespace LedTextParser.Parser
{
    // Representational String Converter Class
    public class RepStringConverter
    {
        private RepValidator validator = new RepValidator();

        private List<string> SplitStringRepresentation(string rep)
        {
            List<string> repPatterns = rep.Split('1').ToList();
            repPatterns.Remove("");
            return repPatterns;
        }

        public string ConvertRep(string rep)
        {
            string convertedString = "";

            if (validator.ValidateRep(rep) != null && rep.Length > 0)
            {
                Dictionary<string, string> dictionary = new LettersPattern().ProvideDictionary();

                foreach (var pattern in SplitStringRepresentation(rep))
                {
                    convertedString += dictionary.FirstOrDefault(d => d.Value == pattern).Key;
                }
            }
            else if (rep.Length == 0)
            {
                convertedString = "I have nothing to convert (but that's okay!)";
            }
            else
            {
                convertedString = "You've entered an invalid string!";
            }
            return convertedString;
        }
    }
}