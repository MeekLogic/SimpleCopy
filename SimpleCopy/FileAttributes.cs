namespace SimpleCopy
{
    public class FileAttributes
    {
        public static FileAttributes Parse(string attributes)
        {
            FileAttributes _FileAttributes = new FileAttributes();

            foreach (char c in attributes.ToLower().ToCharArray())
            {
                switch (c.ToString())
                {
                    case "r":
                        _FileAttributes.ReadOnly = true;
                        break;

                    case "a":
                        _FileAttributes.Archive = true;
                        break;

                    case "s":
                        _FileAttributes.System = true;
                        break;

                    case "h":
                        _FileAttributes.Hidden = true;
                        break;

                    case "c":
                        _FileAttributes.Compressed = true;
                        break;

                    case "n":
                        _FileAttributes.NotContentIndexed = true;
                        break;

                    case "e":
                        _FileAttributes.Encrypted = true;
                        break;

                    case "t":
                        _FileAttributes.Temporary = true;
                        break;

                    case "o":
                        _FileAttributes.Offline = true;
                        break;
                }
            }

            return _FileAttributes;
        }

        public override string ToString()
        {
            string _FileAttributes = "";

            if (ReadOnly) _FileAttributes += "r";
            if (ReadOnly) _FileAttributes += "a";
            if (ReadOnly) _FileAttributes += "s";
            if (ReadOnly) _FileAttributes += "h";
            if (ReadOnly) _FileAttributes += "c";
            if (ReadOnly) _FileAttributes += "n";
            if (ReadOnly) _FileAttributes += "e";
            if (ReadOnly) _FileAttributes += "t";
            if (ReadOnly) _FileAttributes += "o";

            return _FileAttributes;
        }

        public bool ReadOnly { get; set; }
        public bool Archive { get; set; }
        public bool System { get; set; }
        public bool Hidden { get; set; }
        public bool Compressed { get; set; }
        public bool NotContentIndexed { get; set; }
        public bool Encrypted { get; set; }
        public bool Temporary { get; set; }
        public bool Offline { get; set; }
    }
}