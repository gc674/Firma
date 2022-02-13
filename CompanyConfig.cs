using System;
using System.IO;
using System.Xml.Serialization;

namespace Company
{
    public class CompanyConfig
    {
        public decimal HourCost { get; set; }
        public string CompanyName { get; set; }
        //private string fileName = "settings.xml";
        //private string settingsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "setari.xml");
        private string settingsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.xml");

        public CompanyConfig()
        {
            //CompanyConfig = new CompanyConfig(); //-- buffer overflow :)
        }

        public CompanyConfig(string companyname, decimal hourcost)
        {
            CompanyName = companyname;
            HourCost = hourcost;

        }

        public void Save(CompanyConfig companyConfig)
        {
            XmlSerializer xml = new XmlSerializer(typeof(CompanyConfig));
            StreamWriter streamWriter = new StreamWriter(settingsPath);
            xml.Serialize(streamWriter, companyConfig);
            streamWriter.Close();

        }

        public CompanyConfig Load(CompanyConfig companyConfig)
        {
            if (File.Exists(settingsPath))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(CompanyConfig));
                StreamReader streamReader = new StreamReader(settingsPath);
                companyConfig = (CompanyConfig)xmlSerializer.Deserialize(streamReader);
                streamReader.Close();

            }
            else
            {
                //default settings
                companyConfig.CompanyName = "Blabla Inc.";
                companyConfig.HourCost = 25;
            }

            return companyConfig;
        }


    }
}
