using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccpuntCSharp
{
    static class Helper
    {
        public static User[] AppendToArray(User[] users, User user)
        {
            Array.Resize(ref users, users.Length + 1);
            users[users.Length - 1] = user;
            return users;

        }
            
        public static User FindUser(User[] users, int id)
        {
            User result = new User();
            foreach (User user in users)
            {
                if (user.Id == id)
                {

                    result = user;

                }
                
            }
            return result;
           
        }

        public static void ShowUsers(User[] users)
        {
            if (users.Length > 0)
            {
                foreach (User user in users)
                {
                    Console.WriteLine("Id: " + user.Id + " Name: " + user.Name + " Surname: " + user.Surname
                      + " Username: " + user.Username + " Password: " + user.Password);
                }
            }
            else
            {
                Console.WriteLine("Hal Hazirda User Yoxdur");
            }
            
        }
        
    }
}
