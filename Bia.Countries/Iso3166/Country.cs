namespace Bia.Countries.Iso3166
{
    public class Country
    {
        public Country(string shortName, string fullName, string activeDirectoryName, CountryCode alpha2, 
            CountryCodeAlpha3 alpha3, int? numeric)
        {
            ShortName = shortName;
            FullName = fullName;
            ActiveDirectoryName = activeDirectoryName;
            Alpha2 = alpha2;
            Alpha3 = alpha3;
            Numeric = numeric;
        }

        public string ShortName { get; }

        public string FullName { get; }

        public string ActiveDirectoryName { get; }

        public CountryCode Alpha2 { get; }

        public CountryCodeAlpha3 Alpha3 { get; }

        public int? Numeric { get; }

        public override string ToString()
        {
            if (!string.IsNullOrWhiteSpace(ShortName))
            {
                return ShortName;
            }

            if (!string.IsNullOrWhiteSpace(ActiveDirectoryName))
            {
                return ActiveDirectoryName;
            }

            if (!string.IsNullOrWhiteSpace(FullName))
            {
                return FullName;
            }

            if (!string.IsNullOrWhiteSpace(Alpha2.ToString()))
            {
                return Alpha2.ToString();
            }

            if (!string.IsNullOrWhiteSpace(Alpha3.ToString()))
            {
                return Alpha3.ToString();
            }

            if (Numeric != null)
            {
                return Numeric.GetValueOrDefault().ToString();
            }

            return "";
        }
    }
}