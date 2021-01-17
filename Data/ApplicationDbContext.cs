using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using leave_manager.Models;

namespace leave_manager.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<LeaveHistory> LeaveHistory { get; set; }
        public DbSet<leave_manager.Models.LeaveTypeVM> DetailsLeaveTypeVM { get; set; }
        public DbSet<leave_manager.Models.EmployeeVM> EmployeeVM { get; set; }
        public DbSet<leave_manager.Models.LeaveAllocationVM> LeaveAllocationVM { get; set; }
        public DbSet<leave_manager.Models.EditLeaveAllocationVM> EditLeaveAllocationVM { get; set; }
    }
}
