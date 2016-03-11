using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pasikonik
{
    static class Validator
    {
        public static bool CheckGameParameters()
        {
            return false;
        }

        private static bool IsNumber(String str)
        {
            var regex = new Regex("^[0-9]+$");
            return regex.IsMatch(str);
        }
    }
}
