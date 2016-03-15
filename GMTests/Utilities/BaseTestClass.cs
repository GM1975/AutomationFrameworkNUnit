using GMAutomation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GMTests
{
    public class BaseTestClass
    {

        [TestInitialize]
        public void Init()
        {
            Driver.Initialise();
            LoginPage.GoTo();
            LoginPage.LoginAs("gregmawsonblog", "automation123!");
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}
