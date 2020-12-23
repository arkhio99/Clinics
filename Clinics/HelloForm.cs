using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinics
{
    public partial class HelloForm : Form
    {
        public HelloForm()
        {
            InitializeComponent();
            HelloPB.Image = Image.FromFile("..\\..\\..\\HelloPic.png");
            HelloPB.Refresh();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            Authorization f = new Authorization();
            f.ShowDialog();
        }
    }
}
