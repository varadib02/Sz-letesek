using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Születesek
{
    class Személy
    {
        public string SzemélyiSzám { get; set; }

        public Személy(string sor)
        {
            SzemélyiSzám = sor;
        }
    }
}
