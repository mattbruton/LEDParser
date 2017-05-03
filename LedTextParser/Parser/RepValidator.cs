using LedTextParser.Parser.Dictionaries;
using System.Collections.Generic;
using System.Linq;

namespace LedTextParser.Parser
{
    public class RepValidator
    {   
        public string ValidateRep(string rep)
        {
            return ValidateLength(rep) && ValidatePattern(rep) ? rep : null;
        }

        private bool ValidateLength(string rep)
        {  
            return rep.Length % 6 == 0 && rep.Length <= 600;
        }

        public bool ValidatePattern(string rep)
        {
            Dictionary<string, string> dictionary = new LettersPattern().ProvideDictionary();
            List<string> repPatterns = rep.Split('1').ToList();
            repPatterns.Remove(repPatterns.Last());
            int patternCount = 0;

            foreach (var pattern in repPatterns)
            {
                if (dictionary.ContainsValue(pattern))
                {
                    patternCount++;
                }
            }
            return patternCount == repPatterns.Count;
        }
    }
}