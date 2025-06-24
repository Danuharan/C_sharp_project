using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicomTICManagementSystem.Views
{
    public partial class TimetableForm : Form
    {
        public TimetableForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userRole = "Admin"; // Or get it from a login form, etc.

            MainForm mainForm = new MainForm(userRole);
            mainForm.Show();

            this.Hide();
        }
    }
}
