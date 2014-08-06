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
                ImageFileName = "Esteban.jpg",
                IsCurrent = true,
                Position = "President",
                DescriptionHTML = "Esteban Garcia is Principal Consultant at M2E Solutions, and Orlando-based software consulting firm. He has more than 10 years experience in professional software development. He is experienced in all phases of distributed object oriented enterprise application development and design on the Windows platform, and he has focused on the .NET Framework since 2001. He has been involved with different industries such as mobile technologies, financial services, telecommunications, health care, and developer tools. Esteban excels in architecture and best practices and is able to provide advice on SDLC customization and build automation. He holds certifications on MCAD, MCSD.NET, IEEE Certified Software Engineer, and ScrumMaster. Esteban also has a bachelor of science degree in Computer Engineering with an emphasis in software design from the University of Central Florida."
            });
            MemberList.Add(new TeamMember
            {
                Id = 2,
                Name = "Brian Mishler",
                ImageFileName = "BrianMishler.jpg",
                IsCurrent = true,
                Position = "Vice President",
                DescriptionHTML = "Brian is President of Quality Data, Inc., an Orlando-based software development firm. He holds a BS degree in Aerospace Engineering, University of Florida, 1983 where he learned to program in Fortran using punch cards. In his first job as a Quality Engineer at Martin Marietta Corp, he was given the task of learning DBASE II on one of the first IBM PC's at that company. It was here that he developed a passion for programming and in 1991, Brian co-founded The Harrington Group, Inc., a Quality Management Software Company which grew to 23-employees by the time he sold his interest in 2003. During his 26-years as a Software Developer, he has been proficient in xBase, Clipper, VB1 through VB6, VB.Net and C#. His hobbies involve his family and guess-what? .Net! "
            });
            MemberList.Add(new TeamMember
            {
                Id = 3,
                Name = "John Torrey",
                ImageFileName = "johntorrey.jpg",
                IsCurrent = true,
                Position = "Treasurer",
                DescriptionHTML = "John has had a varied background.  His first related job out of college was to work on applications for filling out auto dealership finance contracts.  From there, he took courses in automation systems and started working with a professor writing a Windows-based user interface for proprietary digital audio playback devices used in theme parks around the world.  At another company, he then developed a DOS-based serial communication interface for linking the intercom, video camera, and wireless \"man down\" systems of the Palm Beach County Judicial Center to its security-controlling PLCs and subsequently aided in programming the PLCs controlling the office and stairwell doors, detention cells, and elevators. This guided him into a dark period that has come to be known as the \"evil, PLC era\", where he spent many years creating and maintaining theme park ride control systems.  More recently, he found the world of .NET programming, and has since never looked back.  By day, he writes .NET enterprise applications for the City of Orlando.  By night and weekend, he provides universally useful software and APIs (at least in his mind) and has now established a company called Ryppl for disseminating them."
            });
            MemberList.Add(new TeamMember
            {
                Id = 4,
                Name = "Santosh Hari",
                ImageFileName = "santosh.jpeg",
                IsCurrent = true,
                Position = "Director of Technology",
                DescriptionHTML = "Santosh is a software entrepreneur with experience building products on the .NET platform since 2002 and over 15 years in the software industry. Before 2000, his claim to fame was working on projects that saved the world from the Y2K disasters. He currently works for a startup, leveraging his software skills to help provide better coverage for your wireless devices. He specializes in web services, APIs, ETL and databases and, on-the-side, loves tinkering with geospatial data and software. Santosh holds a Bachelors in Electronics Engineering and a Masters in Computer Science. When not working on software projects, Santosh loves playing tennis, rescuing animals and rooting for his favorite sports team, the Florida State Seminoles."
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
