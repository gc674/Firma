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
        public Firma()
        {
            _oreLucrate = new Orelucrate();
            _resurse = new Resurse();
            InitializeComponent();
            
        }

        private void angajatiButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Angajati angajati = new Angajati();
            DialogResult raspuns = angajati.ShowDialog();
            this.Visible = true;
        }

        private void pontajButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Pontaj pontaj = new Pontaj();
            DialogResult raspuns = pontaj.ShowDialog();
            this.Visible = true;


        }

        private void raportButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            RaportAngajat raportAngajat = new RaportAngajat();
            DialogResult raspuns = raportAngajat.ShowDialog();
            this.Visible = true;
        }

        private void Firma_Load(object sender, EventArgs e)
        {
            _oreLucrate.Load();
            foreach(Ore ore in _oreLucrate.Ore)
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

            //MessageBox.Show(_resurse.OreNoapte.ToString());
            //MessageBox.Show(_resurse.OreZi.ToString());


        }
    }
}
