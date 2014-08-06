using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class MeetupSponsors
    {
        private static string _groupInfoUrl = string.Format("https://api.meetup.com/2/groups?&sign=true&photo-host=public&group_urlname=ONETUG&fields=sponsors&page=20&key={0}", ConfigurationManager.AppSettings["MeetupAPI"]);

        public string Name { get; set; }
        public string CompanyUrl { get; set; }
        public string ImageUrl { get; set; }
        public string Info { get; set; }
        public string Details { get; set; }

        public MeetupSponsors()
        {

        }

        public static List<MeetupSponsors> Get()
        {
            List<MeetupSponsors> sponsors = new List<MeetupSponsors>();
            string jsonResponse = ONETUGRequest.GetResponse(_groupInfoUrl);
            dynamic d = JObject.Parse(jsonResponse);
            if (d.results.Count > 0)
            {
                foreach (var sponsorJSON in d.results[0].sponsors)
                {
                    sponsors.Add(new MeetupSponsors { Name = sponsorJSON.name, CompanyUrl = sponsorJSON.url, ImageUrl = sponsorJSON.image_url, Details = sponsorJSON.details, Info = sponsorJSON.info });
                }
            }
            return sponsors;
        }
    }
}
