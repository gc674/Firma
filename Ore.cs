using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    public class Ore
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string DataOrelor { get; set; }
        public decimal OreLucrate { get; set; }
        public bool DeNoapte { get; set; }

        public Ore()
        {
            //pentru serializare
        }
        public Ore (string nume, string prenume, string data, decimal orelucrate, bool denoapte)
        {
            Nume = nume;
            Prenume = prenume;
            DataOrelor = data;
            OreLucrate = orelucrate;
            DeNoapte = denoapte;
        }


    }
}
