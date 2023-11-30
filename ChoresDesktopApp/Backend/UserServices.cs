using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoresDesktopApp.Backend
{
    public class UserServices
    {

        // Properties that correspond to the columns in the Services table
        public int ServiceID { get; set; }
        public string TaskCategory { get; set; }
        public string TaskDescription { get; set; }
        public decimal Rate { get; set; }
        public DateTime CreatedAT { get; set; }
        public DateTime UpdatedAT { get; set; }
        public bool Active { get; set; }

        // Default constructor
        public UserServices()
        {
            // Initialize properties or perform other setup if needed
        }

        // Parameterized constructor for creating a Services instance with initial data
        public UserServices(int serviceId, string taskCategory, string taskDescription, decimal rate)
        {
            ServiceID = serviceId;
            TaskCategory = taskCategory;
            TaskDescription = taskDescription;
            Rate = rate;
            CreatedAT = DateTime.Now;
            UpdatedAT = DateTime.Now;
            Active = true;
        }
    }
}
