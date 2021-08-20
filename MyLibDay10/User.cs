using System;
using userCompanyList;

namespace MyLibDay10
{
    public class User
    {
        private string name;
        public string Name 
        {
            get
            {
                return name;
            }
            set 
            { 
                name = value; 
            } 
        }

        private string surname;
        public string Surname
        {
            get 
            {
                return surname; 
            }
            set 
            { 
                surname = value; 
            }
        }


        private int age;
        public int Age
        {
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Age must be more 17");
                }
                else
                {
                    age = value;
                }
            }
            get
            {
                return age;
            }
        }        

        private CompanyName companyName;
        public CompanyName CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns>Return sting with "User name:{name} {surname}.</returns>
        public string GetUserName()
        {
            string user = "User name:" + name + " " + surname;
            return user;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Return string "User {name} work in {workIn}.</returns>
        public string GetWorkCompany()
        {
            string comp = "User " + name + " works in company:" + companyName + ".";
            return comp;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Return string "User: {name}, Age: {age}.</returns>
        public string GetAge()
        {
            string o = "User: " + name + ", Age: " + age + ".";
            return o;
        }
    }        
}
 
