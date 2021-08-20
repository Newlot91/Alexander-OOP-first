using System;
using MyLibDay10;
using userCompanyList;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            user1.Name = "Alexander";
            user1.Surname = "Yermalovich";
            user1.Age = 30;
            user1.CompanyName = CompanyName.unemployed;

            User user2 = new User();
            user2.Name = "Andrei";
            user2.Surname = "Yermalovich";
            user2.Age = 25;
            user2.CompanyName = CompanyName.unemployed;

            User user3 = new User();
            user3.Name = "Anastasiya";
            user3.Surname = "Yermalovich";
            user3.Age = 28;
            user3.CompanyName = CompanyName.Amazon;

            User user4 = new User();
            user4.Name = "Anna";
            user4.Surname = "Herasimenko";
            user4.Age = 24;
            user4.CompanyName = CompanyName.EPAM;

            User user5 = new User();
            user5.Name = "Kirill";
            user5.Surname = "Korzun";
            user5.Age = 25;
            user5.CompanyName = CompanyName.EPAM;

            //Display all created users
            User[] users = { user1, user2, user3, user4, user5 };
            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine(users[i].GetUserName());
                Console.WriteLine(users[i].GetAge());
                Console.WriteLine(users[i].GetWorkCompany() + "\n");
            }

            users = RemoveEpam(users);//filtering
            Console.WriteLine("***************************");
            Console.WriteLine("Filtered none EPAM");

            //Display all none epam users
            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine(users[i].GetUserName());
                Console.WriteLine(users[i].GetAge());
                Console.WriteLine(users[i].GetWorkCompany() + "\n");
            }

            static User[] RemoveEpam(User[] users)
            {
                User[] filteredUsers = new User[1];
                int countForFilter = 0;
                for (int i = 0; i < users.Length; i++)
                {

                    if (users[i].CompanyName != CompanyName.EPAM)
                    {

                        filteredUsers[countForFilter] = users[i];
                        Array.Resize(ref filteredUsers, filteredUsers.Length + 1);
                        countForFilter++;
                    }
                }
                Array.Resize(ref filteredUsers, filteredUsers.Length - 1);
                return filteredUsers;
            }
        }
    }
}
