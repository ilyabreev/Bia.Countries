Bia.Countries
=============

ISO-3166-1 country codes for .NET.

This library provides easy way to query countries by ISO-3166-1 short name, full name, alpha 2, alpha 3 and numeric codes. In addition the library also includes country names as seen in Microsoft [Active Directory] Users and Computers (ADUC) on Windows Server 2012 R2.

C# example
-------------
```C#
// Iso3166Countries is a static class, no need to instantiate.

// Get all short country names as they appear in ISO-3166-1 standard.
List<string> shortNames = Iso3166Countries.GetAllShortNames();

// Get all country names as they appear in Microsoft Active Directory Users and Computers on Windows Server 2012 R2.
List<string> adNames = Iso3166Countries.GetAllActiveDirectoryNames();

// Get a country by ISO-3166-1 short name.
Iso3166Country brazil = Iso3166Countries.GetCountryByShortName("Brazil");

// Get a country by ISO-3166-1 full name.
Iso3166Country norway = Iso3166Countries.GetCountryByFullName("the Kingdom of Norway");

// Get a country by Active Directory name.
Iso3166Country russia = Iso3166Countries.GetCountryByActiveDirectoryName("Russia");

// Get a country by ISO-3166-1 Alpha2 code.
Iso3166Country usa = Iso3166Countries.GetCountryByAlpha2("US");

// Get a country by ISO-3166-1 Alpha3 code.
Iso3166Country china = Iso3166Countries.GetCountryByAlpha3("CHN");

// Get a country by ISO-3166-1 Numeric code.
Iso3166Country uk = Iso3166Countries.GetCountryByNumeric(826);

// Get individual properties of a country object.
string shortName = uk.ShortName;
string fullName = uk.FullName;
string adName = uk.ActiveDirectoryName;
string alpha2 = uk.Alpha2;
string alpha3 = uk.Alpha3;
int numeric = uk.Numeric.GetValueOrDefault(); // Numeric property is nullable int.

// Get indeterminate number of countries that have partial, case insensitive match in ISO-3166-1 short name.
// There are 29 countries that have string "land" in ISO-3166-1 short name.
List<Iso3166Country> lands = Iso3166Countries.GetCountryByPartialShortName("land");

// Get indeterminate number of countries that have partial, case insensitive match in ISO-3166-1 full name.
// There are 17 countries that have string "kingdom" in ISO-3166-1 full name.
List<Iso3166Country> kingdoms = Iso3166Countries.GetCountryByPartialFullName("kingdom");

// Get indeterminate number of countries that have partial, case insensitive match in Active Directory name.
// There are 25 countries that have string "island" in Active Directory name.
List<Iso3166Country> islands = Iso3166Countries.GetCountryByPartialActiveDirectoryName("island");
```

PowerShell example
-------------
```PowerShell
# Use Import-Module to load Bia.Countries.dll.
Import-Module 'C:\Path\To\Bia.Countries.dll'

# Get all short country names as they appear in ISO-3166-1 standard.
$shortNames = [Bia.Countries.Iso3166Countries]::GetAllShortNames()

# Get all country names as they appear in Microsoft Active Directory Users and Computers on Windows Server 2012 R2.
$adNames = [Bia.Countries.Iso3166Countries]::GetAllActiveDirectoryNames()

# Get a country by ISO-3166-1 short name.
$brazil = [Bia.Countries.Iso3166Countries]::GetCountryByShortName("Brazil")

# Get a country by ISO-3166-1 full name.
$norway = [Bia.Countries.Iso3166Countries]::GetCountryByFullName("the Kingdom of Norway")

# Get a country by Active Directory name.
$russia = [Bia.Countries.Iso3166Countries]::GetCountryByActiveDirectoryName("Russia")

# Get a country by ISO-3166-1 Alpha2 code.
$usa = [Bia.Countries.Iso3166Countries]::GetCountryByAlpha2("US")

# Get a country by ISO-3166-1 Alpha3 code.
$china = [Bia.Countries.Iso3166Countries]::GetCountryByAlpha3("CHN")

# Get a country by ISO-3166-1 Alpha3 code.
$uk = [Bia.Countries.Iso3166Countries]::GetCountryByNumeric(826)

# Get individual properties of a country object.
$shortName = $uk.ShortName
$fullName = $uk.FullName
$adName = $uk.ActiveDirectoryName
$alpha2 = $uk.Alpha2
$alpha3 = $uk.Alpha3
$numeric = $uk.Numeric
```

Install
-------------
[NuGet]: `Install-Package Bia.Countries` (Not up-to-date yet)

[PowerShell Gallery]: `Install-Package Bia.Countries` (Not available yet)

Resources
-------------
[iso.org](https://www.iso.org/obp/ui/#search/code/)

[ISO-3166-1]:https://en.wikipedia.org/wiki/ISO_3166-1
[Active Directory]:https://en.wikipedia.org/wiki/Active_Directory
[NuGet]:https://www.nuget.org/packages/Bia.Countries/
[PowerShell Gallery]:https://www.powershellgallery.com/
