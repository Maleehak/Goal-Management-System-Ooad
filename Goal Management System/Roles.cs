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
    public partial class Roles : Form
    {
        Idatastore datastore;
        public Roles()
        {
            InitializeComponent();
            btnRolesr.BackColor = System.Drawing.Color.RoyalBlue;
            datastore.showRoleData();
        }
        public Roles(Idatastore datastore)
        {
            InitializeComponent();
            btnRolesr.BackColor = System.Drawing.Color.RoyalBlue;
            datastore.showRoleData();
            this.datastore = datastore;
        }

        private void btAddr_Click(object sender, EventArgs e)
        {
            Role myRole = new Role();
            myRole.RoleName = txtRoleNamer.Text;
            myRole.Type = comboRoleTyper.Text;
            datastore.addRole(myRole);
            dataGridViewRoles.DataSource = datastore.showRoleData();
        }

        private void dataGridViewRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
           
            if (e.ColumnIndex == 0)
            {
                this.Close();
               Goals formGoals = new Goals(e.RowIndex,datastore);
               formGoals.Show();
            }
        }

        private void Roles_Load(object sender, EventArgs e)
        {

        }
    }
    }
