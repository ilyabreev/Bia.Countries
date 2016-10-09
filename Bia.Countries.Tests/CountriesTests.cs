using System;
using NUnit.Framework;

namespace Bia.Countries.Tests
{
    [TestFixture]
    public class CountriesTests
    {
        [TestCase("Unexisting Country", false)]
        [TestCase(null, false)]
        [TestCase("", false)]
        [TestCase(" ", false)]
        [TestCase("United Kingdom", false)]
        [TestCase("United Kingdom of Great Britain and Northern Ireland", true)]
        [TestCase("Russian Federation", true)]
        [TestCase("Netherlands", true)]
        [TestCase("Spain", true)]
        [TestCase("Andorra", true)]
        [TestCase("BELGIUM", false)]
        [TestCase("RuSSiaN Federation", false)]
        [TestCase("andorra", false)]
        public void IsNameValid_Test(string countryName, string result)
        {
            var countries = new Iso3166Countries();
            Assert.AreEqual(result, countries.IsNameValid(countryName));
        }

        [TestCase("Unexisting Country", false)]
        [TestCase(null, false)]
        [TestCase("", false)]
        [TestCase(" ", false)]
        [TestCase("United Kingdom", false)]
        [TestCase("United Kingdom of Great Britain and Northern Ireland", true)]
        [TestCase("Russian Federation", true)]
        [TestCase("Netherlands", true)]
        [TestCase("Spain", true)]
        [TestCase("Andorra", true)]
        [TestCase("BELGIUM", true)]
        [TestCase("RuSSiaN Federation", true)]
        [TestCase("andorra", true)]
        public void IsNameValid_IgnoreCaseTest(string countryName, string result)
        {
            var countries = new Iso3166Countries(StringComparer.OrdinalIgnoreCase);
            Assert.AreEqual(result, countries.IsNameValid(countryName));
        }

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

        [TestCase("Unexisting Country", null)]
        [TestCase(null, null)]
        [TestCase("", null)]
        [TestCase(" ", null)]
        [TestCase("United Kingdom", null)]
        [TestCase("United Kingdom of Great Britain and Northern Ireland", "GBR")]
        [TestCase("Russian Federation", "RUS")]
        [TestCase("Netherlands", "NLD")]
        [TestCase("Spain", "ESP")]
        [TestCase("Andorra", "AND")]
        [TestCase("BELGIUM", null)]
        [TestCase("RuSSiaN Federation", null)]
        [TestCase("andorra", null)]
        public void GetAlpha3CodeByName_Test(string countryName, string result)
        {
            var countries = new Iso3166Countries();
            Assert.AreEqual(result, countries.GetAlpha3CodeByName(countryName));
        }

        [TestCase("Unexisting Country", null)]
        [TestCase(null, null)]
        [TestCase("", null)]
        [TestCase(" ", null)]
        [TestCase("United Kingdom", null)]
        [TestCase("UniTed KingdoM of GREAT Britain and NORTHERN Ireland", "GBR")]
        [TestCase("Russian Federation", "RUS")]
        [TestCase("Netherlands", "NLD")]
        [TestCase("Spain", "ESP")]
        [TestCase("Andorra", "AND")]
        [TestCase("BELGIUM", "BEL")]
        [TestCase("RuSSiaN Federation", "RUS")]
        [TestCase("andorra", "AND")]
        public void GetAlpha3CodeByName_IgnoreCaseTest(string countryName, string result)
        {
            var countries = new Iso3166Countries(StringComparer.OrdinalIgnoreCase);
            Assert.AreEqual(result, countries.GetAlpha3CodeByName(countryName));
        }

        [TestCase("Unexisting Country", null)]
        [TestCase(null, null)]
        [TestCase("", null)]
        [TestCase(" ", null)]
        [TestCase("United Kingdom", null)]
        [TestCase("United Kingdom of Great Britain and Northern Ireland", 826)]
        [TestCase("Russian Federation", 643)]
        [TestCase("Netherlands", 528)]
        [TestCase("Spain", 724)]
        [TestCase("Andorra", 20)]
        [TestCase("BELGIUM", null)]
        [TestCase("RuSSiaN Federation", null)]
        [TestCase("andorra", null)]
        public void GetNumericCodeByName_Test(string countryName, string result)
        {
            var countries = new Iso3166Countries();
            Assert.AreEqual(result, countries.GetNumericCodeByName(countryName));
        }

        [TestCase("Unexisting Country", null)]
        [TestCase(null, null)]
        [TestCase("", null)]
        [TestCase(" ", null)]
        [TestCase("United Kingdom", null)]
        [TestCase("United Kingdom of Great Britain and Northern Ireland", 826)]
        [TestCase("Russian Federation", 643)]
        [TestCase("Netherlands", 528)]
        [TestCase("Spain", 724)]
        [TestCase("Andorra", 20)]
        [TestCase("BELGIUM", 56)]
        [TestCase("RuSSiaN Federation", 643)]
        [TestCase("andorra", 20)]
        public void GetNumericCodeByName_IgnoreCaseTest(string countryName, string result)
        {
            var countries = new Iso3166Countries(StringComparer.OrdinalIgnoreCase);
            Assert.AreEqual(result, countries.GetNumericCodeByName(countryName));
        }
    }
}
