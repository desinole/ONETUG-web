using Core;
using MailChimp;
using MailChimp.Helper;
using MailChimp.Lists;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ONETUG.Controllers
{
    public class Subscriber
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }
    public class SubscribeNewsletterController : ApiController
    {
        private string _mailchimpKey = GroupSettings.Instance.MailChimpApiKey;
        private string _mailchimpGroupId = GroupSettings.Instance.MailChimpGroupId;

        // POST api/mailchimp
        public string Post(Subscriber subscriber)
        {
            MailChimpManager mc = new MailChimpManager(_mailchimpKey);
            MyMergeVar myMergeVars = new MyMergeVar();
            myMergeVars.FirstName = subscriber.FirstName;
            myMergeVars.LastName = subscriber.LastName;           //  Create the email parameter
            EmailParameter email = new EmailParameter()
            {
                Email = subscriber.EmailAddress
            };

            EmailParameter results = mc.Subscribe(_mailchimpGroupId, email, myMergeVars);
            return results.LEId;
        }

        [System.Runtime.Serialization.DataContract]
        public class MyMergeVar : MergeVar
        {
            [System.Runtime.Serialization.DataMember(Name = "FNAME")]
            public string FirstName { get; set; }
            [System.Runtime.Serialization.DataMember(Name = "LNAME")]
            public string LastName { get; set; }
        }

    }
}
