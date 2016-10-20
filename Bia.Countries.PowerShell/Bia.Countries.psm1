Function Get-BiaAllShortNames
{
	<#
	.SYNOPSIS
	Get all short country names as they appear in the ISO 3166-1 standard.

	.EXAMPLE
	$shortNames = Get-BiaAllShortNames
	#>
	
	[OutputType([string[]])]
	Param ()
	
	[Bia.Countries.Iso3166Countries]::GetAllShortNames()
}

Function Get-BiaAllActiveDirectoryNames
{
	<#
	.SYNOPSIS
	Get all country names as they appear in Microsoft Active Directory Users and Computers on Windows Server 2012 R2.
	
	.EXAMPLE
	$adNames = Get-BiaAllActiveDirectoryNames
	#>
	
	[OutputType([string[]])]
	Param ()
	
	[Bia.Countries.Iso3166Countries]::GetAllActiveDirectoryNames()
}

Function Get-BiaCountryByShortName
{
	<#
	.SYNOPSIS
	Get a country by ISO 3166-1 short name.
	
	.PARAMETER ShortName
	Specifies a name to look for. If name does not exist, a null is returned.
	
	.EXAMPLE
	$brazil = Get-BiaCountryByShortName Brazil
	#>
	
	[OutputType([string[]])]
	Param (
		[Parameter(Mandatory = $true, Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true)]
		[Alias("Name")]
		[ValidateNotNullOrEmpty()]
		[string]
		$ShortName	
	)
	
	[Bia.Countries.Iso3166Countries]::GetCountryByShortName($ShortName)
}

Function Get-BiaCountryByFullName
{
	<#
	.SYNOPSIS
	Get a country by ISO 3166-1 full name.
	
	.PARAMETER FullName
	Specifies a name to look for. If name does not exist, a null is returned.
	
	.EXAMPLE
	$norway = Get-BiaCountryByFullName "the Kingdom of Norway"
	#>
	
	[OutputType([Bia.Countries.Iso3166Country])]
	Param (
		[Parameter(Mandatory = $true, Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true)]
		[Alias("Name")]
		[ValidateNotNullOrEmpty()]
		[string]
		$FullName
	)
	
	[Bia.Countries.Iso3166Countries]::GetCountryByFullName($FullName)
}

Function Get-BiaCountryByActiveDirectoryName
{
	<#
	.SYNOPSIS
	Get a country by Microsoft Active Directory name.
	
	.PARAMETER ActiveDirectoryName
	Specifies a name to look for. If name does not exist, a null is returned.
	
	.EXAMPLE
	$russia = Get-BiaCountryByActiveDirectoryName Russia
	#>
	
	[OutputType([Bia.Countries.Iso3166Country])]
	Param (
		[Parameter(Mandatory = $true, Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true)]
		[Alias("Name")]
		[ValidateNotNullOrEmpty()]
		[string]
		$ActiveDirectoryName
	)
	
	[Bia.Countries.Iso3166Countries]::GetCountryByActiveDirectoryName($ActiveDirectoryName)
}

Function Get-BiaCountryByAlpha2
{
	<#
	.SYNOPSIS
	Get a country by ISO 3166-1 alpha 2 code.
	
	.PARAMETER Alpha2
	Specifies an alpha 2 code to look for. If code does not exist, a null is returned.
	
	.EXAMPLE
	$usa = Get-BiaCountryByAlpha2 US
	#>
	
	[OutputType([Bia.Countries.Iso3166Country])]
	Param (
		[Parameter(Mandatory = $true, Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true)]
		[Alias("Code")]
		[ValidateNotNullOrEmpty()]
		[string]
		$Alpha2
	)
	
	[Bia.Countries.Iso3166Countries]::GetCountryByAlpha2($Alpha2)
}

