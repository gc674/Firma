using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company
{
    public partial class Booking : Form
    {
        private Compay _company;
        private WorkedHours _workedhours;
        private Employee _employee;
        public Booking()
        {
            _company = new Compay();
            _workedhours = new WorkedHours();
            InitializeComponent();
        }

        private void Pontaj_Load(object sender, EventArgs e)
        {
            // loading company
            _company.Load();
            _workedhours.Load();
            // loading employees in combobox
            angajatiComboBox.BeginUpdate();
            foreach( Employee employee in _company.Employees)
            {
                angajatiComboBox.Items.Add(employee.First + " " + employee.Last);

            }
            angajatiComboBox.EndUpdate();
            dataMonthCalendar.ShowWeekNumbers = true;
            dataGridView1.DataSource = _workedhours.Hours;

        }

        private void AdaugaButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(angajatiComboBox.Text))
            {
                MessageBox.Show("Please select employee!");

            }
            else
            {
                string name = angajatiComboBox.SelectedItem.ToString();
                name = name.Split()[0];
                foreach (Employee employee in _company.Employees)
                {
                    if (employee.First == name)
                    {
                        _employee = employee;
                    }
                }
                // adding number of hours and type
                Hours hours = new Hours(_employee.First, _employee.Last, dataMonthCalendar.SelectionRange.Start.ToString("dd.MM.yyyy"), OrenumericUpDown.Value, turaNoaptecheckBox.Checked);
                _workedhours.Hours.Add(hours);
                // reinitializing datasource
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _workedhours.Hours;
                _workedhours.Save();

            }
        }

        private void StergeButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(row.Index);
                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _workedhours.Hours;
            _workedhours.Save();

        }
    }
}
