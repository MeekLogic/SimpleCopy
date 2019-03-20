using System;
using System.IO;
using System.Xml;

namespace SimpleCopy
{
    internal class ProfileLoadedEventArgs : EventArgs
    {
        internal Profile ProfileLoaded { get; set; }
    }

    internal static class Profiles
    {
        private static string ProfilesDir = "profiles";
        private static string ProfilesFile = "profiles.xml";

        private static readonly XmlDocument ProfilesXML = new XmlDocument();

        private static Profile _Current;

        internal static event EventHandler<ProfileLoadedEventArgs> ProfileLoaded;

        internal static Profile Current
        {
            get { return _Current; }
            private set
            {
                // If a Profile is already loaded, let's make sure to dispose of it's resources
                if (Current != null)
                {
                    Current.Dispose();
                }

                _Current = value;
            }
        }

        internal static string Dir { get { return ProfilesDir; } }

        internal static void Init(string WorkDir)
        {
            // Set default paths
            ProfilesDir = WorkDir + "\\" + ProfilesDir;
            ProfilesFile = WorkDir + "\\" + ProfilesFile;

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

                // Load "last" profile
                Load("last");
            }
            else
            {
                // Create profiles.xml
                ProfilesXML.AppendChild(ProfilesXML.CreateXmlDeclaration("1.0", "UTF-8", null));
                ProfilesXML.AppendChild(ProfilesXML.CreateElement("Profiles"));

                // Create "last" profile (and save)
                Create("last");
            }
        }

        internal static void Create(string Name, string FileName = null)
        {
            // Default directory?
            if (string.IsNullOrEmpty(FileName))
            {
                FileName = ProfilesDir + Utilities.SanitizeFileName(Name) + ".xml";
            }

            // Create Profile XML file
            Current = Profile.Create(FileName);

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

        internal static bool Load(string Name)
        {
            XmlNode FileXMLElement = ProfilesXML.SelectSingleNode("/Profiles/Profile[@Name='" + Name + "']/File");

            // Profile exists in profiles?
            if (FileXMLElement == null)
            {
                return false;
            }

            return LoadFile(FileXMLElement.InnerText);
        }

        internal static bool LoadFile(string FileName)
        {
            // Profile exists?
            if (!File.Exists(FileName))
            {
                return false;
            }

            Current = Profile.Open(FileName);

            ProfileLoadedEventArgs e = new ProfileLoadedEventArgs
            {
                ProfileLoaded = Current
            };

            ProfileLoaded(null, e);

            return true;
        }
    }
}