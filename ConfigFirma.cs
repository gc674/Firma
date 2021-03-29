using System;
using System.IO;
using System.Xml.Serialization;

namespace Firma
{
    public class ConfigFirma
    {
        public decimal CostOra { get; set; }
        public string NumeFirma { get; set; }
        private string fisierSetari = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "setari.xml");

        public ConfigFirma()
        {
            //configFirma = new ConfigFirma(); //-- buffer overflow :)
        }

        public ConfigFirma(string numefirma, decimal costora)
        {
            NumeFirma = numefirma;
            CostOra = costora;

        }

        public void Save(ConfigFirma configFirma)
        {
            XmlSerializer xml = new XmlSerializer(typeof(ConfigFirma));
            StreamWriter streamWriter = new StreamWriter(fisierSetari);
            xml.Serialize(streamWriter, configFirma);
            streamWriter.Close();

        }

        public ConfigFirma Load(ConfigFirma configFirma)
        {
            if (File.Exists(fisierSetari))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(ConfigFirma));
                StreamReader streamReader = new StreamReader(fisierSetari);
                configFirma = (ConfigFirma)xmlSerializer.Deserialize(streamReader);
                streamReader.Close();

            }
            else
            {
                configFirma.NumeFirma = "Firma";
                configFirma.CostOra = 25;
            }

            return configFirma;
        }


    }
}
