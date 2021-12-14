using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

namespace Születesek
{
    
    class Program
    {
        static void Main(string[] args)
        {
            List<Személy> személyek = new List<Személy>();

            foreach (var sor in File.ReadAllLines("vas.txt"))
            {
                személyek.Add(new Személy(sor));
            }
        }
    }
}
