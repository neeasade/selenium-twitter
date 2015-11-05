using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bumblebee.Extensions;
using Bumblebee.Implementation;
using Bumblebee.Interfaces;
using Bumblebee.Setup;
using OpenQA.Selenium;

namespace selenium_twitter
{
    /// <summary>
    /// A class to represent a tweet as a bumblebee block.
    /// </summary>
    class Tweet : SpecificBlock
    {
        public Tweet (Session session, IWebElement tag) : base(session, tag)
        {
        }

        public IClickable<WebBlock> Content
        {
            get { return new Clickable<WebBlock>(this, By.ClassName("tweet-text")); }
        }

        public IClickable<WebBlock> Username
        {
            get { return new Clickable<WebBlock>(this, By.ClassName("username")); }
        }

        public IClickable<WebBlock> FullName
        {
            get { return new Clickable<WebBlock>(this, By.ClassName("fullname")); }
        }

        public IClickable<WebBlock> Favorites
        {
            get { return new Clickable<WebBlock>(this, By.ClassName("ProfileTweet-actionCountForPresentation")); }
        }
    }
}
