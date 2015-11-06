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

        public IClickable<TwitterLoggedOut> LoginButton
        {
            get { return new Clickable<TwitterLoggedOut>(this, By.ClassName("js-login")); }
        }
        public LoginDialog LoginDialog
        {
            get { return new LoginDialog(Session); }
        }
    }

    class LoginDialog : WebBlock
    {
        public LoginDialog(Session session) : base(session)
        {
            Tag = FindElement(By.ClassName("LoginDialog-body"));
        }

        public ITextField<LoginDialog> UsernameField
        {
            get { return new TextField<LoginDialog>(this, By.Id("signin-email")); }
        }

        public ITextField<LoginDialog> PasswordField
        {
            get { return new TextField<LoginDialog>(this, By.Id("signin-password")); }
        }

        public IClickable LoginButton
        {
            get { return new Clickable(this, By.ClassName("submit")); }
        }
     }
}
