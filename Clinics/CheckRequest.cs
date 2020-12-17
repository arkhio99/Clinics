using Databases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinics
{
    public partial class CheckRequest : Form
    {
        Request _request;
        public CheckRequest(Request request)
        {
            _request = request;
            InitializeComponent();
            User user = Database.Users.First(u => u.Id == _request.UserId);
            FIOLbl.Text = user.FIO;
            PhoneNumberLbl.Text = user.PhoneNumber;
            EmailLbl.Text = user.Email;
            VisitDate date = Database.VisitDates.First(d => d.Id == _request.VisistDateId);
            DateLbl.Text = date.Date.ToShortDateString();
            TimeLbl.Text = date.Date.ToShortTimeString();
            Service service = Database.Services.First(s => s.Id == date.ServiceId);
            ServiceLbl.Text = service.Name;
            Clinic clinic = Database.Clinics.First(c => c.Id == date.ClinicId);
            ClinicLbl.Text = clinic.Address;
            PriceLbl.Text = date.Price.ToString();
        }

        private void BuyBtn_Click(object sender, EventArgs e)
        {
            BuyForm form = new BuyForm(_request);
            form.Activate();
        }
    }
}
