using System;

namespace MyLibDay10
{
    public enum CompanyName
    {
        EPAM,
        Yandex,
        Amazon,
        Walmart,
        unemployed
    }

    public class User
    {
        public string name;
        public string surname;
        public int age;
        public CompanyName companyName;

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

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Return sting with "User name:{name} {surname}.</returns>
        public string GetUserName()
        {
            string user = "User name:" + name +" "+ surname;
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
