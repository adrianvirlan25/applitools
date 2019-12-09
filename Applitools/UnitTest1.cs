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
            Eyes.Open(Driver, AppName, TestCaseName, Resolution1080p);
        }
    }
}
