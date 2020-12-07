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
    public partial class frmCreateClient : Form
    {
        public frmCreateClient()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text != "" && txtPassword.Text != "" && txtConfirm.Text != "")
            {
                if(txtPassword.Text == txtConfirm.Text)
                {
                    Client newclient = new Client(txtFirst.Text, txtLast.Text, txtPassword.Text, txtEmail.Text, txtPhone.Text, txtContact.Text);
                    Database.addPerson(newclient);
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
