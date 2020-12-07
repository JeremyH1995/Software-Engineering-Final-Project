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
    public partial class frmCreateEmp : Form
    {
        public frmCreateEmp()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != "" && txtConfirm.Text != "")
            {
                if (txtPassword.Text == txtConfirm.Text)
                {
                    if(ddlRole.Text == "Logistics")
                    {
                        string eid = "L" + Logistics.getCount();
                        Logistics log = new Logistics(eid, txtFirst.Text, txtLast.Text);
                        Database.addPerson(log);
                    }
                    else if(ddlRole.Text == "Secretary")
                    {
                        string eid = "S" + Secretary.getCount();
                        Secretary sec = new Secretary(eid, txtFirst.Text, txtLast.Text);
                        Database.addPerson(sec);
                    }
                    frmManagerHome homeForm = new frmManagerHome();
                    homeForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password does not match the confirm textbox");
                }
            }
            else
            {
                MessageBox.Show("Email and password can't be empty");
            }
        }
    }
}
