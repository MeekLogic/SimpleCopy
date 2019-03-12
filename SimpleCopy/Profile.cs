using System.Xml.Serialization;
using System.IO;

namespace SimpleCopy
{
    public class Profile
    {
        private static XmlSerializer SerializerXML = new XmlSerializer(typeof(Profile));

        public static Profile FromFile(string FileName)
        {
            Profile _Profile;

            using (FileStream _FileStream = File.Open(FileName, FileMode.Open))
            {
                _Profile = (Profile)SerializerXML.Deserialize(_FileStream);
            }

            _Profile.FileName = FileName;

            return _Profile;
        }

        public void Save()
        {
            // Do not attempt to save during initialization (terrible implementation, but it works)
            if (!Initialized) return;

            using (FileStream _FileStream = File.Open(FileName, FileMode.Truncate))
            {
                SerializerXML.Serialize(_FileStream, this);
            }
        }

        [XmlIgnore]
        public bool Initialized
        {
            get { return (!string.IsNullOrEmpty(FileName)); }
        }

        [XmlIgnore]
        public string FileName { get; set; }

        #region XML Elements

        // Default values
        private string _Source;
        private string _Destination;
        private string _FileFilter = "*.*";
        private bool _CopySubdirectories = true;
        private bool _CopySubdirectoriesIncludingEmpty = false;
        private bool _EnableRestartMode = false;
        private bool _EnableBackupMode = false;
        private bool _UseUnbufferedIo = false;
        private bool _EnableEfsRawMode = false;
        private bool _Mirror = false;
        private bool _Purge = false;

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

        #endregion
    }
}
