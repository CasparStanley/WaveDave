using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DaveSurfShop.MockData
{
    public class MockData
    {
        public static List<LocalEvent> events = new List<LocalEvent>()
        {
            new LocalEvent("420, birthday", new DateTime(2021, 4, 20),"Berlin"),
            new LocalEvent("Summer of 69 party", new DateTime(2021, 6, 4), "The love dungeon"),
            new LocalEvent("It happens now", DateTime.Now, "Just here"),
            new LocalEvent("Too late mate", new DateTime(1999, 12, 31), "Y2K beach")
        };

        public List<LocalEvent> GetEvents()
        {
            return events;
        }
    }
}
