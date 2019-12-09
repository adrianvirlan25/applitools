using Applitools.Selenium;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Drawing;

namespace Applitools
{
    public class BaseClass
    {
        public IWebDriver Driver { get; set; }

        public Eyes Eyes { get; set; }

        public Size ResolutionCustom1366 => new Size(1366, 625);

        public Size Resolution1080p => new Size(1311, 969);

        public void GoToPricingPage()
        {
            Driver.Navigate().GoToUrl("https://www.ultimateqa.com/fake-pricing-page");
        }

        public void GoToPricingPageWithCurrencyUpdate()
        {
            Driver.Navigate().GoToUrl("https://www.ultimateqa.com/fake-pricing-page-currency");
        }

        [SetUp]
        public void SetupForEverySingleTestMethod()
        {
            Driver = new ChromeDriver();

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Eyes = new Eyes
            {
                ApiKey = "2S99p3MX104rG9QIw8kQ0zpjTXi1068lYHCb2998Sz6gTLcRc110"
                //ApiKey = Environment.GetEnvironmentVariable("APPLITOOLS_API_KEY",
                //EnvironmentVariableTarget.User)
            };
        }

        [TearDown]
        public void TearDownForEverySingleTestMethod()
        {
            Driver.Quit();
            Eyes.Close();
            Eyes.AbortIfNotClosed();
        }
    }
}
