using System;
using System.Windows.Forms;

namespace Firma
{
    public partial class Config : Form
    {
        private ConfigFirma _config;
        public Config()
        {
            _config = new ConfigFirma();
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(numeFirmaTextBox.Text) || string.IsNullOrWhiteSpace(costOreNumericUpDown.Value.ToString()))
            {
                MessageBox.Show("Numele firmei sau Costul orei de lucru sunt completate eronat!");
            }
            else
            {
                _config.NumeFirma = numeFirmaTextBox.Text;
                _config.CostOra = costOreNumericUpDown.Value;
                //MessageBox.Show(_config.CostOra.ToString());
                //MessageBox.Show(_config.NumeFirma);
                _config.Save(_config);

            }


        }

        private void Config_Load(object sender, EventArgs e)
        {
            _config = _config.Load(_config);
            numeFirmaTextBox.Text = _config.NumeFirma;
            costOreNumericUpDown.Value = _config.CostOra;

        }
    }
}
