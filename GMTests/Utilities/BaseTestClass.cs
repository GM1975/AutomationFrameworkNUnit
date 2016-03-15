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

        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}
