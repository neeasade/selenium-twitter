using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bumblebee.Implementation;
using Bumblebee.Interfaces;
using Bumblebee.Setup;

using OpenQA.Selenium;

namespace selenium_twitter
{
    class ProfilePage : WebBlock
    {
        public ProfilePage(Session session) : base(session)
		{
        }

        public IEnumerable<Tweet> Tweets 
        {
            get
            {
                return FindElements(By.CssSelector("[data-item-type=\"tweet\"]"))
                    .Select(tag => new Tweet(Session, tag));
            }
        }
    }
}
