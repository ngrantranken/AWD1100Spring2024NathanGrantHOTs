using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOT6_1
{
    public class Password
    {
        private readonly string _raw;
        private readonly string _hash;

        public Password()
        {
            _raw = string.Empty; 
            _hash = string.Empty;
        }

        public Password(string raw, string hash)
        {
            _raw = raw;
            _hash = hash;
        }

        public string Raw { get { return _raw; } }
        public string Hash { get { return _hash; } }
    }
}
