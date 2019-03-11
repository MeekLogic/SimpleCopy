using System;
using System.IO;
using System.Text.RegularExpressions;

namespace SimpleCopy
{
    static class Utilities
    {
        // https://msdn.microsoft.com/en-us/library/aa365247.aspx#naming_conventions
        // http://stackoverflow.com/questions/146134/how-to-remove-illegal-characters-from-path-and-filenames
        private static readonly Regex removeInvalidChars = new Regex($"[{Regex.Escape(new string(Path.GetInvalidFileNameChars()))}]",
            RegexOptions.Singleline | RegexOptions.Compiled | RegexOptions.CultureInvariant);

        public static string SanitizeFilename(string filename, string replacement = "_")
        {
            if (String.IsNullOrEmpty(filename))
            {
                return null;
            }

            return removeInvalidChars.Replace(filename, replacement);
        }
    }
}
