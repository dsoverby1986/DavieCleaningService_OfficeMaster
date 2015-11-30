using System;
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
        public decimal VacationTime { get; set; }
        public decimal SickTime { get; set; }
        public decimal PersonalTime { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public int ManagerId { get; set; }
        public string Email { get; set; }
    }
}