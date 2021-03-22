using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Firma
{
    public class Companie
    {
        //creare lista de angajati
        public List<Angajat> Angajati;
        public int Id { get; set; }

        private string fisierCompanie = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "companie.xml");

        public Companie()
        {
            //constructor pentru lista de angajati
            Angajati = new List<Angajat>();

        }

        public void Save()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Angajat>));
            StreamWriter streamWriter = new StreamWriter(fisierCompanie);
            xml.Serialize(streamWriter, Angajati);
            //xml.Serialize(streamWriter, dataGridView1.DataSource);
            streamWriter.Close();

        }

        public void Load()
        {
            if (File.Exists(fisierCompanie))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Angajat>));
                StreamReader streamReader = new StreamReader(fisierCompanie);
                Angajati = (List<Angajat>)xmlSerializer.Deserialize(streamReader);
                streamReader.Close();
            }

        }

    }
}
