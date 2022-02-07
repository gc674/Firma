using System;
using System.Windows.Forms;

namespace Company
{
    public partial class Company : Form
    {
        private WorkedHours _workedHours;
        private Resources _resources;
        private Compay _company;
        public Company()
        {
            _workedHours = new WorkedHours();
            _resources = new Resources();
            _company = new Compay();
            InitializeComponent();
            
        }

        private void angajatiButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Employees employees = new Employees();
            DialogResult response = employees.ShowDialog();
            if (response == DialogResult.Cancel)
            {
                Refresh(sender, e);
            }
            this.Visible = true;
        }

        private void pontajButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Booking booking = new Booking();
            DialogResult raspuns = booking.ShowDialog();
            if (raspuns == DialogResult.Cancel)
            {
                Refresh(sender, e);
            }

            this.Visible = true;


        }

        private void raportButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            EmployeeReport employeeReport = new EmployeeReport();
            employeeReport.ShowDialog();
            this.Visible = true;
        }

        private void Refresh(object sender, EventArgs e)
        {
            resurseListView.Items.Clear();
            _resources.NightHours = 0;
            _resources.DayHours = 0;

            _workedHours.Load();
            _company.Load();

            foreach (Hours hours in _workedHours.Hours)
            {
                if (hours.Night == true)
                {
                    _resources.NightHours += hours.WorkedHours;
                }
                else
                {
                    _resources.DayHours += hours.WorkedHours;
                }
            }

            _resources.EmployeeNumber = _company.Employees.Count;
            _resources.Calcul();


            //se actualizeaza listView cu Resursele
            
            ListViewItem item = new ListViewItem(_resources.EmployeeNumber.ToString());
            item.SubItems.Add(_resources.NightHours.ToString());
            item.SubItems.Add(_resources.NightHoursCost.ToString());
            item.SubItems.Add(_resources.DayHours.ToString());
            item.SubItems.Add(_resources.DayHoursCost.ToString());
            item.SubItems.Add(_resources.TotalCost.ToString());
            resurseListView.Items.Add(item);
            resurseListView.Sorting = SortOrder.Ascending;


        }
        private void Firma_Load(object sender, EventArgs e)
        {
            Refresh(sender, e);

         

        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Config config = new Config();
            DialogResult raspuns = config.ShowDialog();
            if (raspuns == DialogResult.Cancel)
            {
                Refresh(sender, e);
            }
            this.Visible = true;
        }
    }
}
