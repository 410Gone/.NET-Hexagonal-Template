using System;

namespace ConsoleApp4
{
    public class EventModel
    {
        public DateTimeOffset Date { get; internal set; }
        public bool ShouldSendMail { get; internal set; }
        public string Type { get; internal set; }
    }
}