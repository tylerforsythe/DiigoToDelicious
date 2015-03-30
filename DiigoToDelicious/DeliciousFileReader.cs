using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiigoToDelicious
{
    public static class DeliciousFileReader
    {
        public static IList<ImportRecord> ReadRecords(string filePath) {
            var results = new List<ImportRecord>();

            var allLines = File.ReadAllLines(filePath);

            for (var i = 0; i < allLines.Count(); ++i) {
                var l = allLines[i];
                if (l.StartsWith("<DT>")) {
                    var r = new ImportRecord();
                    r.url = ExtractValueOf(l, "HREF");
                    r.title = ExtractValueOfTitle(l);
                    r.tags = ExtractValueOf(l, "TAGS");
                    r.isPrivate = ExtractValueOf(l, "PRIVATE") == "0" ? false : true;
                    r.addedDT = new DateTime(1970, 1, 1).AddSeconds(double.Parse(ExtractValueOf(l, "ADD_DATE")));
                    if (allLines[i + 1].StartsWith("<DD>")) {
                        r.description = allLines[i + 1].Replace("<DD>", "");
                        ++i;
                    }
                    results.Add(r);
                }
            }

            return results;
        }

        public static string ExtractValueOf(string haystack, string needle) {
            var index = haystack.IndexOf(needle);
            var indexQuote = haystack.IndexOf("\"", index + 1);
            var indexLastQuote = haystack.IndexOf("\"", indexQuote + 1);
            var val = haystack.Substring(indexQuote + 1, indexLastQuote - indexQuote - 1);
            return val;
        }

        public static string ExtractValueOfTitle(string haystack) {
            var index = haystack.IndexOf("\">") + 2;
            var indexLastQuote = haystack.IndexOf("</A>", index + 1);
            var val = haystack.Substring(index, indexLastQuote - index);
            return val;
        }
    }
}
