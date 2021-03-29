
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
        public decimal CostOre { get; set; }
        public decimal CostOreN;

        public Resurse ()
        {
            

        }

        public void Calcul()
        {
            ConfigFirma configFirma = new ConfigFirma();
            configFirma = configFirma.Load(configFirma); // copiere obiect serializat in obiect
            CostOre = configFirma.CostOra;
            CostOreZi = OreZi * CostOre;
            CostOreNoapte = OreNoapte * (CostOre * 2);
            CostTotal = CostOreZi + CostOreNoapte;

        }

    }
}
