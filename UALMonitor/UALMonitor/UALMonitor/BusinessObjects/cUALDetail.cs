namespace UALMonitor.BusinessObjects
{
    public class CUalDetail
    {
        public string CommandOutput { get; set; }
        public string CommandStartTime { get; set; }
        public string CommandEndTime { get; set; }
        public int StartPos { get; set; }

        public double TimeTaken { get; set; }
    }
}
