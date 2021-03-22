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
    public partial class RaportAngajat : Form
    {
        private Companie _companie;
        private Orelucrate _oreLucrate;
        private Angajat _angajat;
        decimal totalore;

        public RaportAngajat()
        {
            _companie = new Companie();
            _oreLucrate = new Orelucrate();
            InitializeComponent();
        }

        private void RaportAngajat_Load(object sender, EventArgs e)
        {
            // se incarca compania
            _companie.Load();
            _oreLucrate.Load();
            // se incarca numele angajatilor in combobox
            angajatComboBox.BeginUpdate();
            foreach (Angajat angajat in _companie.Angajati)
            {
                angajatComboBox.Items.Add(angajat.Nume + " " + angajat.Prenume);

            }
            angajatComboBox.EndUpdate();

        }

        private void raportButton_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrEmpty(angajatComboBox.Text))
            {
                MessageBox.Show("Va rog selectati un angajat!");

            }
            else
            {
                string angajat = angajatComboBox.SelectedItem.ToString();
                string nume = angajat.Split()[0];
                string prenume = angajat.Split()[1];
                //MessageBox.Show(nume);
                //MessageBox.Show(prenume);
                Orelucrate oreAngajat = new Orelucrate();
                oreAngajat = _oreLucrate.OreAngajat(nume, prenume);
                raportDataGridView.DataSource = null;
                raportDataGridView.DataSource = oreAngajat.Ore;


                foreach(Ore ore in oreAngajat.Ore)
                {
                    totalore += ore.OreLucrate;
                }
                oreLabel.Text = totalore.ToString();
                totalore = 0;

            }
        }
    }
}
