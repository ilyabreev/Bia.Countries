using System;
using System.Collections.Generic;

namespace Bia.Countries
{
    public class Iso3166Countries
    {
        private readonly Dictionary<string, Iso3166Country> _countries;

        public Iso3166Countries(StringComparer comparer)
        {
            _countries = InitializeCountries(comparer);
        }

        public Iso3166Countries() : this(StringComparer.Ordinal)
        {
        }

        public Dictionary<string, Iso3166Country> Countries
        {
            get { return _countries; }
        }

        public bool IsNameValid(string countryName)
        {
            if (!String.IsNullOrWhiteSpace(countryName) && Countries.ContainsKey(countryName))
            {
                return true;
            }

            return false;
        }

        public string GetAlpha2CodeByName(string countryName)
        {
            if (String.IsNullOrWhiteSpace(countryName))
            {
                return null;
            }

            if (!Countries.ContainsKey(countryName))
            {
                return null;
            }

            return Countries[countryName].Alpha2;
        }

        public string GetAlpha3CodeByName(string countryName)
        {
            if (String.IsNullOrWhiteSpace(countryName))
            {
                return null;
            }

            if (!Countries.ContainsKey(countryName))
            {
                return null;
            }

            return Countries[countryName].Alpha3;
        }

        public int? GetMumericCodeByName(string countryName)
        {
            if (String.IsNullOrWhiteSpace(countryName))
            {
                return null;
            }

            if (!Countries.ContainsKey(countryName))
            {
                return null;
            }

            return Countries[countryName].Numeric;
        }

