using System.Linq;
using NUnit.Framework;

namespace Bia.Countries.Tests
{
    [TestFixture]
    public class CountriesTests
    {
        [TestCase(null)]
        [TestCase("foobar")]
        [TestCase("")]
        [TestCase(" ")]
        public void NameAndAlpha_Test(string countryName)
        {
            var shortNameQuery = Iso3166Countries.GetCountryByShortName(countryName);
            Assert.IsNull(shortNameQuery);

            var fullNameQuery = Iso3166Countries.GetCountryByFullName(countryName);
            Assert.IsNull(fullNameQuery);

            var adNameQuery = Iso3166Countries.GetCountryByActiveDirectoryName(countryName);
            Assert.IsNull(adNameQuery);

            var alpha2Query = Iso3166Countries.GetCountryByAlpha2(countryName);
            Assert.IsNull(alpha2Query);

            var alpha3Query = Iso3166Countries.GetCountryByAlpha3(countryName);
            Assert.IsNull(alpha3Query);
        }

        [TestCase(0)]
        [TestCase(999)]
        [TestCase(-4)]
        [TestCase(null)]
        public void Numeric_Test(int? number)
        {
            var numericQuery = Iso3166Countries.GetCountryByNumeric(number);
            Assert.IsNull(numericQuery);
        }

        [TestCase("Åland Islands")]
        [TestCase("Côte d'Ivoire")]
        [TestCase("Curaçao")]
        [TestCase("United Kingdom of Great Britain and Northern Ireland")]
        [TestCase("United States of America")]
        [TestCase("Russian Federation")]
        public void ShortName_Test(string countryName)
        {
            var query = Iso3166Countries.GetCountryByShortName(countryName);
            Assert.IsNotNull(query);
        }

        [TestCase("the Commonwealth of the Bahamas")]
        [TestCase("the Republic of Cabo Verde")]
        [TestCase("the People's Republic of China")]
        [TestCase("the Federal Republic of Germany")]
        [TestCase("the Republic of Namibia")]
        [TestCase("the Bolivarian Republic of Venezuela")]
        public void FullName_Test(string countryName)
        {
            var query = Iso3166Countries.GetCountryByFullName(countryName);
            Assert.IsNotNull(query);
        }

        [TestCase("Baker Island")]
        [TestCase("Hong Kong SAR")]
        [TestCase("United Kingdom")]
        [TestCase("United States")]
        [TestCase("Russia")]
        public void ActiveDirectoryName_Test(string countryName)
        {
            var query = Iso3166Countries.GetCountryByActiveDirectoryName(countryName);
            Assert.IsNotNull(query);
        }

        [TestCase("GB")]
        [TestCase("US")]
        [TestCase("RU")]
        public void ActiveDirectoryAlpha2_Test(string code)
        {
            var query = Iso3166Countries.GetCountryByAlpha2(code);
            Assert.IsNotNull(query);
        }

        [TestCase("GBR")]
        [TestCase("USA")]
        [TestCase("RUS")]
        public void ActiveDirectoryAlpha3_Test(string code)
        {
            var query = Iso3166Countries.GetCountryByAlpha3(code);
            Assert.IsNotNull(query);
        }

        [TestCase(826)]
        [TestCase(840)]
        [TestCase(643)]
        public void ActiveDirectoryNumeric_Test(int code)
        {
            var query = Iso3166Countries.GetCountryByNumeric(code);
            Assert.IsNotNull(query);
        }

        [TestCase(null, 0)]
        [TestCase("foobar", 0)]
        [TestCase("rico", 1)]
        [TestCase("congo", 2)]
        [TestCase("land", 29)]
        public void PartialShortName_Test(string countryName, int result)
        {
            var query = Iso3166Countries.GetCountryByPartialShortName(countryName);
            Assert.IsNotNull(query);
            Assert.AreEqual(query.Count, result);
        }

        [TestCase(null, 0)]
        [TestCase("foobar", 0)]
        [TestCase("federation", 2)]
        [TestCase("kingdom", 17)]
        [TestCase("republic", 128)]
        public void PartialFullName_Test(string countryName, int result)
        {
            var query = Iso3166Countries.GetCountryByPartialFullName(countryName);
            Assert.IsNotNull(query);
            Assert.AreEqual(query.Count, result);
        }

        [TestCase(null, 0)]
        [TestCase("foobar", 0)]
        [TestCase("Bahamas", 1)]
        [TestCase("British", 2)]
        [TestCase("island", 25)]
        public void PartialActiveDirectoryName_Test(string countryName, int result)
        {
            var query = Iso3166Countries.GetCountryByPartialActiveDirectoryName(countryName);
            Assert.IsNotNull(query);
            Assert.AreEqual(query.Count, result);
        }

        [Test]
        public void SingleCountryForEachAlpha2Code()
        {
            var countries = Iso3166Countries.Countries.Cast<Iso3166Country>();
            Assert.IsTrue(countries.Where(c => c.Alpha2 != "XX").GroupBy(c => c.Alpha2).All(g => g.Count() == 1));
        }
    }
}
