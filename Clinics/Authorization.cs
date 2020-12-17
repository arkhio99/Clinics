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
    public partial class Authorization : Form
    {
        private Dictionary<string, User> users = new Dictionary<string, User>();

        public Authorization()
        {
            InitializeComponent();
            users = Database.Users.ToDictionary(user => user.Username);
        }

        private void LogOnBtn_Click(object sender, EventArgs e)
        {
            if (users.ContainsKey(LoginTB.Text) && users[LoginTB.Text].Password == PasswordTB.Text)
            {
                ServiceChoosing form = new ServiceChoosing(users[LoginTB.Text]);
                form.ShowDialog();
            }
            else
            {
                PasswordErrorLbl.Text = "Неправильный логин/пароль.";
            }
        }

        private void RegistrationBtn_Click(object sender, EventArgs e)
        {
            Registration form = new Registration();
            form.ShowDialog();
        }

        private void Authorization_Activated(object sender, EventArgs e)
        {
            users = Database.Users.ToDictionary(user => user.Username);
        }
    }
}
