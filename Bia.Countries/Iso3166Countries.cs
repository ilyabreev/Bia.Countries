using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Bia.Countries
{
    static public partial class Iso3166Countries
    {
        // Get all short names.
        public static List<string> GetAllShortNames()
        {
            return Countries.Where(c => c.ShortName != null).Select(c => c.ShortName).ToList();
        }

        // Get country by short name, case sensitive.
        public static Iso3166Country GetCountryByShortName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return null;

            return Countries.Where(c => c.ShortName != null && c.ShortName == name).FirstOrDefault();
        }

        // Get all countries by short name that partially match given input. Case insensitive.
        public static List<Iso3166Country> GetCountryByPartialShortName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return new List<Iso3166Country>();

            return Countries.Where(c => c.ShortName != null && CultureInfo.CurrentCulture.CompareInfo.IndexOf(c.ShortName, name, CompareOptions.OrdinalIgnoreCase) >= 0).ToList();
        }

        // Get country by full name, case sensitive.
        public static Iso3166Country GetCountryByFullName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return null;

            return Countries.Where(c => c.FullName != null && c.FullName == name).FirstOrDefault();
        }

        // Get all countries by full name that partially match given input. Case insensitive.
        public static List<Iso3166Country> GetCountryByPartialFullName(string countryName)
        {
            if (string.IsNullOrWhiteSpace(countryName))
                return new List<Iso3166Country>();

            return Countries.Where(c => c.FullName != null && CultureInfo.CurrentCulture.CompareInfo.IndexOf(c.FullName, countryName, CompareOptions.OrdinalIgnoreCase) >= 0).ToList();
        }

        // Get all Active Directory names.
        public static List<string> GetAllActiveDirectoryNames()
        {
            return Countries.Where(c => c.ActiveDirectoryName != null).Select(c => c.ActiveDirectoryName).ToList();
        }

        // Get country by Active Directory name, case sensitive.
        public static Iso3166Country GetCountryByActiveDirectoryName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return null;

            return Countries.Where(c => c.ActiveDirectoryName != null && c.ActiveDirectoryName == name).FirstOrDefault();
        }

        // Get all countries by Active Directory name that partially match given input. Case insensitive.
        public static List<Iso3166Country> GetCountryByPartialActiveDirectoryName(string countryName)
        {
            if (string.IsNullOrWhiteSpace(countryName))
                return new List<Iso3166Country>();

            return Countries.Where(c => c.ActiveDirectoryName != null && CultureInfo.CurrentCulture.CompareInfo.IndexOf(c.ActiveDirectoryName, countryName, CompareOptions.OrdinalIgnoreCase) >= 0).ToList();
        }

        // Get country by alpha2, case sensitive.
        public static Iso3166Country GetCountryByAlpha2(string code)
        {
            if (string.IsNullOrWhiteSpace(code))
                return null;

            return Countries.Where(c => c.Alpha2 != null && c.Alpha2 == code).FirstOrDefault();
        }

        // Get country by alpha3, case sensitive.
        public static Iso3166Country GetCountryByAlpha3(string code)
        {
            if (string.IsNullOrWhiteSpace(code))
                return null;

            return Countries.Where(c => c.Alpha3 != null && c.Alpha3 == code).FirstOrDefault();
        }

        // Get country by numeric.
        public static Iso3166Country GetCountryByNumeric(int? code)
        {
            if (code == null)
                return null;

            return Countries.Where(c => c.Numeric != null && c.Numeric == code).FirstOrDefault();
        }
    }
}
