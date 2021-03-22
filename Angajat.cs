using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    public class Angajat
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string DataNasterii { get; set; }
        public string Telefon { get; set; }

        //public List<Orelucrate> Orelucrate;
        public Angajat()
        {
            //constructor pentru lista de angajati
        }
        public Angajat (int id, string nume, string prenume, string datanasterii, string telefon)
        {
            //constructor de adaugat Id
            this.Id = id;
            this.Nume = nume;
            this.Prenume = prenume;
            this.DataNasterii = datanasterii;
            this.Telefon = telefon;
            //this.Orelucrate = new List<Orelucrate>();

        }
    }
}
