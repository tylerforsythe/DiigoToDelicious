using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiigoToDelicious
{
    public class ImportRecord
    {
        public string title { get; set; }
        public string url { get; set; }
        public string tags { get; set; }
        public string description { get; set; }
        public DateTime addedDT { get; set; }
        public bool isPrivate { get; set; }
    }
}
