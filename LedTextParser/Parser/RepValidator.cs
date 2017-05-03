using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LedTextParser.Parser
{
    public class RepValidator
    {
        public bool ValidateRep(string rep)
        {
            if (CheckLength(rep))
            {
                return false;
            }
            return true;
        }

        private bool CheckLength(string rep)
        {
            if (rep.Length % 7 != 0 && rep.Length >= 700)
            {
                return false;
            }
            return true;
        }

        public bool CheckLetterListForValidKey(string rep)
        {
            return true;
        }
    }
}