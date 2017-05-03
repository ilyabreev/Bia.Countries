using System.Linq;
using NUnit.Framework;

namespace Bia.Countries.Tests
{
    using Bia.Countries.Iso3166;

    [TestFixture]
    public class CountriesTests
    {
        [TestCase(null)]
        [TestCase("foobar")]
        [TestCase("")]
        [TestCase(" ")]
        public void NameAndAlphaTest(string countryName)
        {
            var shortNameQuery = Countries.GetCountryByShortName(countryName);
            Assert.IsNull(shortNameQuery);

            var fullNameQuery = Countries.GetCountryByFullName(countryName);
            Assert.IsNull(fullNameQuery);

            var activeDirectoryName = Countries.GetCountryByActiveDirectoryName(countryName);
            Assert.IsNull(activeDirectoryName);

            var alpha2Query = Countries.GetCountryByAlpha2(countryName);
            Assert.IsNull(alpha2Query);

            var alpha3Query = Countries.GetCountryByAlpha3(countryName);
            Assert.IsNull(alpha3Query);
        }

        [TestCase(0)]
        [TestCase(999)]
        [TestCase(-4)]
        [TestCase(null)]
        public void NumericTest(int? number)
        {
            var numericQuery = Countries.GetCountryByNumeric(number);
            Assert.IsNull(numericQuery);
        }

        [TestCase("Åland Islands")]
        [TestCase("Côte d'Ivoire")]
        [TestCase("Curaçao")]
        [TestCase("United Kingdom of Great Britain and Northern Ireland")]
        [TestCase("United States of America")]
        [TestCase("Russian Federation")]
        public void ShortNameTest(string countryName)
        {
            var query = Countries.GetCountryByShortName(countryName);
            Assert.IsNotNull(query);
        }

        [TestCase("the Commonwealth of the Bahamas")]
        [TestCase("the Republic of Cabo Verde")]
        [TestCase("the People's Republic of China")]
        [TestCase("the Federal Republic of Germany")]
        [TestCase("the Republic of Namibia")]
        [TestCase("the Bolivarian Republic of Venezuela")]
        public void FullNameTest(string countryName)
        {
            var query = Countries.GetCountryByFullName(countryName);
            Assert.IsNotNull(query);
        }

        [TestCase("Baker Island")]
        [TestCase("Hong Kong SAR")]
        [TestCase("United Kingdom")]
        [TestCase("United States")]
        [TestCase("Russia")]
        public void ActiveDirectoryNameTest(string countryName)
        {
            var query = Countries.GetCountryByActiveDirectoryName(countryName);
            Assert.IsNotNull(query);
        }

        [TestCase("GB")]
        [TestCase("US")]
        [TestCase("RU")]
        public void ActiveDirectoryAlpha2Test(string code)
        {
            var query = Countries.GetCountryByAlpha2(code);
            Assert.IsNotNull(query);
        }

        [TestCase("GBR")]
        [TestCase("USA")]
        [TestCase("RUS")]
        public void ActiveDirectoryAlpha3Test(string code)
        {
            var query = Countries.GetCountryByAlpha3(code);
            Assert.IsNotNull(query);
        }

        [TestCase(826)]
        [TestCase(840)]
        [TestCase(643)]
        public void ActiveDirectoryNumericTest(int code)
        {
            var query = Countries.GetCountryByNumeric(code);
            Assert.IsNotNull(query);
        }

        [TestCase(null, 0)]
        [TestCase("foobar", 0)]
        [TestCase("rico", 1)]
        [TestCase("congo", 2)]
        [TestCase("land", 29)]
        public void PartialShortNameTest(string countryName, int result)
        {
            var query = Countries.GetCountryByPartialShortName(countryName);
            Assert.IsNotNull(query);
            Assert.AreEqual(query.Count, result);
        }

        [TestCase(null, 0)]
        [TestCase("foobar", 0)]
        [TestCase("federation", 2)]
        [TestCase("kingdom", 17)]
        [TestCase("republic", 128)]
        public void PartialFullNameTest(string countryName, int result)
        {
            var query = Countries.GetCountryByPartialFullName(countryName);
            Assert.IsNotNull(query);
            Assert.AreEqual(query.Count, result);
        }

        [TestCase(null, 0)]
        [TestCase("foobar", 0)]
        [TestCase("Bahamas", 1)]
        [TestCase("British", 2)]
        [TestCase("island", 25)]
        public void PartialActiveDirectoryNameTest(string countryName, int result)
        {
            var query = Countries.GetCountryByPartialActiveDirectoryName(countryName);
            Assert.IsNotNull(query);
            Assert.AreEqual(query.Count, result);
        }

        [Test]
        public void SingleCountryForEachAlpha2Code()
        {
            var countries = Countries.CountryList.Cast<Country>();
            Assert.IsTrue(countries.Where(c => c.Alpha2 != "XX").GroupBy(c => c.Alpha2).All(g => g.Count() == 1));
        }
    }
}
