using System;
using System.IO;
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
            // get creds from my super secret secure file.
            List<string> lUserInfo = File.ReadAllLines("creds.txt")[2].Split('|').ToList<string>();
            String lUsername = lUserInfo[3];
            String lPassword = lUserInfo[2];
            
            // Create a session, login.
            User lUser = new User(lUsername, lPassword);

            // pause
            Console.ReadLine();
        }
    }
}
