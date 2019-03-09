using System;
using System.IO;
using System.Xml;

namespace SimpleCopy
{
    class Profile
    {
        private string filename;
        private XmlDocument _xmlDocument;

        public Profile(string filename)
        {
            this.filename = filename;

            _xmlDocument = new XmlDocument();

            // Profile initialized?
            if (File.Exists(this.filename))
            {
                _xmlDocument.Load(this.filename);
            }
            else
            {
                // Create profile xml
                _xmlDocument.AppendChild(_xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null));

                XmlElement profile = _xmlDocument.CreateElement("Profile");
                _xmlDocument.AppendChild(profile);

                profile.AppendChild(_xmlDocument.CreateElement("Source"));
                //
                profile.AppendChild(_xmlDocument.CreateElement("Destination"));
                //
                XmlElement setting = _xmlDocument.CreateElement("CopySubdirectories");
                setting.InnerText = "True";
                profile.AppendChild(setting);
                //
                setting = _xmlDocument.CreateElement("CopySubdirectoriesIncludingEmpty");
                setting.InnerText = "False";
                profile.AppendChild(setting);
                //
                setting = _xmlDocument.CreateElement("EnableRestartMode");
                setting.InnerText = "False";
                profile.AppendChild(setting);
                //
                setting = _xmlDocument.CreateElement("EnableBackupMode");
                setting.InnerText = "False";
                profile.AppendChild(setting);
                //
                setting = _xmlDocument.CreateElement("UseUnbufferedIo");
                setting.InnerText = "False";
                profile.AppendChild(setting);
                //
                setting = _xmlDocument.CreateElement("EnableEfsRawMode");
                setting.InnerText = "False";
                profile.AppendChild(setting);
                //
                setting = _xmlDocument.CreateElement("Mirror");
                setting.InnerText = "True";
                profile.AppendChild(setting);
                //
                setting = _xmlDocument.CreateElement("Purge");
                setting.InnerText = "False";
                profile.AppendChild(setting);
                //
                setting = _xmlDocument.CreateElement("FileFilter");
                setting.InnerText = "*.*";
                profile.AppendChild(setting);

                _xmlDocument.Save(filename);
            }
        }

        private string _get(string elementName)
        {
            return _xmlDocument.SelectSingleNode("/Profile/" + elementName).InnerText;
        }

        private void _set(string elementName, string value)
        { 
            _xmlDocument.SelectSingleNode("/Profile/" + elementName).InnerText = value;

            _xmlDocument.Save(filename);
        }

        public string Source
        {
            get { return _get("Source"); }
            set { _set("Source", value); }
        }

        public string Destination
        {
            get { return _get("Destination"); }
            set { _set("Destination", value); }
        }

        public string FileFilter
        {
            get { return _get("FileFilter"); }
            set { _set("FileFilter", value); }
        }

        public bool CopySubdirectories
        {
            get { return Convert.ToBoolean(_get("CopySubdirectories")); }
            set { _set("CopySubdirectories", value.ToString()); }
        }

        public bool CopySubdirectoriesIncludingEmpty
        {
            get { return Convert.ToBoolean(_get("CopySubdirectoriesIncludingEmpty")); }
            set { _set("CopySubdirectoriesIncludingEmpty", value.ToString()); }
        }

        public bool EnableRestartMode
        {
            get { return Convert.ToBoolean(_get("EnableRestartMode")); }
            set { _set("EnableRestartMode", value.ToString()); }
        }

        public bool EnableBackupMode
        {
            get { return Convert.ToBoolean(_get("EnableBackupMode")); }
            set { _set("EnableBackupMode", value.ToString()); }
        }

        public bool UseUnbufferedIo
        {
            get { return Convert.ToBoolean(_get("UseUnbufferedIo")); }
            set { _set("UseUnbufferedIo", value.ToString()); }
        }

        public bool EnableEfsRawMode
        {
            get { return Convert.ToBoolean(_get("EnableEfsRawMode")); }
            set { _set("EnableEfsRawMode", value.ToString()); }
        }

        public bool Mirror
        {
            get { return Convert.ToBoolean(_get("Mirror")); }
            set { _set("Mirror", value.ToString()); }
        }

        public bool Purge
        {
            get { return Convert.ToBoolean(_get("Purge")); }
            set { _set("Purge", value.ToString()); }
        }
    }
}
