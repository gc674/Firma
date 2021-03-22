using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    public class Orelucrate : Angajat
    {
        public string DataOrelor { get; set; }
        public decimal Ore { get; set; }
        public bool DeNoapte { get; set; }

        public Orelucrate()
        {
            //pentru serializare
        }
        public Orelucrate (string data, decimal ore, bool denoapte)
        {
            DataOrelor = data;
            Ore = ore;
            DeNoapte = denoapte;
        }


    }
}
