using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Meeting
    {
        private static string _eventURL = string.Format("https://api.meetup.com/2/events?&sign=true&photo-host=public&group_urlname=ONETUG&page=20&key={0}", ConfigurationManager.AppSettings["MeetupAPI"]);

        public string VenueName { get; set; }
        public string VenueAddress { get; set; }
        public int NumberRSVPedYes { get; set; }
        public string MeetingDescriptionHTML { get; set; }
        public string MeetingTime { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }

        public Meeting()
        {

        }

        public static List<Meeting> GetUpcomingMeetings()
        {
            List<Meeting> meetings = new List<Meeting>();
            string jsonResponse = ONETUGRequest.GetResponse(_eventURL);
            dynamic d = JObject.Parse(jsonResponse);
            foreach (var result in d.results)
            {
                Meeting meeting = new Meeting { 
                    VenueName = result.venue.name,
                    VenueAddress = string.Format("{0} {1} {2} {3}", result.venue.address_1, result.venue.city, result.venue.state, result.venue.zip),
                    NumberRSVPedYes = result.yes_rsvp_count,
                    MeetingTime = GetMeetingTime(
                    Int64.Parse(result.utc_offset.ToString()),
                    Int64.Parse(result.duration == null ? "7200000" : result.duration.ToString()),
                    Int64.Parse(result.time.ToString())),
                    MeetingDescriptionHTML = result.description,
                    Name = result.name,
                    Url = result.event_url
                };
                meetings.Add(meeting);
            }
            return meetings;
        }

        private static string GetMeetingTime(Int64 offset, Int64 duration, Int64 ticks)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            DateTime startDate = epoch.AddMilliseconds(ticks).AddMilliseconds(offset);
            DateTime endDate = epoch.AddMilliseconds(ticks).AddMilliseconds(duration).AddMilliseconds(offset);
            return string.Format("{0} {1} - {2}", 
                startDate.ToShortDateString(),
                startDate.ToShortTimeString(),
                endDate.ToShortTimeString());
        }
    }
}
