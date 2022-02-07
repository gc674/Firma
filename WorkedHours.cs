using System;
using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;

namespace Company
{
    public class WorkedHours
    {
        //creating hour listper employee
        public BindingList<Hours> Hours;
        public decimal TotalOre { get; set; }
        //private string fisierOreLucrate = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "orelucrate.xml");
        private string workedHoursFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "workedhours.xml");

        public WorkedHours()
        {
            //constructor pentru lista de ore
            Hours = new BindingList<Hours>();

        }

        public void Save()
        {
            XmlSerializer xml = new XmlSerializer(typeof(BindingList<Hours>));
            StreamWriter streamWriter = new StreamWriter(workedHoursFile);
            xml.Serialize(streamWriter, Hours);
            streamWriter.Close();

        }

        public void Load()
        {
            if (File.Exists(workedHoursFile))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(BindingList<Hours>));
                StreamReader streamReader = new StreamReader(workedHoursFile);
                Hours = (BindingList<Hours>)xmlSerializer.Deserialize(streamReader);
                streamReader.Close();
            }

        }

        public WorkedHours EmployeeHours(string first, string last)
        {
            WorkedHours workedHours = new WorkedHours();
            foreach (Hours ore in Hours)
            {
                if (ore.First == first || ore.Last == last)
                {
                    workedHours.Hours.Add(ore);
                }


            }
            return workedHours;
        }

    }
}
