using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class MeetupGroup
    {
        public string GroupUrl { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }

        private string _groupInfoUrl = string.Format("https://api.meetup.com/2/groups?&sign=true&photo-host=public&group_urlname={0}&page=20&key={1}", GroupSettings.Instance.MeetupGroupName, GroupSettings.Instance.MeetupApi);

        public MeetupGroup()
        {
            string jsonResponse = ONETUGRequest.GetResponse(_groupInfoUrl);
            dynamic d = JObject.Parse(jsonResponse);
            this.GroupUrl = string.Format("http://www.meetup.com/{0}/", GroupSettings.Instance.MeetupGroupName);
            this.ImageUrl = "~/Images/bacon.jpeg";
            this.Description = "<p>Join us for one of our regular Nerd Dinners. These are events are simply social and have no planned agenda. We typically meet at the Mall at Millenia food court at the base of the ramp that leads to the center lounge area. Grab some food from one of the many vendors in the food court area and enjoy some good conversation and networking.</p> <p>Naturally there will be .NET developers there but we welcome developers and IT professionals from all disciplines. The more diversity, the better the conversation. :-)</p>";
            this.Name = string.Format("{0} - {1}", GroupSettings.Instance.Name, GroupSettings.Instance.Title);
            if (d.results.Count > 0)
            {
                this.GroupUrl = d.results[0].link;
                this.ImageUrl = d.results[0].group_photo.photo_link;
                this.Description = d.results[0].description;
                this.Name = d.results[0].name;
            }
        }

    }

}
