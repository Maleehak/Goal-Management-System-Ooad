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
    public partial class Goals : Form
    {

        Idatastore datastore;
        static Role myRole = new Role();
        int i;
        public Goals()
        {
            InitializeComponent();
            btnRolesg.BackColor = System.Drawing.Color.RoyalBlue;
            
        }
        public Goals(int index,Idatastore datastore)
        {
            InitializeComponent();
            btnGoalsg.BackColor = System.Drawing.Color.RoyalBlue;
            this.datastore = datastore;
            i = index;
       

        }

        private void Goals_Load(object sender, EventArgs e)
        {

        }

        private void btnPlusg_Click(object sender, EventArgs e)
        {
            Goal myGoal = new Goal();
            myGoal.GoalName = txtGoalg.Text;
            datastore.addGoals(myGoal,i);
            dataGridViewG.DataSource = datastore.showGoalData();
            
        }

        private void dataGridViewG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0)
            {
                this.Close();
                ToDos formToDo = new ToDos(e.RowIndex,datastore);
                formToDo.Show();
            }
        }

        private void txtGoalg_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRoleg_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblGoalg_Click(object sender, EventArgs e)
        {

        }

        private void lblTypeg1_Click(object sender, EventArgs e)
        {

        }

        private void lblTypeg_Click(object sender, EventArgs e)
        {

        }

        private void lblRoleg_Click(object sender, EventArgs e)
        {

        }

        private void btnReportg_Click(object sender, EventArgs e)
        {

        }

        private void btnTodog_Click(object sender, EventArgs e)
        {

        }

        private void btnGoalsg_Click(object sender, EventArgs e)
        {

        }

        private void btnRolesg_Click(object sender, EventArgs e)
        {

        }
    }
}
