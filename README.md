# [Bia.Countries]

ISO-3166-1 country codes for .NET.

This library provides easy way to query countries by their ISO-3166-1 short name, full name, alpha 2, alpha 3 and numeric codes.

### [Active Directory]

The library also includes country names as seen in Microsoft Active Directory Users and Computers (ADUC) on Windows Server 2012 R2. Several countries were added to the library that do not exist in, or have since been removed from ISO-3166-1. Such countries will have only ActiveDirectoryName, Alpha2 and Numeric properties. ShortName, FullName and Alpha3 properties are null to prevent them from appearing in most queries targeted for ISO-3166-1.

Here are some examples of differences between ActiveDirectoryName and ISO-3166-1 ShortName properties:
* ActiveDirectoryName: Cape Verde, ShortName: Cabo Verde
* ActiveDirectoryName: Korea, ShortName: Korea, Republic of
* ActiveDirectoryName: United Kingdom, ShortName: United Kingdom of Great Britain and Northern Ireland
* ActiveDirectoryName: United States, ShortName: United States of America
* ActiveDirectoryName: Russia, ShortName: Russian Federation

### C# example

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

### PowerShell example

```PowerShell
# Get all short country names as they appear in ISO-3166-1 standard.
$shortNames = Get-BiaAllShortNames

# Get all country names as they appear in Microsoft Active Directory Users and Computers on Windows Server 2012 R2.
$adNames = Get-BiaAllActiveDirectoryNames

# Get a country by ISO-3166-1 short name.
$brazil = Get-BiaCountryByShortName Brazil

# Get a country by ISO-3166-1 full name.
$norway = Get-BiaCountryByFullName "the Kingdom of Norway"

# Get a country by Active Directory name.
$russia = Get-BiaCountryByActiveDirectoryName Russia

# Get a country by ISO-3166-1 Alpha2 code.
$usa = Get-BiaCountryByAlpha2 US

# Get a country by ISO-3166-1 Alpha3 code.
$china = Get-BiaCountryByAlpha3 CHN

# Get a country by ISO-3166-1 Numeric code.
$uk = Get-BiaCountryByNumeric 826

# Get individual properties of a country object.
$uk.ShortName
$uk.FullName
$uk.ActiveDirectoryName
$uk.Alpha2
$uk.Alpha3
$uk.Numeric

# Get indeterminate number of countries that have partial, case insensitive match in ISO-3166-1 short name.
# There are 29 countries that have string "land" in ISO-3166-1 short name.
$lands = Get-BiaCountryByPartialShortName land

# Get indeterminate number of countries that have partial, case insensitive match in ISO-3166-1 full name.
# There are 17 countries that have string "kingdom" in ISO-3166-1 full name.
$kingdoms = Get-BiaCountryByPartialFullName kingdom

# Get indeterminate number of countries that have partial, case insensitive match in Active Directory name.
# There are 25 countries that have string "island" in Active Directory name.
$islands = Get-BiaCountryByPartialActiveDirectoryName island
```

### Install

* [NuGet]
* [PowerShell Gallery]

### Resources

* [iso.org Online Browsing Platform]
  - The Online Browsing Platform has a notification feature that can notify you of changes. 'Sig-in' or 'Register' and then select 'Follow' when listing country codes.

[Bia.Countries]:https://github.com/ilyabreev/Bia.Countries
[ISO-3166-1]:https://en.wikipedia.org/wiki/ISO_3166-1
[Active Directory]:https://en.wikipedia.org/wiki/Active_Directory
[NuGet]:https://www.nuget.org/packages/Bia.Countries/
[PowerShell Gallery]:https://www.powershellgallery.com/packages/Bia.Countries/
[iso.org Online Browsing Platform]:https://www.iso.org/obp/ui/#search/code/
