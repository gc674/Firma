﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Company
{
    public class Compay
    {
        //creare lista de angajati
        public List<Employee> Employees;
        //public int Id { get; set; }

        //private string companyFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "company.xml");
        private string companyFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "company.xml");
        public Compay()
        {
            //constructor for employees list
            Employees = new List<Employee>();

        }

        public void Save()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Employee>));
            StreamWriter streamWriter = new StreamWriter(companyFile);
            xml.Serialize(streamWriter, Employees);
            //xml.Serialize(streamWriter, dataGridView1.DataSource);
            streamWriter.Close();

        }

        public void Load()
        {
            if (File.Exists(companyFile))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Employee>));
                StreamReader streamReader = new StreamReader(companyFile);
                Employees = (List<Employee>)xmlSerializer.Deserialize(streamReader);
                streamReader.Close();
            }

        }

    }
}
