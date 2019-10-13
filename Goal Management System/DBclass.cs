using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Proooooooooooject
{
    class DBclass : Idatastore
    {
        BindingSource abc = new BindingSource();
        string constr = "Data Source=MK\\SQLEXPRESS;Initial Catalog=lab9;Integrated Security=True";
        public Boolean adduser(User u)
        {  
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            string query = "insert into tblUser(Username,Password) values ('" + u.Username.ToString() + "','" + u.Userpassword.ToString() + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            return true;
        }
       public Boolean addRole(Role r)
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            string query = "insert into tblRole(RoleName,RoleType) values ('" + r.RoleName.ToString() + "','" + r.Type.ToString() + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            return true;

        }
        public Boolean addGoals(Goal g,int index)
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            string query = "insert into tblGoal(GoalName) values ('" + g.GoalName.ToString() + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            return true;

        }
       public Boolean addToDo(ToDo t,int i)
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            string query = "insert into tblToDo(ToDoName,Day) values ('" + t.ToDoName.ToString() + "','" + t.Day.ToString() + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            return true;

        }
        public BindingSource showRoleData()
        {
            SqlConnection con = new SqlConnection(constr);
            SqlDataAdapter sda = new SqlDataAdapter("Select * From tblRole  ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            abc.DataSource=dt;
            return abc;

        }
        public BindingSource showGoalData()
        {
            SqlConnection con = new SqlConnection(constr);
            SqlDataAdapter sda = new SqlDataAdapter("Select * From tblGoal  ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            abc.DataSource = dt;
            return abc;

        }
        public BindingSource showToDoData()
        {
            SqlConnection con = new SqlConnection(constr);
            SqlDataAdapter sda = new SqlDataAdapter("Select * From tblToDo  ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            abc.DataSource = dt;
            return abc;

        }
        public int searchUser(User user)
        {
            return 1;
        }
        public Role getRoles(int index)
        {
            return null;
        }
        public Goal getGoal(int index)
        {
            return null;
        }
    }
}
