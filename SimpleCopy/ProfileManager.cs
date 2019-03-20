using System;
using System.IO;
using System.Xml;

namespace SimpleCopy
{
    internal class ProfileLoadedEventArgs : EventArgs
    {
        internal Profile ProfileLoaded { get; set; }
    }

    internal static class ProfileManager
    {
        internal static event EventHandler<ProfileLoadedEventArgs> ProfileLoaded;

        private static readonly XmlDocument ProfilesXML = new XmlDocument();

        internal static string ProfilesDirectory { get; private set; } = "profiles";

        internal static string ProfilesFile { get; private set; } = "profiles.xml";

        #region Current Profile

        internal static string CurrentName { get; private set; }

        internal static Profile CurrentProfile { get; private set; }

        internal static void SetCurrentName(string Name)
        {
            XmlElement ProfileXML = (XmlElement)ProfilesXML.SelectSingleNode("/Profiles/Profile[@Name='" + CurrentName + "']");

            ProfileXML.SetAttribute("Name", Name);

            CurrentName = Name;
        }

        private static void SetCurrent(string Name, Profile _Profile, bool SetLast = true)
        {
            // Name
            CurrentName = Name;

            // Profile
            if (CurrentProfile != null)
            {
                CurrentProfile.Dispose();
            }

            CurrentProfile = _Profile;

            // Update LastOpened element for Profile
            XmlNode LastOpenedXMLElement = ProfilesXML.SelectSingleNode("/Profiles/Profile[@Name='" + Name + "']/LastOpened");
            LastOpenedXMLElement.InnerText = DateTime.Now.ToUniversalTime().ToString();

            // Should we set the last used Profile (by Name)
            if (SetLast)
            {
                Last = Name;
            }
            else
            {
                Save();
            }
        }

        #endregion

        internal static string Last
        {
            get
            {
                return ProfilesXML.SelectSingleNode("/Profiles/Last").InnerText;
            }
            private set
            {
                XmlNode LastProfile = ProfilesXML.SelectSingleNode("/Profiles/Last");

                LastProfile.InnerText = value;

                Save();
            }
        }

        internal static void Init(string WorkDir)
        {
            // Set default paths
            ProfilesDirectory = WorkDir + "\\" + ProfilesDirectory;
            ProfilesFile = WorkDir + "\\" + ProfilesFile;

            // Profiles folder missing?
            if (!Directory.Exists(ProfilesDirectory))
            {
                Directory.CreateDirectory(ProfilesDirectory);
            }

            ProfilesDirectory += "\\";

            // Already initialized?
            if (File.Exists(ProfilesFile))
            {
                // Load profiles
                ProfilesXML.Load(ProfilesFile);

                // Load "Default" profile
                Load(Last, false);
            }
            else
            {
                // Create profiles.xml
                ProfilesXML.AppendChild(ProfilesXML.CreateXmlDeclaration("1.0", "UTF-8", null));

                XmlElement Profiles = ProfilesXML.CreateElement("Profiles");

                XmlElement LastProfile = ProfilesXML.CreateElement("Last");
                LastProfile.InnerText = "Default";
                Profiles.AppendChild(LastProfile);

                ProfilesXML.AppendChild(Profiles);

                // Create "Default" profile (and save)
                Create("Default");
                Load("Default");
            }
        }

        internal static void Save()
        {
            // Save Profiles XML
            ProfilesXML.Save(ProfilesFile);
        }

        internal static void Create(string Name, string FileName = null)
        {
            // Default directory?
            if (string.IsNullOrEmpty(FileName))
            {
                FileName = ProfilesDirectory + Utilities.SanitizeFileName(Name).ToLower() + ".xml";
            }

            // Create Profile XML file
            if (!File.Exists(FileName))
            {
                Profile.Create(FileName);
            }

            // Create Profile element (adding Name as an attribute)
            XmlElement ProfileXMLElement = ProfilesXML.CreateElement("Profile");
            ProfileXMLElement.SetAttribute("Name", Name);

            // Create FileName element in Profile
            XmlElement FileXML = ProfilesXML.CreateElement("File");
            FileXML.InnerText = FileName;
            ProfileXMLElement.AppendChild(FileXML);

            // Create LastOpened element in Profile
            XmlElement LastUsedXML = ProfilesXML.CreateElement("LastOpened");
            ProfileXMLElement.AppendChild(LastUsedXML);

            // Append new Profile element to ProfilesXML
            ProfilesXML.SelectSingleNode("/Profiles").AppendChild(ProfileXMLElement);

            Save();
        }

        internal static bool Load(string Name, bool SetLast = true)
        {
            XmlNode FileXMLElement = ProfilesXML.SelectSingleNode("/Profiles/Profile[@Name='" + Name + "']/File");

            // Profile exists in profiles?
            if (FileXMLElement == null)
            {
                return false;
            }

            return LoadFile(FileXMLElement.InnerText, Name, SetLast);
        }

        internal static bool LoadFile(string FileName, string Name = null, bool SetLast = true)
        {
            // Profile exists?
            if (!File.Exists(FileName))
            {
                return false;
            }

            // If Profile is loaded via Name it will be available via the parameters
            if (string.IsNullOrEmpty(Name))
            {
                Name = Path.GetFileNameWithoutExtension(FileName);

                Create(Name, FileName);
            }

            // Set Current Profile, Current Profile LastOpened, & Last Profile (for next time)
            SetCurrent(Name, Profile.Open(FileName), SetLast);

            // Emit ProfileLoaded event
            ProfileLoaded(null, new ProfileLoadedEventArgs
            {
                ProfileLoaded = CurrentProfile
            });

            return true;
        }
    }
}