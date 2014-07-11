using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;

namespace SeleniumClassLibrary
{
    [TestFixture]
    public class AutomatedTest01
    {

        IWebDriver driver;

        [TestFixtureSetUp] // http://www.nunit.org/index.php?p=testFixture&r=2.5
        public void TestSetUp()
        {
            // Set the IWebDriver to use FireFox
            driver = new FirefoxDriver();

            // Set the timeout to 30 seconds
            driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 30));

        }

        [Test] // http://www.nunit.org/index.php?p=test&r=2.5
        public void NavigateToGoogle()
        {
            // Navigate to URL
            driver.Navigate().GoToUrl("http://www.google.com");

            // Assert that the IWebDriver window's title is "Google"
            Assert.AreEqual("Google", driver.Title);
        }

        [TestFixtureTearDown] // http://www.nunit.org/index.php?p=fixtureTeardown&r=2.5
        public void FixtureTearDown()
        {
            // Closes all windows associated with the IWebDriver
            driver.Quit();
        }
    }
}