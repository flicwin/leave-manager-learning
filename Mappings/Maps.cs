﻿using AutoMapper;
using leave_manager.Data;
using leave_manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_manager.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<Employee, EmployeeVM>().ReverseMap();

            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();

            CreateMap<LeaveHistory, LeaveHistoryVM>().ReverseMap();

            CreateMap<LeaveAllocation, LeaveAllocationVM>().ReverseMap();
        }

    }
}
