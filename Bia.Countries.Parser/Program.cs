using System;
using System.IO;
using System.Linq;
using System.Net;
using HtmlAgilityPack;

namespace Bia.Countries.Parser
{
    class Program
    {
        static void Main(string[] args)
        {
            var webClient = new WebClient();
            var page = webClient.DownloadString("https://en.wikipedia.org/wiki/ISO_3166-1");
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(page);
            var tableRows =
                htmlDocument.DocumentNode.SelectNodes("//table[@class='wikitable sortable']/tr")
                    .Skip(1);
            foreach (var tableRow in tableRows)
            {
                try
                {
                    var columns = tableRow.SelectNodes("td");
                    var countryName = columns[0].SelectSingleNode("a").InnerText;
                    var alpha2 = columns[1].SelectSingleNode("a/tt").InnerText;
                    var alpha3 = columns[2].SelectSingleNode("tt").InnerText;
                    var numeric = Convert.ToInt32(columns[3].SelectSingleNode("tt").InnerText);
                    File.AppendAllText("countries.txt",
                        String.Format("{{ \"{0}\", new Country {{ Name = \"{1}\", Alpha2 = \"{2}\", Alpha3 = \"{3}\", Numeric = {4} }} }},\r\n",
                        countryName, countryName, alpha2, alpha3, numeric));

                }
                catch (Exception)
                {
                    continue;
                }
            }
        }
    }
}