Function Get-BiaCountryByAlpha3
{
	<#
	.SYNOPSIS
	Get a country by ISO 3166-1 alpha 3 code.
	
	.PARAMETER Alpha3
	Specifies an alpha 3 code to look for. If code does not exist, a null is returned.
	
	$china = Get-BiaCountryByAlpha3 CHN
	#>
	
	[OutputType([Bia.Countries.Iso3166Country])]
	Param (
		[Parameter(Mandatory = $true, Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true)]
		[Alias("Code")]
		[ValidateNotNullOrEmpty()]
		[string]
		$Alpha3
	)
	
	[Bia.Countries.Iso3166Countries]::GetCountryByAlpha3($Alpha3)
}

Function Get-BiaCountryByNumeric
{
	<#
	.SYNOPSIS
	Get a country by ISO 3166-1 numeric code.
	
	.PARAMETER Numeric
	Specifies n numeric code to look for. If code does not exist, a null is returned.
	
	.EXAMPLE
	$uk = Get-BiaCountryByNumeric 826
	#>
	
	[OutputType([Bia.Countries.Iso3166Country])]
	Param (
		[Parameter(Mandatory = $true, Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true)]
		[Alias("Code")]
		[ValidateNotNullOrEmpty()]
		[int]
		$Numeric
	)
	
	[Bia.Countries.Iso3166Countries]::GetCountryByNumeric($Numeric)
}

Function Get-BiaCountryByPartialShortName
{
	<#
	.SYNOPSIS
	Get a country by partial, case-insensitive ISO 3166-1 short name.
	
	.PARAMETER PartialShortName
	Specifies a partial, case-insensitive name to look for. If name does not exist, an empty List is returned.
	
	.EXAMPLE
	$lands = Get-BiaCountryByPartialShortName land
	
	There are 29 countries that have string "land" in ISO 3166-1 short name.
	#>
	
	[OutputType([System.Collections.Generic.List[Bia.Countries.Iso3166Country]])]
	Param (
		[Parameter(Mandatory = $true, Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true)]
		[Alias("Name")]
		[ValidateNotNullOrEmpty()]
		[string]
		$PartialShortName
	)
	
	[Bia.Countries.Iso3166Countries]::GetCountryByPartialShortName($PartialShortName)
}

Function Get-BiaCountryByPartialFullName
{
	<#
	.SYNOPSIS
	Get a country by partial, case-insensitive ISO 3166-1 full name.
	
	.PARAMETER PartialFullName
	Specifies a partial, case-insensitive name to look for. If name does not exist, an empty List is returned.
	
	.EXAMPLE
	$kingdoms = Get-BiaCountryByPartialFullName kingdom
	
	There are 17 countries that have string "kingdom" in ISO 3166-1 full name.
	#>
	
	[OutputType([System.Collections.Generic.List[Bia.Countries.Iso3166Country]])]
	Param (
		[Parameter(Mandatory = $true, Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true)]
		[Alias("Name")]
		[ValidateNotNullOrEmpty()]
		[string]
		$PartialFullName
	)
	
	[Bia.Countries.Iso3166Countries]::GetCountryByPartialFullName($PartialFullName)
}

Function Get-BiaCountryByPartialActiveDirectoryName
{
	<#
	.SYNOPSIS
	Get a country by partial, case-insensitive Microsoft Active Directory name.
	
	.PARAMETER PartialActiveDirectoryName
	Specifies a partial, case-insensitive name to look for. If name does not exist, an empty List is returned.
	
	.EXAMPLE
	$islands = Get-BiaCountryByPartialActiveDirectoryName island
	
	There are 25 countries that have string "island" in Active Directory name.
	#>
	
	[OutputType([System.Collections.Generic.List[Bia.Countries.Iso3166Country]])]
	Param (
		[Parameter(Mandatory = $true, Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true)]
		[Alias("Name")]
		[ValidateNotNullOrEmpty()]
		[string]
		$PartialActiveDirectoryName
	)
	
	[Bia.Countries.Iso3166Countries]::GetCountryByPartialActiveDirectoryName($PartialActiveDirectoryName)
}