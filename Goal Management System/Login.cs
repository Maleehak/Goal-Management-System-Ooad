using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proooooooooooject
{
    public partial class Login : Form
    {
        Idatastore datastore;
        public Login(Idatastore datastore)
        {
            InitializeComponent();
            this.datastore = datastore;
        }

        private void btnSUlogin_Click(object sender, EventArgs e)
        {
            SignUp formSignup = new SignUp();
            formSignup.Show();
        }

        private void btnlogIn_Click(object sender, EventArgs e)
        {
            User myUser = new User();
            myUser.Username = txtusrLogIn.Text;
            myUser.Userpassword = txtPLogIn.Text;
            if (datastore.searchUser(myUser)==1)
            {
                this.Close();
                Roles r = new Roles(datastore);
                r.Show();
            }
            else
            {
                MessageBox.Show("User not found");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
