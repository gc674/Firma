using System;
using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;

namespace Company
{
    public class WorkedHours
    {
        //creating hour list per employee
        public BindingList<Hours> Hours;
        public decimal TotalOre { get; set; }


        private static string fileName = "workedhours.xml";
        private string workedHoursFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

        public WorkedHours()
        {
            // hours constructor
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
