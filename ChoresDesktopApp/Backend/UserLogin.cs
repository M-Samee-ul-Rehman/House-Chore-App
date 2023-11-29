using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ChoresDesktopApp.Backend
{
    public class UserLogin
    {
        
        public string email { get; set; }
        public string cnic{ get; set; }
        public DateTime CreatedAt { get; set; }
        public static List<UserLogin> userLogins { get; set; } = new List<UserLogin>(); // Initialize the list



        // Constructors
        public UserLogin(string email, string cnic)
        {
            this.email = email;
            this.cnic = cnic;
            CreatedAt = DateTime.Now;
        }

        public UserLogin()
        {

        }



        // Methods
        public static UserLogin GetLatestUserLogin()
        {
            if (userLogins == null || userLogins.Count == 0)
            {
                return null;
            }

            // Use LINQ to order the list by CreatedAt in descending order and get the first element
            UserLogin latestUserLogin = userLogins.OrderByDescending(u => u.CreatedAt).First();

            return latestUserLogin;
        }


        public string GetEmail()
        {
            return this.email;
        }
    }
}
