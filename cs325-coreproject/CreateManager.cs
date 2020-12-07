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
    public partial class frmCreateManager : Form
    {
        public frmCreateManager()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text != "" && txtConfirm.Text != "")
            {
                string eid = "M" + Manager.getCount().ToString();
                Manager manager = new Manager(eid, txtFirst.Text, txtLast.Text);
                Database.addPerson(manager);
            }
        }
    }
}
