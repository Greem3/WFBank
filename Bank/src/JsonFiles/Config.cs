using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Config : Json
    {
        public float H1 { get; set; }
        public float H2 { get; set; }
        public float H3 { get; set; }
        public float H4 { get; set; }
        public float NormalText { get; set; }
        public string FontFamily { get; set; }
    }
}
