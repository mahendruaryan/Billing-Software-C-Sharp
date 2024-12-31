using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace WinFormsApp4
{
    internal class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public bool Manager { get; set; }


        public User(string username, string password,bool manager)
        {
            this.UserName = username;
            this.Password = password;
            this.Manager = manager;
        }
        public static List<User> Users = new List<User>();

        public static void SaveData(List<User> user)//method to save data 
        {
            // convert list of users to JSON string
            string jsonString = JsonSerializer.Serialize(user);

            // write JSON string to a file
            File.WriteAllText("User.json", jsonString);
        }

        public static bool UserCheck(string userexist)
        {
            foreach(User users in User.Users)
            {
                if(users.UserName == userexist)
                {
                    return true;
                }
            }
            return false;
        }



    }
}
