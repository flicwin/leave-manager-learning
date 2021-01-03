using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace leave_manager.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        [Required]
        [Display(Name="Leave Name")]
        public string Name { get; set; }
        [Display(Name="Date Created")]
        public DateTime? DateCreated { get; set; }
    }
}
