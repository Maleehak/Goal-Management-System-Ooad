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
    public partial class SignUp : Form
    {
        Idatastore datastore;
        public SignUp(Idatastore datastore)
        {
            InitializeComponent();
            this.datastore = datastore;
        }
        public SignUp()
        {
            InitializeComponent();
        }
      
        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

            User u = new User();
            u.Username = textBox1.Text;
            u.Userpassword = textBox2.Text;
            datastore.adduser(u);
        }

        private void btnLogInSU_Click(object sender, EventArgs e)
        {
            Login formLogin = new Login(datastore);
            formLogin.Show();
        }
    }
}
