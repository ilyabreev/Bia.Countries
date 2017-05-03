namespace Bia.Countries.Iso3166
{
    public class Country
    {
        public Country(string shortName, string fullName, string activeDirectoryName, string alpha2, string alpha3, int? numeric)
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

        public string Alpha2 { get; }

        public string Alpha3 { get; }

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

            if (!string.IsNullOrWhiteSpace(Alpha2))
            {
                return Alpha2;
            }

            if (!string.IsNullOrWhiteSpace(Alpha3))
            {
                return Alpha3;
            }

            if (Numeric != null)
            {
                return Numeric.GetValueOrDefault().ToString();
            }

            return "";
        }
    }
}