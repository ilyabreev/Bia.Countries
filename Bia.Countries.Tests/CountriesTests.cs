using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bia.Countries.Tests
{
    [TestClass]
    public class CountriesTests
    {
        [TestMethod]
        public void GetCodeByNameTest()
        {
            Assert.IsNull(Iso3166Countries.GetAlpha2CodeByName("Unexisting Country"));
            Assert.AreEqual("GB", Iso3166Countries.GetAlpha2CodeByName("United Kingdom"));
            Assert.AreEqual("RU", Iso3166Countries.GetAlpha2CodeByName("Russian Federation"));
            Assert.AreEqual("NL", Iso3166Countries.GetAlpha2CodeByName("Netherlands"));
            Assert.AreEqual("ES", Iso3166Countries.GetAlpha2CodeByName("Spain"));
            Assert.AreEqual("AD", Iso3166Countries.GetAlpha2CodeByName("Andorra"));
        }
    }
}
