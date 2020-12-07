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
        List<Employee> employees = Database.generateEmployeeList();
        public frmManagerHome()
        {
            InitializeComponent();
        }

        private void frmManagerHome_Load(object sender, EventArgs e)
        {
            updateListBox();   
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Database.logout();
            frmStartupForm startupForm = new frmStartupForm();
            startupForm.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCreateEmp empForm = new frmCreateEmp();
            empForm.Show();
            this.Close();
        }

       

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstEmployees.Items.RemoveAt(lstEmployees.SelectedIndex);
            updateListBox();
        }
        private void updateListBox()
        {
            lstEmployees.Items.Clear();
            foreach (Employee emp in employees)
            {
                lstEmployees.Items.Add(emp);
            }
        }

    }
}
