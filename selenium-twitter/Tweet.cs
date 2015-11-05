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

        public string Content
        {
            get { return new Clickable<WebBlock>(this, By.ClassName("tweet-text")).Text; }
        }

        public String Username
        {
            get { return new Clickable<WebBlock>(this, By.ClassName("username")).Text; }
        }

        public String FullName
        {
            get { return new Clickable<WebBlock>(this, By.ClassName("fullname")).Text; }
        }

        public IClickable<WebBlock> Favorites
        {
            get { return new Clickable<WebBlock>(this, By.ClassName("ProfileTweet-actionCountForPresentation")); }
        }

        public IClickable<WebBlock> RetweetButton
        {
            get { return new Clickable<WebBlock>(this, By.ClassName("Icon--retweet")); }
        }

        public IClickable<WebBlock> ReplyButton
        {
            get { return new Clickable<WebBlock>(this, By.ClassName("Icon--reply")); }
        }
  
        public IClickable<WebBlock> FavoriteButton
        {
            get { return new Clickable<WebBlock>(this, By.ClassName("HeartAnimation")); }
        }

    }
}
