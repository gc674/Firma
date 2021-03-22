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
        public Firma()
        {
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


    }
}
