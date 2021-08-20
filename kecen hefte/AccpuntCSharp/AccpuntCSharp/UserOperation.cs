using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccpuntCSharp
{
    class UserOperation:IAccount
    {
        public User[] Users =  { };

        public void CreateAccount(string name, string surname, string username, string password)
        {
            User user = new User();
            user.Name = name;
            user.Surname = surname;
            user.Username = username;
            user.Password = password;
            Users = Helper.AppendToArray(Users, user);

        }
    }
}
