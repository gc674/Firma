using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firma
{
    public partial class Angajati : Form
    {
        private Companie _companie;
        public Angajati()
        {

            _companie = new Companie();
            InitializeComponent();

        }

        private void adaugaButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(numeBox.Text) || string.IsNullOrWhiteSpace(prenumeBox.Text) || string.IsNullOrWhiteSpace(dateTimePicker1.Text) || string.IsNullOrWhiteSpace(telefonBox.Text))
            {
                MessageBox.Show("Unul dintre campuri nu este completat corespunzator!");

            }
            else
            {
                //se adauga angajat
                Angajat angajat = new Angajat(Convert.ToInt32(idNumericUpDown.Value),
                                              numeBox.Text.Trim(),
                                              prenumeBox.Text.Trim(),
                                              dateTimePicker1.Value.ToString("dd.MM.yyyy"),
                                              telefonBox.Text.Trim());
                _companie.Angajati.Add(angajat);

                //se actualizeaza listView cu angajatul introdus
                ListViewItem item = new ListViewItem(angajat.Id.ToString());
                item.SubItems.Add(angajat.Nume);
                item.SubItems.Add(angajat.Prenume);
                item.SubItems.Add(angajat.DataNasterii);
                item.SubItems.Add(angajat.Telefon);
                angajatiListView.Items.Add(item);
                angajatiListView.Sorting = SortOrder.Ascending;
                numeBox.Clear();
                prenumeBox.Clear();
                telefonBox.Clear();
                numeBox.Focus();
                //MessageBox.Show(string.Format("Am adaugat angajatul: {0} {1} {2} {3}", angajat.Nume, angajat.Prenume, angajat.DataNasterii, angajat.Telefon));
                //se actualizeaza NumericBoxul cu id angajat
                idNumericUpDown.Value = _companie.Angajati.Count;
                idNumericUpDown.Refresh();
                //se salveaza lista de angajati
                _companie.Save();

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
                _companie.Angajati.Remove(_companie.Angajati.Find(x => x.Id == id));
                _companie.Save();

            }
            else
            {
                MessageBox.Show("Nu este nici un rand selectat!");
            }
        }

        private void Angajati_Load(object sender, EventArgs e)
        {
            _companie.Load();
            //creaza lista cu elementele din clasa companie din xml
            foreach (Angajat ang in _companie.Angajati)
            {

                ListViewItem item = new ListViewItem(ang.Id.ToString());
                item.SubItems.Add(ang.Nume);
                item.SubItems.Add(ang.Prenume);
                item.SubItems.Add(ang.DataNasterii);
                item.SubItems.Add(ang.Telefon);
                angajatiListView.Items.Add(item);
            }
            idNumericUpDown.Enabled = false;
            idNumericUpDown.Value = _companie.Angajati.Count;
            idNumericUpDown.Refresh();

        }
    }
}
