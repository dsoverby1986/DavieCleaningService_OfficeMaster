﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DavieCleaningService_OfficeMaster.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EmployeeId { get; set; }
        public decimal PayRate { get; set; }
        public string Position { get; set; }
        public decimal OvertimeRate { get; set; }
    }
}