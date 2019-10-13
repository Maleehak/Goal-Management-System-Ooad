using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proooooooooooject
{
    using System.Windows.Forms;
    public interface Idatastore
    {
        Boolean adduser(User u);
        int searchUser(User user);
        Boolean addRole(Role r);
        Role getRoles(int index);
        Boolean addGoals(Goal g,int index);
        Boolean addToDo(ToDo t,int index);
        BindingSource showRoleData();
        Goal getGoal(int index);
        BindingSource showGoalData();
        BindingSource showToDoData();
    }
}
