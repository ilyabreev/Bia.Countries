using System;
using NUnit.Framework;

namespace Bia.Countries.Tests
{
    [TestFixture]
    public class CountriesTests
    {
        [TestCase("Unexisting Country", null)]
        [TestCase(null, null)]
        [TestCase("", null)]
        [TestCase(" ", null)]
        [TestCase("United Kingdom", null)]
        [TestCase("United Kingdom of Great Britain and Northern Ireland", "GB")]
        [TestCase("Russian Federation", "RU")]
        [TestCase("Netherlands", "NL")]
        [TestCase("Spain", "ES")]
        [TestCase("Andorra", "AD")]
        [TestCase("BELGIUM", null)]
        [TestCase("RuSSiaN Federation", null)]
        [TestCase("andorra", null)]
        public void GetAlpha2CodeByName_Test(string countryName, string result)
        {
            var countries = new Iso3166Countries();
            Assert.AreEqual(result, countries.GetAlpha2CodeByName(countryName));
        }

        [TestCase("Unexisting Country", null)]
        [TestCase(null, null)]
        [TestCase("", null)]
        [TestCase(" ", null)]
        [TestCase("United Kingdom", null)]
        [TestCase("UniTed KingdoM of GREAT Britain and NORTHERN Ireland", "GB")]
        [TestCase("Russian Federation", "RU")]
        [TestCase("Netherlands", "NL")]
        [TestCase("Spain", "ES")]
        [TestCase("Andorra", "AD")]
        [TestCase("BELGIUM", "BE")]
        [TestCase("RuSSiaN Federation", "RU")]
        [TestCase("andorra", "AD")]
        public void GetAlpha2CodeByName_IgnoreCaseTest(string countryName, string result)
        {
            var countries = new Iso3166Countries(StringComparer.OrdinalIgnoreCase);
            Assert.AreEqual(result, countries.GetAlpha2CodeByName(countryName));
        }
    }
}
