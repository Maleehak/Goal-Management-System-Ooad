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
    public partial class ToDos : Form
    {
        Idatastore datastore;
        int i;
        public ToDos()
        {
            InitializeComponent();
        }
        public ToDos(int index, Idatastore datastore)
        {
            InitializeComponent();
           btnTodot.BackColor = System.Drawing.Color.RoyalBlue;
            this.datastore = datastore;
            i = index;
        }

        private void ToDos_Load(object sender, EventArgs e)
        {

        }

        private void btnplust_Click(object sender, EventArgs e)
        {
            ToDo myToDo = new ToDo();
           myToDo.ToDoName = txtTodot.Text;
            myToDo.Day = dateTimePicker1.Text;
            datastore.addToDo(myToDo, i);
            dataGridViewTodos.DataSource = datastore.showToDoData();
            
        }
    }
}
