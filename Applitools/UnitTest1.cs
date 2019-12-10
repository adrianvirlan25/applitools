using NUnit.Framework;

namespace Applitools
{
    [TestFixture]
    [Category("Examples of different baselines")]
    public class BaselinesExamples : BaseClass
    {
        private const string AppName = "sample app 1";

        public string TestCaseName => "Test1";

        [Test]
        public void SetBaselineUsingAppName()
        {
            GoToPricingPage();
            Eyes.Open(Driver, AppName, TestCaseName, ResolutionCustom1366);
        }

        [Test]
        public void SetBaselineUsingDifferentAppName()
        {
            GoToPricingPage();
            Eyes.Open(Driver, "app 2", TestCaseName, ResolutionCustom1366);
            Eyes.CheckWindow();
        }

        [Test]
        public void SetBaselineUsingViewportSize()
        {
            GoToPricingPage();
            Eyes.Open(Driver, AppName, TestCaseName, Resolution1080p);
            Eyes.CheckWindow();
        }

        [Test]
        public void TestBaseline()
        {
            GoToPricingPage();
            UpdateElements();
            Eyes.Open(Driver, AppName, TestCaseName, ResolutionCustom1366);
            Eyes.CheckWindow();
        }

        private void UpdateElements()
        {

        }
    }
}
