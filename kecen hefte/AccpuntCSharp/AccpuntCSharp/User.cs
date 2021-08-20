using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccpuntCSharp
{
    class User
    {
        public string  Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Id { get; }
        private static int counter = 0;
        public User()
        {
            counter++;
            Id = counter;
        }
        public override string ToString()
        {
            return $"Id : {Id} Name {Name} Surname {Surname} Username {Username} Password {Password}"; 
        }
    }
}
