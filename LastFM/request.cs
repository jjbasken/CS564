using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastFM
{
    public class request
    {
        public string artist { get; set; }
        public string api_key { get; set; }
        public int autocorrect { get; set; }
        public int limit { get; set; }
        public string format { get; set; }
    }
}
