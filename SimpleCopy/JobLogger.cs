using System.IO;
using System.Xml.Serialization;

namespace SimpleCopy
{
    internal static class JobLogger
    {
        private static string JobLog = "jobs.xml";
        private static readonly XmlSerializer _XmlSerializer = new XmlSerializer(typeof(JobList));

        internal static void Init(string WorkDir)
        {
            JobLog = WorkDir + "\\" + JobLog;
            
            if (!File.Exists(JobLog)) Save(new JobList());
        }

        internal static JobList JobList
        {
            get
            {
                JobList _JobList;

                using (FileStream _FileStream = File.Open(JobLog, FileMode.Open))
                {
                    _JobList = (JobList)_XmlSerializer.Deserialize(_FileStream);
                }

                return _JobList;
            }
        }

        private static void Save(JobList Jobs)
        {
            using (FileStream _FileStream = File.Open(JobLog, FileMode.Create))
            {
                _XmlSerializer.Serialize(_FileStream, Jobs);
            }
        }

        internal static void Log(Job Job)
        {
            JobList _Temp = JobList;

            int length = 1;
            if (_Temp.Jobs != null)
            {
                length = _Temp.Jobs.Length;
            }
            
            JobList _JobList = new JobList
            {
                Jobs = new Job[length + 1]
            };

            if (_Temp.Jobs != null) _Temp.Jobs.CopyTo(_JobList.Jobs, 0);

            _Temp = null;

            _JobList.Jobs[length] = Job;

            Save(_JobList);

            _JobList = null;
        }
    }
}