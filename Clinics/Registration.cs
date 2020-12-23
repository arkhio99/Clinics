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
                    FIO = SecondNameTB.Text + " " + NameTB.Text + " " + FatherNameTB.Text,
                    Email = EmailTB.Text,
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
            IsRegAvailable();
        }

        private void IsRegAvailable()
        {
            RegisterBtn.Enabled = PasswordTB.Text == Password2TB.Text
                && SecondNameTB.Text != ""
                && NameTB.Text != ""
                && FatherNameTB.Text != ""
                && UsernameTB.Text != ""
                && EmailTB.Text != ""
                && PasswordTB.Text != ""
                && Password2TB.Text != ""
                && DocTypeSelector.SelectedIndex != -1
                && DocCredentialsTB.Text != ""
                && PhoneNumberTB.Text != "";
        }

        private void SecondNameTB_TextChanged(object sender, EventArgs e)
        {
            IsRegAvailable();
        }

        private void NameTB_TextChanged(object sender, EventArgs e)
        {
            IsRegAvailable();
        }

        private void FatherNameTB_TextChanged(object sender, EventArgs e)
        {
            IsRegAvailable();
        }

        private void UsernameTB_TextChanged(object sender, EventArgs e)
        {
            IsRegAvailable();
        }

        private void EmailTB_TextChanged(object sender, EventArgs e)
        {
            IsRegAvailable();
        }

        private void PasswordTB_TextChanged(object sender, EventArgs e)
        {
            IsRegAvailable();
        }

        private void DocTypeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsRegAvailable();
        }

        private void DocCredentialsTB_TextChanged(object sender, EventArgs e)
        {
            IsRegAvailable();
        }

        private void PhoneNumberTB_TextChanged(object sender, EventArgs e)
        {
            IsRegAvailable();
        }
    }
}
