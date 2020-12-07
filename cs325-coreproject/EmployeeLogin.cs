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
    public partial class frmEmployeeLogin : Form
    {
        List<Employee> employee = new List<Employee>();
        public frmEmployeeLogin()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtEID.Text != "" || txtPassword.Text != "")
            {
                foreach (Employee em in employee)
                {
                    if (em.getEid() == txtEID.Text)
                    {
                        if (em.getPassword() == txtPassword.Text)
                        {
                            Database.login(em);
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Employee doesn't exist");
                    }
                }
            }
            else
            {
                MessageBox.Show("EID and Password can't be empty!");
            }
        }

        private void frmEmployeeLogin_Load(object sender, EventArgs e)
        {
            employee = Database.generateEmployeeList();
        }
    }
}
