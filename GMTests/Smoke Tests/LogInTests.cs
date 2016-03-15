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
            Assert.IsTrue(ReaderPage.IsAt());
        }
        
    }
}
