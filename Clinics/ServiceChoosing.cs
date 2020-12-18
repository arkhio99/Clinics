using Databases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinics
{
    public partial class ServiceChoosing : Form
    {
        Service _service;
        Clinic _clinic;
        VisitDate _date;
        User _user;
        Clinic[] clinicsForSelector;
        VisitDate[] datesForSelector;

        public ServiceChoosing(User user)
        {
            _user = user;
            InitializeComponent();
            ServiceSelector.Items.AddRange(Database.Services.Select(s => s.Name).ToArray());
            DisableAll();
        }

        private void DisableAll()
        {
            ClinicSelector.Enabled = false;
            DateSelector.Enabled = false;
            CheckTB.Enabled = false;
            OkBtn.Enabled = false;
            ClinicSelector.Items.Clear();
            DateSelector.Items.Clear();
        }

        private void ServiceSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisableAll();
            DateSelector.Enabled = false;
            ClinicSelector.Enabled = true;
            ClinicSelector.SelectedIndex = -1;
            _service = Database.Services.First(s => s.Id == ServiceSelector.SelectedIndex);
            clinicsForSelector = Database.Clinics.Where(c => _service.ClinicIds.Contains(c.Id)).ToArray();
            ClinicSelector.Items.Clear();
            ClinicSelector.Items.AddRange(clinicsForSelector.Select(c => c.Address).ToArray());
        }

        private void ClinicSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateSelector.SelectedIndex = -1;
            DateSelector.Items.Clear();
            DateSelector.Enabled = true;
            _clinic = clinicsForSelector[ClinicSelector.SelectedIndex];

            datesForSelector = Database.VisitDates.Where(d => d.ClinicId == _clinic.Id && d.ServiceId == _service.Id).ToArray();
            DateSelector.Items.Clear();
            DateSelector.Items.AddRange(datesForSelector.Select(d => d.Date.ToString()).ToArray());
        }

        private void DateSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            _date = datesForSelector[DateSelector.SelectedIndex];
            CheckTB.Enabled = true;
            PriceTB.Text = _date.Price.ToString();
        }

        private void CheckTB_TextChanged(object sender, EventArgs e)
        {
            OkBtn.Enabled = CheckTB.Text == CapchaTB.Text;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            Request request = new Request
            {
                Id = Guid.NewGuid(),
                UserId = _user.Id,
                VisistDateId = _date.Id,
            };

            Database.Requests.Add(request);
            CheckRequest form1 = new CheckRequest(request);
            form1.ShowDialog();
        }
    }
}
