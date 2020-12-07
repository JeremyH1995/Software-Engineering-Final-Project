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
    public partial class frmCreate : Form
    {
        public frmCreate()
        {
            InitializeComponent();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            frmCreateClient createClient = new frmCreateClient();
            createClient.Show();
            this.Close();
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            frmCreateManager createManager = new frmCreateManager();
            createManager.Show();
            this.Close();
        }
    }
}
