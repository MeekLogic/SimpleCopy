namespace SimpleCopy
{
    public class CopyFlags
    {
        public static CopyFlags Parse(string flags)
        {
            CopyFlags _CopyFlags = new CopyFlags();

            foreach (char c in flags.ToLower().ToCharArray())
            {
                switch (c.ToString())
                {
                    case "d":
                        _CopyFlags.Data = true;
                        break;

                    case "a":
                        _CopyFlags.Attributes = true;
                        break;

                    case "t":
                        _CopyFlags.TimeStamps = true;
                        break;

                    case "s":
                        _CopyFlags.Security = true;
                        break;

                    case "o":
                        _CopyFlags.Owner = true;
                        break;

                    case "u":
                        _CopyFlags.Auditing = true;
                        break;
                }
            }

            return _CopyFlags;
        }

        public override string ToString()
        {
            string _CopyFlags = "";

            if (Data) _CopyFlags += "d";
            if (Attributes) _CopyFlags += "a";
            if (TimeStamps) _CopyFlags += "t";
            if (Security) _CopyFlags += "s";
            if (Owner) _CopyFlags += "o";
            if (Auditing) _CopyFlags += "u";

            return _CopyFlags;
        }

        public bool Data { get; set; }

        public bool Attributes { get; set; }

        public bool TimeStamps { get; set; }

        public bool Security { get; set; }

        public bool Owner { get; set; }

        public bool Auditing { get; set; }
    }
}