using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bumblebee.Implementation;
using Bumblebee.Interfaces;
using OpenQA.Selenium;
using Bumblebee.Setup;

namespace selenium_twitter
{
    /// <summary>
    /// https://twitter.com when not logged in.
    /// </summary>
    class TwitterLoggedOut : WebBlock
    {
        public TwitterLoggedOut(Session session) : base(session)
        {
        }

        public IClickable LoginButton
        {
            get { return new Clickable(this, By.ClassName("js-login")); }
        }

    }
}
