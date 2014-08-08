ONETUG-web
==========
ONETUG Web is the code repository for the official [ONETUG website](http://onetug.org).

![alt text](http://www.onetug.org/images/onetug.png "ONETUG Logo")

The ONETUG website serves the following purposes:

  * Information portal for information on the group, team members and meetings

  * Signup tool for ONETUG newsletter

  * Web API feed for data needed for the website and mobile apps

The website gets it's data using Meetup API (meetings and group information) and Twitter API (streaming tweets). Additionally, the signup page uses MailChimp API (add users to newsletter)

Requirements:
-------------

1. Visual Studio 2012 or higher with .NET Framework 4.5
2. ASP.NET MVC 4
3. [Meetup API Key](https://secure.meetup.com/meetup_api/key/)
4. optional - [MailChimp API](http://kb.mailchimp.com/article/where-can-i-find-my-api-key)
5. Get a [Twitter widget ID](https://twitter.com/settings/widgets/new/search?query=ONETUG)
