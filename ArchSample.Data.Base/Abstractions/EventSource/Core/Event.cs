using System;
using System.Collections.Generic;
using System.Text;

namespace ArchSample.Data.Base.Abstractions.EventSource.Core
{
    public abstract class Event
    {
        public DateTime Timestamp { get; private set; }

        public string Origin { get; protected internal set; }
        public string RecordId { get; protected internal set; }

        protected Event()
        {
            Timestamp = DateTime.Now;
        }
    }
}