        private Dictionary<string, Iso3166Country> InitializeCountries(StringComparer comparer)
        {
            return new Dictionary<string, Iso3166Country>(comparer)
            {
                { "Afghanistan", new Iso3166Country { Name = "Afghanistan", Alpha2 = "AF", Alpha3 = "AFG", Numeric = 4 } },
                { "Albania", new Iso3166Country { Name = "Albania", Alpha2 = "AL", Alpha3 = "ALB", Numeric = 8 } },
                { "Algeria", new Iso3166Country { Name = "Algeria", Alpha2 = "DZ", Alpha3 = "DZA", Numeric = 12 } },
                { "American Samoa", new Iso3166Country { Name = "American Samoa", Alpha2 = "AS", Alpha3 = "ASM", Numeric = 16 } },
                { "Andorra", new Iso3166Country { Name = "Andorra", Alpha2 = "AD", Alpha3 = "AND", Numeric = 20 } },
                { "Angola", new Iso3166Country { Name = "Angola", Alpha2 = "AO", Alpha3 = "AGO", Numeric = 24 } },
                { "Anguilla", new Iso3166Country { Name = "Anguilla", Alpha2 = "AI", Alpha3 = "AIA", Numeric = 660 } },
                { "Antarctica", new Iso3166Country { Name = "Antarctica", Alpha2 = "AQ", Alpha3 = "ATA", Numeric = 10 } },
                { "Antigua and Barbuda", new Iso3166Country { Name = "Antigua and Barbuda", Alpha2 = "AG", Alpha3 = "ATG", Numeric = 28 } },
                { "Argentina", new Iso3166Country { Name = "Argentina", Alpha2 = "AR", Alpha3 = "ARG", Numeric = 32 } },
                { "Armenia", new Iso3166Country { Name = "Armenia", Alpha2 = "AM", Alpha3 = "ARM", Numeric = 51 } },
                { "Aruba", new Iso3166Country { Name = "Aruba", Alpha2 = "AW", Alpha3 = "ABW", Numeric = 533 } },
                { "Australia", new Iso3166Country { Name = "Australia", Alpha2 = "AU", Alpha3 = "AUS", Numeric = 36 } },
                { "Austria", new Iso3166Country { Name = "Austria", Alpha2 = "AT", Alpha3 = "AUT", Numeric = 40 } },
                { "Azerbaijan", new Iso3166Country { Name = "Azerbaijan", Alpha2 = "AZ", Alpha3 = "AZE", Numeric = 31 } },
                { "Bahamas", new Iso3166Country { Name = "Bahamas", Alpha2 = "BS", Alpha3 = "BHS", Numeric = 44 } },
                { "Bahrain", new Iso3166Country { Name = "Bahrain", Alpha2 = "BH", Alpha3 = "BHR", Numeric = 48 } },
                { "Bangladesh", new Iso3166Country { Name = "Bangladesh", Alpha2 = "BD", Alpha3 = "BGD", Numeric = 50 } },
                { "Barbados", new Iso3166Country { Name = "Barbados", Alpha2 = "BB", Alpha3 = "BRB", Numeric = 52 } },
                { "Belarus", new Iso3166Country { Name = "Belarus", Alpha2 = "BY", Alpha3 = "BLR", Numeric = 112 } },
                { "Belgium", new Iso3166Country { Name = "Belgium", Alpha2 = "BE", Alpha3 = "BEL", Numeric = 56 } },
                { "Belize", new Iso3166Country { Name = "Belize", Alpha2 = "BZ", Alpha3 = "BLZ", Numeric = 84 } },
                { "Benin", new Iso3166Country { Name = "Benin", Alpha2 = "BJ", Alpha3 = "BEN", Numeric = 204 } },
                { "Bermuda", new Iso3166Country { Name = "Bermuda", Alpha2 = "BM", Alpha3 = "BMU", Numeric = 60 } },
                { "Bhutan", new Iso3166Country { Name = "Bhutan", Alpha2 = "BT", Alpha3 = "BTN", Numeric = 64 } },
                { "Bolivia, Plurinational State of", new Iso3166Country { Name = "Bolivia, Plurinational State of", Alpha2 = "BO", Alpha3 = "BOL", Numeric = 68 } },
                { "Bonaire, Sint Eustatius and Saba", new Iso3166Country { Name = "Bonaire, Sint Eustatius and Saba", Alpha2 = "BQ", Alpha3 = "BES", Numeric = 535 } },
                { "Bosnia and Herzegovina", new Iso3166Country { Name = "Bosnia and Herzegovina", Alpha2 = "BA", Alpha3 = "BIH", Numeric = 70 } },
                { "Botswana", new Iso3166Country { Name = "Botswana", Alpha2 = "BW", Alpha3 = "BWA", Numeric = 72 } },
                { "Bouvet Island", new Iso3166Country { Name = "Bouvet Island", Alpha2 = "BV", Alpha3 = "BVT", Numeric = 74 } },
                { "Brazil", new Iso3166Country { Name = "Brazil", Alpha2 = "BR", Alpha3 = "BRA", Numeric = 76 } },
                { "British Indian Ocean Territory", new Iso3166Country { Name = "British Indian Ocean Territory", Alpha2 = "IO", Alpha3 = "IOT", Numeric = 86 } },
                { "Brunei Darussalam", new Iso3166Country { Name = "Brunei Darussalam", Alpha2 = "BN", Alpha3 = "BRN", Numeric = 96 } },
                { "Bulgaria", new Iso3166Country { Name = "Bulgaria", Alpha2 = "BG", Alpha3 = "BGR", Numeric = 100 } },
                { "Burkina Faso", new Iso3166Country { Name = "Burkina Faso", Alpha2 = "BF", Alpha3 = "BFA", Numeric = 854 } },
                { "Burundi", new Iso3166Country { Name = "Burundi", Alpha2 = "BI", Alpha3 = "BDI", Numeric = 108 } },
                { "Cambodia", new Iso3166Country { Name = "Cambodia", Alpha2 = "KH", Alpha3 = "KHM", Numeric = 116 } },
                { "Cameroon", new Iso3166Country { Name = "Cameroon", Alpha2 = "CM", Alpha3 = "CMR", Numeric = 120 } },
                { "Canada", new Iso3166Country { Name = "Canada", Alpha2 = "CA", Alpha3 = "CAN", Numeric = 124 } },
                { "Cabo Verde", new Iso3166Country { Name = "Cabo Verde", Alpha2 = "CV", Alpha3 = "CPV", Numeric = 132 } },
                { "Cayman Islands", new Iso3166Country { Name = "Cayman Islands", Alpha2 = "KY", Alpha3 = "CYM", Numeric = 136 } },
                { "Central African Republic", new Iso3166Country { Name = "Central African Republic", Alpha2 = "CF", Alpha3 = "CAF", Numeric = 140 } },
                { "Chad", new Iso3166Country { Name = "Chad", Alpha2 = "TD", Alpha3 = "TCD", Numeric = 148 } },
                { "Chile", new Iso3166Country { Name = "Chile", Alpha2 = "CL", Alpha3 = "CHL", Numeric = 152 } },
                { "China", new Iso3166Country { Name = "China", Alpha2 = "CN", Alpha3 = "CHN", Numeric = 156 } },
                { "Christmas Island", new Iso3166Country { Name = "Christmas Island", Alpha2 = "CX", Alpha3 = "CXR", Numeric = 162 } },
                { "Cocos (Keeling) Islands", new Iso3166Country { Name = "Cocos (Keeling) Islands", Alpha2 = "CC", Alpha3 = "CCK", Numeric = 166 } },
                { "Colombia", new Iso3166Country { Name = "Colombia", Alpha2 = "CO", Alpha3 = "COL", Numeric = 170 } },
                { "Comoros", new Iso3166Country { Name = "Comoros", Alpha2 = "KM", Alpha3 = "COM", Numeric = 174 } },
                { "Congo", new Iso3166Country { Name = "Congo", Alpha2 = "CG", Alpha3 = "COG", Numeric = 178 } },
                { "Congo, the Democratic Republic of the", new Iso3166Country { Name = "Congo, the Democratic Republic of the", Alpha2 = "CD", Alpha3 = "COD", Numeric = 180 } },
                { "Cook Islands", new Iso3166Country { Name = "Cook Islands", Alpha2 = "CK", Alpha3 = "COK", Numeric = 184 } },
                { "Costa Rica", new Iso3166Country { Name = "Costa Rica", Alpha2 = "CR", Alpha3 = "CRI", Numeric = 188 } },
                { "Croatia", new Iso3166Country { Name = "Croatia", Alpha2 = "HR", Alpha3 = "HRV", Numeric = 191 } },
                { "Cuba", new Iso3166Country { Name = "Cuba", Alpha2 = "CU", Alpha3 = "CUB", Numeric = 192 } },
                { "Cyprus", new Iso3166Country { Name = "Cyprus", Alpha2 = "CY", Alpha3 = "CYP", Numeric = 196 } },
                { "Czech Republic", new Iso3166Country { Name = "Czech Republic", Alpha2 = "CZ", Alpha3 = "CZE", Numeric = 203 } },
                { "Denmark", new Iso3166Country { Name = "Denmark", Alpha2 = "DK", Alpha3 = "DNK", Numeric = 208 } },
                { "Djibouti", new Iso3166Country { Name = "Djibouti", Alpha2 = "DJ", Alpha3 = "DJI", Numeric = 262 } },
                { "Dominica", new Iso3166Country { Name = "Dominica", Alpha2 = "DM", Alpha3 = "DMA", Numeric = 212 } },
                { "Dominican Republic", new Iso3166Country { Name = "Dominican Republic", Alpha2 = "DO", Alpha3 = "DOM", Numeric = 214 } },
                { "Ecuador", new Iso3166Country { Name = "Ecuador", Alpha2 = "EC", Alpha3 = "ECU", Numeric = 218 } },
                { "Egypt", new Iso3166Country { Name = "Egypt", Alpha2 = "EG", Alpha3 = "EGY", Numeric = 818 } },
                { "El Salvador", new Iso3166Country { Name = "El Salvador", Alpha2 = "SV", Alpha3 = "SLV", Numeric = 222 } },
                { "Equatorial Guinea", new Iso3166Country { Name = "Equatorial Guinea", Alpha2 = "GQ", Alpha3 = "GNQ", Numeric = 226 } },
                { "Eritrea", new Iso3166Country { Name = "Eritrea", Alpha2 = "ER", Alpha3 = "ERI", Numeric = 232 } },
                { "Estonia", new Iso3166Country { Name = "Estonia", Alpha2 = "EE", Alpha3 = "EST", Numeric = 233 } },
                { "Ethiopia", new Iso3166Country { Name = "Ethiopia", Alpha2 = "ET", Alpha3 = "ETH", Numeric = 231 } },
                { "Falkland Islands (Malvinas)", new Iso3166Country { Name = "Falkland Islands (Malvinas)", Alpha2 = "FK", Alpha3 = "FLK", Numeric = 238 } },
                { "Faroe Islands", new Iso3166Country { Name = "Faroe Islands", Alpha2 = "FO", Alpha3 = "FRO", Numeric = 234 } },
                { "Fiji", new Iso3166Country { Name = "Fiji", Alpha2 = "FJ", Alpha3 = "FJI", Numeric = 242 } },
                { "Finland", new Iso3166Country { Name = "Finland", Alpha2 = "FI", Alpha3 = "FIN", Numeric = 246 } },
                { "France", new Iso3166Country { Name = "France", Alpha2 = "FR", Alpha3 = "FRA", Numeric = 250 } },
                { "French Guiana", new Iso3166Country { Name = "French Guiana", Alpha2 = "GF", Alpha3 = "GUF", Numeric = 254 } },
                { "French Polynesia", new Iso3166Country { Name = "French Polynesia", Alpha2 = "PF", Alpha3 = "PYF", Numeric = 258 } },
                { "French Southern Territories", new Iso3166Country { Name = "French Southern Territories", Alpha2 = "TF", Alpha3 = "ATF", Numeric = 260 } },
                { "Gabon", new Iso3166Country { Name = "Gabon", Alpha2 = "GA", Alpha3 = "GAB", Numeric = 266 } },
                { "Gambia", new Iso3166Country { Name = "Gambia", Alpha2 = "GM", Alpha3 = "GMB", Numeric = 270 } },
                { "Georgia", new Iso3166Country { Name = "Georgia", Alpha2 = "GE", Alpha3 = "GEO", Numeric = 268 } },
                { "Germany", new Iso3166Country { Name = "Germany", Alpha2 = "DE", Alpha3 = "DEU", Numeric = 276 } },
                { "Ghana", new Iso3166Country { Name = "Ghana", Alpha2 = "GH", Alpha3 = "GHA", Numeric = 288 } },
                { "Gibraltar", new Iso3166Country { Name = "Gibraltar", Alpha2 = "GI", Alpha3 = "GIB", Numeric = 292 } },
                { "Greece", new Iso3166Country { Name = "Greece", Alpha2 = "GR", Alpha3 = "GRC", Numeric = 300 } },
                { "Greenland", new Iso3166Country { Name = "Greenland", Alpha2 = "GL", Alpha3 = "GRL", Numeric = 304 } },
                { "Grenada", new Iso3166Country { Name = "Grenada", Alpha2 = "GD", Alpha3 = "GRD", Numeric = 308 } },
                { "Guadeloupe", new Iso3166Country { Name = "Guadeloupe", Alpha2 = "GP", Alpha3 = "GLP", Numeric = 312 } },
                { "Guam", new Iso3166Country { Name = "Guam", Alpha2 = "GU", Alpha3 = "GUM", Numeric = 316 } },
                { "Guatemala", new Iso3166Country { Name = "Guatemala", Alpha2 = "GT", Alpha3 = "GTM", Numeric = 320 } },
                { "Guernsey", new Iso3166Country { Name = "Guernsey", Alpha2 = "GG", Alpha3 = "GGY", Numeric = 831 } },
                { "Guinea", new Iso3166Country { Name = "Guinea", Alpha2 = "GN", Alpha3 = "GIN", Numeric = 324 } },
                { "Guinea-Bissau", new Iso3166Country { Name = "Guinea-Bissau", Alpha2 = "GW", Alpha3 = "GNB", Numeric = 624 } },
                { "Guyana", new Iso3166Country { Name = "Guyana", Alpha2 = "GY", Alpha3 = "GUY", Numeric = 328 } },
                { "Haiti", new Iso3166Country { Name = "Haiti", Alpha2 = "HT", Alpha3 = "HTI", Numeric = 332 } },
                { "Heard Island and McDonald Islands", new Iso3166Country { Name = "Heard Island and McDonald Islands", Alpha2 = "HM", Alpha3 = "HMD", Numeric = 334 } },
                { "Holy See (Vatican City State)", new Iso3166Country { Name = "Holy See (Vatican City State)", Alpha2 = "VA", Alpha3 = "VAT", Numeric = 336 } },
                { "Honduras", new Iso3166Country { Name = "Honduras", Alpha2 = "HN", Alpha3 = "HND", Numeric = 340 } },
                { "Hong Kong", new Iso3166Country { Name = "Hong Kong", Alpha2 = "HK", Alpha3 = "HKG", Numeric = 344 } },
                { "Hungary", new Iso3166Country { Name = "Hungary", Alpha2 = "HU", Alpha3 = "HUN", Numeric = 348 } },
                { "Iceland", new Iso3166Country { Name = "Iceland", Alpha2 = "IS", Alpha3 = "ISL", Numeric = 352 } },
                { "India", new Iso3166Country { Name = "India", Alpha2 = "IN", Alpha3 = "IND", Numeric = 356 } },
                { "Indonesia", new Iso3166Country { Name = "Indonesia", Alpha2 = "ID", Alpha3 = "IDN", Numeric = 360 } },
                { "Iran, Islamic Republic of", new Iso3166Country { Name = "Iran, Islamic Republic of", Alpha2 = "IR", Alpha3 = "IRN", Numeric = 364 } },
                { "Iraq", new Iso3166Country { Name = "Iraq", Alpha2 = "IQ", Alpha3 = "IRQ", Numeric = 368 } },
                { "Ireland", new Iso3166Country { Name = "Ireland", Alpha2 = "IE", Alpha3 = "IRL", Numeric = 372 } },
                { "Isle of Man", new Iso3166Country { Name = "Isle of Man", Alpha2 = "IM", Alpha3 = "IMN", Numeric = 833 } },
                { "Israel", new Iso3166Country { Name = "Israel", Alpha2 = "IL", Alpha3 = "ISR", Numeric = 376 } },
                { "Italy", new Iso3166Country { Name = "Italy", Alpha2 = "IT", Alpha3 = "ITA", Numeric = 380 } },
                { "Jamaica", new Iso3166Country { Name = "Jamaica", Alpha2 = "JM", Alpha3 = "JAM", Numeric = 388 } },
                { "Japan", new Iso3166Country { Name = "Japan", Alpha2 = "JP", Alpha3 = "JPN", Numeric = 392 } },
                { "Jersey", new Iso3166Country { Name = "Jersey", Alpha2 = "JE", Alpha3 = "JEY", Numeric = 832 } },
                { "Jordan", new Iso3166Country { Name = "Jordan", Alpha2 = "JO", Alpha3 = "JOR", Numeric = 400 } },
                { "Kazakhstan", new Iso3166Country { Name = "Kazakhstan", Alpha2 = "KZ", Alpha3 = "KAZ", Numeric = 398 } },
                { "Kenya", new Iso3166Country { Name = "Kenya", Alpha2 = "KE", Alpha3 = "KEN", Numeric = 404 } },
                { "Kiribati", new Iso3166Country { Name = "Kiribati", Alpha2 = "KI", Alpha3 = "KIR", Numeric = 296 } },
                { "Korea, Democratic People's Republic of", new Iso3166Country { Name = "Korea, Democratic People's Republic of", Alpha2 = "KP", Alpha3 = "PRK", Numeric = 408 } },
                { "Korea, Republic of", new Iso3166Country { Name = "Korea, Republic of", Alpha2 = "KR", Alpha3 = "KOR", Numeric = 410 } },
                { "Kuwait", new Iso3166Country { Name = "Kuwait", Alpha2 = "KW", Alpha3 = "KWT", Numeric = 414 } },
                { "Kyrgyzstan", new Iso3166Country { Name = "Kyrgyzstan", Alpha2 = "KG", Alpha3 = "KGZ", Numeric = 417 } },
                { "Lao People's Democratic Republic", new Iso3166Country { Name = "Lao People's Democratic Republic", Alpha2 = "LA", Alpha3 = "LAO", Numeric = 418 } },
                { "Latvia", new Iso3166Country { Name = "Latvia", Alpha2 = "LV", Alpha3 = "LVA", Numeric = 428 } },
                { "Lebanon", new Iso3166Country { Name = "Lebanon", Alpha2 = "LB", Alpha3 = "LBN", Numeric = 422 } },
                { "Lesotho", new Iso3166Country { Name = "Lesotho", Alpha2 = "LS", Alpha3 = "LSO", Numeric = 426 } },
                { "Liberia", new Iso3166Country { Name = "Liberia", Alpha2 = "LR", Alpha3 = "LBR", Numeric = 430 } },
                { "Libya", new Iso3166Country { Name = "Libya", Alpha2 = "LY", Alpha3 = "LBY", Numeric = 434 } },
                { "Liechtenstein", new Iso3166Country { Name = "Liechtenstein", Alpha2 = "LI", Alpha3 = "LIE", Numeric = 438 } },
                { "Lithuania", new Iso3166Country { Name = "Lithuania", Alpha2 = "LT", Alpha3 = "LTU", Numeric = 440 } },
                { "Luxembourg", new Iso3166Country { Name = "Luxembourg", Alpha2 = "LU", Alpha3 = "LUX", Numeric = 442 } },
                { "Macao", new Iso3166Country { Name = "Macao", Alpha2 = "MO", Alpha3 = "MAC", Numeric = 446 } },
                { "Macedonia, the former Yugoslav Republic of", new Iso3166Country { Name = "Macedonia, the former Yugoslav Republic of", Alpha2 = "MK", Alpha3 = "MKD", Numeric = 807 } },
                { "Madagascar", new Iso3166Country { Name = "Madagascar", Alpha2 = "MG", Alpha3 = "MDG", Numeric = 450 } },
                { "Malawi", new Iso3166Country { Name = "Malawi", Alpha2 = "MW", Alpha3 = "MWI", Numeric = 454 } },
                { "Malaysia", new Iso3166Country { Name = "Malaysia", Alpha2 = "MY", Alpha3 = "MYS", Numeric = 458 } },
                { "Maldives", new Iso3166Country { Name = "Maldives", Alpha2 = "MV", Alpha3 = "MDV", Numeric = 462 } },
                { "Mali", new Iso3166Country { Name = "Mali", Alpha2 = "ML", Alpha3 = "MLI", Numeric = 466 } },
                { "Malta", new Iso3166Country { Name = "Malta", Alpha2 = "MT", Alpha3 = "MLT", Numeric = 470 } },
                { "Marshall Islands", new Iso3166Country { Name = "Marshall Islands", Alpha2 = "MH", Alpha3 = "MHL", Numeric = 584 } },
                { "Martinique", new Iso3166Country { Name = "Martinique", Alpha2 = "MQ", Alpha3 = "MTQ", Numeric = 474 } },
                { "Mauritania", new Iso3166Country { Name = "Mauritania", Alpha2 = "MR", Alpha3 = "MRT", Numeric = 478 } },
                { "Mauritius", new Iso3166Country { Name = "Mauritius", Alpha2 = "MU", Alpha3 = "MUS", Numeric = 480 } },
                { "Mayotte", new Iso3166Country { Name = "Mayotte", Alpha2 = "YT", Alpha3 = "MYT", Numeric = 175 } },
                { "Mexico", new Iso3166Country { Name = "Mexico", Alpha2 = "MX", Alpha3 = "MEX", Numeric = 484 } },
                { "Micronesia, Federated States of", new Iso3166Country { Name = "Micronesia, Federated States of", Alpha2 = "FM", Alpha3 = "FSM", Numeric = 583 } },
                { "Moldova, Republic of", new Iso3166Country { Name = "Moldova, Republic of", Alpha2 = "MD", Alpha3 = "MDA", Numeric = 498 } },
                { "Monaco", new Iso3166Country { Name = "Monaco", Alpha2 = "MC", Alpha3 = "MCO", Numeric = 492 } },
                { "Mongolia", new Iso3166Country { Name = "Mongolia", Alpha2 = "MN", Alpha3 = "MNG", Numeric = 496 } },
                { "Montenegro", new Iso3166Country { Name = "Montenegro", Alpha2 = "ME", Alpha3 = "MNE", Numeric = 499 } },
                { "Montserrat", new Iso3166Country { Name = "Montserrat", Alpha2 = "MS", Alpha3 = "MSR", Numeric = 500 } },
                { "Morocco", new Iso3166Country { Name = "Morocco", Alpha2 = "MA", Alpha3 = "MAR", Numeric = 504 } },
                { "Mozambique", new Iso3166Country { Name = "Mozambique", Alpha2 = "MZ", Alpha3 = "MOZ", Numeric = 508 } },
                { "Myanmar", new Iso3166Country { Name = "Myanmar", Alpha2 = "MM", Alpha3 = "MMR", Numeric = 104 } },
                { "Namibia", new Iso3166Country { Name = "Namibia", Alpha2 = "NA", Alpha3 = "NAM", Numeric = 516 } },
                { "Nauru", new Iso3166Country { Name = "Nauru", Alpha2 = "NR", Alpha3 = "NRU", Numeric = 520 } },
                { "Nepal", new Iso3166Country { Name = "Nepal", Alpha2 = "NP", Alpha3 = "NPL", Numeric = 524 } },
                { "Netherlands", new Iso3166Country { Name = "Netherlands", Alpha2 = "NL", Alpha3 = "NLD", Numeric = 528 } },
                { "New Caledonia", new Iso3166Country { Name = "New Caledonia", Alpha2 = "NC", Alpha3 = "NCL", Numeric = 540 } },
                { "New Zealand", new Iso3166Country { Name = "New Zealand", Alpha2 = "NZ", Alpha3 = "NZL", Numeric = 554 } },
                { "Nicaragua", new Iso3166Country { Name = "Nicaragua", Alpha2 = "NI", Alpha3 = "NIC", Numeric = 558 } },
                { "Niger", new Iso3166Country { Name = "Niger", Alpha2 = "NE", Alpha3 = "NER", Numeric = 562 } },
                { "Nigeria", new Iso3166Country { Name = "Nigeria", Alpha2 = "NG", Alpha3 = "NGA", Numeric = 566 } },
                { "Niue", new Iso3166Country { Name = "Niue", Alpha2 = "NU", Alpha3 = "NIU", Numeric = 570 } },
                { "Norfolk Island", new Iso3166Country { Name = "Norfolk Island", Alpha2 = "NF", Alpha3 = "NFK", Numeric = 574 } },
                { "Northern Mariana Islands", new Iso3166Country { Name = "Northern Mariana Islands", Alpha2 = "MP", Alpha3 = "MNP", Numeric = 580 } },
                { "Norway", new Iso3166Country { Name = "Norway", Alpha2 = "NO", Alpha3 = "NOR", Numeric = 578 } },
                { "Oman", new Iso3166Country { Name = "Oman", Alpha2 = "OM", Alpha3 = "OMN", Numeric = 512 } },
                { "Pakistan", new Iso3166Country { Name = "Pakistan", Alpha2 = "PK", Alpha3 = "PAK", Numeric = 586 } },
                { "Palau", new Iso3166Country { Name = "Palau", Alpha2 = "PW", Alpha3 = "PLW", Numeric = 585 } },
                { "Palestine, State of", new Iso3166Country { Name = "Palestine, State of", Alpha2 = "PS", Alpha3 = "PSE", Numeric = 275 } },
                { "Panama", new Iso3166Country { Name = "Panama", Alpha2 = "PA", Alpha3 = "PAN", Numeric = 591 } },
                { "Papua New Guinea", new Iso3166Country { Name = "Papua New Guinea", Alpha2 = "PG", Alpha3 = "PNG", Numeric = 598 } },
                { "Paraguay", new Iso3166Country { Name = "Paraguay", Alpha2 = "PY", Alpha3 = "PRY", Numeric = 600 } },
                { "Peru", new Iso3166Country { Name = "Peru", Alpha2 = "PE", Alpha3 = "PER", Numeric = 604 } },
                { "Philippines", new Iso3166Country { Name = "Philippines", Alpha2 = "PH", Alpha3 = "PHL", Numeric = 608 } },
                { "Pitcairn", new Iso3166Country { Name = "Pitcairn", Alpha2 = "PN", Alpha3 = "PCN", Numeric = 612 } },
                { "Poland", new Iso3166Country { Name = "Poland", Alpha2 = "PL", Alpha3 = "POL", Numeric = 616 } },
                { "Portugal", new Iso3166Country { Name = "Portugal", Alpha2 = "PT", Alpha3 = "PRT", Numeric = 620 } },
                { "Puerto Rico", new Iso3166Country { Name = "Puerto Rico", Alpha2 = "PR", Alpha3 = "PRI", Numeric = 630 } },
                { "Qatar", new Iso3166Country { Name = "Qatar", Alpha2 = "QA", Alpha3 = "QAT", Numeric = 634 } },
                { "Romania", new Iso3166Country { Name = "Romania", Alpha2 = "RO", Alpha3 = "ROU", Numeric = 642 } },
                { "Russian Federation", new Iso3166Country { Name = "Russian Federation", Alpha2 = "RU", Alpha3 = "RUS", Numeric = 643 } },
                { "Rwanda", new Iso3166Country { Name = "Rwanda", Alpha2 = "RW", Alpha3 = "RWA", Numeric = 646 } },
                { "Saint Helena, Ascension and Tristan da Cunha", new Iso3166Country { Name = "Saint Helena, Ascension and Tristan da Cunha", Alpha2 = "SH", Alpha3 = "SHN", Numeric = 654 } },
                { "Saint Kitts and Nevis", new Iso3166Country { Name = "Saint Kitts and Nevis", Alpha2 = "KN", Alpha3 = "KNA", Numeric = 659 } },
                { "Saint Lucia", new Iso3166Country { Name = "Saint Lucia", Alpha2 = "LC", Alpha3 = "LCA", Numeric = 662 } },
                { "Saint Martin (French part)", new Iso3166Country { Name = "Saint Martin (French part)", Alpha2 = "MF", Alpha3 = "MAF", Numeric = 663 } },
                { "Saint Pierre and Miquelon", new Iso3166Country { Name = "Saint Pierre and Miquelon", Alpha2 = "PM", Alpha3 = "SPM", Numeric = 666 } },
                { "Saint Vincent and the Grenadines", new Iso3166Country { Name = "Saint Vincent and the Grenadines", Alpha2 = "VC", Alpha3 = "VCT", Numeric = 670 } },
                { "Samoa", new Iso3166Country { Name = "Samoa", Alpha2 = "WS", Alpha3 = "WSM", Numeric = 882 } },
                { "San Marino", new Iso3166Country { Name = "San Marino", Alpha2 = "SM", Alpha3 = "SMR", Numeric = 674 } },
                { "Sao Tome and Principe", new Iso3166Country { Name = "Sao Tome and Principe", Alpha2 = "ST", Alpha3 = "STP", Numeric = 678 } },
                { "Saudi Arabia", new Iso3166Country { Name = "Saudi Arabia", Alpha2 = "SA", Alpha3 = "SAU", Numeric = 682 } },
                { "Senegal", new Iso3166Country { Name = "Senegal", Alpha2 = "SN", Alpha3 = "SEN", Numeric = 686 } },
                { "Serbia", new Iso3166Country { Name = "Serbia", Alpha2 = "RS", Alpha3 = "SRB", Numeric = 688 } },
                { "Seychelles", new Iso3166Country { Name = "Seychelles", Alpha2 = "SC", Alpha3 = "SYC", Numeric = 690 } },
                { "Sierra Leone", new Iso3166Country { Name = "Sierra Leone", Alpha2 = "SL", Alpha3 = "SLE", Numeric = 694 } },
                { "Singapore", new Iso3166Country { Name = "Singapore", Alpha2 = "SG", Alpha3 = "SGP", Numeric = 702 } },
                { "Sint Maarten (Dutch part)", new Iso3166Country { Name = "Sint Maarten (Dutch part)", Alpha2 = "SX", Alpha3 = "SXM", Numeric = 534 } },
                { "Slovakia", new Iso3166Country { Name = "Slovakia", Alpha2 = "SK", Alpha3 = "SVK", Numeric = 703 } },
                { "Slovenia", new Iso3166Country { Name = "Slovenia", Alpha2 = "SI", Alpha3 = "SVN", Numeric = 705 } },
                { "Solomon Islands", new Iso3166Country { Name = "Solomon Islands", Alpha2 = "SB", Alpha3 = "SLB", Numeric = 90 } },
                { "Somalia", new Iso3166Country { Name = "Somalia", Alpha2 = "SO", Alpha3 = "SOM", Numeric = 706 } },
                { "South Africa", new Iso3166Country { Name = "South Africa", Alpha2 = "ZA", Alpha3 = "ZAF", Numeric = 710 } },
                { "South Georgia and the South Sandwich Islands", new Iso3166Country { Name = "South Georgia and the South Sandwich Islands", Alpha2 = "GS", Alpha3 = "SGS", Numeric = 239 } },
                { "South Sudan", new Iso3166Country { Name = "South Sudan", Alpha2 = "SS", Alpha3 = "SSD", Numeric = 728 } },
                { "Spain", new Iso3166Country { Name = "Spain", Alpha2 = "ES", Alpha3 = "ESP", Numeric = 724 } },
                { "Sri Lanka", new Iso3166Country { Name = "Sri Lanka", Alpha2 = "LK", Alpha3 = "LKA", Numeric = 144 } },
                { "Sudan", new Iso3166Country { Name = "Sudan", Alpha2 = "SD", Alpha3 = "SDN", Numeric = 729 } },
                { "Suriname", new Iso3166Country { Name = "Suriname", Alpha2 = "SR", Alpha3 = "SUR", Numeric = 740 } },
                { "Svalbard and Jan Mayen", new Iso3166Country { Name = "Svalbard and Jan Mayen", Alpha2 = "SJ", Alpha3 = "SJM", Numeric = 744 } },
                { "Swaziland", new Iso3166Country { Name = "Swaziland", Alpha2 = "SZ", Alpha3 = "SWZ", Numeric = 748 } },
                { "Sweden", new Iso3166Country { Name = "Sweden", Alpha2 = "SE", Alpha3 = "SWE", Numeric = 752 } },
                { "Switzerland", new Iso3166Country { Name = "Switzerland", Alpha2 = "CH", Alpha3 = "CHE", Numeric = 756 } },
                { "Syrian Arab Republic", new Iso3166Country { Name = "Syrian Arab Republic", Alpha2 = "SY", Alpha3 = "SYR", Numeric = 760 } },
                { "Taiwan, Province of China", new Iso3166Country { Name = "Taiwan, Province of China", Alpha2 = "TW", Alpha3 = "TWN", Numeric = 158 } },
                { "Tajikistan", new Iso3166Country { Name = "Tajikistan", Alpha2 = "TJ", Alpha3 = "TJK", Numeric = 762 } },
                { "Tanzania, United Republic of", new Iso3166Country { Name = "Tanzania, United Republic of", Alpha2 = "TZ", Alpha3 = "TZA", Numeric = 834 } },
                { "Thailand", new Iso3166Country { Name = "Thailand", Alpha2 = "TH", Alpha3 = "THA", Numeric = 764 } },
                { "Timor-Leste", new Iso3166Country { Name = "Timor-Leste", Alpha2 = "TL", Alpha3 = "TLS", Numeric = 626 } },
                { "Togo", new Iso3166Country { Name = "Togo", Alpha2 = "TG", Alpha3 = "TGO", Numeric = 768 } },
                { "Tokelau", new Iso3166Country { Name = "Tokelau", Alpha2 = "TK", Alpha3 = "TKL", Numeric = 772 } },
                { "Tonga", new Iso3166Country { Name = "Tonga", Alpha2 = "TO", Alpha3 = "TON", Numeric = 776 } },
                { "Trinidad and Tobago", new Iso3166Country { Name = "Trinidad and Tobago", Alpha2 = "TT", Alpha3 = "TTO", Numeric = 780 } },
                { "Tunisia", new Iso3166Country { Name = "Tunisia", Alpha2 = "TN", Alpha3 = "TUN", Numeric = 788 } },
                { "Turkey", new Iso3166Country { Name = "Turkey", Alpha2 = "TR", Alpha3 = "TUR", Numeric = 792 } },
                { "Turkmenistan", new Iso3166Country { Name = "Turkmenistan", Alpha2 = "TM", Alpha3 = "TKM", Numeric = 795 } },
                { "Turks and Caicos Islands", new Iso3166Country { Name = "Turks and Caicos Islands", Alpha2 = "TC", Alpha3 = "TCA", Numeric = 796 } },
                { "Tuvalu", new Iso3166Country { Name = "Tuvalu", Alpha2 = "TV", Alpha3 = "TUV", Numeric = 798 } },
                { "Uganda", new Iso3166Country { Name = "Uganda", Alpha2 = "UG", Alpha3 = "UGA", Numeric = 800 } },
                { "Ukraine", new Iso3166Country { Name = "Ukraine", Alpha2 = "UA", Alpha3 = "UKR", Numeric = 804 } },
                { "United Arab Emirates", new Iso3166Country { Name = "United Arab Emirates", Alpha2 = "AE", Alpha3 = "ARE", Numeric = 784 } },
                { "United Kingdom of Great Britain and Northern Ireland", new Iso3166Country { Name = "United Kingdom of Great Britain and Northern Ireland", Alpha2 = "GB", Alpha3 = "GBR", Numeric = 826 } },
                { "United States", new Iso3166Country { Name = "United States", Alpha2 = "US", Alpha3 = "USA", Numeric = 840 } },
                { "United States Minor Outlying Islands", new Iso3166Country { Name = "United States Minor Outlying Islands", Alpha2 = "UM", Alpha3 = "UMI", Numeric = 581 } },
                { "Uruguay", new Iso3166Country { Name = "Uruguay", Alpha2 = "UY", Alpha3 = "URY", Numeric = 858 } },
                { "Uzbekistan", new Iso3166Country { Name = "Uzbekistan", Alpha2 = "UZ", Alpha3 = "UZB", Numeric = 860 } },
                { "Vanuatu", new Iso3166Country { Name = "Vanuatu", Alpha2 = "VU", Alpha3 = "VUT", Numeric = 548 } },
                { "Venezuela, Bolivarian Republic of", new Iso3166Country { Name = "Venezuela, Bolivarian Republic of", Alpha2 = "VE", Alpha3 = "VEN", Numeric = 862 } },
                { "Viet Nam", new Iso3166Country { Name = "Viet Nam", Alpha2 = "VN", Alpha3 = "VNM", Numeric = 704 } },
                { "Virgin Islands, British", new Iso3166Country { Name = "Virgin Islands, British", Alpha2 = "VG", Alpha3 = "VGB", Numeric = 92 } },
                { "Virgin Islands, U.S.", new Iso3166Country { Name = "Virgin Islands, U.S.", Alpha2 = "VI", Alpha3 = "VIR", Numeric = 850 } },
                { "Wallis and Futuna", new Iso3166Country { Name = "Wallis and Futuna", Alpha2 = "WF", Alpha3 = "WLF", Numeric = 876 } },
                { "Western Sahara", new Iso3166Country { Name = "Western Sahara", Alpha2 = "EH", Alpha3 = "ESH", Numeric = 732 } },
                { "Yemen", new Iso3166Country { Name = "Yemen", Alpha2 = "YE", Alpha3 = "YEM", Numeric = 887 } },
                { "Zambia", new Iso3166Country { Name = "Zambia", Alpha2 = "ZM", Alpha3 = "ZMB", Numeric = 894 } },
                { "Zimbabwe", new Iso3166Country { Name = "Zimbabwe", Alpha2 = "ZW", Alpha3 = "ZWE", Numeric = 716 } },
            };
        }
    }
}
