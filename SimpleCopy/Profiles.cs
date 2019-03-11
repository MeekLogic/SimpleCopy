using System.IO;
using System.Xml;

namespace SimpleCopy
{
    static class Profiles
    {
        private static string _directory;
        private static string _filename;
        private static XmlDocument _xmlDocument;

        public static Profile Current { get; private set; }

        public static void Init(string directory = null, string filename = "profiles.xml")
        {
            // Default directory?
            if (string.IsNullOrEmpty(directory))
            {
                directory = Directory.GetCurrentDirectory();
            }

            // Ensure directory ends with slash
            if (!directory.EndsWith("/"))
            {
                directory += "/";
            }

            // Set class variables
            _directory = directory;
            _filename = filename;

            // Create XmlDocument class
            _xmlDocument = new XmlDocument();

            // Profiles folder missing?
            if (!Directory.Exists(_directory + "profiles"))
            {
                Directory.CreateDirectory(_directory + "profiles");
            }

            // Already initialized?
            if (File.Exists(_directory + _filename))
            {
                // Load profiles
                _xmlDocument.Load(_directory + _filename);
            }
            else
            {
                // Create profiles.xml
                _xmlDocument.AppendChild(_xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null));
                _xmlDocument.AppendChild(_xmlDocument.CreateElement("Profiles"));

                Create("last");
            }

            Load("last");
        }

        public static Profile Create(string name)
        {
            string filename = Utilities.SanitizeFilename(name) + ".xml";

            Profile profile = new Profile(_directory + "profiles/" + filename);
            
            // Update profiles
            XmlElement profileElement = _xmlDocument.CreateElement("Profile");
            profileElement.SetAttribute("Name", name);

            XmlElement file = _xmlDocument.CreateElement("Filename");
            file.InnerText = filename;
            profileElement.AppendChild(file);

            _xmlDocument.SelectSingleNode("/Profiles").AppendChild(profileElement);

            _xmlDocument.Save(_directory + _filename);

            return profile;
        }

        public static Profile Get(string name)
        {
            XmlNode filename = _xmlDocument.SelectSingleNode("/Profiles/Profile[@Name='" + name + "']/Filename");

            if (!File.Exists(_directory + "profiles/" + filename.InnerText))
            {
                return null;
            }

            return new Profile(_directory + "profiles/" + filename.InnerText);
        }

        public static Profile[] All()
        {
            XmlNodeList nodes = _xmlDocument.SelectNodes("/Profiles/Profile");

            Profile[] _profiles = new Profile[nodes.Count];

            int i = 0;
            foreach (XmlNode node in nodes)
            {
                _profiles[i++] = Get(node.Attributes["Name"].InnerText);
            }

            return _profiles;
        }

        public static bool Load(string name = "last")
        {
            Profile _profile = Get(name);

            if (_profile == null)
            {
                return false;
            }

            Current = _profile;

            return true;
        }
    }
}
