using System.IO;
using System.Xml;
using System.Reflection;
using System.Xml.Serialization;

namespace SimpleCopy
{
    static class Profiles
    {
        private static string ProfilesDir = "profiles";
        private static string ProfilesFile = "profiles.xml";
        private static XmlDocument ProfilesXML = new XmlDocument();

        public static Profile Current { get; private set; }

        public static void Init()
        {
            // Set default paths
            string WorkDir = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\";
            ProfilesDir = WorkDir + ProfilesDir;
            ProfilesFile = WorkDir + ProfilesFile;

            // Profiles folder missing?
            if (!Directory.Exists(ProfilesDir))
            {
                Directory.CreateDirectory(ProfilesDir);
            }

            ProfilesDir += "\\";

            // Already initialized?
            if (File.Exists(ProfilesFile))
            {
                // Load profiles
                ProfilesXML.Load(ProfilesFile);
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

        public static void Create(string Name, string FileName = null)
        {
            // Default directory?
            if (string.IsNullOrEmpty(FileName))
            {
                FileName = ProfilesDir + Utilities.SanitizeFileName(Name) + ".xml";
            }

            // Create Profile XML file
            XmlDocument ProfileXML = new XmlDocument();
            ProfileXML.AppendChild(ProfileXML.CreateXmlDeclaration("1.0", "UTF-8", null));
            ProfileXML.AppendChild(ProfileXML.CreateElement("Profile"));
            ProfileXML.Save(FileName);

            // Create Profile element (adding Name as an attribute)
            XmlElement ProfileXMLElement = ProfilesXML.CreateElement("Profile");
            ProfileXMLElement.SetAttribute("Name", Name);

            // Create FileName element in Profile
            XmlElement FileXML = ProfilesXML.CreateElement("File");
            FileXML.InnerText = FileName;
            ProfileXMLElement.AppendChild(FileXML);

            // Append new Profile element to ProfilesXML
            ProfilesXML.SelectSingleNode("/Profiles").AppendChild(ProfileXMLElement);

            // Save Profiles XML
            ProfilesXML.Save(ProfilesFile);
        }

        public static bool Load(string Name)
        {
            XmlNode FileXMLElement = ProfilesXML.SelectSingleNode("/Profiles/Profile[@Name='" + Name + "']/File");

            // Profile exists in profiles?
            if (FileXMLElement == null)
            {
                return false;
            }

            return LoadFile(FileXMLElement.InnerText);
        }

        public static bool LoadFile(string FileName)
        {
            // Profile exists?
            if (!File.Exists(FileName))
            {
                return false;
            }

            Current = Profile.FromFile(FileName);

            return true;
        }
    }
}
