using System;
using System.IO;
using System.Linq;
using System.Net;
using HtmlAgilityPack;

namespace Bia.Countries.Parser
{
    public static class Program
    {
        public static void Main()
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
                    File.AppendAllText(
                        "countries.txt",
                        $"{{ \"{countryName}\", new Country {{ Name = \"{countryName}\", Alpha2 = \"{alpha2}\", Alpha3 = \"{alpha3}\", Numeric = {numeric} }} }},\r\n");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
            }
        }
    }
}
