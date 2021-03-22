using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;

namespace Firma
{
    public class Orelucrate
    {
        //creare lista de ore per angajat
        public BindingList<Ore> Ore;
        private string fisierOreLucrate = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "orelucrate.xml");

        public Orelucrate()
        {
            //constructor pentru lista de ore
            Ore = new BindingList<Ore>();

        }

        public void Save()
        {
            XmlSerializer xml = new XmlSerializer(typeof(BindingList<Ore>));
            StreamWriter streamWriter = new StreamWriter(fisierOreLucrate);
            xml.Serialize(streamWriter, Ore);
            streamWriter.Close();

        }

        public void Load()
        {
            if (File.Exists(fisierOreLucrate))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(BindingList<Ore>));
                StreamReader streamReader = new StreamReader(fisierOreLucrate);
                Ore = (BindingList<Ore>)xmlSerializer.Deserialize(streamReader);
                streamReader.Close();
            }

        }
    }
}
