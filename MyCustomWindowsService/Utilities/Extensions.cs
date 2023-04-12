using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.ServiceProcess;
using System.Text;

namespace MyCustomWindowsService.Utilities
{
    public static class Extensions
    {
        public static void WriteEventLog(this ServiceBase service, string eventLogIdentifier, string message, EventLogEntryType eventEntryType = EventLogEntryType.Information)
        {
            if (!EventLog.SourceExists(eventLogIdentifier))
            {
                try
                {
                    EventLog.CreateEventSource(eventLogIdentifier, "Application");
                }
                catch(Exception ex)
                {

                }
            }

            try
            {
                EventLog.WriteEntry(eventLogIdentifier, message, eventEntryType);
            }
            catch(Exception ex)
            {
                EventLog.WriteEntry(eventLogIdentifier, ex.Message, EventLogEntryType.Error);
            }

        }

        // Kotlin: fun <T, R> T.Let(block: (T) -> R): R
        public static R Let<T, R>(this T self, Func<T, R> block)
        {
            return block(self);
        }

        // Kotlin: fun <T> T.Also(block: (T) -> Unit): T
        public static T Also<T>(this T self, Action<T> block)
        {
            block(self);
            return self;
        }

        public static string Sha512(this string sourceString)
        {
            return Convert.ToBase64String(SHA512.Create().ComputeHash(UTF8Encoding.UTF8.GetBytes(sourceString)));
        }
    }
}
