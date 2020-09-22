using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SimpleWebScraper.Data
{
    class ScrapeCriteria
    {
        // Make constructor:
        public ScrapeCriteria()
        {
            // Using parts of the HTML element to drill down inside this element
            Parts = new List<ScrapeCriteriaPart>();
        }

        // Add properties:
        public string Data { get; set; }
        public string Regex { get; set; }
        public RegexOptions RegexOption { get; set; }
        public List<ScrapeCriteriaPart> Parts { get; set; }
    }
}
