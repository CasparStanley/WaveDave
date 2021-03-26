using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DaveSurfShop
{
    public class LocalEvent
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DateAndTime { get; set; }
        public string Location { get; set; }

        public LocalEvent(string name, DateTime eventDateTime, string location)
        {
            Name = name;
            DateAndTime = eventDateTime;
            Location = location;
        }
    }
}
