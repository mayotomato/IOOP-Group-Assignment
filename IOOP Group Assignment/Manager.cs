using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Group_Assignment
{
    internal class Manager
    {
        string username;
        string password;
        string managerID;

        public Manager(string userName,string Password, string ManagerID)
        {
            username = userName;
            password = Password;
            managerID = ManagerID;

        }

         public void ManageAccounts()
        {
            ManageAccountsForm form = new ManageAccountsForm();

            form.Show();

        }
    }
}
