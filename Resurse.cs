using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Firma
{
    public class Resurse
    {
        public decimal OreNoapte { get; set; }
        public decimal OreZi { get; set; }
        public int NrAngajati { get; set; }

        //public List<Resurse> TotalResurse;
        public int CostOreZi { get; set; }
        public int CostOreNoapte { get; set; }

        private decimal CostOre = 25;

        private string fisierOreLucrate = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "orelucrate.xml");
        public Resurse ()
        {
            

        }



    }
}
