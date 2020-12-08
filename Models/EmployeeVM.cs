using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_manager.Models
{
    public class EmployeeVM
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TFN { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateJoined { get; set; }
    }
}
