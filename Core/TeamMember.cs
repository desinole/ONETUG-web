using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [JsonObject(MemberSerialization.OptIn)]
    public class TeamMember
    {
        [JsonProperty]
        public string Id { get; set; }
        [JsonProperty]
        public string FullName { get; set; }
        [JsonProperty]
        public string BoardRole { get; set; }
        [JsonProperty]
        public string DescriptionHTML { get; set; }
        [JsonProperty]
        public string PhotoURL { get; set; }
    }
}
