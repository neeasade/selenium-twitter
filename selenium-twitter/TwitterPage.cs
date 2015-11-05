using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bumblebee.Implementation;
using Bumblebee.Interfaces;
using Bumblebee.Setup;

using OpenQA.Selenium;


namespace selenium_twitter
{
    /// <summary>
    /// A class for a 'twitter' page, meant to be extended by home/profile/notifications etc.
    /// Certain things like the tweet dialog are always available so this makes sense.
    /// </summary>
    class TwitterPage : WebBlock
    {
        public TwitterPage(Session session) : base(session)
		{
        }

        /// <summary>
        /// Tweets present on this page.
        /// </summary>
        public IEnumerable<Tweet> Tweets 
        {
            get
            {
                return FindElements(By.CssSelector("[data-item-type=\"tweet\"]"))
                    .Select(tag => new Tweet(Session, tag));
            }
        }


        /// <summary>
        /// Make a tweet.
        /// </summary>
        /// <param name="tweet"></param>
        public bool Tweet(String aTweet)
        {
            // Character check.
            if (aTweet.Length > 160)
            {
                return false;
            }

            // todo : get tweetbox, tweet.

            return true;
        }
    }
}
