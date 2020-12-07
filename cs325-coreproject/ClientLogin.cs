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
    public partial class frmClientLogin : Form
    { 
        List<Client> clients = new List<Client>();
        public frmClientLogin()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text != "" && txtPassword.Text != "")
            {
                foreach(Client c in clients)
                {
                    if(c.getEmail() == txtEmail.Text)
                    {
                        if(c.getPassword() == txtPassword.Text)
                        {
                            Database.login(c);
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Client doesn't exist");
                    }
                }
            }
            else
            {
                MessageBox.Show("Email and Password can't be empty!");
            }
        }

        private void frmClientLogin_Load(object sender, EventArgs e)
        {
            clients = Database.generateClientList();
        }
    }
}
