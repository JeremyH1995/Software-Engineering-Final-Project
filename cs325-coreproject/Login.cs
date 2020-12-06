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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            frmClientLogin loginForm = new frmClientLogin();
            loginForm.Show();
            this.Close();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            frmEmployeeLogin loginForm = new frmEmployeeLogin();
            loginForm.Show();
            this.Close();
        }
    }
}
