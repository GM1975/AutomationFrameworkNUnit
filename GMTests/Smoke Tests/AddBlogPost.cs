using GMAutomation;
using GMAutomation.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GMTests
{
    [TestClass]
    public class AddBlogPost : BaseTestClass
    {
        
        [TestMethod]
        public void AddBlogPostOpensNewForm()
        {

            TopBarPage.ClickMySite();
        }

    }
}
