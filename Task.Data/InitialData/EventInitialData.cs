using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Data.Models;

namespace Task.Data.InitialData
{
    public static class EventInitialData
    {
        public static List<Event> DataSeed = new List<Event>
        {
            new Event {
                Id = 1,
                Timestamp= DateTime.Now,
                Level = "Information",
                MessageTemplate = "Logging {@User} from {Location}",
                RenderedMessage = "Logging { UserName: \"Mike\"}",
                Location = new Location
                {
                     User = new User { UserName = "Antanas"},
                     Address = "Gedimino pr. 16, Vilnius, Lithuania",
                     Latitude = "54.687157",
                     Longitude =  "25.279652",
                     Retries = +1,
                },
                
            },
        };
    }
}
