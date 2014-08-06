using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MailChimp;
using MailChimp.Helper;
using MailChimp.Lists;

namespace ONETUG.Controllers
{
    public class MemberController : ApiController
    {
        private string _mailchimpKey = System.Configuration.ConfigurationManager.AppSettings["MailChimpAPIKey"];
        private string _mailchimpGroupId = System.Configuration.ConfigurationManager.AppSettings["MailChimpGroupId"];

        [HttpPost]
        public bool Subscribe(ONETUGMember member)
        {
            MailChimpManager mc = new MailChimpManager(_mailchimpKey);
            MyMergeVar myMergeVars = new MyMergeVar();
            myMergeVars.FirstName = member.FirstName;
            myMergeVars.LastName = member.LastName;           //  Create the email parameter
            EmailParameter email = new EmailParameter()
            {
                Email = member.EmailAddress
            };

            EmailParameter results = mc.Subscribe(_mailchimpGroupId, email, myMergeVars);
            return string.IsNullOrEmpty(results.LEId);
        }
    }

    [System.Runtime.Serialization.DataContract]
    public class MyMergeVar : MergeVar
    {
        [System.Runtime.Serialization.DataMember(Name = "FNAME")]
        public string FirstName { get; set; }
        [System.Runtime.Serialization.DataMember(Name = "LNAME")]
        public string LastName { get; set; }
    }

    public class ONETUGMember
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }

}
