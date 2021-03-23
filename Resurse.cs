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

        public decimal CostOreZi { get; set; }
        public decimal CostOreNoapte { get; set; }
        public decimal CostTotal { get; set; }

        public decimal CostOre = 25;
        public decimal CostOreN;

        //private string fisierOreLucrate = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "orelucrate.xml");
        public Resurse ()
        {
            

        }

        public void Calcul()
        {
            CostOreZi = OreZi * CostOre;
            CostOreNoapte = OreNoapte * (CostOre * 2);
            CostTotal = CostOreZi + CostOreNoapte;

        }

    }
}
