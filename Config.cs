using System;
using System.Windows.Forms;

namespace Company
{
    public partial class Config : Form
    {
        private CompanyConfig _config;
        public Config()
        {
            _config = new CompanyConfig();
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(numeFirmaTextBox.Text) || string.IsNullOrWhiteSpace(costOreNumericUpDown.Value.ToString()))
            {
                MessageBox.Show("Company name or Working Hour Cost are not correct!");
            }
            else
            {
                _config.CompanyName = numeFirmaTextBox.Text;
                _config.HourCost = costOreNumericUpDown.Value;
                //MessageBox.Show(_config.CostOra.ToString());
                //MessageBox.Show(_config.NumeFirma);
                _config.Save(_config);

            }


        }

        private void Config_Load(object sender, EventArgs e)
        {
            _config = _config.Load(_config);
            numeFirmaTextBox.Text = _config.CompanyName;
            costOreNumericUpDown.Value = _config.HourCost;

        }

        private void numeFirmaLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
