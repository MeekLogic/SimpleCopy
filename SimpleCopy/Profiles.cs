using System.IO;
using System.Xml;
using System.Reflection;

namespace SimpleCopy
{
    static class Profiles
    {
        private static string WorkingDir;
        private static string ProfilesDir = "profiles";
        private static string ProfilesFileName = "profiles.xml";

        private static XmlDocument ProfilesXML;

        public static Profile Current { get; private set; }

        public static void Init()
        {
            WorkingDir = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\";

            // Create XmlDocument class
            ProfilesXML = new XmlDocument();

            // Profiles folder missing?
            if (!Directory.Exists(WorkingDir + ProfilesDir))
            {
                Directory.CreateDirectory(WorkingDir + ProfilesDir);
            }

            ProfilesDir += "\\";

            // Already initialized?
            if (File.Exists(WorkingDir + ProfilesFileName))
            {
                // Load profiles
                ProfilesXML.Load(WorkingDir + ProfilesFileName);
            }
            else
            {
                // Create profiles.xml
                ProfilesXML.AppendChild(ProfilesXML.CreateXmlDeclaration("1.0", "UTF-8", null));
                ProfilesXML.AppendChild(ProfilesXML.CreateElement("Profiles"));

                // Create "last" profile (and save)
                Create("last");
            }

            // Load "last" profile
            Load("last");
        }

        public static Profile Create(string Name)
        {
            // Generate safe file name
            string FileName = Utilities.SanitizeFileName(Name) + ".xml";

            // Create new profile
            Profile profile = new Profile(WorkingDir + ProfilesDir + FileName);
            
            // Update profiles
            XmlElement profileElement = ProfilesXML.CreateElement("Profile");
            profileElement.SetAttribute("Name", Name);

            XmlElement file = ProfilesXML.CreateElement("FileName");
            file.InnerText = FileName;
            profileElement.AppendChild(file);

            ProfilesXML.SelectSingleNode("/Profiles").AppendChild(profileElement);

            ProfilesXML.Save(WorkingDir + ProfilesFileName);

            return profile;
        }

        public static Profile Get(string name)
        {
            XmlNode FileNameXML = ProfilesXML.SelectSingleNode("/Profiles/Profile[@Name='" + name + "']/FileName");

            // Profile exists in profiles?
            if (FileNameXML == null)
            {
                return null;
            }

            // Profile file exists?
            if (!File.Exists(WorkingDir + ProfilesDir + FileNameXML.InnerText))
            {
                return null;
            }

            return new Profile(WorkingDir + ProfilesDir + FileNameXML.InnerText);
        }

        public static Profile[] All()
        {
            XmlNodeList nodes = ProfilesXML.SelectNodes("/Profiles/Profile");

            Profile[] _profiles = new Profile[nodes.Count];

            int i = 0;
            foreach (XmlNode node in nodes)
            {
                _profiles[i++] = Get(node.Attributes["Name"].InnerText);
            }

            return _profiles;
        }

        public static bool Load(string name)
        {
            Profile _profile = Get(name);

            if (_profile == null)
            {
                return false;
            }

            Current = _profile;

            return true;
        }

        public static bool LoadFile(string FileName)
        {
            if (Path.GetExtension(FileName) != "xml")
            {
                return false;
            }

            Current = new Profile(FileName);

            return true;
        }
    }
}
