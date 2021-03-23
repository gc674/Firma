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
    public partial class Firma : Form
    {
        private Orelucrate _oreLucrate;
        private Resurse _resurse;
        private Companie _companie;
        public Firma()
        {
            _oreLucrate = new Orelucrate();
            _resurse = new Resurse();
            _companie = new Companie();
            InitializeComponent();
            
        }

        private void angajatiButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Angajati angajati = new Angajati();
            DialogResult raspuns = angajati.ShowDialog();
            if (raspuns == DialogResult.Cancel)
            {
                Refresh(sender, e);
            }
            this.Visible = true;
        }

        private void pontajButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Pontaj pontaj = new Pontaj();
            DialogResult raspuns = pontaj.ShowDialog();
            if (raspuns == DialogResult.Cancel)
            {
                Refresh(sender, e);
            }

            this.Visible = true;


        }

        private void raportButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            RaportAngajat raportAngajat = new RaportAngajat();
            raportAngajat.ShowDialog();
            this.Visible = true;
        }

        private void Refresh(object sender, EventArgs e)
        {
            resurseListView.Items.Clear();
            _resurse.OreNoapte = 0;
            _resurse.OreZi = 0;

            _oreLucrate.Load();
            _companie.Load();

            foreach (Ore ore in _oreLucrate.Ore)
            {
                if (ore.DeNoapte == true)
                {
                    _resurse.OreNoapte += ore.OreLucrate;
                }
                else
                {
                    _resurse.OreZi += ore.OreLucrate;
                }
            }

            _resurse.NrAngajati = _companie.Angajati.Count;
            _resurse.Calcul();


            //se actualizeaza listView cu Resursele
            
            ListViewItem item = new ListViewItem(_resurse.NrAngajati.ToString());
            item.SubItems.Add(_resurse.OreNoapte.ToString());
            item.SubItems.Add(_resurse.CostOreNoapte.ToString());
            item.SubItems.Add(_resurse.OreZi.ToString());
            item.SubItems.Add(_resurse.CostOreZi.ToString());
            item.SubItems.Add(_resurse.CostTotal.ToString());
            resurseListView.Items.Add(item);
            resurseListView.Sorting = SortOrder.Ascending;


        }
        private void Firma_Load(object sender, EventArgs e)
        {
            Refresh(sender, e);

         

        }
    }
}
