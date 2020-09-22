using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SimpleWebScraper.Data
{
    class ScrapeCriteriaPart
    {
        // Add properties:
        public string Regex { get; set; }
        public RegexOptions RegexOptions { get; set; }
    }
}
