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
            LoginPage.GoTo();
            LoginPage.LoginAs("gregmawsonblog", "automation123!");
            TopBarPage.ClickMySite();
        }

    }
}
