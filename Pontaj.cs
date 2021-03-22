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
    public partial class Pontaj : Form
    {
        private Companie _companie;
        private Orelucrate _oreLucrate;
        private Angajat _angajat;
        public Pontaj()
        {
            _companie = new Companie();
            _oreLucrate = new Orelucrate();
            InitializeComponent();
        }

        private void Pontaj_Load(object sender, EventArgs e)
        {
            // se incarca compania
            _companie.Load();
            _oreLucrate.Load();
            // se incarca numele angajatilor in combobox
            angajatiComboBox.BeginUpdate();
            foreach( Angajat angajat in _companie.Angajati)
            {
                angajatiComboBox.Items.Add(angajat.Nume + " " + angajat.Prenume);

            }
            angajatiComboBox.EndUpdate();
            dataMonthCalendar.ShowWeekNumbers = true;
            dataGridView1.DataSource = _oreLucrate.Ore;

        }

        private void AdaugaButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(angajatiComboBox.Text))
            {
                MessageBox.Show("Va rog selectati un angajat!");

            }
            else
            {
                string nume = angajatiComboBox.SelectedItem.ToString();
                nume = nume.Split()[0];
                foreach (Angajat angajat in _companie.Angajati)
                {
                    if (angajat.Nume == nume)
                    {
                        _angajat = angajat;
                    }
                }
                // sender adauga numarul de ore si tipul
                Ore ore = new Ore(_angajat.Nume, _angajat.Prenume, dataMonthCalendar.SelectionRange.Start.ToString("dd.MM.yyyy"), OrenumericUpDown.Value, turaNoaptecheckBox.Checked);
                _oreLucrate.Ore.Add(ore);
                // se reinitializeaza datasource
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _oreLucrate.Ore;
                _oreLucrate.Save();

            }
        }

        private void StergeButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(row.Index);
                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _oreLucrate.Ore;
            _oreLucrate.Save();

        }
    }
}
