namespace SimpleCopy
{
    public class JobList
    {
        public Job[] Jobs { get; set; }
    }

    public class Job
    {
        public int FileCount { get; set; }
        public long TotalFileSize { get; set; }
        public long TotalTime { get; set; } // milliseconds
    }
}