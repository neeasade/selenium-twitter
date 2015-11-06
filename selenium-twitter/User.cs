using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bumblebee.Setup;
using Bumblebee.Setup.DriverEnvironments;
using Bumblebee.Implementation;
using Bumblebee.Interfaces;
using System.Threading;


namespace selenium_twitter
{
    /// <summary>
    /// a Twitter user.
    /// </summary>
    class User
    {
        private String mUsername;
        protected Session mSession { get; private set; }
        private bool mLoggedIn;

        /// <summary>
        /// Open up browser for this user.
        /// </summary>
        public User()
        {
            mLoggedIn = false;
            mSession = new Session<Firefox>();
        }

        /// <summary>
        /// Open up driver for this user, attempt to login.
        /// </summary>
        /// <param name="aUsername"></param>
        /// <param name="aPassword"></param>
        public User(string aUsername, string aPassword)
        {
            mLoggedIn = false;
            mSession = new Session<Firefox>();
            login(aUsername, aPassword);
        }

        /// <summary>
        /// Attempt to login.
        /// </summary>
        /// <param name=""></param>
        /// <param name=""></param>
        public bool login(string aUsername, string aPassword)
        {
            if (!mLoggedIn)
            {
                mUsername = aUsername;

                mSession.NavigateTo<TwitterLoggedOut>("https://twitter.com")
                    .LoginButton.Click<TwitterLoggedOut>();

                Thread.Sleep(2000);

                // Exception on click why
                mSession.CurrentBlock<TwitterLoggedOut>()
                    .LoginDialog.UsernameField.EnterText(aUsername);

                //lDialog.UsernameField.EnterText(aUsername);
                //lDialog.PasswordField.EnterText(aPassword);

                //TODO check 
                return true;
            }
            return false;
       }

        /// <summary>
        /// Log out a user.
        /// </summary>
        public void logout()
        {
            //TODO
        }

        /// <summary>
        /// Close the browser for this user.
        /// </summary>
        public void close()
        {
            mSession.End();
        }
    }
}
