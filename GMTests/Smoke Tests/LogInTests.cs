using GMAutomation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GMTests
{
    [TestClass]
    public class LogInTests : BaseTestClass
    {

        [TestMethod]
        public void UserCanLogin()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("gregmawsonblog", "automation123!");
            Assert.IsTrue(ReaderPage.IsAt());
        }
        
    }
}
