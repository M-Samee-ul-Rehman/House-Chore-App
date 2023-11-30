using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoresDesktopApp.Backend
{
    public class UserRegistration
    {
        // Properties that correspond to the columns in the Registration table
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string HomeAddress { get; set; }
        public string CNIC { get; set; }
        public DateTime CreatedAT { get; set; }
        public DateTime UpdatedAT { get; set; }
        public bool Active { get; set; }

        // Default constructor
        public UserRegistration()
        {
            // Initialize properties or perform other setup if needed
        }

        // Parameterized constructor for creating a Registration instance with initial data
        public UserRegistration(int userId, string firstName, string lastName, string email, string phoneNumber, string homeAddress, string cnic)
        {
            UserID = userId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            HomeAddress = homeAddress;
            CNIC = cnic;
            CreatedAT = DateTime.Now;
            UpdatedAT = DateTime.Now;
            Active = true;
        }
    }
}
