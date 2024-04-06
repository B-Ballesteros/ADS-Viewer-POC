using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS_Viewer.Utilities
{
    internal class LogEntry
    {
        public uint EntryId;
        public DateTime EntryTimeStamp;
        public required string EntryText;
    }
}
