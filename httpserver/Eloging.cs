using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace httpserver
{
    class Eloging
    {
        public const string sSource = "Stripp og Svendsen server";
        public const string sLog = "Application";

        public static void Ewriting(string logMessage, string entryType)
        {
            using (EventLog log = new EventLog(sLog))
            {
                log.Source = sSource;

                if (entryType == "Information")
                {
                    log.WriteEntry(logMessage, EventLogEntryType.Information);
                }
                else if (entryType == "Error")
                {
                    log.WriteEntry(logMessage, EventLogEntryType.Error);
                }
                else if (entryType == "Warning")
                {
                    log.WriteEntry(logMessage, EventLogEntryType.Warning);
                }
               
              
            }
        }
    }
}
