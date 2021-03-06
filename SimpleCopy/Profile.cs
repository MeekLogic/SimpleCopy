﻿using System.IO;
using System.Timers;
using System.Xml.Serialization;

namespace SimpleCopy
{
    public class Profile
    {
        private static readonly XmlSerializer SerializerXML = new XmlSerializer(typeof(Profile));
        private readonly Timer SaveTimer = new Timer(1000);

        internal static Profile Open(string FileName)
        {
            Profile _Profile;

            // Desearilize XML file to Profile object
            using (FileStream _FileStream = File.Open(FileName, FileMode.Open))
            {
                _Profile = (Profile)SerializerXML.Deserialize(_FileStream);
            }

            // Manually set Name & FileName (necessary for saving)
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

        internal void Save()
        {
            // Do not attempt to save during initialization (terrible implementation, but it works)
            if (!Initialized) return;

            // If timer is already running, let's stop it
            if (SaveTimer.Enabled) SaveTimer.Stop();

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

        internal void Dispose()
        {
            if (SaveTimer.Enabled)
            {
                SaveTimer.Stop();
                SaveTimer_Elapsed(this, null);
            }

            SaveTimer.Dispose();
        }

        [XmlAttribute]
        public string Version { get; set; } = "0.0.0.1";

        [XmlIgnore]
        internal bool Initialized
        {
            get { return (!string.IsNullOrEmpty(FileName)); }
        }

        [XmlIgnore]
        internal string FileName { get; set; }

        #region Copy Options

        private string _Source = null;
        private string _Destination = null;
        private string _FileFilter = "*.*";
        private bool _CopySubdirectories = false;
        private bool _CopySubdirectoriesIncludingEmpty = false;
        private bool _EnableRestartMode = false;
        private bool _EnableBackupMode = false;
        private bool _UseUnbufferedIo = false;
        private bool _EnableEfsRawMode = false;
        private bool _Mirror = false;
        private bool _Purge = false;
        private int _Depth = -1;

        private CopyFlags _FileCopyFlags = new CopyFlags
        {
            Data = true,
            Attributes = true,
            TimeStamps = true
        };

        private CopyFlags _DirectoryCopyFlags = new CopyFlags
        {
            Data = true,
            Attributes = true
        };

        private bool _CopyFilesWithSecurity = false;
        private bool _CopyAll = false;
        private bool _RemoveFileInformation = false;
        private bool _FixFileSecurityOnAllFiles = false;
        private bool _FixFileTimesOnAllFiles = false;
        private bool _MoveFiles = false;
        private bool _MoveFilesAndDirectories = false;
        private FileAttributes _AddAttributes = new FileAttributes();
        private FileAttributes _RemoveAttributes = new FileAttributes();
        private bool _CreateDirectoryAndFileTree = false;
        private bool _FatFiles = false;
        private bool _TurnLongPathSupportOff = false;
        private int _MonitorSourceChangesLimit = 0;
        private int _MonitorSourceTimeLimit = 0;
        private string _RunHours = null;
        private bool _CheckPerFile = false;
        private int _InterPacketGap = 0;
        private bool _CopySymbolicLink = false;
        private int _MultiThreadedCopiesCount = 0;
        private bool _DoNotCopyDirectoryInfo = false;
        private bool _DoNotUseWindowsCopyOffload = false;

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

        public CopyFlags FileCopyFlags
        {
            get { return _FileCopyFlags; }
            set { _FileCopyFlags = value; Save(); }
        }

        public CopyFlags DirectoryCopyFlags
        {
            get { return _DirectoryCopyFlags; }
            set { _DirectoryCopyFlags = value; Save(); }
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

        public FileAttributes AddAttributes
        {
            get { return _AddAttributes; }
            set { _AddAttributes = value; Save(); }
        }

        public FileAttributes RemoveAttributes
        {
            get { return _RemoveAttributes; }
            set { _RemoveAttributes = value; Save(); }
        }

        public bool CreateDirectoryAndFileTree
        {
            get { return _CreateDirectoryAndFileTree; }
            set { _CreateDirectoryAndFileTree = value; Save(); }
        }

        public bool FatFiles
        {
            get { return _FatFiles; }
            set { _FatFiles = value; Save(); }
        }

        public bool TurnLongPathSupportOff
        {
            get { return _TurnLongPathSupportOff; }
            set { _TurnLongPathSupportOff = value; Save(); }
        }

        public int MonitorSourceChangesLimit
        {
            get { return _MonitorSourceChangesLimit; }
            set { _MonitorSourceChangesLimit = value; Save(); }
        }

        public int MonitorSourceTimeLimit
        {
            get { return _MonitorSourceTimeLimit; }
            set { _MonitorSourceTimeLimit = value; Save(); }
        }

        public string RunHours
        {
            get { return _RunHours; }
            set { _RunHours = value; Save(); }
        }

        public bool CheckPerFile
        {
            get { return _CheckPerFile; }
            set { _CheckPerFile = value; Save(); }
        }

        public int InterPacketGap
        {
            get { return _InterPacketGap; }
            set { _InterPacketGap = value; Save(); }
        }

        public bool CopySymobolicLink
        {
            get { return _CopySymbolicLink; }
            set { _CopySymbolicLink = value; Save(); }
        }

        public int MultiThreadedCopiesCount
        {
            get { return _MultiThreadedCopiesCount; }
            set { _MultiThreadedCopiesCount = value; Save(); }
        }

        public bool DoNotCopyDirectoryInfo
        {
            get { return _DoNotCopyDirectoryInfo; }
            set { _DoNotCopyDirectoryInfo = value; Save(); }
        }

        public bool DoNotUseWindowsCopyOffload
        {
            get { return _DoNotUseWindowsCopyOffload; }
            set { _DoNotUseWindowsCopyOffload = value; Save(); }
        }

        #endregion Copy Options

        #region Retry Options

        // Rety options
        private int _RetryCount = 10;

        private int _RetryWaitTime = 30;

        public int RetryCount
        {
            get { return _RetryCount; }
            set { _RetryCount = value; Save(); }
        }

        public int RetryWaitTime
        {
            get { return _RetryWaitTime; }
            set { _RetryWaitTime = value; Save(); }
        }

        #endregion Retry Options
    }
}