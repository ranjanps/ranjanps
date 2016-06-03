using System.IO;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using System;
using System.Collections.Generic;
using UALMonitor.BusinessObjects;
using System.Xml;
using System.Linq;

namespace UALMonitor
{
    public class UALCommon
    {

        private DateTime startTime;
        private DateTime endTime;
        private List<LogFileInfo> _logFiles;

        public UALCommon()
        {
            _logFiles = new List<LogFileInfo>();
        }


        public List<Server> GetServerList(string serverListPath)
        {
            var servers = new List<Server>();
            string serverName, ualPath;
            var xml = new XmlDocument();
            xml.Load(serverListPath);


            foreach (XmlNode rootNode in xml.ChildNodes)
            {
                foreach (XmlNode serverNode in rootNode)
                {
                    serverName = "";
                    ualPath = "";

                    foreach (XmlNode innerNode in serverNode)
                    {
                        if (innerNode.Name == "Name")
                            serverName = innerNode.InnerText;

                        if (innerNode.Name == "UALPath")
                            ualPath = innerNode.InnerText;
                    }
                    if (serverName != "")
                        servers.Add(new Server { Name = serverName, UALPath = ualPath });
                }
            }

            return servers;
        }


        public  bool FindMatch(string content, string pattern)
        {
            MatchCollection coll = Regex.Matches(content, pattern, RegexOptions.IgnoreCase);
            return (coll.Count > 0);
        }

        public  void CopyLogs(string sourceFolder, string fileName, string dest, string serverName)
        {
            string sourcePath = sourceFolder + fileName;
            string destPath = dest + "\\\\" + serverName + "-" + fileName;

            if (File.Exists(sourcePath) && Directory.Exists(dest))
                File.Copy(sourcePath, destPath, true);
        }


        private void ClearFormat(System.Windows.Forms.RichTextBox rtbFileContent)
        {
            string content = rtbFileContent.Text;
            rtbFileContent.Clear();
            rtbFileContent.Text = content;
        }


        private void ParseTheLog(System.Windows.Forms.RichTextBox rtbFileContent)
        {
            int iStartPos, iEndPos;
            MatchCollection coll = Regex.Matches(rtbFileContent.Text, "EXECUTED:", RegexOptions.IgnoreCase);

            int iTotal = coll.Count;

            for (int i = 0; i < iTotal - 1; i += 2)
            {
                Match m = coll[i];
                iStartPos = m.Index;
                iEndPos = rtbFileContent.Text.IndexOf("\n", iStartPos + 5);
                if (iEndPos > iStartPos)
                {
                    rtbFileContent.Select(iStartPos, iEndPos - iStartPos);
                    rtbFileContent.SelectionBackColor = Color.Orange;
                }


                m = coll[i + 1];
                iStartPos = m.Index;
                iEndPos = rtbFileContent.Text.IndexOf("\n", iStartPos + 5);
                if (iEndPos > iStartPos)
                {
                    rtbFileContent.Select(iStartPos, iEndPos - iStartPos);
                    rtbFileContent.SelectionBackColor = Color.PaleTurquoise;
                }
            }
        }


       
        public List<LogFileInfo> GetFiles(DateTime startTime, DateTime endTime, string serverName, string ualPath, string searchText = "", string agentid = "")
        {
            var logFiles = new List<LogFileInfo>();
            var t = new ThreadStart(() =>
            {
                string pattern;

                if (agentid == "")
                    pattern = "*.log";
                else
                    pattern = agentid + "*.log";


                DirectoryInfo di = new DirectoryInfo(ualPath);
                if (di.Exists)
                {
                    var files = di.GetFiles(pattern);
                    
                    IEnumerable<System.IO.FileInfo> fileList = di.GetFiles(pattern);

                    var logs = (from file in fileList
                               where file.LastWriteTime >= startTime && file.LastWriteTime <= endTime
                               select new LogFileInfo()
                               {
                                   ServerName = serverName,
                                   Name = file.Name,
                                   FileCreated = file.CreationTime,
                                   FileUpdated = file.LastWriteTime,
                                   Size = file.Length / 1024,
                                   FullPath = file.FullName
                               }).Take(50).ToList<LogFileInfo>();

                    if (searchText != "")
                    {
                        logFiles = (from f in logs
                                    where GetFileContent(f.FullPath).Contains(searchText)
                                    select f).ToList<LogFileInfo>();
                    }
                    else
                        logFiles = logs;
                }
            });
            t.Invoke();
            return logFiles;
        }

        public List<LogFileInfo> GetFiles(string serverName, string ualPath, string searchText = "", string agentid = "")
        {
            var logFiles = new List<LogFileInfo>();

            var t = new ThreadStart(() =>
            {
                string pattern;

                if (agentid == "")
                    pattern = "*.log";
                else
                {
                    pattern = agentid + "*.log";
                }


                DirectoryInfo di = new DirectoryInfo(ualPath);
                if (di.Exists)
                {
                    var files = di.GetFiles(pattern);
                    foreach (var file in files)
                    {
                        if (GetFileContent(file.FullName).Contains(searchText))
                            _logFiles.Add(
                              new LogFileInfo()
                              {
                                  ServerName = serverName,
                                  Name = file.Name,
                                  FileCreated = file.CreationTime,
                                  FileUpdated = file.LastWriteTime,
                                  Size = file.Length / 1024
                              });
                    }
                }
            });

            t.Invoke();

            return logFiles;
        }

        
        public string GetFileContent(string fileName)
        {
            string strContent = "";
            var t = new ThreadStart(() =>
            {
                FileInfo fl = new FileInfo(fileName);
                if (fl.Exists)
                {
                    StreamReader sm = new StreamReader(fileName);
                    strContent = sm.ReadToEnd();
                    sm.Close();
                }
            });
            t.Invoke();

            return strContent;
        }
    }
}
