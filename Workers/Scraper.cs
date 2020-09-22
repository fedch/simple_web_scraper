using SimpleWebScraper.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SimpleWebScraper.Workers
{
    class Scraper
    {
        public List<string> Scrape(ScrapeCriteria scrapeCriteria)
        {
            List<string> scrappedElements = new List<string>();

            MatchCollection matches = Regex.Matches(scrapeCriteria.Data, scrapeCriteria.Regex, scrapeCriteria.RegexOption);

            foreach (Match match in matches)
            {
                if (!scrapeCriteria.Parts.Any())
                {
                    scrappedElements.Add(match.Groups[0].Value);
                }
                else
                {
                    foreach (var part in scrapeCriteria.Parts)
                    {
                        Match matchedPart = Regex.Match(match.Groups[0].Value, part.Regex, part.RegexOptions);

                        // [0] {>2007 Toyota Highlander very low miles</a>}
                        // [1] {2007 Toyota Highlander verly low miles} <--- Takes the group out
                        if (matchedPart.Success) scrappedElements.Add(matchedPart.Groups[1].Value);
                    }
                }
            }

            return scrappedElements;
        }
    }
}
