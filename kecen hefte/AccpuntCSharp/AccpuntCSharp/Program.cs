using System;

namespace AccpuntCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

         

            UserOperation operation = new UserOperation();
            int i = 0;
            while (true)
            {
                Console.WriteLine("Please Select Operation");

                Console.WriteLine("Register: 1");
                Console.WriteLine("Show Users: 2");
                Console.WriteLine("Find User: 3");
                string stroperation = Console.ReadLine();
                if (stroperation == "1")
                {
                    Console.WriteLine("Name");
                    string name = Console.ReadLine();

                    Console.WriteLine("SurName");
                    string surname = Console.ReadLine();

                    Console.WriteLine("UserName");
                    string username = Console.ReadLine();

                    Console.WriteLine("Password");
                    string password = Console.ReadLine();

                    operation.CreateAccount(name, surname, username, password);
                }
                else if (stroperation == "2")
                {
                    Helper.ShowUsers(operation.Users);
                }
                else if (stroperation == "3")
                {
                    Console.WriteLine("Id");
                    string id = Console.ReadLine();
                    Console.WriteLine(Helper.FindUser(operation.Users, int.Parse(id)));
                }
                else
                {
                    i++;
                    if (i == 3)
                    {
                        Console.WriteLine("Cix get burdan");
                        break;
                    }
                    Console.WriteLine("Zehmet Olmasa duzgun secim edin");
                    
                }
            }
            
            


        }

    }
}
