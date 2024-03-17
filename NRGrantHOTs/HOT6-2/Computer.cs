using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOT6_2
{
    public class Computer
    {
        private readonly string _name;
        private readonly string _ipAddress;
        private readonly int[] _services;

        public Computer(string name, string ipAddress, int[] services)
        {
            _name = name;
            _ipAddress = ipAddress;
            _services = services;
        }

        public string Name { get { return _name; } }

        public string IpAddress { get { return _ipAddress;} }

        public int[] Services { get { return _services; } }
    }
}
