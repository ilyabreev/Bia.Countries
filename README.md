Bia.Countries
=============

ISO-3166-1 country codes for .NET

Why so serious?
-------------
.NET Framework globalization API is **extremely** uncomfortable in terms of ISO-3166 standard.
You don't have any simple way to get country code by it's name.

Example
-------------
`var alpha2 = Iso3166Countries.GetAlpha2CodeByName("Russian Federation") // RU`

Install
-------------
**via NuGet**: `Install-Package Bia.Countries`

Resources
-------------
[Wikipedia](https://en.wikipedia.org/wiki/ISO_3166-1)