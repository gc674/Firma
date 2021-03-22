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
        private Angajat _angajat;
        public Pontaj()
        {
            _companie = new Companie();
            InitializeComponent();
        }

        private void Pontaj_Load(object sender, EventArgs e)
        {
            // se incarca compania
            _companie.Load();
            // se incarca numele angajatilor in combobox
            angajatiComboBox.BeginUpdate();
            foreach( Angajat angajat in _companie.Angajati)
            {
                angajatiComboBox.Items.Add(angajat.Nume + " " + angajat.Prenume);

            }
            angajatiComboBox.EndUpdate();
            dataMonthCalendar.ShowWeekNumbers = true;


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
                MessageBox.Show(_angajat.Nume);
                Orelucrate ore = new Orelucrate(dataMonthCalendar.SelectionRange.Start.ToString("dd.MM.yyyy"), OrenumericUpDown.Value, turaNoaptecheckBox.Checked);
                _angajat.Orelucrate.Add(ore);

                _companie.Save();
            }
        }

        private void StergeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
