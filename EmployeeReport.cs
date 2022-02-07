using System;
using System.Windows.Forms;

namespace Company
{
    public partial class EmployeeReport : Form
    {
        private Compay _company;
        private WorkedHours _workedhours;
        //private Angajat _angajat;
        decimal totalhours;

        public EmployeeReport()
        {
            _company = new Compay();
            _workedhours = new WorkedHours();
            InitializeComponent();
        }

        private void RaportAngajat_Load(object sender, EventArgs e)
        {
            // se incarca compania
            _company.Load();
            _workedhours.Load();
            // se incarca numele angajatilor in combobox
            angajatComboBox.BeginUpdate();
            foreach (Employee angajat in _company.Employees)
            {
                angajatComboBox.Items.Add(angajat.First + " " + angajat.Last);

            }
            angajatComboBox.EndUpdate();

        }

        private void raportButton_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrEmpty(angajatComboBox.Text))
            {
                MessageBox.Show("Please select an employee!");

            }
            else
            {
                string employee = angajatComboBox.SelectedItem.ToString();
                string first = employee.Split()[0];
                string last = employee.Split()[1];
                //MessageBox.Show(nume);
                //MessageBox.Show(prenume);
                WorkedHours employeeHours = new WorkedHours();
                employeeHours = _workedhours.EmployeeHours(first, last);
                raportDataGridView.DataSource = null;
                raportDataGridView.DataSource = employeeHours.Hours;


                foreach(Hours hours in employeeHours.Hours)
                {
                    totalhours += hours.WorkedHours;
                }
                oreLabel.Text = totalhours.ToString();
                totalhours = 0;

            }
        }
    }
}
