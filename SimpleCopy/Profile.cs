using System.IO;
using System.Timers;
using System.Xml.Serialization;

namespace SimpleCopy
{
    public class Profile
    {
        private static readonly XmlSerializer SerializerXML = new XmlSerializer(typeof(Profile));
        private readonly Timer SaveTimer = new Timer(1000);

        internal static Profile Load(string FileName)
        {
            Profile _Profile;

            // Desearilize XML file to Profile object
            using (FileStream _FileStream = File.Open(FileName, FileMode.Open))
            {
                _Profile = (Profile)SerializerXML.Deserialize(_FileStream);
            }

            // Manually set FileName (necessary for saving)
            _Profile.FileName = FileName;

            return _Profile;
        }

        internal static Profile Create(string FileName)
        {
            Profile _Profile = new Profile();

            _Profile.FileName = FileName;

            _Profile.Save();

            return _Profile;
        }

        public Profile()
        {
            SaveTimer.AutoReset = false;
            SaveTimer.Elapsed += SaveTimer_Elapsed;
        }

        internal void Dispose()
        {
            if (SaveTimer.Enabled)
            {
                SaveTimer.Stop();
                SaveTimer_Elapsed(this, null);
            }

            SaveTimer.Dispose();
        }

        internal void Save()
        {
            // Do not attempt to save during initialization (terrible implementation, but it works)
            if (!Initialized) return;

            // If timer is already running, let's stop it
            if (SaveTimer.Enabled) SaveTimer.Stop();

            //
            SaveTimer.Start();
        }

        private void SaveTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            // Searilize current Profile object to XML file
            using (FileStream _FileStream = File.Open(FileName, FileMode.Create))
            {
                SerializerXML.Serialize(_FileStream, this);
            }
        }

        [XmlIgnore]
        internal bool Initialized
        {
            get { return (!string.IsNullOrEmpty(FileName)); }
        }

        [XmlIgnore]
        internal string FileName { get; set; }

        // Default values
        private string _Source = null;

        private string _Destination = null;
        private string _FileFilter = "*.*";
        private bool _CopySubdirectories = true;
        private bool _CopySubdirectoriesIncludingEmpty = false;
        private bool _EnableRestartMode = false;
        private bool _EnableBackupMode = false;
        private bool _UseUnbufferedIo = false;
        private bool _EnableEfsRawMode = false;
        private bool _Mirror = false;
        private bool _Purge = false;
        private int _Depth = -1;
        private string _CopyFlags = "DAT";
        private bool _CopyFilesWithSecurity = false;
        private bool _CopyAll = false;
        private bool _RemoveFileInformation = false;
        private bool _FixFileSecurityOnAllFiles = false;
        private bool _FixFileTimesOnAllFiles = false;
        private bool _MoveFiles = false;
        private bool _MoveFilesAndDirectories = false;

        // Getter/Setters
        public string Source
        {
            get { return _Source; }
            set { _Source = value; Save(); }
        }

        public string Destination
        {
            get { return _Destination; }
            set { _Destination = value; Save(); }
        }

        public string FileFilter
        {
            get { return _FileFilter; }
            set { _FileFilter = value; Save(); }
        }

        public bool CopySubdirectories
        {
            get { return _CopySubdirectories; }
            set { _CopySubdirectories = value; Save(); }
        }

        public bool CopySubdirectoriesIncludingEmpty
        {
            get { return _CopySubdirectoriesIncludingEmpty; }
            set { _CopySubdirectoriesIncludingEmpty = value; Save(); }
        }

        public bool EnableRestartMode
        {
            get { return _EnableRestartMode; }
            set { _EnableRestartMode = value; Save(); }
        }

        public bool EnableBackupMode
        {
            get { return _EnableBackupMode; }
            set { _EnableBackupMode = value; Save(); }
        }

        public bool UseUnbufferedIo
        {
            get { return _UseUnbufferedIo; }
            set { _UseUnbufferedIo = value; Save(); }
        }

        public bool EnableEfsRawMode
        {
            get { return _EnableEfsRawMode; }
            set { _EnableEfsRawMode = value; Save(); }
        }

        public bool Mirror
        {
            get { return _Mirror; }
            set { _Mirror = value; Save(); }
        }

        public bool Purge
        {
            get { return _Purge; }
            set { _Purge = value; Save(); }
        }

        public int Depth
        {
            get { return _Depth; }
            set { _Depth = value; Save(); }
        }

        public string CopyFlags
        {
            get { return _CopyFlags; }
            set { _CopyFlags = value; Save(); }
        }

        public bool CopyFilesWithSecurity
        {
            get { return _CopyFilesWithSecurity; }
            set { _CopyFilesWithSecurity = value; Save(); }
        }

        public bool CopyAll
        {
            get { return _CopyAll; }
            set { _CopyAll = value; Save(); }
        }

        public bool RemoveFileInformation
        {
            get { return _RemoveFileInformation; }
            set { _RemoveFileInformation = value; Save(); }
        }

        public bool FixFileSecurityOnAllFiles
        {
            get { return _FixFileSecurityOnAllFiles; }
            set { _FixFileSecurityOnAllFiles = value; Save(); }
        }

        public bool FixFileTimesOnAllFiles
        {
            get { return _FixFileTimesOnAllFiles; }
            set { _FixFileTimesOnAllFiles = value; Save(); }
        }

        public bool MoveFiles
        {
            get { return _MoveFiles; }
            set { _MoveFiles = value; Save(); }
        }

        public bool MoveFilesAndDirectories
        {
            get { return _MoveFilesAndDirectories; }
            set { _MoveFilesAndDirectories = value; Save(); }
        }
    }
}