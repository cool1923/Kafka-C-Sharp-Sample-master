using System;

namespace Kafka.Data.Models
{
    public class Msg
    {
        public string User { get; set; }

        public string Message { get; set; }

        public DateTime? TimeStamp { get; set; }
    }
}
