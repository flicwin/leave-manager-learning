using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace leave_manager.Models
{
    public class EmployeeVM
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        [Display(Name="Phone Number")]
        public string PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TFN { get; set; }
        [Display(Name ="Date Of Birth")]
        public DateTime DateOfBirth { get; set; }
        [Display(Name="Date Joined")]
        public DateTime DateJoined { get; set; }
        [Display(Name ="Subscribed")]
        public bool SubscriptionCompleted { get; set; }
    }
}
