using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ONETUG.Controllers
{
    public class TeamController : ApiController
    {
        TeamMembers teamMembers = new TeamMembers();

        public List<TeamMember> GetAll()
        {
            return teamMembers.MemberList.OrderBy(t => t.Id).Select(t => t).ToList<TeamMember>();
        }
    }

    public class TeamMembers
    {
        public List<TeamMember> MemberList { get; set; }
        public TeamMembers()
        {
            MemberList = new List<TeamMember>();
            MemberList.Add(new TeamMember
            {
                Id = 1,
                Name = "Esteban Garcia",
                ImageFileName = "esteban.jpg",
                IsCurrent = true,
                Position = "President",
                DescriptionHTML = "<p>Esteban Garcia is the Founder and Chief Technologist at " +
                "<a href=\"http://www.nebbiatech.com/\" target=\"_blank\">Nebbia Technology</a>, " +
                "where he focuses on DevOps and Azure. He spends his time  helping organizations " +
                "moving to the Cloud and adopting DevOps best practices.&nbsp; Esteban is a " +
                "<a href=\"https://mvp.microsoft.com/en-us/PublicProfile/4039786\" target=\"_blank\">Microsoft Visual Studio ALM MVP</a> " +
                "and <a href=\"https://blogs.msdn.microsoft.com/willy-peter_schaub/2012/03/28/introducing-the-visual-studio-alm-rangers-esteban-garcia/\" target=\"_blank\">ALM Ranger</a>, " +
                "<a href=\"http://www.pluralsight.com/author/esteban-garcia\" target=\"_blank\">Pluralsight author</a>, and member of <a href=\"http://www.red-gate.com/community/friends-of-rg/directory\" target=\"_blank\">Friends of Redgate</a>.</p>" +
                "<p> After graduating with a Computer Engineering degree from the University of Central Florida in 1999, " +
                "Esteban has worked in various roles in the Software Development field, " +
                "ranging from QA to Solutions Architect.A year after battling the Y2K bug, " +
                "he joined a company that was experimenting with a new framework called.NET and a new language called C# and he has been a .NET developer ever since. " +
                "You can often find Esteban speaking at other user groups in Florida, Code Camps throughout the Southeast, and national conferences such as DevConnections and VSLive.</p>" +
                "< p > Blog: < a href = \"http://www.almguide.com/\" target = \"_blank\" >http://www.almguide.com/</a></p>" +
                "< p > Twitter: < a href = \"https://twitter.com/estebanfgarcia\" target = \"_blank\" >@EstebanFGarcia</ a ></ p >" +
                "< p > LinkedIn: < a href = \"https://www.linkedin.com/in/estebangarcia\" target = \"_blank\" >https://www.linkedin.com/in/estebangarcia</a></p>" +
                "< p > Email: < a href = \"mailto:esteban@nebbiatech.com\" target = \"_blank\" >esteban@nebbiatech.com </ a ></ p >"
            });
            MemberList.Add(new TeamMember
            {
                Id = 2,
                Name = "Brian Mishler",
                ImageFileName = "brian.jpg",
                IsCurrent = true,
                Position = "Vice President",
                DescriptionHTML = "<p>Brian is a full stack .Net software developer for <a target=\"_blank\" href=\"https://seaworldentertainment.com/\">Sea World Parks & Entertainment</a>." +
                "While earning a B.S.degree in Aerospace Engineering from the University of Florida, " +
                "Brian took exactly one computer course: FORTRAN 77.Otherwise, " +
                "all his professional skills are self taught.His passions include software development and aviation. Lately, " +
                "he’s been spending a lot of time in gliders.</ p >" +
                "< p > LinkedIn: < a href =\"https://www.linkedin.com/in/brian-mishler-000b3493\" target=\"_blank\">https://www.linkedin.com/in/brian-mishler-000b3493</a></p>" +
                "< p > Email: < a href =\"mailto:brian@onetug.org\" target=\"_blank\">brian@onetug.org</a></p>"
            });
            MemberList.Add(new TeamMember
            {
                Id = 3,
                Name = "Santosh Hari",
                ImageFileName = "santosh.jpg",
                IsCurrent = true,
                Position = "Director of Technology",
                DescriptionHTML = "<p>Santosh Hari is Director of Software for <a href=\"https://spectrumbridge.com/\" target=\"_blank\">Spectrum Bridge</a>, a wireless startup, where he leverages his software skills to help provide high quality, affordable wireless broadband to the developing world. He is also Director of Tech for <a href=\"http://onetug.org/\" target=\"_blank\">Orlando .NET User Group</a>, co-organizer of <a href=\"http://orlandocodecamp.com/\" target=\"_blank\">Orlando Codecamp</a>, a frequent speaker on topics like Azure and GIS at user group meetups and Codecamps and participates in creative side projects with Sand Dollar Technology.</p>" +
                "< p > Santosh is a software entrepreneur with experience building products on the.NET platform since 2002 and nearly 2 decades in the software industry. Before 2000, " +
                "his claim to fame was working on projects that saved the world from the Y2K disasters.</ p >" +
                "< p > Santosh holds a Bachelors in Electronics Engineering and a Masters in Computer Science.When not working on software projects, " +
                "Santosh loves playing tennis, " +
                "rescuing animals and rooting for his favorite sports team, the Florida State Seminoles.</ p >" +
                "< p > Blog: < a href = \"https://santoshhari.wordpress.com/\" target =\"_blank\" > https://santoshhari.wordpress.com/</a></p>" +
                "< p > Twitter: < a href = \"https://twitter.com/_s_hari\" target = \"_blank\" > @_s_hari </ a ></ p >" +
                "< p > LinkedIn: < a href = \"https://www.linkedin.com/in/santoshhari\" target = \"_blank\" > https://www.linkedin.com/in/santoshhari</a></p>" +
                "< p > Email: < a href = \"mailto:santosh@onetug.org\" target = \"_blank\" > santosh@onetug.org </ a ></ p >"
            });
            MemberList.Add(new TeamMember
            {
                Id = 4,
                Name = "Chelsea Coster",
                ImageFileName = "chelsea.jpg",
                IsCurrent = true,
                Position = "Director of Communications",
                DescriptionHTML = "<p>Chelsea Coster is the Director of Communications of the <a href=\"http://onetug.org/\" target=\"_blank\">Orlando .NET User Group</a> and Director of Sales and Operations at <a href=\"http://www.nebbiatech.com/\" target=\"_blank\">Nebbia Technology</a>. Prior to Nebbia Technology, she worked in Information Technology Staffing for 5 ½ years and held various roles including Technical Recruiter, Executive Recruiter and Division Director for Orlando at SNI Technology.</p>"+
                "< p > She has a Bachelor's Degree in Marketing and Human Resources from the Florida State University and is very involved in both the technical community and the Orlando community. She is an active member of the Junior League of Greater Orlando and when she is not at the ONETUG meetings or volunteering, you can find her at CrossFit Winter Park or hanging out with her Springer Spaniel, Bailey.</p>"+
                "< p > Twitter: < a href = \"https://twitter.com/chelseazcoster\" target = \"_blank\" >@chelseazcoster</ a ></ p >"+
                "< p > LinkedIn: < a href = \"https://www.linkedin.com/in/chelseazcoster\" target = \"_blank\" >https://www.linkedin.com/in/chelseazcoster</a></p>"+
                "< p > Email: < a href = \"mailto:chelsea@nebbiatech.com\" target = \"_blank\" >chelsea@nebbiatech.com </ a ></ p >"
            });
            MemberList.Add(new TeamMember
            {
                Id = 5,
                Name = "Joel Martinez",
                ImageFileName = "joel.jpg",
                IsCurrent = false,
                Position = "Founder",
                DescriptionHTML = "Joel has been involved with .NET since the public beta was released by Microsoft and founded the Orlando .NET User Group to meet other like-minded individuals. Aside from past achievements such as co-authoring books, writing articles online, and speaking at industry events; he fills his \"extra\" time with Family, friends, and new technologies such as XNA.  More Here (<a href=\"http://codecube.net/?page_id=2\">http://codecube.net/?page_id=2</a>)"
            });
            MemberList.Add(new TeamMember
            {
                Id = 6,
                Name = "Jessica Sterner",
                ImageFileName = "jessica.jpg",
                IsCurrent = false,
                Position = "Ex-President",
                DescriptionHTML = "Jessica has been in the IT field since 1999 and working with .Net since 2003. She graduated from Kaplan University with a B.S. IT in Programming in May of 2006. Jessica is currently employed as a Software Engineer at Symantec Corporation, working on the engine for their Backup Exec product. Although she works with C/C++ professionally, Jessica enjoys staying up to date with the latest .NET technologies and learning/practicing .Net in her spare time. In addition to work and programming, Jessica enjoys spending time with her family and physical fitness. "
            });
            MemberList.Add(new TeamMember
            {
                Id = 7,
                Name = "Shawn Weisfeld",
                ImageFileName = "shawn.jpg",
                IsCurrent = false,
                Position = "Ex-President",
                DescriptionHTML = "Shawn is a Staff Developer at a fortune 20 company. There he specializes in intranet & smart client development for internal line of business applications. Besides his day job Shawn also is an Adjunct Professor at The Florida Institute of Technology. He also does freelance software development work for local small businesses and training. In his free time he volunteers with INETA NorAm (<a href=\"http://www.ineta.org/\">http://www.ineta.org/</a>). Shawn started his career at his family business in Port St. Lucie FL while working on his undergraduate degree in Business Administration at the University of Central Florida and after a year off Shawn moved back to Orlando to pursue a Masters degree in Management Information Systems at The University of Central Florida and has since earned a second Masters degree in Computer Information Systems from Florida Institute of Technology. Shawn was awarded the Microsoft C# Most Valuable Professional award for 2007 & 2008. Shawn is an avid technology presenter and since July of 2005 Shawn has presented at over 25 user group events, and even got to speak for Microsoft at the launch of Visual Studio."
            });

        }
    }

    public class TeamMember
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageFileName { get; set; }
        public string Position { get; set; }
        public string Twitter { get; set; }
        public string Website { get; set; }
        public string DescriptionHTML { get; set; }
        public bool IsCurrent { get; set; }
    }
}
