using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class GroupSettings
    {
        private static GroupSettings _instance;
        private static readonly object _instanceLock = new object();

        public string Title { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string FacebookGroupName { get; set; }
        public string LinkedInGroup { get; set; }
        public string TwitterHandle { get; set; }
        public string TwitterWidgetId { get; set; }
        public string MeetupGroupName { get; set; }
        public string MeetupApi { get; set; }
        public string MailChimpApiKey { get; set; }
        public string MailChimpGroupId { get; set; }

        public static GroupSettings Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_instanceLock)
                    {
                        _instance = new GroupSettings
                        {
                            Title = Properties.Settings.Default.Title,
                            Name = Properties.Settings.Default.GroupName,
                            EmailAddress = Properties.Settings.Default.EmailAddress,
                            FacebookGroupName = Properties.Settings.Default.FacebookGroupName,
                            LinkedInGroup = Properties.Settings.Default.LinkedInGroup,
                            TwitterHandle = Properties.Settings.Default.TwitterHandle,
                            TwitterWidgetId = Properties.Settings.Default.TwitterWidgetId,
                            MeetupGroupName = Properties.Settings.Default.MeetupGroupName,
                            MeetupApi = Properties.Settings.Default.MeetupApi,
                            MailChimpApiKey = Properties.Settings.Default.MailChimpApiKey,
                            MailChimpGroupId = Properties.Settings.Default.MailChimpGroupId
                        };
                    }
                }

                return _instance;
            }
        }
    }
}
