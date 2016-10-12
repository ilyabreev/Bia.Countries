namespace Bia.Countries
{
    public class Iso3166Country
    {
        public Iso3166Country(string shortName, string fullName, string activeDirectoryName, string alpha2, string alpha3, int? numeric)
        {
            ShortName = shortName;
            FullName = fullName;
            ActiveDirectoryName = activeDirectoryName;
            Alpha2 = alpha2;
            Alpha3 = alpha3;
            Numeric = numeric;
        }

        public string ShortName { get; private set; }
        public string FullName { get; private set; }
        public string ActiveDirectoryName { get; private set; }
        public string Alpha2 { get; private set; }
        public string Alpha3 { get; private set; }
        public int? Numeric { get; private set; }

        public override string ToString()
        {
            if (!string.IsNullOrWhiteSpace(ShortName))
            {
                return ShortName;
            }
            else if (!string.IsNullOrWhiteSpace(ActiveDirectoryName))
            {
                return ActiveDirectoryName;
            }
            else if (!string.IsNullOrWhiteSpace(FullName))
            {
                return FullName;
            }
            else if (!string.IsNullOrWhiteSpace(Alpha2))
            {
                return Alpha2;
            }
            else if (!string.IsNullOrWhiteSpace(Alpha3))
            {
                return Alpha3;
            }
            else if (Numeric != null)
            {
                return Numeric.GetValueOrDefault().ToString();
            }
            else
            {
                return "";
            }
        }
    }
}