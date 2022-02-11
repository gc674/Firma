using System;
using System.Windows.Forms;

namespace Company
{
    public partial class Employees : Form
    {
        private Compay _company;
        public Employees()
        {

            _company = new Compay();
            InitializeComponent();

        }

        private void adaugaButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(numeBox.Text) || string.IsNullOrWhiteSpace(prenumeBox.Text) || string.IsNullOrWhiteSpace(dateTimePicker1.Text) || string.IsNullOrWhiteSpace(telefonBox.Text))
            {
                MessageBox.Show("Please check inputed values!");

            }
            else
            {
                //add an employee
                Employee employee = new Employee(Convert.ToInt32(idNumericUpDown.Value),
                                              numeBox.Text.Trim(),
                                              prenumeBox.Text.Trim(),
                                              dateTimePicker1.Value.ToString("dd.MM.yyyy"),
                                              telefonBox.Text.Trim());
                _company.Employees.Add(employee);

                //updating listView with the employee
                ListViewItem item = new ListViewItem(employee.Id.ToString());
                item.SubItems.Add(employee.First);
                item.SubItems.Add(employee.Last);
                item.SubItems.Add(employee.BirthDate);
                item.SubItems.Add(employee.Phone);
                angajatiListView.Items.Add(item);
                angajatiListView.Sorting = SortOrder.Ascending;
                numeBox.Clear();
                prenumeBox.Clear();
                telefonBox.Clear();
                numeBox.Focus();
                //MessageBox.Show(string.Format("Am adaugat angajatul: {0} {1} {2} {3}", angajat.Nume, angajat.Prenume, angajat.DataNasterii, angajat.Telefon));
                //se actualizeaza NumericBoxul cu id angajat
                idNumericUpDown.Value = _company.Employees.Count;
                idNumericUpDown.Refresh();
                //se salveaza lista de angajati
                _company.Save();

            }

        }

        private void StergeButton_Click(object sender, EventArgs e)
        {
            //stergere din lista
            if (angajatiListView.SelectedItems.Count > 0)
            {
                //verificare id
                ListViewItem item = angajatiListView.SelectedItems[0];
                int id = Convert.ToInt32(item.Text);
                //MessageBox.Show("Id selectat " + id);
                angajatiListView.Items.Remove(item);
                //stergere dupa Id din clasa companie
                _company.Employees.Remove(_company.Employees.Find(x => x.Id == id));
                _company.Save();

            }
            else
            {
                MessageBox.Show("Please select a row!");
            }
        }

        private void Angajati_Load(object sender, EventArgs e)
        {
            _company.Load();
            //creaza lista cu elementele din clasa companie din xml
            foreach (Employee empl in _company.Employees)
            {

                ListViewItem item = new ListViewItem(empl.Id.ToString());
                item.SubItems.Add(empl.First);
                item.SubItems.Add(empl.Last);
                item.SubItems.Add(empl.BirthDate);
                item.SubItems.Add(empl.Phone);
                angajatiListView.Items.Add(item);
            }
            idNumericUpDown.Enabled = false;
            idNumericUpDown.Value = _company.Employees.Count;
            idNumericUpDown.Refresh();

        }

        private void numeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
