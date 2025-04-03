using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class SectionNames : Json
    {
        public Dictionary<string, string> Admin { get; set; }
        public Dictionary<string, string> User { get; set; }
    }
}
