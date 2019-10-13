using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proooooooooooject
{
  
    class Datastore_List : Idatastore

    {
        ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
        public static List<User> storedata = new List<User>();
        public List<Role> storeRole = new List<Role>();

        public Boolean adduser(User u)
        {

           
            ServiceReference1.User myUser = new ServiceReference1.User();
            myUser.UserName = u.Username;
            myUser.UserPassword = u.Userpassword;
            myserver.addUser(myUser);
            return true;
        }
        public Boolean addGoals(Goal g,int index)
        {
            
            myserver.getRoles(index);
            ServiceReference1.Goals myGoal = new ServiceReference1.Goals();
            myGoal.GoalName = g.GoalName;
            myserver.addGoal(myGoal);
            return true;
        }

        public int searchUser(User user)
        {
           
            ServiceReference1.User myUser = new ServiceReference1.User();
            myUser.UserName = user.Username;
            myUser.UserPassword = user.Userpassword;
            if (myserver.searchUser(myUser) == 1)
            {
                return 1; 
            }
            else
            {
                return 0;
            }
        }
        public Boolean addRole(Role Role)
        {
           
            ServiceReference1.Roles myRole = new ServiceReference1.Roles();
            myRole.Role = Role.RoleName;
            myRole.Type = Role.Type;
            myserver.addRoles(myRole);
            return true;

        }
        public BindingSource showGoalData()
        {
            ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
            BindingSource abc = new BindingSource();
            abc.DataSource = myserver.getGoalslist();
            return abc;

        }
        public Role getRoles(int index)
        {
            ServiceReference1.Roles myRole = new ServiceReference1.Roles();
            myRole = myserver.getRoles(index);
            Role r = new Role();
            r.RoleName = myRole.Role;
            r.Type = myRole.Type;
            return r;
        }
        public BindingSource showRoleData()
        {
            BindingSource abc = new BindingSource();
            abc.DataSource = myserver.getRoleslist();
            return abc;
        }
        public BindingSource showToDoData()
        {
            BindingSource abc = new BindingSource();
            abc.DataSource = myserver.getToDoList();
            return abc;

        }
        public Goal getGoal(int index)
        {
            ServiceReference1.Goals myGoal = new ServiceReference1.Goals();
            myGoal = myserver.getGoal(index);
            Goal g = new Goal();
           g.GoalName = myGoal.GoalName;
            return g;
        }
        public Boolean addToDo(ToDo t, int index)
        {
            ServiceReference1.To_Dos myToDo = new ServiceReference1.To_Dos();
            myserver.getGoal(index);
            myToDo.ToDo = t.ToDoName;
            myToDo.Day = t.Day;
            myserver.addToDo(myToDo);
            return true;
        }

    }
}
