using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ADS_Viewer.Utilities
{
    internal class Logger
    {
        private readonly Queue<LogEntry> log;
        private uint entryNumber;
        private readonly uint maxEntries;
        private readonly object logLock = new();


        public Logger(uint maxEntries)
        {
            log = new Queue<LogEntry>();
            this.maxEntries = maxEntries;
        }

        public void AddToLog(string text)
        {
            lock(logLock)
            {
                if (entryNumber >= uint.MaxValue)
                {
                    entryNumber = 0;
                    
                }
                entryNumber++;
                LogEntry entry = new LogEntry
                {
                    EntryId = entryNumber,
                    EntryTimeStamp = DateTime.Now,
                    EntryText = text,
                };
                log.Enqueue(entry);
                while (log.Count > maxEntries)
                {
                    log.Dequeue();
                }
            }
        }

        public void Clear()
        {
            lock(logLock)
            {
                log.Clear();
            }
        }

        public string GetLogAsText(bool includeEntryNumbers) {
            lock (logLock)
            {
                StringBuilder sb = new StringBuilder();
                foreach(LogEntry entry in log)
                {
                    if (includeEntryNumbers) 
                    {
                        sb.Append($"{ entry.EntryId }. ");
                    }
                    sb.Append($"{entry.EntryTimeStamp.ToShortDateString()} {entry.EntryTimeStamp.ToShortTimeString()}: ");
                    sb.Append(entry.EntryText).AppendLine();
                }
                return sb.ToString();
            }
        }

    }
}
