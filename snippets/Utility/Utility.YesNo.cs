﻿using System.Text.RegularExpressions;

namespace Conplement.Snippets.Utility
{
    /// <summary>
    /// Partial class for utility snippets
    /// </summary>
    /// Stopwatch documentation
    /// https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.stopwatch?redirectedfrom=MSDN&view=netframework-4.7.2
    public static partial class Utility
    {
        /// <summary>
        /// Returns true if the string is y/yes or false if the string is n/no, otherwise false
        /// </summary>
        public static bool YesNo(this string test, bool defaultVal = false)
        {
            return new Regex(@"^(y|yes)$", RegexOptions.IgnoreCase).IsMatch(test)
                ? true
                : new Regex(@"^(n|no)$", RegexOptions.IgnoreCase).IsMatch(test)
                    ? false
                    : defaultVal;
        }
    }
}
