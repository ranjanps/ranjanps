
namespace UALMonitor.BusinessObjects
{
    public class TelnetSession
    {
        public string Id { get; set; }
        public string Domain { get; set; }
        public string UserName { get; set; }
        public string Client { get; set; }
        public string LogonDate { get; set; }
        public string LogonTime { get; set; }
        public string IdleTime { get; set; }
    }
}
