using System;


namespace UALMonitor.BusinessObjects
{
    public class LogFileInfo
    {
        private int _loginidlength;

        public  LogFileInfo()
        {
        }

        public string ServerName { get; set; }
        public string Name { get; set; }
        public long Size { get; set; }
        public DateTime FileCreated { get; set; }
        public DateTime FileUpdated { get; set; }

        public string FullPath { get; set; }
        public string PartialLogFileName
        {
            get
            {
                if(Name.IndexOf("-")>0)
                    return Name.Substring(0, Name.IndexOf("-")-9);
                return Name;
            }
        }
    }
}
