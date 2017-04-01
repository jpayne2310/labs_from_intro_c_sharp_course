using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormLayout
{
    class myValidate
    {
        public static bool HasBadWords(string temp)
        {
            bool result = false;

            if (temp.Contains("poop") || temp.Contains("feces") ||
                temp.Contains("homework"))
            {
                result = true;
            }
            return result;
        }

    }
}
