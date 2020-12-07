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
    public partial class frmStartupForm : Form
    {
        public frmStartupForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        { 
            
            frmLogin loginform = new frmLogin();
            loginform.Show();
            this.Hide();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreate createForm = new frmCreate();
            createForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
