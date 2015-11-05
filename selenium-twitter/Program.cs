using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bumblebee.Extensions;
using Bumblebee.Setup;
using Bumblebee.Setup.DriverEnvironments;

using OpenQA.Selenium;

namespace selenium_twitter
{
    class Program
    {
        static void Main(string[] args)
        {
            // bring up a profile page:
            Threaded<Session>
                .With<Firefox>()
                .NavigateTo<ProfilePage>("https://twitter.com/sele_test_2");

             IEnumerable<Tweet> lTweets = Threaded<Session>
                .CurrentBlock<ProfilePage>()
                .Tweets;

            // print the content of the tweets
            foreach (Tweet lTweet in lTweets)
            {
                Console.WriteLine(lTweet.Content.Text);
            }

            // Close a profile page:
            Threaded<Session>
                .End();

            // pause
            Console.ReadLine();
        }
    }
}
