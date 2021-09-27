using System;
using HomeWorkTask.Data.Models;

namespace HomeWorkTask.Data.InitialData
{
    public static class EventInitialData
    {
        public static Event DataSeed =
        
            new Event
            {
                //Id = 1,
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
                }
            };
    }
}

//            new Event {
//                //Id = 2,
//                Timestamp= DateTime.Now,
//                Level = "Warning",
//                MessageTemplate = "Logging {@User} from {Location}",
//                RenderedMessage = "Logging { UserName: \"Vardenis\"}",
//                Location = new Location
//                {
//                     User = new User { UserName = "Vardenis"},
//                     Address = "Vytauto pr. 22, Kaunas, Lithuania",
//                     Latitude = "53.68327",
//                     Longitude =  "25.245652",
//                     Retries = +1,
//                },
//            },
//            new Event {
//                //Id = 3,
//                Timestamp= DateTime.Now,
//                Level = "Error",
//                MessageTemplate = "Logging {@User} from {Location}",
//                RenderedMessage = "Logging { UserName: \"John\"}",
//                Location = new Location
//                {
//                     User = new User { UserName = "Jonas"},
//                     Address = "Taikos pr. 12, Klaipeda, Lithuania",
//                     Latitude = "53.68123",
//                     Longitude =  "25.244562",
//                     Retries = +1,
//                },
//            },
//        };
//    }
//}
