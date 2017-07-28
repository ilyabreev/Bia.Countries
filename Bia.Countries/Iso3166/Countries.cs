namespace Bia.Countries.Iso3166
{
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public static partial class Countries
    {
        // Get all short names.
        public static List<string> GetAllShortNames()
        {
            return CountryList.Where(c => c.ShortName != null).Select(c => c.ShortName).ToList();
        }

        // Get country by short name, case sensitive.
        public static Country GetCountryByShortName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return null;
            }
            
            return CountryList.FirstOrDefault(c => c.ShortName != null && c.ShortName == name);
        }

        // Get all countries by short name that partially match given input. Case insensitive.
        public static List<Country> GetCountryByPartialShortName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return new List<Country>();
            }
            
            return CountryList.Where(c => c.ShortName != null && CultureInfo.CurrentCulture.CompareInfo.IndexOf(c.ShortName, name, CompareOptions.OrdinalIgnoreCase) >= 0).ToList();
        }

        // Get country by full name, case sensitive.
        public static Country GetCountryByFullName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return null;
            }

            return CountryList.FirstOrDefault(c => c.FullName != null && c.FullName == name);
        }

        // Get all countries by full name that partially match given input. Case insensitive.
        public static List<Country> GetCountryByPartialFullName(string countryName)
        {
            if (string.IsNullOrWhiteSpace(countryName))
            {
                return new List<Country>();
            }

            return CountryList.Where(c => c.FullName != null && CultureInfo.CurrentCulture.CompareInfo.IndexOf(c.FullName, countryName, CompareOptions.OrdinalIgnoreCase) >= 0).ToList();
        }

        // Get all Active Directory names.
        public static List<string> GetAllActiveDirectoryNames()
        {
            return CountryList.Where(c => c.ActiveDirectoryName != null).Select(c => c.ActiveDirectoryName).ToList();
        }

        // Get country by Active Directory name, case sensitive.
        public static Country GetCountryByActiveDirectoryName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return null;
            }

            return CountryList.FirstOrDefault(c => c.ActiveDirectoryName != null && c.ActiveDirectoryName == name);
        }

        // Get all countries by Active Directory name that partially match given input. Case insensitive.
        public static List<Country> GetCountryByPartialActiveDirectoryName(string countryName)
        {
            if (string.IsNullOrWhiteSpace(countryName))
            {
                return new List<Country>();
            }

            return CountryList.Where(c => c.ActiveDirectoryName != null && CultureInfo.CurrentCulture.CompareInfo.IndexOf(c.ActiveDirectoryName, countryName, CompareOptions.OrdinalIgnoreCase) >= 0).ToList();
        }

        // Get country by alpha2 code.
        public static Country GetCountryByAlpha2(CountryCode code)
        {
            if (code == CountryCode.None)
            {
                return null;
            }

            return CountryList.FirstOrDefault(c => c.Alpha2 == code);
        }

        // Get country by alpha3 code.
        public static Country GetCountryByAlpha3(CountryCodeAlpha3 code)
        {
            if (code == CountryCodeAlpha3.None)
            {
                return null;
            }

            return CountryList.FirstOrDefault(c => c.Alpha3 == code);
        }

        // Get country by alpha2, case sensitive.
        public static Country GetCountryByAlpha2(string code)
        {
            if (string.IsNullOrWhiteSpace(code))
            {
                return null;
            }

            return CountryList.FirstOrDefault(c => c.Alpha2 != CountryCode.None && c.Alpha2.ToString() == code);
        }

        // Get country by alpha3, case sensitive.
        public static Country GetCountryByAlpha3(string code)
        {
            if (string.IsNullOrWhiteSpace(code))
            {
                return null;
            }

            return CountryList.FirstOrDefault(c => c.Alpha3 != CountryCodeAlpha3.None && c.Alpha3.ToString() == code);
        }

        // Get country by numeric.
        public static Country GetCountryByNumeric(int? code)
        {
            if (code == null)
            {
                return null;
            }

            return CountryList.FirstOrDefault(c => c.Numeric != null && c.Numeric == code);
        }
    }
}
