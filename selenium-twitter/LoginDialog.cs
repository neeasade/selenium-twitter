using System;
using System.Collections.Generic;

using Bumblebee.Interfaces;
using Bumblebee.Implementation;
using Bumblebee.Setup;
using OpenQA.Selenium;

namespace selenium_twitter
{
    class LoginDialog : SpecificBlock
    {
        public LoginDialog(Session session, IWebElement tag) : base(session, tag)
        {
        }

        public ITextField<WebBlock> UsernameField
        {
            get { return new TextField<WebBlock>(this, By.Id("signin-email")); }
        }

        public ITextField<WebBlock> PasswordField
        {
            get { return new TextField<WebBlock>(this, By.Id("signin-password")); }
        }
     }
}
