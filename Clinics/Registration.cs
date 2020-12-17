using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Databases;

namespace Clinics
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            DocTypeSelector.Items.AddRange(
                new object[]
                {
                    "Паспорт",
                    "Свидетельство о рождении",
                });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database.Users.Add
            (
                new User
                {
                    Id = Guid.NewGuid(),
                    FIO = SecondNameTB + " " + NameTB + " " + FatherNameTB,
                    Username = UsernameTB.Text,
                    Password = PasswordTB.Text,
                    DocCredentials = DocCredentialsTB.Text,
                    DocType = (DocType)DocTypeSelector.SelectedIndex,
                    PhoneNumber = PhoneNumberTB.Text,
                }
            );
            this.Close();
        }

        private void Password2TB_TextChanged(object sender, EventArgs e)
        {
            RegisterBtn.Enabled = PasswordTB.Text == Password2TB.Text;
        }
    }
}
