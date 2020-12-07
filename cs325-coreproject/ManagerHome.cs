using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs325_coreproject
{
    public partial class frmManagerHome : Form
    {
        List<Person> people = Database.getPeopleList();
        List<Employee> employees;
        public frmManagerHome()
        {
            InitializeComponent();
        }

        private void frmManagerHome_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Database.logout();
            frmStartupForm startupForm = new frmStartupForm();
            startupForm.Show();
            this.Close();
        }
    }
}
