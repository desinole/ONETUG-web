using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Helpers;
using System.Web.Http;
using Core;

namespace ONETUG.Controllers
{
    public class GroupController : ApiController
    {
        public MeetupGroup Get()
        {
            return new MeetupGroup();
        }

    }
}
