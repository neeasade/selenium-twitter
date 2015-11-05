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
    public enum ProfileViews
    {
        Tweets,
        TweetsAndReplies,
        PhotosAndVideos
    }

    class ProfilePage : TwitterPage
    {
        public ProfilePage(Session session) : base(session)
		{
        }

        /// <summary>
        /// Change to a different ProfilePage view.
        /// </summary>
        /// <param name="aView"></param>
        public void ChangeView(ProfileViews aView)
        {
            switch (aView)
            {
                case ProfileViews.Tweets:
                    break;
                case ProfileViews.TweetsAndReplies:
                    break;
                case ProfileViews.PhotosAndVideos:
                    break;
            }
        }
    }
}
