namespace SimpleCopy
{
    public class JobList
    {
        public Job[] Jobs { get; set; }
    }

    public class Job
    {
        public long TotalBytes { get; set; }
        public int TotalFiles { get; set; }
        public long TotalMillseconds { get; set; } // milliseconds
    }
}