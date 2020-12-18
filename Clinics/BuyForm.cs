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
    public partial class BuyForm : Form
    {
        Request _request;
        public BuyForm(Request request)
        {
            _request = request;
            InitializeComponent();
        }

        private void BuyBtn_Click(object sender, EventArgs e)
        {
            if (CardTB.Text.Length == 16 && CvcTB.Text.Length == 3 && TermTB.Text.Length == 5 && FILbl.Text.Length != 0)
            {
                Database.Cheques.Add(
                new Cheque
                {
                    Id = Guid.NewGuid(),
                    RequestId = _request.Id,
                });
                MessageBox.Show("Оплата произведена");
                Database.VisitDates.First(d => d.Id == _request.VisistDateId).AreTaken = true;
                Close();
            }
            else
            {
                MessageBox.Show("Данные введены некорректно");
            }
        }
    }
}
